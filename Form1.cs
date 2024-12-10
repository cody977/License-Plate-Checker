using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Emgu.CV.Structure;
using Emgu.CV;
using Tesseract;
using System.Drawing;
using Patagames.Ocr;
using Patagames.Ocr.Enums;
using TesseractOCR.Pix;
using System.Security.Cryptography;
using Emgu.CV.CvEnum;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;
using System.Net;
using System.Drawing.Imaging;


namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public static string Plate { get; set; }

        string plate = Plate;
        string state = "";
        string website = "https://...";
        string logPath = Path.Combine(Directory.GetCurrentDirectory(), "log.txt");
        bool notePadActive = true;
        public Form1()
        {
            InitializeComponent();
            string disclosureText = "By Using This Software You Acknowledge That You Are An Authorized User. /n /n" +
                                    "You Agree To Always Confirm With Dispatch Before Acting On The Information Provided, /n /n" +
                                    "Agree That This Software Cannot Be Used In Reports, As Probable Cause, As Reasonable Suspicion, Or Can Be Blamed For Misinformation, /n" +
                                    "And Agree To Not Ditribute This Software To Anyone Without Authorization.";

            disclosureText = disclosureText.Replace("/n", " " + System.Environment.NewLine);

            System.Windows.Forms.MessageBox.Show(disclosureText);

            webView21.SendToBack();

            // Create a TextBox control for Enter key.
            System.Windows.Forms.TextBox tb = textBox_enterState;
            this.Controls.Add(tb);
            tb.KeyPress += new KeyPressEventHandler(keypressed);

            System.Windows.Forms.TextBox tb_plate = textBox_enterPlate;
            this.Controls.Add(tb_plate);
            tb_plate.KeyPress += new KeyPressEventHandler(keypressed);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Open File Log File
            string file = Path.Combine(Directory.GetCurrentDirectory(), "log.txt");
            //Process.Start(file);
            webView_log.Visible = true;
            webView_log.Source = new System.Uri(logPath, System.UriKind.Absolute);
        }

        private void keypressed(Object o, KeyPressEventArgs e)
        {
            //When Enter Key Is Pressed, Set Plate And State Var. W/ Text From Fields.
            //Alabama
            if ((e.KeyChar == (char)Keys.Return) && state == "AL")
            {
                e.Handled = true;
                website = $"https://alabamalicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Alaska
            if ((e.KeyChar == (char)Keys.Return) && state == "AK")
            {
                e.Handled = true;
                website = $"https://alaskalicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Arizona
            if ((e.KeyChar == (char)Keys.Return) && state == "AZ")
            {
                e.Handled = true;
                website = $"https://arizonalicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Arkansas
            if ((e.KeyChar == (char)Keys.Return) && state == "AR")
            {
                e.Handled = true;
                website = $"https://arkansaslicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //California
            if ((e.KeyChar == (char)Keys.Return) && state == "CA")
            {
                e.Handled = true;
                website = $"https://californialicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Colorado
            if ((e.KeyChar == (char)Keys.Return) && state == "CO")
            {
                e.Handled = true;
                website = $"https://coloradolicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Connecticut
            if ((e.KeyChar == (char)Keys.Return) && state == "CT")
            {
                e.Handled = true;
                website = $"https://connecticutlicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Delaware
            if ((e.KeyChar == (char)Keys.Return) && state == "DE")
            {
                e.Handled = true;
                website = $"https://delawarelicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //District Of Columbia
            if ((e.KeyChar == (char)Keys.Return) && state == "DC")
            {
                e.Handled = true;
                website = $"https://districtofcolumbialicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Florida
            if ((e.KeyChar == (char)Keys.Return) && state == "FL")
            {
                e.Handled = true;
                website = $"https://floridalicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Georgia
            if ((e.KeyChar == (char)Keys.Return) && state == "GA")
            {
                e.Handled = true;
                website = $"https://georgialicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Idaho
            if ((e.KeyChar == (char)Keys.Return) && state == "ID")
            {
                e.Handled = true;
                website = $"https://idaholicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Illinois
            if ((e.KeyChar == (char)Keys.Return) && state == "IL")
            {
                e.Handled = true;
                website = $"https://illinoislicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Indiana
            if ((e.KeyChar == (char)Keys.Return) && state == "IN")
            {
                e.Handled = true;
                website = $"https://indianalicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Iowa
            if ((e.KeyChar == (char)Keys.Return) && state == "IA")
            {
                e.Handled = true;
                website = $"https://iowalicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Kansas
            if ((e.KeyChar == (char)Keys.Return) && state == "KS")
            {
                e.Handled = true;
                website = $"https://kansaslicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Kentucky
            if ((e.KeyChar == (char)Keys.Return) && state == "KY")
            {
                e.Handled = true;
                website = $"https://kentuckylicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Louisiana
            if ((e.KeyChar == (char)Keys.Return) && state == "LA")
            {
                e.Handled = true;
                website = $"https://louisianalicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Maine
            if ((e.KeyChar == (char)Keys.Return) && state == "ME")
            {
                e.Handled = true;
                website = $"https://mainelicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Maryland
            if ((e.KeyChar == (char)Keys.Return) && state == "MD")
            {
                e.Handled = true;
                website = $"https://marylandlicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Massachussetts
            if ((e.KeyChar == (char)Keys.Return) && state == "MA")
            {
                e.Handled = true;
                website = $"https://massachusettslicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Michigan
            if ((e.KeyChar == (char)Keys.Return) && state == "MI")
            {
                e.Handled = true;
                website = $"https://michiganlicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Minnesota
            if ((e.KeyChar == (char)Keys.Return) && state == "MN")
            {
                e.Handled = true;
                website = $"https://minnesotalicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Missisippi
            if ((e.KeyChar == (char)Keys.Return) && state == "MS")
            {
                e.Handled = true;
                website = $"https://mississippilicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Missouri
            if ((e.KeyChar == (char)Keys.Return) && state == "MO")
            {
                e.Handled = true;
                website = $"https://missourilicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Montana
            if ((e.KeyChar == (char)Keys.Return) && state == "MT")
            {
                e.Handled = true;
                website = $"https://montanalicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Nebraska
            if ((e.KeyChar == (char)Keys.Return) && state == "NE")
            {
                e.Handled = true;
                website = $"https://nebraskalicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Nevada
            if ((e.KeyChar == (char)Keys.Return) && state == "NV")
            {
                e.Handled = true;
                website = $"https://nevadalicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //New Hampshire
            if ((e.KeyChar == (char)Keys.Return) && state == "NH")
            {
                e.Handled = true;
                website = $"https://newhampshirelicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //New Jersey
            if ((e.KeyChar == (char)Keys.Return) && state == "NJ")
            {
                e.Handled = true;
                website = $"https://newjerseylicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //New Mexico
            if ((e.KeyChar == (char)Keys.Return) && state == "NM")
            {
                e.Handled = true;
                website = $"https://newmexicolicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //New York
            if ((e.KeyChar == (char)Keys.Return) && state == "NY")
            {
                e.Handled = true;
                website = $"https://newyorklicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //North Carolina
            if ((e.KeyChar == (char)Keys.Return) && state == "NC")
            {
                e.Handled = true;
                website = $"https://northcarolinalicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //North Dakota
            if ((e.KeyChar == (char)Keys.Return) && state == "ND")
            {
                e.Handled = true;
                website = $"https://northdakotalicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Ohio
            if ((e.KeyChar == (char)Keys.Return) && state == "OH")
            {
                e.Handled = true;
                website = $"https://ohiolicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Oklahoma
            if ((e.KeyChar == (char)Keys.Return) && state == "OK")
            {
                e.Handled = true;
                website = $"https://oklahomalicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Oregon
            if ((e.KeyChar == (char)Keys.Return) && state == "OR")
            {
                e.Handled = true;
                website = $"https://oregonlicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Pennsylvania
            if ((e.KeyChar == (char)Keys.Return) && state == "PA")
            {
                e.Handled = true;
                website = $"https://pennsylavnialicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Rhode Island
            if ((e.KeyChar == (char)Keys.Return) && state == "RI")
            {
                e.Handled = true;
                website = $"https://rhodeislandlicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //South Carolina
            if ((e.KeyChar == (char)Keys.Return) && state == "SC")
            {
                e.Handled = true;
                website = $"https://southcarolinalicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //South Dakota
            if ((e.KeyChar == (char)Keys.Return) && state == "SD")
            {
                e.Handled = true;
                website = $"https://southdakotalicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Tennessee
            if ((e.KeyChar == (char)Keys.Return) && state == "TN")
            {
                e.Handled = true;
                website = $"https://tennesseelicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Texas
            if ((e.KeyChar == (char)Keys.Return) && state == "TX")
            {
                e.Handled = true;
                website = $"https://texaslicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Utah
            if ((e.KeyChar == (char)Keys.Return) && state == "UT")
            {
                e.Handled = true;
                website = $"https://utahlicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Vermont
            if ((e.KeyChar == (char)Keys.Return) && state == "VT")
            {
                e.Handled = true;
                website = $"https://vermontlicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Virginia
            if ((e.KeyChar == (char)Keys.Return) && state == "VA")
            {
                e.Handled = true;
                website = $"https://virginialicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Washington
            if ((e.KeyChar == (char)Keys.Return) && state == "WA")
            {
                e.Handled = true;
                website = $"https://washingtonlicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //West Virginia
            if ((e.KeyChar == (char)Keys.Return) && state == "WV")
            {
                e.Handled = true;
                website = $"https://westvirginialicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Wisconsin
            if ((e.KeyChar == (char)Keys.Return) && state == "WI")
            {
                e.Handled = true;
                website = $"https://wisconsinlicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Wyoming
            if ((e.KeyChar == (char)Keys.Return) && state == "WY")
            {
                e.Handled = true;
                website = $"https://wyominglicenseplate.com/result?plate={plate}";
                webView21.Source = new System.Uri($"{website}", System.UriKind.Absolute);
                webView21.Visible = true;
                webView21.SendToBack();
            }

            //Create/Add "log.txt" File On Enter Key Down
            if ((e.KeyChar == (char)Keys.Return))
            {
                // If file does not exists
                if (!File.Exists(logPath))
                {
                    File.Create("log.txt").Close(); // Create file
                    using (StreamWriter sw = File.AppendText(logPath))
                    {

                        sw.WriteLine(plate + " " + state); // Write text to .txt file
                        textBox_enterPlate.Text = "";
                    }
                }
                // If file already exists
                else
                {
                    
                    // Read existing content
                    string fileContent = File.ReadAllText(logPath);

                    // Prepend the new line
                    string updatedContent = plate + " " + state + Environment.NewLine + fileContent;

                    // Write back to the file
                    File.WriteAllText(logPath, updatedContent);

                    // File.WriteAllText("FILENAME.txt", String.Empty); // Clear file
                    using (StreamWriter sw = File.AppendText(logPath))
                    {
                        textBox_enterPlate.Text = "";
                        webView_log.Reload();
                    }
                }
            }

        }

        //License Plate Text Box
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Assign Plate Var. With Text From Text Box
            plate = textBox_enterPlate.Text;

        }

        private void textBox1_KeyDown(object sender, EventArgs e)
        {

        }

        //State Text Box
        private void textBox_enterState_TextChanged_1(object sender, EventArgs e)
        {
            //Assign State Var. With Text From Text Box
            state = textBox_enterState.Text;
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_disclaimerText_Click(object sender, EventArgs e)
        {

        }

        private void webView_placeHolder_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_text_state_Click(object sender, EventArgs e)
        {

        }

        private void label_disclaimedTest_2_Click(object sender, EventArgs e)
        {

        }

        private void label_text_plate_Click(object sender, EventArgs e)
        {

        }

        //Clear Log Button
        private void button1_Click(object sender, EventArgs e)
        {
            // Read existing content
            string fileContent = File.ReadAllText(logPath);

            // Prepend the new line
            string updatedContent = " ";

            // Write back to the file
            File.WriteAllText(logPath, updatedContent);

            webView_log.Reload();
        } 


     

            private void pictureBox_preview_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_capture_Click(object sender, EventArgs e)
        {

        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void webView21_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_themeColor.Visible = true;
            button_fontColor.Visible = true;
            button_editTheme_2.Visible = true;
            button_buttonColor.Visible = true;
            //button_editTheme_1.Visible = false;
        }

        private void button_themeColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;


            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                BackColor = MyDialog.Color;
           
        }

        private void button_fontColor_Click(object sender, EventArgs e)
        {
            //Font
            ColorDialog MyDialog2 = new ColorDialog();
            MyDialog2.AllowFullOpen = true;

            // Update the text box color if the user clicks OK 
            if (MyDialog2.ShowDialog() == DialogResult.OK)
                ForeColor = MyDialog2.Color;
        }

        private void button_editTheme_2_Click(object sender, EventArgs e)
        {
            button_themeColor.Visible = false;
            button_fontColor.Visible = false;
            button_editTheme.Visible = true;
            button_editTheme_2.Visible = false;
            button_buttonColor.Visible = false;
            button_editTheme_2.BackColor = System.Drawing.Color.DarkGray;
        }

        private void button_trafficLaws_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://motrafficlaws.com/");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ColorDialog MyDialog3 = new ColorDialog();
            MyDialog3.AllowFullOpen = true;


            // Update the text box color if the user clicks OK 
            if (MyDialog3.ShowDialog() == DialogResult.OK)
            {
                button_trafficLaws.BackColor = MyDialog3.Color;
                button1.BackColor = MyDialog3.Color;
                button_buttonColor.BackColor = MyDialog3.Color;
                button_editTheme.BackColor = MyDialog3.Color;
                button_editTheme_2.BackColor = MyDialog3.Color;
                button_fontColor.BackColor = MyDialog3.Color;
                button_themeColor.BackColor = MyDialog3.Color;


            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (notePadActive)
            {
                textBox_notePad.Visible = false;
                notePadActive = false;
            }

            else if (!notePadActive)
            {
                textBox_notePad.Visible = true;
                notePadActive = true;
            }
        }
    }
}


