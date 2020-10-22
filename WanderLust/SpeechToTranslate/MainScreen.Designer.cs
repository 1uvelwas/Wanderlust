namespace SpeechToTranslate
{
    partial class MainScreen
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbdil1 = new System.Windows.Forms.ComboBox();
            this.cbdil2 = new System.Windows.Forms.ComboBox();
            this.btnkonus = new System.Windows.Forms.Button();
            this.txtyazi = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblmessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Translated Language:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(317, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Language to translate:";
            // 
            // cbdil1
            // 
            this.cbdil1.FormattingEnabled = true;
            this.cbdil1.Items.AddRange(new object[] {
            "en",
            "tr"});
            this.cbdil1.Location = new System.Drawing.Point(171, 9);
            this.cbdil1.Name = "cbdil1";
            this.cbdil1.Size = new System.Drawing.Size(140, 23);
            this.cbdil1.TabIndex = 2;
            // 
            // cbdil2
            // 
            this.cbdil2.FormattingEnabled = true;
            this.cbdil2.Items.AddRange(new object[] {
            "tr",
            "en"});
            this.cbdil2.Location = new System.Drawing.Point(487, 9);
            this.cbdil2.Name = "cbdil2";
            this.cbdil2.Size = new System.Drawing.Size(140, 23);
            this.cbdil2.TabIndex = 3;
            // 
            // btnkonus
            // 
            this.btnkonus.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkonus.Location = new System.Drawing.Point(12, 35);
            this.btnkonus.Name = "btnkonus";
            this.btnkonus.Size = new System.Drawing.Size(569, 49);
            this.btnkonus.TabIndex = 4;
            this.btnkonus.Text = "Speak";
            this.btnkonus.UseVisualStyleBackColor = true;
            this.btnkonus.Click += new System.EventHandler(this.btnkonus_Click);
            // 
            // txtyazi
            // 
            this.txtyazi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyazi.Location = new System.Drawing.Point(12, 90);
            this.txtyazi.Name = "txtyazi";
            this.txtyazi.Size = new System.Drawing.Size(569, 222);
            this.txtyazi.TabIndex = 5;
            this.txtyazi.Text = "";
            this.txtyazi.TextChanged += new System.EventHandler(this.txtyazi_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Message : ";
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmessage.Location = new System.Drawing.Point(77, 315);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(0, 23);
            this.lblmessage.TabIndex = 7;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 364);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtyazi);
            this.Controls.Add(this.btnkonus);
            this.Controls.Add(this.cbdil2);
            this.Controls.Add(this.cbdil1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.RightToLeftLayout = true;
            this.Text = "Lydia V2 // ____.Wanderlust.______";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbdil1;
        private System.Windows.Forms.ComboBox cbdil2;
        private System.Windows.Forms.Button btnkonus;
        private System.Windows.Forms.RichTextBox txtyazi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmessage;
    }
}

