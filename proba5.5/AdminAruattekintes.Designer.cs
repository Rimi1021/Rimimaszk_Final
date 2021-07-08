
namespace proba5._5
{
    partial class AdminAruattekintes
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
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.radioButtonGY = new System.Windows.Forms.RadioButton();
            this.radioButtonBP = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_Osszes = new System.Windows.Forms.RadioButton();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Listazas = new System.Windows.Forms.Button();
            this.button_export = new System.Windows.Forms.Button();
            this.textBox_Export = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox_Lista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(230, 19);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(72, 17);
            this.radioButtonD.TabIndex = 11;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "Debrecen";
            this.radioButtonD.UseVisualStyleBackColor = true;
            this.radioButtonD.CheckedChanged += new System.EventHandler(this.hatterszinradiobuttondebrecen);
            // 
            // radioButtonGY
            // 
            this.radioButtonGY.AutoSize = true;
            this.radioButtonGY.Location = new System.Drawing.Point(186, 19);
            this.radioButtonGY.Name = "radioButtonGY";
            this.radioButtonGY.Size = new System.Drawing.Size(47, 17);
            this.radioButtonGY.TabIndex = 10;
            this.radioButtonGY.TabStop = true;
            this.radioButtonGY.Text = "Győr";
            this.radioButtonGY.UseVisualStyleBackColor = true;
            this.radioButtonGY.CheckedChanged += new System.EventHandler(this.hatterszinradiobuttongyor);
            // 
            // radioButtonBP
            // 
            this.radioButtonBP.AutoSize = true;
            this.radioButtonBP.Location = new System.Drawing.Point(119, 19);
            this.radioButtonBP.Name = "radioButtonBP";
            this.radioButtonBP.Size = new System.Drawing.Size(70, 17);
            this.radioButtonBP.TabIndex = 9;
            this.radioButtonBP.TabStop = true;
            this.radioButtonBP.Text = "Budapest";
            this.radioButtonBP.UseVisualStyleBackColor = true;
            this.radioButtonBP.CheckedChanged += new System.EventHandler(this.szinvaltozasradiogomb);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "LOCATION";
            // 
            // radioButton_Osszes
            // 
            this.radioButton_Osszes.AutoSize = true;
            this.radioButton_Osszes.Location = new System.Drawing.Point(309, 19);
            this.radioButton_Osszes.Name = "radioButton_Osszes";
            this.radioButton_Osszes.Size = new System.Drawing.Size(59, 17);
            this.radioButton_Osszes.TabIndex = 12;
            this.radioButton_Osszes.TabStop = true;
            this.radioButton_Osszes.Text = "Összes";
            this.radioButton_Osszes.UseVisualStyleBackColor = true;
            this.radioButton_Osszes.CheckedChanged += new System.EventHandler(this.hatterosszesradiobutton);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Gazmaszk",
            "Szelepes",
            "Fashion",
            "Szuros",
            "Egyszerhasznalatos",
            "Mintas",
            "Osszes"});
            this.comboBox.Location = new System.Drawing.Point(155, 42);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 13;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.termekvaltozas);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Termék csoport";
            // 
            // button_Listazas
            // 
            this.button_Listazas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Listazas.Location = new System.Drawing.Point(297, 37);
            this.button_Listazas.Name = "button_Listazas";
            this.button_Listazas.Size = new System.Drawing.Size(169, 26);
            this.button_Listazas.TabIndex = 15;
            this.button_Listazas.Text = "Listázás";
            this.button_Listazas.UseVisualStyleBackColor = true;
            this.button_Listazas.Click += new System.EventHandler(this.button_Listazas_Click);
            // 
            // button_export
            // 
            this.button_export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_export.Location = new System.Drawing.Point(35, 411);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(125, 23);
            this.button_export.TabIndex = 19;
            this.button_export.Text = "Exportálás";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // textBox_Export
            // 
            this.textBox_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Export.Location = new System.Drawing.Point(176, 413);
            this.textBox_Export.Name = "textBox_Export";
            this.textBox_Export.Size = new System.Drawing.Size(100, 20);
            this.textBox_Export.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = ".CSV";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // listBox_Lista
            // 
            this.listBox_Lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_Lista.FormattingEnabled = true;
            this.listBox_Lista.Location = new System.Drawing.Point(35, 76);
            this.listBox_Lista.Name = "listBox_Lista";
            this.listBox_Lista.Size = new System.Drawing.Size(596, 329);
            this.listBox_Lista.TabIndex = 22;
            // 
            // Eladas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox_Lista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Export);
            this.Controls.Add(this.button_export);
            this.Controls.Add(this.button_Listazas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.radioButton_Osszes);
            this.Controls.Add(this.radioButtonD);
            this.Controls.Add(this.radioButtonGY);
            this.Controls.Add(this.radioButtonBP);
            this.Controls.Add(this.label1);
            this.Name = "Eladas";
            this.Size = new System.Drawing.Size(673, 455);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.RadioButton radioButtonGY;
        private System.Windows.Forms.RadioButton radioButtonBP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_Osszes;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Listazas;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.TextBox textBox_Export;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox_Lista;
    }
}
