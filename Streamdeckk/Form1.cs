using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Streamdeckk
{
    public partial class Form1 : Form
    {
        //Media
        public const int KEYEVENTF_EXTENTEDKEY = 1;
        public const int KEYEVENTF_KEYUP = 0;
        public const int VK_MEDIA_NEXT_TRACK = 0xB0;
        public const int VK_MEDIA_PLAY_PAUSE = 0xB3;
        public const int VK_MEDIA_PREV_TRACK = 0xB1;

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte virtualKey, byte scanCode, uint flags, IntPtr extraInfo);

        //Form events
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Propertytrue(5);
            textBoxs(15);
            selection2();
            string[] ports = SerialPort.GetPortNames();  //Seri portları diziye ekleme
            foreach (string port in ports)
                Comports.Items.Add(port);               //Seri portları comboBox1'e ekleme

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived); //DataReceived eventini oluşturma
           
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            Itemsnull();
            textBoxs(15);
            selection2();
        }
        //Data
        private string data;
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            try
            {
                data = serialPort1.ReadLine();                      //Veriyi al
                this.Invoke(new EventHandler(DisplayData_event));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");    //Hata mesajı göster
            }
        }

        private void DisplayData_event(object sender, EventArgs e)
        {
            int testInt = Convert.ToInt16(data);
            if (testInt == 1) //eğer arduinodan 1 verisi gelirse zoom açılsın
            {
                if (appfile.Visible == true)
                {
                    System.Diagnostics.Process.Start(textBox2.Text);
                }

                if (textBox2.Text == "Media Stop/Play")
                 {
                   keybd_event(VK_MEDIA_PLAY_PAUSE, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
                 }

                if (textBox2.Text == "Screanshot")
                {
                    //SendKeys.Send("^a");        
                    Bitmap foto = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                    Graphics grafik = Graphics.FromImage(foto);
                    grafik.CopyFromScreen(0, 0, 0, 0, new Size(foto.Width, foto.Height));
                    İtems01.Image = foto;
                }
            }
            if (testInt == 2) //eğer arduinodan 1 verisi gelirse zoom açılsın
            {
                if (appfile.Visible == true)
                {
                    System.Diagnostics.Process.Start(textBox3.Text);
                }

                if (textBox3.Text == "Media Stop/Play")
                {
                    keybd_event(VK_MEDIA_PLAY_PAUSE, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
                }

                if (textBox3.Text == "Screanshot")
                {
                    //SendKeys.Send("^a");        
                    Bitmap foto = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                    Graphics grafik = Graphics.FromImage(foto);
                    grafik.CopyFromScreen(0, 0, 0, 0, new Size(foto.Width, foto.Height));
                    İtems02.Image = foto;
                }
            }
        }
        //Lists
        private void Propertyfalse(int cNumber)
        {
            foreach (var pb in this.Controls.OfType<Button>())
            {
                //do stuff
                if (pb.Name.StartsWith("Property")) 
                {
                    pb.Visible = false;
                }
            }
        }
        private void Propertytrue(int cNumber)
        {
            foreach (var pb in this.Controls.OfType<Button>())
            {
                //do stuff
                if (pb.Name.StartsWith("Property"))
                {
                    pb.Visible = true;
                }
            }
        }

        private void Itemsnull()
        {
            foreach (var pb in this.Controls.OfType<PictureBox>())
            {
                //do stuff
                if (pb.Name.StartsWith("items"))
                {
                    pb.Image = null;
                }
            }
        }

        private void textBoxs(int cNumber)
        {
            foreach (var pb in this.Controls.OfType<TextBox>())
            {
                //do stuff
                if (pb.Name.StartsWith("textBox"))
                {
                    pb.Visible = false;
                }
            }
        }

        private void selection()
        {
            nPropertylabel.Visible = true;
            nlabel1.Visible = false;
            nSelectphoto.Visible = true;
            name.Visible = true;
            nLine.Visible = true;
        }
        private void selection2()
        {
            trash.Visible = false;
            appfile.Visible = false;
            nLine.Visible = false;
            name.Visible = false;
            nSelectphoto.Visible = false;
            nPropertylabel.Visible = false;
            nlabel1.Visible = true;
            nLine.Visible = false;
        }
        // İtems
        private void items1_Click(object sender, EventArgs e)
        {
            selection();
            Itemsnull();
            items1.Visible = true;
            items1.Image = Image.FromFile("Frame icon.png");
            name.Text = "Control Center : Button 1";            
            textBoxs(15);
            textBox2.Visible = true;
            if (textBox2.Text == "Url")
            {
                trash.Visible = true;
            }
            if (textBox2.Text == "Open")
            {
                trash.Visible = true;
                appfile.Visible = true;
            }
        }
        private void items2_Click(object sender, EventArgs e)
        {
            Itemsnull();
            items2.Visible = true;
            items2.Image = Image.FromFile("Frame icon.png");
            selection();
            name.Text = "Control Center : Button 2";
            nSelectphoto.Visible = true;
            textBoxs(15);
            textBox3.Visible = true;
            if (textBox3.Text == "Url")
            {
                trash.Visible = true;
            }
            if (textBox3.Text == "Open")
            {
                trash.Visible = true;
                appfile.Visible = true;
            }
        }
        private void items3_Click(object sender, EventArgs e)
        {
            Itemsnull();
            items3.Visible = true;
            items3.Image = Image.FromFile("Frame icon.png");
            selection();
            name.Text = "Control Center : Button 3";
            textBoxs(15);
            textBox4.Visible = true;
            if (textBox4.Text == "Url")
            {
                trash.Visible = true;
            }
            if (textBox4.Text == "Open")
            {
                trash.Visible = true;
                appfile.Visible = true;
            }
        }
        private void items4_Click(object sender, EventArgs e)
        {

        }
        private void items5_Click(object sender, EventArgs e)
        {

        }
        private void items6_Click(object sender, EventArgs e)
        {

        }
        private void items7_Click(object sender, EventArgs e)
        {

        }
        private void items8_Click(object sender, EventArgs e)
        {

        }
        private void items9_Click(object sender, EventArgs e)
        {

        }

        private void items10_Click(object sender, EventArgs e)
        {

        }

        private void items11_Click(object sender, EventArgs e)
        {

        }

        private void items12_Click(object sender, EventArgs e)
        {

        }

        private void items13_Click(object sender, EventArgs e)
        {

        }
        private void items14_Click(object sender, EventArgs e)
        {

        }
        private void items15_Click(object sender, EventArgs e)
        {

        }

        private void Comports_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = Comports.Text;  //ComboBox1'de seçili nesneyi port ismine ata
                serialPort1.BaudRate = 9600;            //BaudRate 9600 olarak ayarla
                serialPort1.Open();                //Seri portu aç
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");    //Hata mesajı göster
            }
        }
        private void Selectphoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya3 = new OpenFileDialog();
            dosya3.Filter = "Image file |*.jpg;*.nef;*.png| |*.*";
            dosya3.ShowDialog();
            string DosyaYolu3 = dosya3.FileName;
            if (name.Text == "Control Center : Button 1")
            {
                İtems01.Image = Image.FromFile(DosyaYolu3);
            }
            if (name.Text == "Control Center : Button 2")
            {
                İtems02.Image = Image.FromFile(DosyaYolu3);
            }
        }

        private void appfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya2 = new OpenFileDialog();
            dosya2.Filter = "All files |";
            dosya2.ShowDialog();
            string DosyaYolu2 = dosya2.FileName;
            if (name.Text == "Control Center : Button 1")
            {
                textBox2.Text = DosyaYolu2;
            }
            if (name.Text == "Control Center : Button 2")
            {
                textBox3.Text = DosyaYolu2;
            }
        }

        bool metroBtnFlag = true;
        private void Arrow_Click(object sender, EventArgs e)
        {          
            if (metroBtnFlag)
            {
                metroBtnFlag = false;
                Arrow.Image = Image.FromFile("chevron (3).png");
                Propertyfalse(7);
                Property06.Visible = false;
            }
            else
            {
                Propertytrue(7);
                metroBtnFlag = true;
                Arrow.Image = Image.FromFile("chevron (2).png");
                Property06.Visible = true;
            }           
        }
      
        //Screanshot
        private void Property1_Click(object sender, EventArgs e)
        {          
            if (name.Text == "Control Center : Button 1")
            {
                trash.Visible = true;
                İtems01.Image = Image.FromFile("camera (1).png");
                textBox2.Text = "Screanshot";
                appfile.Visible = false;
            }
            if (name.Text == "Control Center : Button 2")
            {
                trash.Visible = true;
                İtems02.Image = Image.FromFile("camera (1).png");
                textBox3.Text = "Screanshot";
                appfile.Visible = false;
            }
            if (name.Text == "Control Center : Button 3")
            {
                trash.Visible = true;
                İtems03.Image = Image.FromFile("camera (1).png");
                textBox4.Text = "Screanshot";
                appfile.Visible = false;
            }
        }
        //Create Folder
        private void Property2_Click(object sender, EventArgs e)
        {
            appfile.Visible = false;         
        }
        //Open
        private void Property3_Click(object sender, EventArgs e)
        {
            if (name.Text == "Control Center : Button 1")
            {
                trash.Visible = true;
                İtems01.Image = Image.FromFile("open (1).png");
                textBox2.Text = "Open";
                appfile.Visible = true;
            }
            if (name.Text == "Control Center : Button 2")
            {
                trash.Visible = true;
                İtems02.Image = Image.FromFile("open (1).png");
                textBox3.Text = "Open";
                appfile.Visible = true;
            }
            if (name.Text == "Control Center : Button 3")
            {
                trash.Visible = true;
                İtems03.Image = Image.FromFile("open (1).png");
                textBox4.Text = "Open";
                appfile.Visible = true;
            }
        }
        //Media Stop/Play
        private void Property4_Click(object sender, EventArgs e)
        {     
            
            if(name.Text == "Control Center : Button 1")
            {
                appfile.Visible = false;
                trash.Visible = true;
                İtems01.Image = Image.FromFile("StopPlay icon.png");
                textBox2.Text = "Media Stop/Play";
            }
            if (name.Text == "Control Center : Button 2")
            {
                appfile.Visible = false;
                trash.Visible = true;
                İtems02.Image = Image.FromFile("StopPlay icon.png");
                textBox3.Text = "Media Stop/Play";
            }
            if (name.Text == "Control Center : Button 3")
            {
                appfile.Visible = false;
                trash.Visible = true;
                İtems03.Image = Image.FromFile("StopPlay icon.png");
                textBox4.Text = "Media Stop/Play";
            }
        }
        //Website
        private void Property5_Click(object sender, EventArgs e)
        {                    
            if (name.Text == "Control Center : Button 1")
            {
                trash.Visible = true;
                İtems01.Image = Image.FromFile("global.png");
                textBox2.Text = "Url";
                appfile.Visible = false;
            }
            if (name.Text == "Control Center : Button 2")
            {
                trash.Visible = true;
                İtems02.Image = Image.FromFile("global.png");
                textBox3.Text = "Url";
                appfile.Visible = false;
            }
            if (name.Text == "Control Center : Button 3")
            {
                trash.Visible = true;
                İtems03.Image = Image.FromFile("global.png");
                textBox4.Text = "Url";
                appfile.Visible = false;
            }
        }

         //Text Property
        private void Property6_Click(object sender, EventArgs e)
        {
            if (name.Text == "Control Center : Button 1")
            {
                trash.Visible = true;
                İtems01.Image = Image.FromFile("T icon.png");
                textBox2.Text = "Url";
                appfile.Visible = false;
            }
            if (name.Text == "Control Center : Button 2")
            {
                trash.Visible = true;
                İtems02.Image = Image.FromFile("T icon.png");
                textBox3.Text = "Url";
                appfile.Visible = false;
            }
            if (name.Text == "Control Center : Button 3")
            {
                trash.Visible = true;
                İtems03.Image = Image.FromFile("T icon.png");
                textBox4.Text = "Url";
                appfile.Visible = false;
            }
        }
        //Text icon
        private void Property06_Click(object sender, EventArgs e)
        {
            if (name.Text == "Control Center : Button 1")
            {
                trash.Visible = true;
                İtems01.Image = Image.FromFile("T icon.png");
                textBox2.Text = "Url";
                appfile.Visible = false;
            }
            if (name.Text == "Control Center : Button 2")
            {
                trash.Visible = true;
                İtems02.Image = Image.FromFile("T icon.png");
                textBox3.Text = "Url";
                appfile.Visible = false;
            }
            if (name.Text == "Control Center : Button 3")
            {
                trash.Visible = true;
                İtems03.Image = Image.FromFile("T icon.png");
                textBox4.Text = "Url";
                appfile.Visible = false;
            }
        }
        private void trash_MouseEnter(object sender, EventArgs e)
        {
            trash.Height += 6;
            trash.Width += 6;
        }

        private void trash_MouseLeave(object sender, EventArgs e)
        {
            trash.Height -= 6;
            trash.Width -= 6;
        }
       private void trash_Click(object sender, EventArgs e)
        {
            if(name.Text == "Control Center : Button 1")
            {
                appfile.Visible = false;
                İtems01.Image = null;
                textBox2.Text = null;
            }
            if (name.Text == "Control Center : Button 2")
            {
                appfile.Visible = false;
                İtems01.Image = null;
                textBox3.Text = null;
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                MessageBox.Show("Pressed " + Keys.Control);
            }
        }

        private void items03_Click(object sender, EventArgs e)
        {
            Itemsnull();
            items3.Visible = true;
            items3.Image = Image.FromFile("Frame icon.png");
            selection();
            name.Text = "Control Center : Button 3";
            textBoxs(15);
            textBox4.Visible = true;
            if (textBox4.Text == "Url")
            {
                trash.Visible = true;
            }
            if (textBox4.Text == "Open")
            {
                trash.Visible = true;
                appfile.Visible = true;
            }
        }
    }
}