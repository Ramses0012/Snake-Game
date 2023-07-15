namespace PA5_Draft
{
    partial class ChooseNumberOfApplesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.chooseNumberOfApplesUpDown = new System.Windows.Forms.NumericUpDown();
            this.OKButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chooseNumberOfApplesUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chartreuse;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Number Of Apples";
            // 
            // chooseNumberOfApplesUpDown
            // 
            this.chooseNumberOfApplesUpDown.Location = new System.Drawing.Point(345, 332);
            this.chooseNumberOfApplesUpDown.Name = "chooseNumberOfApplesUpDown";
            this.chooseNumberOfApplesUpDown.Size = new System.Drawing.Size(62, 22);
            this.chooseNumberOfApplesUpDown.TabIndex = 1;
            this.chooseNumberOfApplesUpDown.ValueChanged += new System.EventHandler(this.chooseNumberOfApplesUpDown_ValueChanged);
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.Color.LightGreen;
            this.OKButton.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OKButton.Location = new System.Drawing.Point(554, 247);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(111, 47);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "Start!";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ChooseNumberOfApplesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PA5_Draft.Properties.Resources.snake;
            this.ClientSize = new System.Drawing.Size(966, 474);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.chooseNumberOfApplesUpDown);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ChooseNumberOfApplesForm";
            this.Text = "ChooseNumberOfApplesForm";
            ((System.ComponentModel.ISupportInitialize)(this.chooseNumberOfApplesUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown chooseNumberOfApplesUpDown;
        private System.Windows.Forms.Button OKButton;
    }
}