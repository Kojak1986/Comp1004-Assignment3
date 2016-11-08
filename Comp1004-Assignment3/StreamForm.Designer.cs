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
            this.components = new System.ComponentModel.Container();
            this.StreamOkButton = new System.Windows.Forms.Button();
            this.StreamProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressTimer = new System.Windows.Forms.Timer(this.components);
            this.StreamLabel = new System.Windows.Forms.Label();
            this.MovieReadyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StreamOkButton
            // 
            this.StreamOkButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StreamOkButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamOkButton.Location = new System.Drawing.Point(164, 187);
            this.StreamOkButton.Name = "StreamOkButton";
            this.StreamOkButton.Size = new System.Drawing.Size(82, 33);
            this.StreamOkButton.TabIndex = 1;
            this.StreamOkButton.Text = "OK";
            this.StreamOkButton.UseVisualStyleBackColor = false;
            this.StreamOkButton.Visible = false;
            this.StreamOkButton.Click += new System.EventHandler(this.StreamOkButton_Click);
            // 
            // StreamProgressBar
            // 
            this.StreamProgressBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StreamProgressBar.Location = new System.Drawing.Point(111, 158);
            this.StreamProgressBar.Name = "StreamProgressBar";
            this.StreamProgressBar.Size = new System.Drawing.Size(185, 23);
            this.StreamProgressBar.TabIndex = 2;
            // 
            // ProgressTimer
            // 
            this.ProgressTimer.Enabled = true;
            this.ProgressTimer.Interval = 20;
            this.ProgressTimer.Tick += new System.EventHandler(this.ProgressTimer_Tick);
            // 
            // StreamLabel
            // 
            this.StreamLabel.AutoSize = true;
            this.StreamLabel.BackColor = System.Drawing.Color.Transparent;
            this.StreamLabel.Location = new System.Drawing.Point(69, 42);
            this.StreamLabel.Name = "StreamLabel";
            this.StreamLabel.Size = new System.Drawing.Size(0, 19);
            this.StreamLabel.TabIndex = 3;
            this.StreamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MovieReadyLabel
            // 
            this.MovieReadyLabel.AutoSize = true;
            this.MovieReadyLabel.BackColor = System.Drawing.Color.Transparent;
            this.MovieReadyLabel.Location = new System.Drawing.Point(134, 136);
            this.MovieReadyLabel.Name = "MovieReadyLabel";
            this.MovieReadyLabel.Size = new System.Drawing.Size(133, 19);
            this.MovieReadyLabel.TabIndex = 4;
            this.MovieReadyLabel.Text = "Click OK to Watch!";
            this.MovieReadyLabel.Visible = false;
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = global::Comp1004_Assignment3.Properties.Resources.MovieBackGround3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(395, 266);
            this.Controls.Add(this.MovieReadyLabel);
            this.Controls.Add(this.StreamLabel);
            this.Controls.Add(this.StreamProgressBar);
            this.Controls.Add(this.StreamOkButton);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StreamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Bananza Stream";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StreamForm_FormClosing);
            this.Load += new System.EventHandler(this.StreamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StreamOkButton;
        private System.Windows.Forms.ProgressBar StreamProgressBar;
        private System.Windows.Forms.Timer ProgressTimer;
        private System.Windows.Forms.Label StreamLabel;
        private System.Windows.Forms.Label MovieReadyLabel;
    }
}