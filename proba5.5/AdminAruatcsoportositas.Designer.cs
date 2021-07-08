
namespace proba5._5
{
    partial class AdminAruatcsoportositas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAruatcsoportositas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton_BP = new System.Windows.Forms.RadioButton();
            this.radioButton_Gyor = new System.Windows.Forms.RadioButton();
            this.radioButton_Debrecen = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Maszktipus = new System.Windows.Forms.ComboBox();
            this.comboBox_Maszknev = new System.Windows.Forms.ComboBox();
            this.label_Maszknev = new System.Windows.Forms.Label();
            this.label_Maszktipus = new System.Windows.Forms.Label();
            this.label_Maszkdb = new System.Windows.Forms.Label();
            this.textBox_atcsoportositDB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.button_Atcsoportosit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_Találat = new System.Windows.Forms.Button();
            this.label_Honnan = new System.Windows.Forms.Label();
            this.label_Hova = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 179);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(8)))), ((int)(((byte)(6)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(280, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // radioButton_BP
            // 
            this.radioButton_BP.AutoSize = true;
            this.radioButton_BP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_BP.Location = new System.Drawing.Point(108, 38);
            this.radioButton_BP.Name = "radioButton_BP";
            this.radioButton_BP.Size = new System.Drawing.Size(96, 24);
            this.radioButton_BP.TabIndex = 1;
            this.radioButton_BP.TabStop = true;
            this.radioButton_BP.Text = "Budapest";
            this.radioButton_BP.UseVisualStyleBackColor = true;
            this.radioButton_BP.CheckedChanged += new System.EventHandler(this.radioButton_BP_CheckedChanged);
            // 
            // radioButton_Gyor
            // 
            this.radioButton_Gyor.AutoSize = true;
            this.radioButton_Gyor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_Gyor.Location = new System.Drawing.Point(213, 38);
            this.radioButton_Gyor.Name = "radioButton_Gyor";
            this.radioButton_Gyor.Size = new System.Drawing.Size(61, 24);
            this.radioButton_Gyor.TabIndex = 2;
            this.radioButton_Gyor.TabStop = true;
            this.radioButton_Gyor.Text = "Győr";
            this.radioButton_Gyor.UseVisualStyleBackColor = true;
            this.radioButton_Gyor.CheckedChanged += new System.EventHandler(this.radioButton_Gyor_CheckedChanged);
            // 
            // radioButton_Debrecen
            // 
            this.radioButton_Debrecen.AutoSize = true;
            this.radioButton_Debrecen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_Debrecen.Location = new System.Drawing.Point(280, 40);
            this.radioButton_Debrecen.Name = "radioButton_Debrecen";
            this.radioButton_Debrecen.Size = new System.Drawing.Size(97, 24);
            this.radioButton_Debrecen.TabIndex = 3;
            this.radioButton_Debrecen.TabStop = true;
            this.radioButton_Debrecen.Text = "Debrecen";
            this.radioButton_Debrecen.UseVisualStyleBackColor = true;
            this.radioButton_Debrecen.CheckedChanged += new System.EventHandler(this.radioButton_Debrecen_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Áru átcsoportosítás";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(18, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Maszk név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(18, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Maszk típus:";
            // 
            // comboBox_Maszktipus
            // 
            this.comboBox_Maszktipus.FormattingEnabled = true;
            this.comboBox_Maszktipus.Items.AddRange(new object[] {
            "Gazmaszk",
            "Szelepes",
            "Fashion",
            "Szuros",
            "Egyszerhasznalatos",
            "Mintas"});
            this.comboBox_Maszktipus.Location = new System.Drawing.Point(131, 92);
            this.comboBox_Maszktipus.Name = "comboBox_Maszktipus";
            this.comboBox_Maszktipus.Size = new System.Drawing.Size(129, 21);
            this.comboBox_Maszktipus.TabIndex = 7;
            this.comboBox_Maszktipus.SelectedIndexChanged += new System.EventHandler(this.MasztipusShange);
            // 
            // comboBox_Maszknev
            // 
            this.comboBox_Maszknev.FormattingEnabled = true;
            this.comboBox_Maszknev.Items.AddRange(new object[] {
            "Csipkes",
            "DC",
            "Feher",
            "Fekete",
            "Frozen",
            "Hupikek",
            "Kek",
            "Marvel",
            "Memes",
            "Piros",
            "Rozsaszin",
            "Sarga",
            "Shrek",
            "Terepmintas",
            "Zold"});
            this.comboBox_Maszknev.Location = new System.Drawing.Point(131, 120);
            this.comboBox_Maszknev.Name = "comboBox_Maszknev";
            this.comboBox_Maszknev.Size = new System.Drawing.Size(129, 21);
            this.comboBox_Maszknev.TabIndex = 8;
            this.comboBox_Maszknev.SelectedIndexChanged += new System.EventHandler(this.Maszknevchange);
            // 
            // label_Maszknev
            // 
            this.label_Maszknev.AutoSize = true;
            this.label_Maszknev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Maszknev.Location = new System.Drawing.Point(105, 189);
            this.label_Maszknev.Name = "label_Maszknev";
            this.label_Maszknev.Size = new System.Drawing.Size(80, 18);
            this.label_Maszknev.TabIndex = 9;
            this.label_Maszknev.Text = "Maszk név";
            // 
            // label_Maszktipus
            // 
            this.label_Maszktipus.AutoSize = true;
            this.label_Maszktipus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Maszktipus.Location = new System.Drawing.Point(3, 189);
            this.label_Maszktipus.Name = "label_Maszktipus";
            this.label_Maszktipus.Size = new System.Drawing.Size(88, 18);
            this.label_Maszktipus.TabIndex = 10;
            this.label_Maszktipus.Text = "Maszk típus";
            // 
            // label_Maszkdb
            // 
            this.label_Maszkdb.AutoSize = true;
            this.label_Maszkdb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Maszkdb.Location = new System.Drawing.Point(197, 189);
            this.label_Maszkdb.Name = "label_Maszkdb";
            this.label_Maszkdb.Size = new System.Drawing.Size(29, 18);
            this.label_Maszkdb.TabIndex = 11;
            this.label_Maszkdb.Text = "DB";
            // 
            // textBox_atcsoportositDB
            // 
            this.textBox_atcsoportositDB.Location = new System.Drawing.Point(242, 187);
            this.textBox_atcsoportositDB.Name = "textBox_atcsoportositDB";
            this.textBox_atcsoportositDB.Size = new System.Drawing.Size(59, 20);
            this.textBox_atcsoportositDB.TabIndex = 12;
            this.textBox_atcsoportositDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_atcsoportositDB.TextChanged += new System.EventHandler(this.textBox_atcsoportositDB_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(15, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Célraktár:";
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton4.Location = new System.Drawing.Point(102, 273);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(88, 22);
            this.radioButton4.TabIndex = 14;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Budapest";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton5.Location = new System.Drawing.Point(102, 306);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(59, 22);
            this.radioButton5.TabIndex = 15;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Győr";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton6.Location = new System.Drawing.Point(102, 343);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(90, 22);
            this.radioButton6.TabIndex = 16;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Debrecen";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // button_Atcsoportosit
            // 
            this.button_Atcsoportosit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Atcsoportosit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Atcsoportosit.Location = new System.Drawing.Point(213, 273);
            this.button_Atcsoportosit.Name = "button_Atcsoportosit";
            this.button_Atcsoportosit.Size = new System.Drawing.Size(147, 92);
            this.button_Atcsoportosit.TabIndex = 17;
            this.button_Atcsoportosit.Text = "Átcsoportosítás";
            this.button_Atcsoportosit.UseVisualStyleBackColor = true;
            this.button_Atcsoportosit.Click += new System.EventHandler(this.button_Atcsoportosit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(367, 273);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // button_Találat
            // 
            this.button_Találat.Location = new System.Drawing.Point(273, 92);
            this.button_Találat.Name = "button_Találat";
            this.button_Találat.Size = new System.Drawing.Size(77, 49);
            this.button_Találat.TabIndex = 19;
            this.button_Találat.Text = "Raktár";
            this.button_Találat.UseVisualStyleBackColor = true;
            this.button_Találat.Click += new System.EventHandler(this.button_Találat_Click);
            // 
            // label_Honnan
            // 
            this.label_Honnan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Honnan.AutoSize = true;
            this.label_Honnan.Location = new System.Drawing.Point(226, 381);
            this.label_Honnan.Name = "label_Honnan";
            this.label_Honnan.Size = new System.Drawing.Size(45, 13);
            this.label_Honnan.TabIndex = 20;
            this.label_Honnan.Text = "Honnan";
            // 
            // label_Hova
            // 
            this.label_Hova.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Hova.AutoSize = true;
            this.label_Hova.Location = new System.Drawing.Point(310, 381);
            this.label_Hova.Name = "label_Hova";
            this.label_Hova.Size = new System.Drawing.Size(33, 13);
            this.label_Hova.TabIndex = 21;
            this.label_Hova.Text = "Hova";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(17, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Honnan:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(98, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Hova:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "-->";
            // 
            // AdminAruatcsoportositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_Hova);
            this.Controls.Add(this.label_Honnan);
            this.Controls.Add(this.button_Találat);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_Atcsoportosit);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_atcsoportositDB);
            this.Controls.Add(this.label_Maszkdb);
            this.Controls.Add(this.label_Maszktipus);
            this.Controls.Add(this.label_Maszknev);
            this.Controls.Add(this.comboBox_Maszknev);
            this.Controls.Add(this.comboBox_Maszktipus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton_Debrecen);
            this.Controls.Add(this.radioButton_Gyor);
            this.Controls.Add(this.radioButton_BP);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAruatcsoportositas";
            this.Size = new System.Drawing.Size(805, 576);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton_BP;
        private System.Windows.Forms.RadioButton radioButton_Gyor;
        private System.Windows.Forms.RadioButton radioButton_Debrecen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Maszktipus;
        private System.Windows.Forms.ComboBox comboBox_Maszknev;
        private System.Windows.Forms.Label label_Maszknev;
        private System.Windows.Forms.Label label_Maszktipus;
        private System.Windows.Forms.Label label_Maszkdb;
        private System.Windows.Forms.TextBox textBox_atcsoportositDB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Button button_Atcsoportosit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_Találat;
        private System.Windows.Forms.Label label_Honnan;
        private System.Windows.Forms.Label label_Hova;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
