using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Net;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Web;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Collections;
using SpeechLib;

namespace SpeechToTranslate
{
    public partial class tt : Form
    {
        public tt()
        {
            InitializeComponent();
        }
        SpeechRecognitionEngine sr = new SpeechRecognitionEngine();
        Grammar gr = new DictationGrammar();
        public string s1="", s2="";
        public bool Test()//This method queries the internet
        {
            string address = "http://Google.com";
            try
            {
                WebRequest claim = WebRequest.Create(address);
                WebResponse response = claim.GetResponse();
            }
            catch (Exception)
            { return false; }
            return true;
        }
        private void tt_Load(object sender, EventArgs e)
        {
            sr.LoadGrammar(gr);
            sr.SetInputToDefaultAudioDevice();
            cbdil1.Text = "en";
            cbdil2.Text = "tr";
            if (Test())
            {lblmessage.Text = "Internet connection provided."; }
            else
            {lblmessage.Text = "Internet connection could not be established."; }
        }
        public string TranslateText(string input, string lan, string tolan)
        {
            // Set the language from/to in the url (or pass it into this function)
            string url = String.Format
            ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
             lan, tolan, Uri.EscapeUriString(input));
            HttpClient httpClient = new HttpClient();
            string result = httpClient.GetStringAsync(url).Result;
            // Get all json data
            var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(result);
            // Extract just the first array element (This is the only data we are interested in)
            var translationItems = jsonData[0];
            // Translation Data
            string translation = "";
            // Loop through the collection extracting the translated objects
            foreach (object item in translationItems)
            {
                // Convert the item array to IEnumerable
                IEnumerable translationLineObject = item as IEnumerable;
                // Convert the IEnumerable translationLineObject to a IEnumerator
                IEnumerator translationLineString = translationLineObject.GetEnumerator();
                // Get first object in IEnumerator
                translationLineString.MoveNext();
                // Save its value (translated text)
                translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
            }
            // Remove first blank character
            if (translation.Length > 1) { translation = translation.Substring(1); };
            return translation;
        }

        private void txtyazi_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btnkonus_Click(object sender, EventArgs e)
        {
            try
            {
                RecognitionResult res = sr.Recognize();
                if (res != null)
                {
                    txtyazi.Text += "\ncontent:" + res.Text + "\n";
                    txtyazi.Text += "Translation:" + TranslateText(res.Text, cbdil1.Text, cbdil2.Text);
                    txtyazi.Text += "\n";
                    txtyazi.Text += "\nThis program is a gift";
                    SpVoice oku = new SpVoice();
                    oku.Speak(txtyazi.Text, SpeechVoiceSpeakFlags.SVSFDefault);
                }
                else
                {txtyazi.Text += "\nTry again."; }
            }
            catch (Exception)
            {txtyazi.Text += "\nAn error occurred, please try again."; }
            
        }
    }
}
