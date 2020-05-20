namespace _08_EdiorIcons
{
    partial class FormMainEditor
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
            this.buttonColor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ikonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eksportujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIconSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconEditor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxIconList
            // 
            this.comboBoxIconList.DisplayMember = "Name";
            this.comboBoxIconList.FormattingEnabled = true;
            this.comboBoxIconList.Location = new System.Drawing.Point(96, 33);
            this.comboBoxIconList.Name = "comboBoxIconList";
            this.comboBoxIconList.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIconList.TabIndex = 0;
            this.comboBoxIconList.SelectedIndexChanged += new System.EventHandler(this.comboBoxIconList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista ikon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rozmiar";
            // 
            // textBoxIconName
            // 
            this.textBoxIconName.Location = new System.Drawing.Point(96, 61);
            this.textBoxIconName.Name = "textBoxIconName";
            this.textBoxIconName.Size = new System.Drawing.Size(121, 20);
            this.textBoxIconName.TabIndex = 4;
            this.textBoxIconName.TextChanged += new System.EventHandler(this.textBoxIconName_TextChanged);
            // 
            // numericUpDownIconSize
            // 
            this.numericUpDownIconSize.Location = new System.Drawing.Point(96, 88);
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
            // pictureBoxIconEditor
            // 
            this.pictureBoxIconEditor.Location = new System.Drawing.Point(15, 164);
            this.pictureBoxIconEditor.Name = "pictureBoxIconEditor";
            this.pictureBoxIconEditor.Size = new System.Drawing.Size(174, 167);
            this.pictureBoxIconEditor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxIconEditor.TabIndex = 6;
            this.pictureBoxIconEditor.TabStop = false;
            this.pictureBoxIconEditor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxIconEditor_MouseDown);
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.Red;
            this.buttonColor.Location = new System.Drawing.Point(96, 115);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(120, 23);
            this.buttonColor.TabIndex = 7;
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kolor pióra";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ikonaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ikonaToolStripMenuItem
            // 
            this.ikonaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaToolStripMenuItem,
            this.eksportujToolStripMenuItem});
            this.ikonaToolStripMenuItem.Name = "ikonaToolStripMenuItem";
            this.ikonaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ikonaToolStripMenuItem.Text = "Ikona";
            // 
            // nowaToolStripMenuItem
            // 
            this.nowaToolStripMenuItem.Name = "nowaToolStripMenuItem";
            this.nowaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nowaToolStripMenuItem.Text = "Nowa";
            this.nowaToolStripMenuItem.Click += new System.EventHandler(this.nowaToolStripMenuItem_Click);
            // 
            // eksportujToolStripMenuItem
            // 
            this.eksportujToolStripMenuItem.Name = "eksportujToolStripMenuItem";
            this.eksportujToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eksportujToolStripMenuItem.Text = "Eksportuj";
            this.eksportujToolStripMenuItem.Click += new System.EventHandler(this.eksportujToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.pictureBoxIconEditor);
            this.Controls.Add(this.numericUpDownIconSize);
            this.Controls.Add(this.textBoxIconName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxIconList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIconSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconEditor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ikonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eksportujToolStripMenuItem;
    }
}

