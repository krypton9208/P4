namespace Monopoly
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.AddPlayer = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DoNothing = new System.Windows.Forms.Button();
            this.PayFine = new System.Windows.Forms.Button();
            this.BuyHotel = new System.Windows.Forms.Button();
            this.BuyHouse = new System.Windows.Forms.Button();
            this.BuyObject = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pieniądze = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Posiadłości = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Domy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hotele = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Czerwone = new System.Windows.Forms.RichTextBox();
            this.Niebieskie = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 65);
            this.button1.TabIndex = 9;
            this.button1.Text = "Rzuć koścami";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(235, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Nowy gracz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 12;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "BLACK.png");
            this.imageList1.Images.SetKeyName(1, "BLUE.png");
            this.imageList1.Images.SetKeyName(2, "GREEN.png");
            this.imageList1.Images.SetKeyName(3, "GREY.png");
            this.imageList1.Images.SetKeyName(4, "PINK.png");
            this.imageList1.Images.SetKeyName(5, "RED.png");
            this.imageList1.Images.SetKeyName(6, "WHITE.png");
            this.imageList1.Images.SetKeyName(7, "YELLOW.png");
            // 
            // pictureBox9
            // 
            this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox9.Location = new System.Drawing.Point(26, 45);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(101, 80);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 13;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // AddPlayer
            // 
            this.AddPlayer.Location = new System.Drawing.Point(52, 131);
            this.AddPlayer.Name = "AddPlayer";
            this.AddPlayer.Size = new System.Drawing.Size(75, 23);
            this.AddPlayer.TabIndex = 14;
            this.AddPlayer.Text = "Dodaj";
            this.AddPlayer.UseVisualStyleBackColor = true;
            this.AddPlayer.Click += new System.EventHandler(this.button3_Click);
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(178, 253);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Rozpocznij grę";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DoNothing);
            this.panel2.Controls.Add(this.PayFine);
            this.panel2.Controls.Add(this.BuyHotel);
            this.panel2.Controls.Add(this.BuyHouse);
            this.panel2.Controls.Add(this.BuyObject);
            this.panel2.Location = new System.Drawing.Point(740, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 267);
            this.panel2.TabIndex = 18;
            // 
            // DoNothing
            // 
            this.DoNothing.Location = new System.Drawing.Point(3, 213);
            this.DoNothing.Name = "DoNothing";
            this.DoNothing.Size = new System.Drawing.Size(146, 45);
            this.DoNothing.TabIndex = 19;
            this.DoNothing.Text = "Nic nie rób";
            this.DoNothing.UseVisualStyleBackColor = true;
            this.DoNothing.Visible = false;
            this.DoNothing.Click += new System.EventHandler(this.DoNothing_Click);
            // 
            // PayFine
            // 
            this.PayFine.Location = new System.Drawing.Point(3, 162);
            this.PayFine.Name = "PayFine";
            this.PayFine.Size = new System.Drawing.Size(146, 45);
            this.PayFine.TabIndex = 21;
            this.PayFine.Text = "Zapłać karę";
            this.PayFine.UseVisualStyleBackColor = true;
            this.PayFine.Visible = false;
            // 
            // BuyHotel
            // 
            this.BuyHotel.Location = new System.Drawing.Point(3, 108);
            this.BuyHotel.Name = "BuyHotel";
            this.BuyHotel.Size = new System.Drawing.Size(146, 48);
            this.BuyHotel.TabIndex = 20;
            this.BuyHotel.Text = "Kup hotel";
            this.BuyHotel.UseVisualStyleBackColor = true;
            this.BuyHotel.Visible = false;
            this.BuyHotel.Click += new System.EventHandler(this.BuyHotel_Click);
            // 
            // BuyHouse
            // 
            this.BuyHouse.Location = new System.Drawing.Point(3, 57);
            this.BuyHouse.Name = "BuyHouse";
            this.BuyHouse.Size = new System.Drawing.Size(146, 45);
            this.BuyHouse.TabIndex = 19;
            this.BuyHouse.Text = "Kup dom";
            this.BuyHouse.UseVisualStyleBackColor = true;
            this.BuyHouse.Visible = false;
            this.BuyHouse.Click += new System.EventHandler(this.button7_Click);
            // 
            // BuyObject
            // 
            this.BuyObject.Location = new System.Drawing.Point(3, 6);
            this.BuyObject.Name = "BuyObject";
            this.BuyObject.Size = new System.Drawing.Size(146, 45);
            this.BuyObject.TabIndex = 0;
            this.BuyObject.Text = "Kup obiekt";
            this.BuyObject.UseVisualStyleBackColor = true;
            this.BuyObject.Visible = false;
            this.BuyObject.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.pictureBox9);
            this.groupBox1.Controls.Add(this.AddPlayer);
            this.groupBox1.Location = new System.Drawing.Point(388, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 160);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane gracza";
            this.groupBox1.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nazwa,
            this.Pieniądze,
            this.Posiadłości,
            this.Domy,
            this.Hotele});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(134, 361);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(600, 115);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Nazwa
            // 
            this.Nazwa.Text = "Nazwa gracza";
            this.Nazwa.Width = 90;
            // 
            // Pieniądze
            // 
            this.Pieniądze.Text = "Stan Konta";
            this.Pieniądze.Width = 80;
            // 
            // Posiadłości
            // 
            this.Posiadłości.Text = "Ilość posiadanych obiektów";
            this.Posiadłości.Width = 148;
            // 
            // Domy
            // 
            this.Domy.Text = "Wybudowane domy";
            this.Domy.Width = 120;
            // 
            // Hotele
            // 
            this.Hotele.Text = "Wybudowane hotele";
            this.Hotele.Width = 113;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(303, 482);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 101);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kości";
            this.groupBox2.Visible = false;
            // 
            // Czerwone
            // 
            this.Czerwone.Location = new System.Drawing.Point(76, 56);
            this.Czerwone.Name = "Czerwone";
            this.Czerwone.Size = new System.Drawing.Size(567, 43);
            this.Czerwone.TabIndex = 22;
            this.Czerwone.Text = resources.GetString("Czerwone.Text");
            this.Czerwone.Visible = false;
            // 
            // Niebieskie
            // 
            this.Niebieskie.Location = new System.Drawing.Point(76, 105);
            this.Niebieskie.Name = "Niebieskie";
            this.Niebieskie.Size = new System.Drawing.Size(567, 68);
            this.Niebieskie.TabIndex = 23;
            this.Niebieskie.Text = resources.GetString("Niebieskie.Text");
            this.Niebieskie.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.Niebieskie);
            this.Controls.Add(this.Czerwone);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "Form1";
            this.Tag = "a";
            this.Text = "Monopoly in Windows Form Aplication C#";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button AddPlayer;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BuyHouse;
        private System.Windows.Forms.Button BuyObject;
        private System.Windows.Forms.Button BuyHotel;
        private System.Windows.Forms.Button DoNothing;
        private System.Windows.Forms.Button PayFine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nazwa;
        private System.Windows.Forms.ColumnHeader Pieniądze;
        private System.Windows.Forms.ColumnHeader Posiadłości;
        private System.Windows.Forms.ColumnHeader Domy;
        private System.Windows.Forms.ColumnHeader Hotele;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox Czerwone;
        private System.Windows.Forms.RichTextBox Niebieskie;




    }
}

