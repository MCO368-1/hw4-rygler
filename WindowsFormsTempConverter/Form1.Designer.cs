namespace WindowsFormsTempConverter
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
            this.convertButton = new System.Windows.Forms.Button();
            this.fromLabel = new System.Windows.Forms.Label();
            this.tempFromBox = new System.Windows.Forms.ComboBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.temptToBox = new System.Windows.Forms.ComboBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(99, 332);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(84, 137);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(113, 17);
            this.fromLabel.TabIndex = 1;
            this.fromLabel.Text = "Tempature From";
            // 
            // tempFromBox
            // 
            this.tempFromBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tempFromBox.FormattingEnabled = true;
            this.tempFromBox.Items.AddRange(new object[] {
            "Fahrenheit",
            "Celsius",
            "Kelvin"});
            this.tempFromBox.Location = new System.Drawing.Point(228, 134);
            this.tempFromBox.Name = "tempFromBox";
            this.tempFromBox.Size = new System.Drawing.Size(121, 24);
            this.tempFromBox.TabIndex = 2;
            this.tempFromBox.SelectedIndexChanged += new System.EventHandler(this.tempFromBox_SelectedIndexChanged);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(84, 229);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(111, 17);
            this.toLabel.TabIndex = 3;
            this.toLabel.Text = "Temperature To";
            // 
            // temptToBox
            // 
            this.temptToBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.temptToBox.FormattingEnabled = true;
            this.temptToBox.Items.AddRange(new object[] {
            "Fahrenheit",
            "Celsius",
            "Kelvin"});
            this.temptToBox.Location = new System.Drawing.Point(228, 226);
            this.temptToBox.Name = "temptToBox";
            this.temptToBox.Size = new System.Drawing.Size(121, 24);
            this.temptToBox.TabIndex = 4;
            this.temptToBox.SelectedIndexChanged += new System.EventHandler(this.temptToBox_SelectedIndexChanged);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(87, 61);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(58, 17);
            this.numberLabel.TabIndex = 5;
            this.numberLabel.Text = "Number";
            this.numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(228, 61);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(121, 22);
            this.numberTextBox.TabIndex = 6;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(228, 337);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(48, 17);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 491);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.temptToBox);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.tempFromBox);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.convertButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.ComboBox tempFromBox;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.ComboBox temptToBox;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label resultLabel;
    }
}

