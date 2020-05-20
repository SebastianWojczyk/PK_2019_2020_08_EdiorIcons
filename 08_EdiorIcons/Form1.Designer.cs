namespace _08_EdiorIcons
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
            this.comboBoxIconList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIconName = new System.Windows.Forms.TextBox();
            this.numericUpDownIconSize = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxIconEditor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIconSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxIconList
            // 
            this.comboBoxIconList.DisplayMember = "Name";
            this.comboBoxIconList.FormattingEnabled = true;
            this.comboBoxIconList.Location = new System.Drawing.Point(96, 12);
            this.comboBoxIconList.Name = "comboBoxIconList";
            this.comboBoxIconList.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIconList.TabIndex = 0;
            this.comboBoxIconList.SelectedIndexChanged += new System.EventHandler(this.comboBoxIconList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista ikon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rozmiar";
            // 
            // textBoxIconName
            // 
            this.textBoxIconName.Location = new System.Drawing.Point(96, 40);
            this.textBoxIconName.Name = "textBoxIconName";
            this.textBoxIconName.Size = new System.Drawing.Size(121, 20);
            this.textBoxIconName.TabIndex = 4;
            this.textBoxIconName.TextChanged += new System.EventHandler(this.textBoxIconName_TextChanged);
            // 
            // numericUpDownIconSize
            // 
            this.numericUpDownIconSize.Location = new System.Drawing.Point(96, 67);
            this.numericUpDownIconSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownIconSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownIconSize.Name = "numericUpDownIconSize";
            this.numericUpDownIconSize.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownIconSize.TabIndex = 5;
            this.numericUpDownIconSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownIconSize.ValueChanged += new System.EventHandler(this.numericUpDownIconSize_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBoxIconEditor.Location = new System.Drawing.Point(15, 98);
            this.pictureBoxIconEditor.Name = "pictureBox1";
            this.pictureBoxIconEditor.Size = new System.Drawing.Size(174, 167);
            this.pictureBoxIconEditor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxIconEditor.TabIndex = 6;
            this.pictureBoxIconEditor.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxIconEditor);
            this.Controls.Add(this.numericUpDownIconSize);
            this.Controls.Add(this.textBoxIconName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxIconList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIconSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIconList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIconName;
        private System.Windows.Forms.NumericUpDown numericUpDownIconSize;
        private System.Windows.Forms.PictureBox pictureBoxIconEditor;
    }
}

