namespace DrawApp
{
    partial class Pallet
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
            this.circleButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.lineButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.penSizeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(12, 12);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(115, 109);
            this.circleButton.TabIndex = 0;
            this.circleButton.Text = "Circle";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.CircleButtonClicked);
            // 
            // rectangleButton
            // 
            this.rectangleButton.Location = new System.Drawing.Point(134, 13);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(113, 108);
            this.rectangleButton.TabIndex = 1;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.RectButtonClicked);
            // 
            // lineButton
            // 
            this.lineButton.Location = new System.Drawing.Point(254, 12);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(111, 109);
            this.lineButton.TabIndex = 2;
            this.lineButton.Text = "Line";
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.LineButtonClicked);
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.SystemColors.WindowText;
            this.colorButton.Location = new System.Drawing.Point(391, 51);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(36, 36);
            this.colorButton.TabIndex = 3;
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.ColorButtonClicked);
            // 
            // penSizeBox
            // 
            this.penSizeBox.Location = new System.Drawing.Point(391, 101);
            this.penSizeBox.Name = "penSizeBox";
            this.penSizeBox.Size = new System.Drawing.Size(100, 19);
            this.penSizeBox.TabIndex = 4;
            this.penSizeBox.Text = "3";
            // 
            // Pallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 135);
            this.Controls.Add(this.penSizeBox);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.lineButton);
            this.Controls.Add(this.rectangleButton);
            this.Controls.Add(this.circleButton);
            this.Name = "Pallet";
            this.Text = "Pallet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.TextBox penSizeBox;
    }
}