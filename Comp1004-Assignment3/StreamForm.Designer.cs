namespace Comp1004_Assignment3
{
    partial class StreamForm
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
            this.StreamTextBox = new System.Windows.Forms.TextBox();
            this.StreamOkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StreamTextBox
            // 
            this.StreamTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.StreamTextBox.Location = new System.Drawing.Point(50, 27);
            this.StreamTextBox.Name = "StreamTextBox";
            this.StreamTextBox.Size = new System.Drawing.Size(298, 26);
            this.StreamTextBox.TabIndex = 0;
            this.StreamTextBox.Text = "\r\n";
            // 
            // StreamOkButton
            // 
            this.StreamOkButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamOkButton.Location = new System.Drawing.Point(161, 221);
            this.StreamOkButton.Name = "StreamOkButton";
            this.StreamOkButton.Size = new System.Drawing.Size(82, 33);
            this.StreamOkButton.TabIndex = 1;
            this.StreamOkButton.Text = "OK";
            this.StreamOkButton.UseVisualStyleBackColor = true;
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(395, 266);
            this.Controls.Add(this.StreamOkButton);
            this.Controls.Add(this.StreamTextBox);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StreamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Bananza Stream";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StreamTextBox;
        private System.Windows.Forms.Button StreamOkButton;
    }
}