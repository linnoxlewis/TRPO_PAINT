namespace PaintOVV.GUI
{
    partial class NewFileForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.defaultSize4 = new System.Windows.Forms.RadioButton();
            this.defaultSize3 = new System.Windows.Forms.RadioButton();
            this.defaultSize2 = new System.Windows.Forms.RadioButton();
            this.defaultSize1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.usersSize = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.defaultSize4);
            this.groupBox1.Controls.Add(this.defaultSize3);
            this.groupBox1.Controls.Add(this.defaultSize2);
            this.groupBox1.Controls.Add(this.defaultSize1);
            this.groupBox1.Location = new System.Drawing.Point(25, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Default size";
            // 
            // defaultSize4
            // 
            this.defaultSize4.AutoSize = true;
            this.defaultSize4.Location = new System.Drawing.Point(17, 97);
            this.defaultSize4.Name = "defaultSize4";
            this.defaultSize4.Size = new System.Drawing.Size(72, 17);
            this.defaultSize4.TabIndex = 3;
            this.defaultSize4.TabStop = true;
            this.defaultSize4.Text = "1024x768";
            this.defaultSize4.UseVisualStyleBackColor = true;
            // 
            // defaultSize3
            // 
            this.defaultSize3.AutoSize = true;
            this.defaultSize3.Location = new System.Drawing.Point(17, 74);
            this.defaultSize3.Name = "defaultSize3";
            this.defaultSize3.Size = new System.Drawing.Size(66, 17);
            this.defaultSize3.TabIndex = 2;
            this.defaultSize3.TabStop = true;
            this.defaultSize3.Text = "800x600";
            this.defaultSize3.UseVisualStyleBackColor = true;
            // 
            // defaultSize2
            // 
            this.defaultSize2.AutoSize = true;
            this.defaultSize2.Location = new System.Drawing.Point(17, 51);
            this.defaultSize2.Name = "defaultSize2";
            this.defaultSize2.Size = new System.Drawing.Size(66, 17);
            this.defaultSize2.TabIndex = 1;
            this.defaultSize2.TabStop = true;
            this.defaultSize2.Text = "640x480";
            this.defaultSize2.UseVisualStyleBackColor = true;
            // 
            // defaultSize1
            // 
            this.defaultSize1.AutoSize = true;
            this.defaultSize1.Location = new System.Drawing.Point(17, 28);
            this.defaultSize1.Name = "defaultSize1";
            this.defaultSize1.Size = new System.Drawing.Size(66, 17);
            this.defaultSize1.TabIndex = 0;
            this.defaultSize1.TabStop = true;
            this.defaultSize1.Text = "320x240";
            this.defaultSize1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.usersSize);
            this.groupBox2.Location = new System.Drawing.Point(185, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(6, 77);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 51);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1100,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // usersSize
            // 
            this.usersSize.AutoSize = true;
            this.usersSize.Location = new System.Drawing.Point(6, 19);
            this.usersSize.Name = "usersSize";
            this.usersSize.Size = new System.Drawing.Size(117, 17);
            this.usersSize.TabIndex = 0;
            this.usersSize.Text = "Introduces the user";
            this.usersSize.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(104, 164);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(185, 164);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // NewFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(369, 208);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewFileForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton defaultSize4;
        private System.Windows.Forms.RadioButton defaultSize3;
        private System.Windows.Forms.RadioButton defaultSize2;
        private System.Windows.Forms.RadioButton defaultSize1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox usersSize;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}