namespace Comp1004_Assignment3
{
    partial class SelectionForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ListBoxLabel = new System.Windows.Forms.Label();
            this.SelectGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectionPictureBox = new System.Windows.Forms.PictureBox();
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.SelectGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
            "Cedar Rapids",
            "Company Men",
            "Death Race 2",
            "Footloose",
            "Gnomeo and Juliet",
            "I am Number Four",
            "Just Go With It",
            "No Strings Attached",
            "Real Steal",
            "Sanctum",
            "Season of the Witch",
            "The Dilemma",
            "The Eagle",
            "The Green Hornet",
            "The Mechanic",
            "The Other Woman",
            "The Rite",
            "The Roommate",
            "The Way Back",
            "Waiting for Forever"});
            this.listBox1.Location = new System.Drawing.Point(33, 93);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 327);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(13, 9);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(249, 22);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Please Select a Movie Below:";
            // 
            // ListBoxLabel
            // 
            this.ListBoxLabel.AutoSize = true;
            this.ListBoxLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxLabel.Location = new System.Drawing.Point(53, 67);
            this.ListBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ListBoxLabel.Name = "ListBoxLabel";
            this.ListBoxLabel.Size = new System.Drawing.Size(139, 22);
            this.ListBoxLabel.TabIndex = 2;
            this.ListBoxLabel.Text = "Current Movies";
            // 
            // SelectGroupBox
            // 
            this.SelectGroupBox.Controls.Add(this.CostTextBox);
            this.SelectGroupBox.Controls.Add(this.CostLabel);
            this.SelectGroupBox.Controls.Add(this.GenreTextBox);
            this.SelectGroupBox.Controls.Add(this.GenreLabel);
            this.SelectGroupBox.Controls.Add(this.TitleTextBox);
            this.SelectGroupBox.Controls.Add(this.MovieTitleLabel);
            this.SelectGroupBox.Controls.Add(this.SelectionPictureBox);
            this.SelectGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectGroupBox.Location = new System.Drawing.Point(227, 93);
            this.SelectGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectGroupBox.Name = "SelectGroupBox";
            this.SelectGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectGroupBox.Size = new System.Drawing.Size(466, 256);
            this.SelectGroupBox.TabIndex = 3;
            this.SelectGroupBox.TabStop = false;
            this.SelectGroupBox.Text = "Your Selection";
            // 
            // SelectionPictureBox
            // 
            this.SelectionPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SelectionPictureBox.Location = new System.Drawing.Point(9, 27);
            this.SelectionPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectionPictureBox.Name = "SelectionPictureBox";
            this.SelectionPictureBox.Size = new System.Drawing.Size(186, 224);
            this.SelectionPictureBox.TabIndex = 0;
            this.SelectionPictureBox.TabStop = false;
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Location = new System.Drawing.Point(222, 27);
            this.MovieTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(34, 19);
            this.MovieTitleLabel.TabIndex = 1;
            this.MovieTitleLabel.Text = "Title";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TitleTextBox.Location = new System.Drawing.Point(226, 54);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(216, 26);
            this.TitleTextBox.TabIndex = 2;
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(222, 88);
            this.GenreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(46, 19);
            this.GenreLabel.TabIndex = 3;
            this.GenreLabel.Text = "Genre";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.GenreTextBox.Location = new System.Drawing.Point(226, 115);
            this.GenreTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.ReadOnly = true;
            this.GenreTextBox.Size = new System.Drawing.Size(118, 26);
            this.GenreTextBox.TabIndex = 4;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(222, 149);
            this.CostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(38, 19);
            this.CostLabel.TabIndex = 5;
            this.CostLabel.Text = "Cost";
            // 
            // CostTextBox
            // 
            this.CostTextBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CostTextBox.Location = new System.Drawing.Point(226, 176);
            this.CostTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(118, 26);
            this.CostTextBox.TabIndex = 6;
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(611, 387);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(82, 33);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(706, 435);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.SelectGroupBox);
            this.Controls.Add(this.ListBoxLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selection Form";
            this.SelectGroupBox.ResumeLayout(false);
            this.SelectGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ListBoxLabel;
        private System.Windows.Forms.GroupBox SelectGroupBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.PictureBox SelectionPictureBox;
        private System.Windows.Forms.Button NextButton;
    }
}

