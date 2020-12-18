
namespace Streamdeckk
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Comports = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.items1 = new System.Windows.Forms.PictureBox();
            this.items2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.items3 = new System.Windows.Forms.PictureBox();
            this.items4 = new System.Windows.Forms.PictureBox();
            this.items5 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.items7 = new System.Windows.Forms.PictureBox();
            this.items6 = new System.Windows.Forms.PictureBox();
            this.items8 = new System.Windows.Forms.PictureBox();
            this.items9 = new System.Windows.Forms.PictureBox();
            this.items10 = new System.Windows.Forms.PictureBox();
            this.items11 = new System.Windows.Forms.PictureBox();
            this.items12 = new System.Windows.Forms.PictureBox();
            this.items13 = new System.Windows.Forms.PictureBox();
            this.items14 = new System.Windows.Forms.PictureBox();
            this.items15 = new System.Windows.Forms.PictureBox();
            this.pictureBox49 = new System.Windows.Forms.PictureBox();
            this.İtems01 = new System.Windows.Forms.PictureBox();
            this.İtems02 = new System.Windows.Forms.PictureBox();
            this.İtems03 = new System.Windows.Forms.PictureBox();
            this.Property1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Arrow = new System.Windows.Forms.PictureBox();
            this.Property2 = new System.Windows.Forms.Button();
            this.Property4 = new System.Windows.Forms.Button();
            this.Property3 = new System.Windows.Forms.Button();
            this.Property5 = new System.Windows.Forms.Button();
            this.Property6 = new System.Windows.Forms.Button();
            this.Property06 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.nlabel1 = new System.Windows.Forms.Label();
            this.appfile = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nSelectphoto = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.nLine = new System.Windows.Forms.PictureBox();
            this.nPropertylabel = new System.Windows.Forms.Label();
            this.trash = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.items1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.İtems01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.İtems02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.İtems03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Property06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSelectphoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trash)).BeginInit();
            this.SuspendLayout();
            // 
            // Comports
            // 
            this.Comports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Comports.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comports.ForeColor = System.Drawing.Color.White;
            this.Comports.FormattingEnabled = true;
            this.Comports.Location = new System.Drawing.Point(22, 23);
            this.Comports.Name = "Comports";
            this.Comports.Size = new System.Drawing.Size(160, 26);
            this.Comports.TabIndex = 0;
            this.Comports.Text = "Developer Keyboard";
            this.Comports.SelectedIndexChanged += new System.EventHandler(this.Comports_SelectedIndexChanged);
            // 
            // items1
            // 
            this.items1.BackColor = System.Drawing.Color.Black;
            this.items1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.items1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.items1.Location = new System.Drawing.Point(298, 104);
            this.items1.Name = "items1";
            this.items1.Size = new System.Drawing.Size(84, 81);
            this.items1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.items1.TabIndex = 9;
            this.items1.TabStop = false;
            this.items1.Click += new System.EventHandler(this.items1_Click);
            // 
            // items2
            // 
            this.items2.BackColor = System.Drawing.Color.Black;
            this.items2.Location = new System.Drawing.Point(397, 104);
            this.items2.Name = "items2";
            this.items2.Size = new System.Drawing.Size(84, 81);
            this.items2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.items2.TabIndex = 10;
            this.items2.TabStop = false;
            this.items2.Click += new System.EventHandler(this.items2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(-479, 46);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(153, 81);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // items3
            // 
            this.items3.BackColor = System.Drawing.Color.Black;
            this.items3.Location = new System.Drawing.Point(497, 104);
            this.items3.Name = "items3";
            this.items3.Size = new System.Drawing.Size(84, 81);
            this.items3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.items3.TabIndex = 30;
            this.items3.TabStop = false;
            this.items3.Click += new System.EventHandler(this.items3_Click);
            // 
            // items4
            // 
            this.items4.BackColor = System.Drawing.Color.Black;
            this.items4.Location = new System.Drawing.Point(597, 104);
            this.items4.Name = "items4";
            this.items4.Size = new System.Drawing.Size(84, 81);
            this.items4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.items4.TabIndex = 31;
            this.items4.TabStop = false;
            this.items4.Click += new System.EventHandler(this.items4_Click);
            // 
            // items5
            // 
            this.items5.BackColor = System.Drawing.Color.Black;
            this.items5.Location = new System.Drawing.Point(697, 104);
            this.items5.Name = "items5";
            this.items5.Size = new System.Drawing.Size(84, 81);
            this.items5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.items5.TabIndex = 32;
            this.items5.TabStop = false;
            this.items5.Click += new System.EventHandler(this.items5_Click);
            // 
            // items7
            // 
            this.items7.BackColor = System.Drawing.Color.Black;
            this.items7.Location = new System.Drawing.Point(397, 201);
            this.items7.Name = "items7";
            this.items7.Size = new System.Drawing.Size(84, 80);
            this.items7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.items7.TabIndex = 54;
            this.items7.TabStop = false;
            this.items7.Click += new System.EventHandler(this.items7_Click);
            // 
            // items6
            // 
            this.items6.BackColor = System.Drawing.Color.Black;
            this.items6.Location = new System.Drawing.Point(298, 199);
            this.items6.Name = "items6";
            this.items6.Size = new System.Drawing.Size(84, 81);
            this.items6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.items6.TabIndex = 33;
            this.items6.TabStop = false;
            this.items6.Click += new System.EventHandler(this.items6_Click);
            // 
            // items8
            // 
            this.items8.BackColor = System.Drawing.Color.Black;
            this.items8.Location = new System.Drawing.Point(497, 201);
            this.items8.Name = "items8";
            this.items8.Size = new System.Drawing.Size(84, 80);
            this.items8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.items8.TabIndex = 56;
            this.items8.TabStop = false;
            this.items8.Click += new System.EventHandler(this.items8_Click);
            // 
            // items9
            // 
            this.items9.BackColor = System.Drawing.Color.Black;
            this.items9.Location = new System.Drawing.Point(597, 201);
            this.items9.Name = "items9";
            this.items9.Size = new System.Drawing.Size(84, 80);
            this.items9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.items9.TabIndex = 58;
            this.items9.TabStop = false;
            this.items9.Click += new System.EventHandler(this.items9_Click);
            // 
            // items10
            // 
            this.items10.BackColor = System.Drawing.Color.Black;
            this.items10.Location = new System.Drawing.Point(697, 200);
            this.items10.Name = "items10";
            this.items10.Size = new System.Drawing.Size(84, 80);
            this.items10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.items10.TabIndex = 60;
            this.items10.TabStop = false;
            this.items10.Click += new System.EventHandler(this.items10_Click);
            // 
            // items11
            // 
            this.items11.BackColor = System.Drawing.Color.Black;
            this.items11.Location = new System.Drawing.Point(298, 297);
            this.items11.Name = "items11";
            this.items11.Size = new System.Drawing.Size(84, 80);
            this.items11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.items11.TabIndex = 62;
            this.items11.TabStop = false;
            this.items11.Click += new System.EventHandler(this.items11_Click);
            // 
            // items12
            // 
            this.items12.BackColor = System.Drawing.Color.Black;
            this.items12.Location = new System.Drawing.Point(397, 297);
            this.items12.Name = "items12";
            this.items12.Size = new System.Drawing.Size(84, 80);
            this.items12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.items12.TabIndex = 64;
            this.items12.TabStop = false;
            this.items12.Click += new System.EventHandler(this.items12_Click);
            // 
            // items13
            // 
            this.items13.BackColor = System.Drawing.Color.Black;
            this.items13.Location = new System.Drawing.Point(497, 297);
            this.items13.Name = "items13";
            this.items13.Size = new System.Drawing.Size(84, 80);
            this.items13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.items13.TabIndex = 66;
            this.items13.TabStop = false;
            this.items13.Click += new System.EventHandler(this.items13_Click);
            // 
            // items14
            // 
            this.items14.BackColor = System.Drawing.Color.Black;
            this.items14.Location = new System.Drawing.Point(597, 297);
            this.items14.Name = "items14";
            this.items14.Size = new System.Drawing.Size(84, 80);
            this.items14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.items14.TabIndex = 68;
            this.items14.TabStop = false;
            this.items14.Click += new System.EventHandler(this.items14_Click);
            // 
            // items15
            // 
            this.items15.BackColor = System.Drawing.Color.Black;
            this.items15.Location = new System.Drawing.Point(697, 297);
            this.items15.Name = "items15";
            this.items15.Size = new System.Drawing.Size(84, 80);
            this.items15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.items15.TabIndex = 70;
            this.items15.TabStop = false;
            this.items15.Click += new System.EventHandler(this.items15_Click);
            // 
            // pictureBox49
            // 
            this.pictureBox49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pictureBox49.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox49.Image")));
            this.pictureBox49.Location = new System.Drawing.Point(-4, 403);
            this.pictureBox49.Name = "pictureBox49";
            this.pictureBox49.Size = new System.Drawing.Size(1100, 38);
            this.pictureBox49.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox49.TabIndex = 51;
            this.pictureBox49.TabStop = false;
            // 
            // İtems01
            // 
            this.İtems01.BackColor = System.Drawing.Color.Black;
            this.İtems01.Location = new System.Drawing.Point(316, 121);
            this.İtems01.Name = "İtems01";
            this.İtems01.Size = new System.Drawing.Size(48, 46);
            this.İtems01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.İtems01.TabIndex = 72;
            this.İtems01.TabStop = false;
            this.İtems01.Click += new System.EventHandler(this.items1_Click);
            // 
            // İtems02
            // 
            this.İtems02.BackColor = System.Drawing.Color.Black;
            this.İtems02.Location = new System.Drawing.Point(416, 121);
            this.İtems02.Name = "İtems02";
            this.İtems02.Size = new System.Drawing.Size(48, 46);
            this.İtems02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.İtems02.TabIndex = 73;
            this.İtems02.TabStop = false;
            this.İtems02.Click += new System.EventHandler(this.items2_Click);
            // 
            // İtems03
            // 
            this.İtems03.BackColor = System.Drawing.Color.Black;
            this.İtems03.Location = new System.Drawing.Point(515, 121);
            this.İtems03.Name = "İtems03";
            this.İtems03.Size = new System.Drawing.Size(48, 46);
            this.İtems03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.İtems03.TabIndex = 74;
            this.İtems03.TabStop = false;
            this.İtems03.Click += new System.EventHandler(this.items03_Click);
            // 
            // Property1
            // 
            this.Property1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Property1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Property1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Property1.Location = new System.Drawing.Point(1166, 49);
            this.Property1.Name = "Property1";
            this.Property1.Size = new System.Drawing.Size(137, 33);
            this.Property1.TabIndex = 75;
            this.Property1.Text = "📸 Screanshot";
            this.Property1.UseVisualStyleBackColor = false;
            this.Property1.Click += new System.EventHandler(this.Property1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1181, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "System";
            // 
            // Arrow
            // 
            this.Arrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Arrow.Image = ((System.Drawing.Image)(resources.GetObject("Arrow.Image")));
            this.Arrow.Location = new System.Drawing.Point(1141, 9);
            this.Arrow.Name = "Arrow";
            this.Arrow.Size = new System.Drawing.Size(34, 20);
            this.Arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Arrow.TabIndex = 2;
            this.Arrow.TabStop = false;
            this.Arrow.Click += new System.EventHandler(this.Arrow_Click);
            // 
            // Property2
            // 
            this.Property2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Property2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Property2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Property2.Location = new System.Drawing.Point(1166, 88);
            this.Property2.Name = "Property2";
            this.Property2.Size = new System.Drawing.Size(137, 33);
            this.Property2.TabIndex = 6;
            this.Property2.Text = "📁 Create folder";
            this.Property2.UseVisualStyleBackColor = false;
            this.Property2.Click += new System.EventHandler(this.Property2_Click);
            // 
            // Property4
            // 
            this.Property4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Property4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Property4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Property4.Location = new System.Drawing.Point(1166, 166);
            this.Property4.Name = "Property4";
            this.Property4.Size = new System.Drawing.Size(137, 33);
            this.Property4.TabIndex = 8;
            this.Property4.Text = "⏯ Media Stop/Play";
            this.Property4.UseVisualStyleBackColor = false;
            this.Property4.Click += new System.EventHandler(this.Property4_Click);
            // 
            // Property3
            // 
            this.Property3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Property3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Property3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Property3.Location = new System.Drawing.Point(1166, 127);
            this.Property3.Name = "Property3";
            this.Property3.Size = new System.Drawing.Size(137, 33);
            this.Property3.TabIndex = 7;
            this.Property3.Text = "🚀 Open";
            this.Property3.UseVisualStyleBackColor = false;
            this.Property3.Click += new System.EventHandler(this.Property3_Click);
            // 
            // Property5
            // 
            this.Property5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Property5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Property5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Property5.Location = new System.Drawing.Point(1166, 205);
            this.Property5.Name = "Property5";
            this.Property5.Size = new System.Drawing.Size(137, 33);
            this.Property5.TabIndex = 9;
            this.Property5.Text = "🌐 Website";
            this.Property5.UseVisualStyleBackColor = false;
            this.Property5.Click += new System.EventHandler(this.Property5_Click);
            // 
            // Property6
            // 
            this.Property6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Property6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Property6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Property6.Location = new System.Drawing.Point(1166, 244);
            this.Property6.Name = "Property6";
            this.Property6.Size = new System.Drawing.Size(137, 33);
            this.Property6.TabIndex = 10;
            this.Property6.Text = "Text";
            this.Property6.UseVisualStyleBackColor = false;
            this.Property6.Click += new System.EventHandler(this.Property6_Click);
            // 
            // Property06
            // 
            this.Property06.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Property06.Image = ((System.Drawing.Image)(resources.GetObject("Property06.Image")));
            this.Property06.Location = new System.Drawing.Point(1202, 253);
            this.Property06.Name = "Property06";
            this.Property06.Size = new System.Drawing.Size(15, 15);
            this.Property06.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Property06.TabIndex = 11;
            this.Property06.TabStop = false;
            this.Property06.Click += new System.EventHandler(this.Property06_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pictureBox1.Location = new System.Drawing.Point(1095, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(534, 694);
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(478, 499);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 28);
            this.textBox3.TabIndex = 8;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // nlabel1
            // 
            this.nlabel1.AutoSize = true;
            this.nlabel1.BackColor = System.Drawing.Color.Transparent;
            this.nlabel1.Font = new System.Drawing.Font("Calibri", 11F);
            this.nlabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.nlabel1.Location = new System.Drawing.Point(428, 530);
            this.nlabel1.Name = "nlabel1";
            this.nlabel1.Size = new System.Drawing.Size(220, 18);
            this.nlabel1.TabIndex = 26;
            this.nlabel1.Text = "Select a key to configure its action.";
            // 
            // appfile
            // 
            this.appfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.appfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.appfile.Location = new System.Drawing.Point(734, 498);
            this.appfile.Name = "appfile";
            this.appfile.Size = new System.Drawing.Size(31, 28);
            this.appfile.TabIndex = 36;
            this.appfile.Text = "...";
            this.appfile.UseVisualStyleBackColor = false;
            this.appfile.Click += new System.EventHandler(this.appfile_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(478, 499);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 28);
            this.textBox2.TabIndex = 4;
            // 
            // nSelectphoto
            // 
            this.nSelectphoto.Image = ((System.Drawing.Image)(resources.GetObject("nSelectphoto.Image")));
            this.nSelectphoto.Location = new System.Drawing.Point(328, 490);
            this.nSelectphoto.Name = "nSelectphoto";
            this.nSelectphoto.Size = new System.Drawing.Size(75, 68);
            this.nSelectphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nSelectphoto.TabIndex = 9;
            this.nSelectphoto.TabStop = false;
            this.nSelectphoto.Click += new System.EventHandler(this.Selectphoto_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.name.Location = new System.Drawing.Point(295, 444);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(45, 18);
            this.name.TabIndex = 24;
            this.name.Text = "Name";
            // 
            // nLine
            // 
            this.nLine.BackColor = System.Drawing.Color.Transparent;
            this.nLine.Image = ((System.Drawing.Image)(resources.GetObject("nLine.Image")));
            this.nLine.Location = new System.Drawing.Point(298, 465);
            this.nLine.Name = "nLine";
            this.nLine.Size = new System.Drawing.Size(483, 19);
            this.nLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nLine.TabIndex = 28;
            this.nLine.TabStop = false;
            // 
            // nPropertylabel
            // 
            this.nPropertylabel.AutoSize = true;
            this.nPropertylabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nPropertylabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.nPropertylabel.Location = new System.Drawing.Point(409, 504);
            this.nPropertylabel.Name = "nPropertylabel";
            this.nPropertylabel.Size = new System.Drawing.Size(66, 18);
            this.nPropertylabel.TabIndex = 30;
            this.nPropertylabel.Text = "Property:";
            // 
            // trash
            // 
            this.trash.Image = ((System.Drawing.Image)(resources.GetObject("trash.Image")));
            this.trash.Location = new System.Drawing.Point(750, 432);
            this.trash.Name = "trash";
            this.trash.Size = new System.Drawing.Size(31, 43);
            this.trash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trash.TabIndex = 50;
            this.trash.TabStop = false;
            this.trash.Click += new System.EventHandler(this.trash_Click);
            this.trash.MouseEnter += new System.EventHandler(this.trash_MouseEnter);
            this.trash.MouseLeave += new System.EventHandler(this.trash_MouseLeave);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(478, 499);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(250, 28);
            this.textBox4.TabIndex = 77;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1313, 693);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.trash);
            this.Controls.Add(this.nPropertylabel);
            this.Controls.Add(this.Property06);
            this.Controls.Add(this.nLine);
            this.Controls.Add(this.İtems02);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Property6);
            this.Controls.Add(this.nSelectphoto);
            this.Controls.Add(this.İtems01);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Property5);
            this.Controls.Add(this.appfile);
            this.Controls.Add(this.İtems03);
            this.Controls.Add(this.nlabel1);
            this.Controls.Add(this.Property3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.items15);
            this.Controls.Add(this.Property4);
            this.Controls.Add(this.items14);
            this.Controls.Add(this.Property2);
            this.Controls.Add(this.items13);
            this.Controls.Add(this.Arrow);
            this.Controls.Add(this.items12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Property1);
            this.Controls.Add(this.items11);
            this.Controls.Add(this.items10);
            this.Controls.Add(this.items9);
            this.Controls.Add(this.items8);
            this.Controls.Add(this.items7);
            this.Controls.Add(this.items6);
            this.Controls.Add(this.items5);
            this.Controls.Add(this.items4);
            this.Controls.Add(this.items3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.items2);
            this.Controls.Add(this.items1);
            this.Controls.Add(this.Comports);
            this.Controls.Add(this.pictureBox49);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.items1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.İtems01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.İtems02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.İtems03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Property06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSelectphoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Comports;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox items1;
        private System.Windows.Forms.PictureBox items2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox items3;
        private System.Windows.Forms.PictureBox items4;
        private System.Windows.Forms.PictureBox items5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox items7;
        private System.Windows.Forms.PictureBox items6;
        private System.Windows.Forms.PictureBox items8;
        private System.Windows.Forms.PictureBox items9;
        private System.Windows.Forms.PictureBox items10;
        private System.Windows.Forms.PictureBox items11;
        private System.Windows.Forms.PictureBox items12;
        private System.Windows.Forms.PictureBox items13;
        private System.Windows.Forms.PictureBox items14;
        private System.Windows.Forms.PictureBox items15;
        private System.Windows.Forms.PictureBox pictureBox49;
        private System.Windows.Forms.PictureBox İtems01;
        private System.Windows.Forms.PictureBox İtems02;
        private System.Windows.Forms.PictureBox İtems03;
        private System.Windows.Forms.Button Property1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Arrow;
        private System.Windows.Forms.Button Property2;
        private System.Windows.Forms.Button Property4;
        private System.Windows.Forms.Button Property3;
        private System.Windows.Forms.Button Property5;
        private System.Windows.Forms.Button Property6;
        private System.Windows.Forms.PictureBox Property06;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label nlabel1;
        private System.Windows.Forms.Button appfile;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox nSelectphoto;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox nLine;
        private System.Windows.Forms.Label nPropertylabel;
        private System.Windows.Forms.PictureBox trash;
        private System.Windows.Forms.TextBox textBox4;
    }
}

