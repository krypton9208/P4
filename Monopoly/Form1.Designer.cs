﻿namespace Monopoly
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
            this.AddPlayer = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DoNothing = new System.Windows.Forms.Button();
            this.BuyHotel = new System.Windows.Forms.Button();
            this.BuyHouse = new System.Windows.Forms.Button();
            this.BuyObject = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pieniądze = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Posiadłości = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Domy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hotele = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Czerwone = new System.Windows.Forms.RichTextBox();
            this.Niebieskie = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 80);
            this.button1.TabIndex = 9;
            this.button1.Text = "Rzuć koścami";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(243, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 76);
            this.label1.TabIndex = 10;
            this.label1.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(376, 311);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "Nowy gracz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 22);
            this.textBox1.TabIndex = 12;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
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
            // AddPlayer
            // 
            this.AddPlayer.Location = new System.Drawing.Point(69, 161);
            this.AddPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddPlayer.Name = "AddPlayer";
            this.AddPlayer.Size = new System.Drawing.Size(100, 28);
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
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(237, 311);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 28);
            this.button5.TabIndex = 16;
            this.button5.Text = "Rozpocznij grę";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DoNothing);
            this.panel2.Controls.Add(this.BuyHotel);
            this.panel2.Controls.Add(this.BuyHouse);
            this.panel2.Controls.Add(this.BuyObject);
            this.panel2.Location = new System.Drawing.Point(987, 299);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 270);
            this.panel2.TabIndex = 18;
            // 
            // DoNothing
            // 
            this.DoNothing.Location = new System.Drawing.Point(4, 207);
            this.DoNothing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoNothing.Name = "DoNothing";
            this.DoNothing.Size = new System.Drawing.Size(195, 55);
            this.DoNothing.TabIndex = 19;
            this.DoNothing.Text = "Nic nie rób";
            this.DoNothing.UseVisualStyleBackColor = true;
            this.DoNothing.Visible = false;
            this.DoNothing.Click += new System.EventHandler(this.DoNothing_Click);
            // 
            // BuyHotel
            // 
            this.BuyHotel.Location = new System.Drawing.Point(4, 140);
            this.BuyHotel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BuyHotel.Name = "BuyHotel";
            this.BuyHotel.Size = new System.Drawing.Size(195, 59);
            this.BuyHotel.TabIndex = 20;
            this.BuyHotel.Text = "Kup hotel";
            this.BuyHotel.UseVisualStyleBackColor = true;
            this.BuyHotel.Visible = false;
            this.BuyHotel.Click += new System.EventHandler(this.BuyHotel_Click);
            // 
            // BuyHouse
            // 
            this.BuyHouse.Location = new System.Drawing.Point(4, 78);
            this.BuyHouse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BuyHouse.Name = "BuyHouse";
            this.BuyHouse.Size = new System.Drawing.Size(195, 55);
            this.BuyHouse.TabIndex = 19;
            this.BuyHouse.Text = "Kup dom";
            this.BuyHouse.UseVisualStyleBackColor = true;
            this.BuyHouse.Visible = false;
            this.BuyHouse.Click += new System.EventHandler(this.button7_Click);
            // 
            // BuyObject
            // 
            this.BuyObject.Location = new System.Drawing.Point(4, 15);
            this.BuyObject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BuyObject.Name = "BuyObject";
            this.BuyObject.Size = new System.Drawing.Size(195, 55);
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
            this.groupBox1.Location = new System.Drawing.Point(517, 220);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(208, 197);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane gracza";
            this.groupBox1.Visible = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox9.Location = new System.Drawing.Point(35, 55);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(134, 98);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 13;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
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
            this.listView1.Location = new System.Drawing.Point(179, 425);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(799, 211);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            this.groupBox2.Location = new System.Drawing.Point(987, 593);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(360, 112);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kości";
            this.groupBox2.Visible = false;
            // 
            // Czerwone
            // 
            this.Czerwone.Location = new System.Drawing.Point(101, 69);
            this.Czerwone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Czerwone.Name = "Czerwone";
            this.Czerwone.Size = new System.Drawing.Size(755, 52);
            this.Czerwone.TabIndex = 22;
            this.Czerwone.Text = resources.GetString("Czerwone.Text");
            this.Czerwone.Visible = false;
            // 
            // Niebieskie
            // 
            this.Niebieskie.Location = new System.Drawing.Point(101, 129);
            this.Niebieskie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Niebieskie.Name = "Niebieskie";
            this.Niebieskie.Size = new System.Drawing.Size(755, 83);
            this.Niebieskie.TabIndex = 23;
            this.Niebieskie.Text = resources.GetString("Niebieskie.Text");
            this.Niebieskie.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(304, 759);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 42);
            this.label2.TabIndex = 24;
            this.label2.Text = "Aktualny gracz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(599, 759);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 42);
            this.label3.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Monopoly.Properties.Resources.monopoly_us_pack_logo;
            this.pictureBox1.Location = new System.Drawing.Point(299, 807);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(853, 394);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1367, 912);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Niebieskie);
            this.Controls.Add(this.Czerwone);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1359, 883);
            this.Name = "Form1";
            this.Tag = "a";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;




    }
}

