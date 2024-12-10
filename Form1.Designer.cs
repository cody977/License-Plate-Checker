using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

     

        private void InitializeComponent()
        {
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.textBox_enterPlate = new System.Windows.Forms.TextBox();
            this.label_previousPlateTitle = new System.Windows.Forms.Label();
            this.textBox_enterState = new System.Windows.Forms.TextBox();
            this.label_text_plate = new System.Windows.Forms.Label();
            this.label_text_state = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.webView_log = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.label_text_supportedTitle = new System.Windows.Forms.Label();
            this.button_editTheme = new System.Windows.Forms.Button();
            this.button_themeColor = new System.Windows.Forms.Button();
            this.button_fontColor = new System.Windows.Forms.Button();
            this.button_editTheme_2 = new System.Windows.Forms.Button();
            this.button_trafficLaws = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label_plateChecker = new System.Windows.Forms.Label();
            this.label_copyright = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_buttonColor = new System.Windows.Forms.Button();
            this.textBox_notePad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView_log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(291, 110);
            this.webView21.Margin = new System.Windows.Forms.Padding(0);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(465, 329);
            this.webView21.Source = new System.Uri("https://com", System.UriKind.Absolute);
            this.webView21.TabIndex = 0;
            this.webView21.Visible = false;
            this.webView21.ZoomFactor = 1.1D;
            this.webView21.Click += new System.EventHandler(this.webView21_Click_1);
            // 
            // textBox_enterPlate
            // 
            this.textBox_enterPlate.AcceptsReturn = true;
            this.textBox_enterPlate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_enterPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox_enterPlate.Location = new System.Drawing.Point(291, 165);
            this.textBox_enterPlate.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_enterPlate.MaxLength = 8;
            this.textBox_enterPlate.Name = "textBox_enterPlate";
            this.textBox_enterPlate.Size = new System.Drawing.Size(227, 45);
            this.textBox_enterPlate.TabIndex = 1;
            this.textBox_enterPlate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_previousPlateTitle
            // 
            this.label_previousPlateTitle.AutoSize = true;
            this.label_previousPlateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_previousPlateTitle.Location = new System.Drawing.Point(828, 74);
            this.label_previousPlateTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_previousPlateTitle.Name = "label_previousPlateTitle";
            this.label_previousPlateTitle.Size = new System.Drawing.Size(54, 29);
            this.label_previousPlateTitle.TabIndex = 6;
            this.label_previousPlateTitle.Text = "Log";
            this.label_previousPlateTitle.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_enterState
            // 
            this.textBox_enterState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_enterState.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox_enterState.Location = new System.Drawing.Point(556, 165);
            this.textBox_enterState.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_enterState.MaxLength = 2;
            this.textBox_enterState.Name = "textBox_enterState";
            this.textBox_enterState.Size = new System.Drawing.Size(156, 45);
            this.textBox_enterState.TabIndex = 2;
            this.textBox_enterState.TextChanged += new System.EventHandler(this.textBox_enterState_TextChanged_1);
            // 
            // label_text_plate
            // 
            this.label_text_plate.AutoSize = true;
            this.label_text_plate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_text_plate.Location = new System.Drawing.Point(309, 128);
            this.label_text_plate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_text_plate.Name = "label_text_plate";
            this.label_text_plate.Size = new System.Drawing.Size(158, 29);
            this.label_text_plate.TabIndex = 11;
            this.label_text_plate.Text = "License Plate";
            this.label_text_plate.Click += new System.EventHandler(this.label_text_plate_Click);
            // 
            // label_text_state
            // 
            this.label_text_state.AutoSize = true;
            this.label_text_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_text_state.Location = new System.Drawing.Point(596, 128);
            this.label_text_state.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_text_state.Name = "label_text_state";
            this.label_text_state.Size = new System.Drawing.Size(68, 29);
            this.label_text_state.TabIndex = 12;
            this.label_text_state.Text = "State";
            this.label_text_state.Click += new System.EventHandler(this.label_text_state_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(713, 110);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 329);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(291, 110);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(465, 55);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(798, 449);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 39);
            this.button1.TabIndex = 22;
            this.button1.Text = "Clear Log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(291, 404);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(461, 34);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // webView_log
            // 
            this.webView_log.AllowExternalDrop = true;
            this.webView_log.CreationProperties = null;
            this.webView_log.DefaultBackgroundColor = System.Drawing.Color.LightGray;
            this.webView_log.Location = new System.Drawing.Point(760, 110);
            this.webView_log.Margin = new System.Windows.Forms.Padding(0);
            this.webView_log.Name = "webView_log";
            this.webView_log.Size = new System.Drawing.Size(189, 329);
            this.webView_log.Source = new System.Uri("https://com", System.UriKind.Absolute);
            this.webView_log.TabIndex = 28;
            this.webView_log.ZoomFactor = 1D;
            // 
            // label_text_supportedTitle
            // 
            this.label_text_supportedTitle.AutoSize = true;
            this.label_text_supportedTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label_text_supportedTitle.Location = new System.Drawing.Point(383, 439);
            this.label_text_supportedTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_text_supportedTitle.Name = "label_text_supportedTitle";
            this.label_text_supportedTitle.Size = new System.Drawing.Size(281, 31);
            this.label_text_supportedTitle.TabIndex = 13;
            this.label_text_supportedTitle.Text = "All States Supported";
            // 
            // button_editTheme
            // 
            this.button_editTheme.BackColor = System.Drawing.Color.LightGray;
            this.button_editTheme.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_editTheme.FlatAppearance.BorderSize = 0;
            this.button_editTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_editTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editTheme.ForeColor = System.Drawing.Color.Black;
            this.button_editTheme.Location = new System.Drawing.Point(88, 13);
            this.button_editTheme.Margin = new System.Windows.Forms.Padding(4);
            this.button_editTheme.Name = "button_editTheme";
            this.button_editTheme.Size = new System.Drawing.Size(116, 46);
            this.button_editTheme.TabIndex = 35;
            this.button_editTheme.Text = "Edit Theme";
            this.button_editTheme.UseVisualStyleBackColor = false;
            this.button_editTheme.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_themeColor
            // 
            this.button_themeColor.BackColor = System.Drawing.Color.LightGray;
            this.button_themeColor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_themeColor.FlatAppearance.BorderSize = 0;
            this.button_themeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_themeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_themeColor.ForeColor = System.Drawing.Color.Black;
            this.button_themeColor.Location = new System.Drawing.Point(18, 65);
            this.button_themeColor.Margin = new System.Windows.Forms.Padding(4);
            this.button_themeColor.Name = "button_themeColor";
            this.button_themeColor.Size = new System.Drawing.Size(116, 46);
            this.button_themeColor.TabIndex = 36;
            this.button_themeColor.Text = "Background";
            this.button_themeColor.UseVisualStyleBackColor = false;
            this.button_themeColor.Visible = false;
            this.button_themeColor.Click += new System.EventHandler(this.button_themeColor_Click);
            // 
            // button_fontColor
            // 
            this.button_fontColor.BackColor = System.Drawing.Color.LightGray;
            this.button_fontColor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_fontColor.FlatAppearance.BorderSize = 0;
            this.button_fontColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fontColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fontColor.ForeColor = System.Drawing.Color.Black;
            this.button_fontColor.Location = new System.Drawing.Point(163, 66);
            this.button_fontColor.Margin = new System.Windows.Forms.Padding(4);
            this.button_fontColor.Name = "button_fontColor";
            this.button_fontColor.Size = new System.Drawing.Size(116, 46);
            this.button_fontColor.TabIndex = 37;
            this.button_fontColor.Text = "Font Color";
            this.button_fontColor.UseVisualStyleBackColor = false;
            this.button_fontColor.Visible = false;
            this.button_fontColor.Click += new System.EventHandler(this.button_fontColor_Click);
            // 
            // button_editTheme_2
            // 
            this.button_editTheme_2.BackColor = System.Drawing.Color.LightGray;
            this.button_editTheme_2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_editTheme_2.FlatAppearance.BorderSize = 0;
            this.button_editTheme_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_editTheme_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editTheme_2.ForeColor = System.Drawing.Color.Black;
            this.button_editTheme_2.Location = new System.Drawing.Point(89, 13);
            this.button_editTheme_2.Margin = new System.Windows.Forms.Padding(4);
            this.button_editTheme_2.Name = "button_editTheme_2";
            this.button_editTheme_2.Size = new System.Drawing.Size(116, 46);
            this.button_editTheme_2.TabIndex = 38;
            this.button_editTheme_2.Text = "Close";
            this.button_editTheme_2.UseVisualStyleBackColor = false;
            this.button_editTheme_2.Visible = false;
            this.button_editTheme_2.Click += new System.EventHandler(this.button_editTheme_2_Click);
            // 
            // button_trafficLaws
            // 
            this.button_trafficLaws.BackColor = System.Drawing.Color.LightGray;
            this.button_trafficLaws.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_trafficLaws.FlatAppearance.BorderSize = 0;
            this.button_trafficLaws.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_trafficLaws.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_trafficLaws.ForeColor = System.Drawing.Color.Black;
            this.button_trafficLaws.Location = new System.Drawing.Point(67, 443);
            this.button_trafficLaws.Margin = new System.Windows.Forms.Padding(4);
            this.button_trafficLaws.Name = "button_trafficLaws";
            this.button_trafficLaws.Size = new System.Drawing.Size(137, 46);
            this.button_trafficLaws.TabIndex = 39;
            this.button_trafficLaws.Text = "MO Traffic Laws";
            this.button_trafficLaws.UseVisualStyleBackColor = false;
            this.button_trafficLaws.Click += new System.EventHandler(this.button_trafficLaws_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(517, 165);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 47);
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            // 
            // label_plateChecker
            // 
            this.label_plateChecker.AutoSize = true;
            this.label_plateChecker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label_plateChecker.Location = new System.Drawing.Point(333, 20);
            this.label_plateChecker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_plateChecker.Name = "label_plateChecker";
            this.label_plateChecker.Size = new System.Drawing.Size(379, 39);
            this.label_plateChecker.TabIndex = 41;
            this.label_plateChecker.Text = "License Plate Checker";
            this.label_plateChecker.Click += new System.EventHandler(this.label7_Click);
            // 
            // label_copyright
            // 
            this.label_copyright.AutoSize = true;
            this.label_copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label_copyright.Location = new System.Drawing.Point(418, 472);
            this.label_copyright.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_copyright.Name = "label_copyright";
            this.label_copyright.Size = new System.Drawing.Size(190, 17);
            this.label_copyright.TabIndex = 42;
            this.label_copyright.Text = "Copyright CK Creations 2024";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(416, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 25);
            this.label7.TabIndex = 43;
            this.label7.Text = "*Not For Offical Use*";
            // 
            // button_buttonColor
            // 
            this.button_buttonColor.BackColor = System.Drawing.Color.LightGray;
            this.button_buttonColor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_buttonColor.FlatAppearance.BorderSize = 0;
            this.button_buttonColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_buttonColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_buttonColor.ForeColor = System.Drawing.Color.Black;
            this.button_buttonColor.Location = new System.Drawing.Point(89, 125);
            this.button_buttonColor.Margin = new System.Windows.Forms.Padding(4);
            this.button_buttonColor.Name = "button_buttonColor";
            this.button_buttonColor.Size = new System.Drawing.Size(116, 46);
            this.button_buttonColor.TabIndex = 44;
            this.button_buttonColor.Text = "Button Color";
            this.button_buttonColor.UseVisualStyleBackColor = false;
            this.button_buttonColor.Visible = false;
            this.button_buttonColor.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox_notePad
            // 
            this.textBox_notePad.Location = new System.Drawing.Point(18, 207);
            this.textBox_notePad.Multiline = true;
            this.textBox_notePad.Name = "textBox_notePad";
            this.textBox_notePad.Size = new System.Drawing.Size(236, 210);
            this.textBox_notePad.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(85, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Note Pad";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(160, 186);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 20);
            this.checkBox1.TabIndex = 47;
            this.checkBox1.Text = "On/Off";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1033, 492);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_notePad);
            this.Controls.Add(this.button_buttonColor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_copyright);
            this.Controls.Add(this.label_plateChecker);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.textBox_enterState);
            this.Controls.Add(this.label_text_state);
            this.Controls.Add(this.textBox_enterPlate);
            this.Controls.Add(this.button_trafficLaws);
            this.Controls.Add(this.button_editTheme_2);
            this.Controls.Add(this.button_fontColor);
            this.Controls.Add(this.button_themeColor);
            this.Controls.Add(this.button_editTheme);
            this.Controls.Add(this.label_text_plate);
            this.Controls.Add(this.label_text_supportedTitle);
            this.Controls.Add(this.webView_log);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_previousPlateTitle);
            this.Controls.Add(this.webView21);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Plate Checker v1.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView_log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private TextBox textBox_enterPlate;
        private Label label_previousPlateTitle;
        private TextBox textBox_enterState;
        private Label label_text_plate;
        private Label label_text_state;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private PictureBox pictureBox3;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_log;
        private Label label_text_supportedTitle;
        private Button button_editTheme;
        private Button button_themeColor;
        private Button button_fontColor;
        private Button button_editTheme_2;
        private Button button_trafficLaws;
        private PictureBox pictureBox4;
        private Label label_plateChecker;
        private Label label_copyright;
        private Label label7;
        private Button button_buttonColor;
        private TextBox textBox_notePad;
        private Label label1;
        private CheckBox checkBox1;
    }
}

