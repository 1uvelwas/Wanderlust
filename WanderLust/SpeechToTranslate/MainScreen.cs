using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using System.Speech.Recognition;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Collections;
using SpeechLib;

namespace SpeechToTranslate
{
    public partial class MainScreen : Form
    {
        private string _s1;
        private string _s2;
        private SpeechRecognitionEngine _speechRecognitionEngine;
        private Grammar _grammer;

        public bool ConnectionStatus()
        {
            try
            {
                WebRequest claim = WebRequest.Create("http://www.google.com");
                WebResponse response = claim.GetResponse();

                return true;
            }
            catch (Exception ex)
            {
                // TODO: ConnectionStatus - Loglama Yapısı Eklenecek
                return false;
            }
        }

        public MainScreen()
        {
            InitializeComponent();
            _speechRecognitionEngine = new SpeechRecognitionEngine();
            _grammer = new DictationGrammar();
        }


        private void MainScreen_Load(object sender, EventArgs e)
        {
            cbdil1.Text = "en";
            cbdil2.Text = "tr";
            _speechRecognitionEngine.LoadGrammar(_grammer);
            _speechRecognitionEngine.SetInputToDefaultAudioDevice();

            if (ConnectionStatus() == true)
                lblmessage.Text = "Network connection : Connected";
            else
            {
                MessageBox.Show("It may not work properly because you don't have a network connection.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblmessage.Text = "Network Connection: Not Connected !!";
            }
        }
        public string TranslateText(string input, string lan, string tolan)
        {
            string translation = "";
            HttpClient httpClient = new HttpClient();

            string baseUrl = String.Format("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}", lan, tolan, Uri.EscapeUriString(input));
            string result = httpClient.GetStringAsync(baseUrl).Result;

            var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(result);
            var translationItems = jsonData[0];

            foreach (object item in translationItems)
            {
                IEnumerable translationLineObject = item as IEnumerable;
                IEnumerator translationLineString = translationLineObject.GetEnumerator();
                translationLineString.MoveNext();
                translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
            }

            if (translation.Length > 1) { translation = translation.Substring(1); };
            return translation;
        }
        private void btnkonus_Click(object sender, EventArgs e)
        {
            try
            {
                RecognitionResult res = _speechRecognitionEngine.Recognize();
                if (res != null)
                {
                    txtyazi.Text += "\ncontent:" + res.Text + "\n";
                    txtyazi.Text += "Translation:" + TranslateText(res.Text, cbdil1.Text, cbdil2.Text);
                    txtyazi.Text += "\n";
                    txtyazi.Text += "\nThis is a gift:";
                    SpVoice oku = new SpVoice();
                    oku.Speak(txtyazi.Text, SpeechVoiceSpeakFlags.SVSFDefault);
                }
                else
                {
                    txtyazi.Text += "\nAlgılanamadı tekrar deneyin.";
                }
            }
            catch (Exception ex)
            {
                // Loglama Yapısı Eklenecek
                MessageBox.Show($"STP Code 1001: An error occurred during detection.\n\nError message:{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtyazi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
