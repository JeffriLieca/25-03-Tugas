
namespace _25_03_Tugas
{
    partial class FormTugas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelData = new System.Windows.Forms.Label();
            this.labelMode = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.buttonProses = new System.Windows.Forms.Button();
            this.listBoxKiri = new System.Windows.Forms.ListBox();
            this.listBoxkanan = new System.Windows.Forms.ListBox();
            this.buttonKananPol = new System.Windows.Forms.Button();
            this.buttonKanan = new System.Windows.Forms.Button();
            this.buttonKiri = new System.Windows.Forms.Button();
            this.buttonKiriPol = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.checkBoxBlock = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(25, 24);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(48, 20);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Data: ";
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Location = new System.Drawing.Point(25, 71);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(51, 20);
            this.labelMode.TabIndex = 1;
            this.labelMode.Text = "Mode:";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(92, 24);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(291, 27);
            this.textBoxData.TabIndex = 2;
            this.textBoxData.TextChanged += new System.EventHandler(this.textBoxData_TextChanged);
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "Add",
            "Replace"});
            this.comboBoxMode.Location = new System.Drawing.Point(92, 71);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(171, 28);
            this.comboBoxMode.TabIndex = 3;
            this.comboBoxMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxMode_SelectedIndexChanged);
            // 
            // buttonProses
            // 
            this.buttonProses.Location = new System.Drawing.Point(25, 124);
            this.buttonProses.Name = "buttonProses";
            this.buttonProses.Size = new System.Drawing.Size(94, 29);
            this.buttonProses.TabIndex = 4;
            this.buttonProses.Text = "Proses";
            this.buttonProses.UseVisualStyleBackColor = true;
            this.buttonProses.Click += new System.EventHandler(this.buttonProses_Click);
            // 
            // listBoxKiri
            // 
            this.listBoxKiri.FormattingEnabled = true;
            this.listBoxKiri.ItemHeight = 20;
            this.listBoxKiri.Location = new System.Drawing.Point(25, 177);
            this.listBoxKiri.Name = "listBoxKiri";
            this.listBoxKiri.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxKiri.Size = new System.Drawing.Size(198, 364);
            this.listBoxKiri.TabIndex = 5;
            // 
            // listBoxkanan
            // 
            this.listBoxkanan.FormattingEnabled = true;
            this.listBoxkanan.ItemHeight = 20;
            this.listBoxkanan.Location = new System.Drawing.Point(316, 177);
            this.listBoxkanan.Name = "listBoxkanan";
            this.listBoxkanan.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxkanan.Size = new System.Drawing.Size(198, 364);
            this.listBoxkanan.TabIndex = 6;
            // 
            // buttonKananPol
            // 
            this.buttonKananPol.Location = new System.Drawing.Point(238, 242);
            this.buttonKananPol.Name = "buttonKananPol";
            this.buttonKananPol.Size = new System.Drawing.Size(44, 29);
            this.buttonKananPol.TabIndex = 7;
            this.buttonKananPol.Text = ">>";
            this.buttonKananPol.UseVisualStyleBackColor = true;
            this.buttonKananPol.Click += new System.EventHandler(this.buttonKananPol_Click);
            // 
            // buttonKanan
            // 
            this.buttonKanan.Location = new System.Drawing.Point(238, 303);
            this.buttonKanan.Name = "buttonKanan";
            this.buttonKanan.Size = new System.Drawing.Size(44, 29);
            this.buttonKanan.TabIndex = 8;
            this.buttonKanan.Text = ">";
            this.buttonKanan.UseVisualStyleBackColor = true;
            this.buttonKanan.Click += new System.EventHandler(this.buttonKanan_Click);
            // 
            // buttonKiri
            // 
            this.buttonKiri.Location = new System.Drawing.Point(238, 366);
            this.buttonKiri.Name = "buttonKiri";
            this.buttonKiri.Size = new System.Drawing.Size(44, 29);
            this.buttonKiri.TabIndex = 9;
            this.buttonKiri.Text = "<";
            this.buttonKiri.UseVisualStyleBackColor = true;
            this.buttonKiri.Click += new System.EventHandler(this.buttonKiri_Click);
            // 
            // buttonKiriPol
            // 
            this.buttonKiriPol.Location = new System.Drawing.Point(238, 426);
            this.buttonKiriPol.Name = "buttonKiriPol";
            this.buttonKiriPol.Size = new System.Drawing.Size(44, 29);
            this.buttonKiriPol.TabIndex = 10;
            this.buttonKiriPol.Text = "<<";
            this.buttonKiriPol.UseVisualStyleBackColor = true;
            this.buttonKiriPol.Click += new System.EventHandler(this.buttonKiriPol_Click);
            // 
            // buttonX
            // 
            this.buttonX.Location = new System.Drawing.Point(238, 484);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(44, 29);
            this.buttonX.TabIndex = 11;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // checkBoxBlock
            // 
            this.checkBoxBlock.AutoSize = true;
            this.checkBoxBlock.Location = new System.Drawing.Point(316, 129);
            this.checkBoxBlock.Name = "checkBoxBlock";
            this.checkBoxBlock.Size = new System.Drawing.Size(67, 24);
            this.checkBoxBlock.TabIndex = 12;
            this.checkBoxBlock.Text = "Block";
            this.checkBoxBlock.UseVisualStyleBackColor = true;
            this.checkBoxBlock.CheckedChanged += new System.EventHandler(this.checkBoxBlock_CheckedChanged);
            // 
            // FormTugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 574);
            this.Controls.Add(this.checkBoxBlock);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonKiriPol);
            this.Controls.Add(this.buttonKiri);
            this.Controls.Add(this.buttonKanan);
            this.Controls.Add(this.buttonKananPol);
            this.Controls.Add(this.listBoxkanan);
            this.Controls.Add(this.listBoxKiri);
            this.Controls.Add(this.buttonProses);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.labelData);
            this.Name = "FormTugas";
            this.Text = "Form Tugas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.Button buttonProses;
        private System.Windows.Forms.ListBox listBoxKiri;
        private System.Windows.Forms.ListBox listBoxkanan;
        private System.Windows.Forms.Button buttonKananPol;
        private System.Windows.Forms.Button buttonKanan;
        private System.Windows.Forms.Button buttonKiri;
        private System.Windows.Forms.Button buttonKiriPol;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.CheckBox checkBoxBlock;
    }
}

