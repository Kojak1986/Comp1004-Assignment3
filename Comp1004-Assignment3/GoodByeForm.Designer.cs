namespace Comp1004_Assignment3
{
    partial class GoodByeForm
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
            this.GoodByeLabel = new System.Windows.Forms.Label();
            this.GoodByeTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // GoodByeLabel
            // 
            this.GoodByeLabel.AutoSize = true;
            this.GoodByeLabel.BackColor = System.Drawing.Color.Transparent;
            this.GoodByeLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoodByeLabel.Location = new System.Drawing.Point(115, 116);
            this.GoodByeLabel.Name = "GoodByeLabel";
            this.GoodByeLabel.Size = new System.Drawing.Size(176, 23);
            this.GoodByeLabel.TabIndex = 0;
            this.GoodByeLabel.Text = "Enjoy Your Movie!!";
            // 
            // GoodByeTimer
            // 
            this.GoodByeTimer.Interval = 3000;
            this.GoodByeTimer.Tick += new System.EventHandler(this.GoodByeTimer_Tick);
            // 
            // GoodByeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Comp1004_Assignment3.Properties.Resources.MovieBackGround3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(395, 266);
            this.Controls.Add(this.GoodByeLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GoodByeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoodByeForm";
            this.Load += new System.EventHandler(this.GoodByeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GoodByeLabel;
        private System.Windows.Forms.Timer GoodByeTimer;
    }
}