
namespace Final_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.selectButton = new System.Windows.Forms.Button();
            this.fileBox = new System.Windows.Forms.TextBox();
            this.readBox = new System.Windows.Forms.TextBox();
            this.goodBox = new System.Windows.Forms.TextBox();
            this.minimumBox = new System.Windows.Forms.TextBox();
            this.maximumBox = new System.Windows.Forms.TextBox();
            this.averageBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialog1.FilterIndex = 2;
            this.openFileDialog1.InitialDirectory = "C:\\Temp";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.ShowReadOnly = true;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(387, 12);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 0;
            this.selectButton.Text = "Select File";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // fileBox
            // 
            this.fileBox.Location = new System.Drawing.Point(27, 12);
            this.fileBox.Name = "fileBox";
            this.fileBox.Size = new System.Drawing.Size(353, 23);
            this.fileBox.TabIndex = 1;
            // 
            // readBox
            // 
            this.readBox.Location = new System.Drawing.Point(190, 53);
            this.readBox.Name = "readBox";
            this.readBox.ReadOnly = true;
            this.readBox.Size = new System.Drawing.Size(100, 23);
            this.readBox.TabIndex = 2;
            // 
            // goodBox
            // 
            this.goodBox.Location = new System.Drawing.Point(190, 82);
            this.goodBox.Name = "goodBox";
            this.goodBox.ReadOnly = true;
            this.goodBox.Size = new System.Drawing.Size(100, 23);
            this.goodBox.TabIndex = 3;
            // 
            // minimumBox
            // 
            this.minimumBox.Location = new System.Drawing.Point(190, 111);
            this.minimumBox.Name = "minimumBox";
            this.minimumBox.ReadOnly = true;
            this.minimumBox.Size = new System.Drawing.Size(100, 23);
            this.minimumBox.TabIndex = 4;
            // 
            // maximumBox
            // 
            this.maximumBox.Location = new System.Drawing.Point(190, 140);
            this.maximumBox.Name = "maximumBox";
            this.maximumBox.ReadOnly = true;
            this.maximumBox.Size = new System.Drawing.Size(100, 23);
            this.maximumBox.TabIndex = 5;
            // 
            // averageBox
            // 
            this.averageBox.Location = new System.Drawing.Point(190, 169);
            this.averageBox.Name = "averageBox";
            this.averageBox.ReadOnly = true;
            this.averageBox.Size = new System.Drawing.Size(100, 23);
            this.averageBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Count of Read Rows:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Count of Good Rows";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Minimum Rainfall";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Maximum Rainfall";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Average Rainfall";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(387, 202);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(301, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(474, 234);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.averageBox);
            this.Controls.Add(this.maximumBox);
            this.Controls.Add(this.minimumBox);
            this.Controls.Add(this.goodBox);
            this.Controls.Add(this.readBox);
            this.Controls.Add(this.fileBox);
            this.Controls.Add(this.selectButton);
            this.Name = "Form1";
            this.Text = "Rainfall Data Collector";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.TextBox fileBox;
        private System.Windows.Forms.TextBox minimumBox;
        private System.Windows.Forms.TextBox maximumBox;
        private System.Windows.Forms.TextBox averageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox readBox;
        private System.Windows.Forms.TextBox goodBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

