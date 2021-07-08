
namespace proba5._5
{
    partial class AdminUserListazasTorles
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
            this.listBox_Felhasznalolistazas = new System.Windows.Forms.ListBox();
            this.checkBox_Adminuserek = new System.Windows.Forms.CheckBox();
            this.checkBox_BPuserek = new System.Windows.Forms.CheckBox();
            this.checkBox_Debuserek = new System.Windows.Forms.CheckBox();
            this.checkBox_Gyoruserek = new System.Windows.Forms.CheckBox();
            this.button_Listazas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_NevKereses = new System.Windows.Forms.TextBox();
            this.button_Kereses = new System.Windows.Forms.Button();
            this.button_Frissites = new System.Windows.Forms.Button();
            this.button_ElemTorles = new System.Windows.Forms.Button();
            this.button_Export = new System.Windows.Forms.Button();
            this.button_ListaBoxKijelzo_clear = new System.Windows.Forms.Button();
            this.textBox_Csv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Kijelotelemtorles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox_Felhasznalolistazas
            // 
            this.listBox_Felhasznalolistazas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_Felhasznalolistazas.FormattingEnabled = true;
            this.listBox_Felhasznalolistazas.Location = new System.Drawing.Point(154, 88);
            this.listBox_Felhasznalolistazas.Name = "listBox_Felhasznalolistazas";
            this.listBox_Felhasznalolistazas.Size = new System.Drawing.Size(412, 277);
            this.listBox_Felhasznalolistazas.TabIndex = 1;
            this.listBox_Felhasznalolistazas.DoubleClick += new System.EventHandler(this.Elemkiir);
            // 
            // checkBox_Adminuserek
            // 
            this.checkBox_Adminuserek.AutoSize = true;
            this.checkBox_Adminuserek.Location = new System.Drawing.Point(16, 38);
            this.checkBox_Adminuserek.Name = "checkBox_Adminuserek";
            this.checkBox_Adminuserek.Size = new System.Drawing.Size(67, 17);
            this.checkBox_Adminuserek.TabIndex = 2;
            this.checkBox_Adminuserek.Text = "Adminok";
            this.checkBox_Adminuserek.UseVisualStyleBackColor = true;
            // 
            // checkBox_BPuserek
            // 
            this.checkBox_BPuserek.AutoSize = true;
            this.checkBox_BPuserek.Location = new System.Drawing.Point(16, 61);
            this.checkBox_BPuserek.Name = "checkBox_BPuserek";
            this.checkBox_BPuserek.Size = new System.Drawing.Size(85, 17);
            this.checkBox_BPuserek.TabIndex = 3;
            this.checkBox_BPuserek.Text = "Budapestiek";
            this.checkBox_BPuserek.UseVisualStyleBackColor = true;
            // 
            // checkBox_Debuserek
            // 
            this.checkBox_Debuserek.AutoSize = true;
            this.checkBox_Debuserek.Location = new System.Drawing.Point(16, 88);
            this.checkBox_Debuserek.Name = "checkBox_Debuserek";
            this.checkBox_Debuserek.Size = new System.Drawing.Size(87, 17);
            this.checkBox_Debuserek.TabIndex = 4;
            this.checkBox_Debuserek.Text = "Debreceniek";
            this.checkBox_Debuserek.UseVisualStyleBackColor = true;
            // 
            // checkBox_Gyoruserek
            // 
            this.checkBox_Gyoruserek.AutoSize = true;
            this.checkBox_Gyoruserek.Location = new System.Drawing.Point(16, 111);
            this.checkBox_Gyoruserek.Name = "checkBox_Gyoruserek";
            this.checkBox_Gyoruserek.Size = new System.Drawing.Size(62, 17);
            this.checkBox_Gyoruserek.TabIndex = 5;
            this.checkBox_Gyoruserek.Text = "Győriek";
            this.checkBox_Gyoruserek.UseVisualStyleBackColor = true;
            // 
            // button_Listazas
            // 
            this.button_Listazas.Location = new System.Drawing.Point(16, 146);
            this.button_Listazas.Name = "button_Listazas";
            this.button_Listazas.Size = new System.Drawing.Size(112, 27);
            this.button_Listazas.TabIndex = 6;
            this.button_Listazas.Text = "Listázás";
            this.button_Listazas.UseVisualStyleBackColor = true;
            this.button_Listazas.Click += new System.EventHandler(this.button_Listazas_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Keresés név szerint";
            // 
            // textBox_NevKereses
            // 
            this.textBox_NevKereses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_NevKereses.Location = new System.Drawing.Point(512, 25);
            this.textBox_NevKereses.Name = "textBox_NevKereses";
            this.textBox_NevKereses.Size = new System.Drawing.Size(162, 20);
            this.textBox_NevKereses.TabIndex = 8;
            // 
            // button_Kereses
            // 
            this.button_Kereses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Kereses.Location = new System.Drawing.Point(538, 57);
            this.button_Kereses.Name = "button_Kereses";
            this.button_Kereses.Size = new System.Drawing.Size(112, 23);
            this.button_Kereses.TabIndex = 9;
            this.button_Kereses.Text = "Keresés";
            this.button_Kereses.UseVisualStyleBackColor = true;
            this.button_Kereses.Click += new System.EventHandler(this.button_Kereses_Click);
            // 
            // button_Frissites
            // 
            this.button_Frissites.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Frissites.Location = new System.Drawing.Point(318, 381);
            this.button_Frissites.Name = "button_Frissites";
            this.button_Frissites.Size = new System.Drawing.Size(75, 23);
            this.button_Frissites.TabIndex = 10;
            this.button_Frissites.Text = "Frissítés";
            this.button_Frissites.UseVisualStyleBackColor = true;
            this.button_Frissites.Click += new System.EventHandler(this.button_Frissites_Click);
            // 
            // button_ElemTorles
            // 
            this.button_ElemTorles.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_ElemTorles.Location = new System.Drawing.Point(275, 410);
            this.button_ElemTorles.Name = "button_ElemTorles";
            this.button_ElemTorles.Size = new System.Drawing.Size(162, 23);
            this.button_ElemTorles.TabIndex = 11;
            this.button_ElemTorles.Text = "Kijelölt felhasználó törlése";
            this.button_ElemTorles.UseVisualStyleBackColor = true;
            this.button_ElemTorles.Click += new System.EventHandler(this.button_ElemTorles_Click);
            // 
            // button_Export
            // 
            this.button_Export.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Export.Location = new System.Drawing.Point(248, 436);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(210, 23);
            this.button_Export.TabIndex = 12;
            this.button_Export.Text = "Lista exportálása csv.-be";
            this.button_Export.UseVisualStyleBackColor = true;
            this.button_Export.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // button_ListaBoxKijelzo_clear
            // 
            this.button_ListaBoxKijelzo_clear.Location = new System.Drawing.Point(16, 179);
            this.button_ListaBoxKijelzo_clear.Name = "button_ListaBoxKijelzo_clear";
            this.button_ListaBoxKijelzo_clear.Size = new System.Drawing.Size(112, 27);
            this.button_ListaBoxKijelzo_clear.TabIndex = 13;
            this.button_ListaBoxKijelzo_clear.Text = "Kijelző törlése";
            this.button_ListaBoxKijelzo_clear.UseVisualStyleBackColor = true;
            this.button_ListaBoxKijelzo_clear.Click += new System.EventHandler(this.button_ListaBoxKijelzo_clear_Click);
            // 
            // textBox_Csv
            // 
            this.textBox_Csv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Csv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Csv.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Csv.Location = new System.Drawing.Point(477, 439);
            this.textBox_Csv.Name = "textBox_Csv";
            this.textBox_Csv.Size = new System.Drawing.Size(122, 20);
            this.textBox_Csv.TabIndex = 14;
            this.textBox_Csv.Text = "Felhasználók";
            this.textBox_Csv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(605, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = ".CSV";
            // 
            // textBox_Kijelotelemtorles
            // 
            this.textBox_Kijelotelemtorles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Kijelotelemtorles.Location = new System.Drawing.Point(477, 413);
            this.textBox_Kijelotelemtorles.Name = "textBox_Kijelotelemtorles";
            this.textBox_Kijelotelemtorles.Size = new System.Drawing.Size(206, 20);
            this.textBox_Kijelotelemtorles.TabIndex = 16;
            // 
            // ListazasTorles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_Kijelotelemtorles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Csv);
            this.Controls.Add(this.button_ListaBoxKijelzo_clear);
            this.Controls.Add(this.button_Export);
            this.Controls.Add(this.button_ElemTorles);
            this.Controls.Add(this.button_Frissites);
            this.Controls.Add(this.button_Kereses);
            this.Controls.Add(this.textBox_NevKereses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Listazas);
            this.Controls.Add(this.checkBox_Gyoruserek);
            this.Controls.Add(this.checkBox_Debuserek);
            this.Controls.Add(this.checkBox_BPuserek);
            this.Controls.Add(this.checkBox_Adminuserek);
            this.Controls.Add(this.listBox_Felhasznalolistazas);
            this.Name = "ListazasTorles";
            this.Size = new System.Drawing.Size(699, 465);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Felhasznalolistazas;
        private System.Windows.Forms.CheckBox checkBox_Adminuserek;
        private System.Windows.Forms.CheckBox checkBox_BPuserek;
        private System.Windows.Forms.CheckBox checkBox_Debuserek;
        private System.Windows.Forms.CheckBox checkBox_Gyoruserek;
        private System.Windows.Forms.Button button_Listazas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_NevKereses;
        private System.Windows.Forms.Button button_Kereses;
        private System.Windows.Forms.Button button_Frissites;
        private System.Windows.Forms.Button button_ElemTorles;
        private System.Windows.Forms.Button button_Export;
        private System.Windows.Forms.Button button_ListaBoxKijelzo_clear;
        private System.Windows.Forms.TextBox textBox_Csv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Kijelotelemtorles;
    }
}
