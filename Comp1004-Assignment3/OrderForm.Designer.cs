namespace Comp1004_Assignment3
{
    partial class OrderForm
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
            this.MovieSelectedGroupBox = new System.Windows.Forms.GroupBox();
            this.YourOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackButton = new System.Windows.Forms.Button();
            this.StreamButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.OrderDvdCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.MovieSelectedGroupBox.SuspendLayout();
            this.YourOrderGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieSelectedGroupBox
            // 
            this.MovieSelectedGroupBox.Controls.Add(this.MoviePictureBox);
            this.MovieSelectedGroupBox.Controls.Add(this.GenreTextBox);
            this.MovieSelectedGroupBox.Controls.Add(this.TitleTextBox);
            this.MovieSelectedGroupBox.Controls.Add(this.GenreLabel);
            this.MovieSelectedGroupBox.Controls.Add(this.TitleLabel);
            this.MovieSelectedGroupBox.Location = new System.Drawing.Point(12, 27);
            this.MovieSelectedGroupBox.Name = "MovieSelectedGroupBox";
            this.MovieSelectedGroupBox.Size = new System.Drawing.Size(329, 396);
            this.MovieSelectedGroupBox.TabIndex = 0;
            this.MovieSelectedGroupBox.TabStop = false;
            this.MovieSelectedGroupBox.Text = "Movie Selected";
            // 
            // YourOrderGroupBox
            // 
            this.YourOrderGroupBox.Controls.Add(this.textBox4);
            this.YourOrderGroupBox.Controls.Add(this.textBox3);
            this.YourOrderGroupBox.Controls.Add(this.textBox2);
            this.YourOrderGroupBox.Controls.Add(this.textBox1);
            this.YourOrderGroupBox.Controls.Add(this.OrderDvdCheckBox);
            this.YourOrderGroupBox.Controls.Add(this.TotalLabel);
            this.YourOrderGroupBox.Controls.Add(this.SalesTaxLabel);
            this.YourOrderGroupBox.Controls.Add(this.SubTotalLabel);
            this.YourOrderGroupBox.Controls.Add(this.CostLabel);
            this.YourOrderGroupBox.Location = new System.Drawing.Point(365, 27);
            this.YourOrderGroupBox.Name = "YourOrderGroupBox";
            this.YourOrderGroupBox.Size = new System.Drawing.Size(329, 321);
            this.YourOrderGroupBox.TabIndex = 1;
            this.YourOrderGroupBox.TabStop = false;
            this.YourOrderGroupBox.Text = "Your Order";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.streamToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // streamToolStripMenuItem
            // 
            this.streamToolStripMenuItem.Name = "streamToolStripMenuItem";
            this.streamToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.streamToolStripMenuItem.Text = "Stream";
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(365, 390);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(82, 33);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // StreamButton
            // 
            this.StreamButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamButton.Location = new System.Drawing.Point(612, 390);
            this.StreamButton.Name = "StreamButton";
            this.StreamButton.Size = new System.Drawing.Size(82, 33);
            this.StreamButton.TabIndex = 4;
            this.StreamButton.Text = "Stream";
            this.StreamButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(524, 390);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(82, 33);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(37, 33);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(34, 19);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(37, 88);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(46, 19);
            this.GenreLabel.TabIndex = 1;
            this.GenreLabel.Text = "Genre";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(41, 55);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(243, 26);
            this.TitleTextBox.TabIndex = 2;
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(41, 110);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(243, 26);
            this.GenreTextBox.TabIndex = 3;
            // 
            // MoviePictureBox
            // 
            this.MoviePictureBox.Location = new System.Drawing.Point(41, 152);
            this.MoviePictureBox.Name = "MoviePictureBox";
            this.MoviePictureBox.Size = new System.Drawing.Size(243, 238);
            this.MoviePictureBox.TabIndex = 4;
            this.MoviePictureBox.TabStop = false;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(126, 38);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(41, 19);
            this.CostLabel.TabIndex = 0;
            this.CostLabel.Text = "Cost:";
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(97, 85);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(70, 19);
            this.SubTotalLabel.TabIndex = 1;
            this.SubTotalLabel.Text = "Sub Total:";
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(71, 132);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(96, 19);
            this.SalesTaxLabel.TabIndex = 2;
            this.SalesTaxLabel.Text = "SalesTax (13):";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(83, 179);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(84, 19);
            this.TotalLabel.TabIndex = 3;
            this.TotalLabel.Text = "Grand Total:";
            // 
            // OrderDvdCheckBox
            // 
            this.OrderDvdCheckBox.AutoSize = true;
            this.OrderDvdCheckBox.Location = new System.Drawing.Point(45, 268);
            this.OrderDvdCheckBox.Name = "OrderDvdCheckBox";
            this.OrderDvdCheckBox.Size = new System.Drawing.Size(199, 23);
            this.OrderDvdCheckBox.TabIndex = 5;
            this.OrderDvdCheckBox.Text = "Order the DVD (Adds $10)";
            this.OrderDvdCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 176);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(181, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(181, 82);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 9;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(706, 435);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.StreamButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.YourOrderGroupBox);
            this.Controls.Add(this.MovieSelectedGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.MovieSelectedGroupBox.ResumeLayout(false);
            this.MovieSelectedGroupBox.PerformLayout();
            this.YourOrderGroupBox.ResumeLayout(false);
            this.YourOrderGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MovieSelectedGroupBox;
        private System.Windows.Forms.GroupBox YourOrderGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button StreamButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.PictureBox MoviePictureBox;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox OrderDvdCheckBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label CostLabel;
    }
}