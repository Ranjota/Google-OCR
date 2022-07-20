namespace Google_OCR
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
            this.BrowseFiles = new System.Windows.Forms.Button();
            this.ConvertFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BrowseFiles
            // 
            this.BrowseFiles.Location = new System.Drawing.Point(122, 45);
            this.BrowseFiles.Name = "BrowseFiles";
            this.BrowseFiles.Size = new System.Drawing.Size(113, 23);
            this.BrowseFiles.TabIndex = 0;
            this.BrowseFiles.Text = "Browse all files";
            this.BrowseFiles.UseVisualStyleBackColor = true;
            this.BrowseFiles.Click += new System.EventHandler(this.BrowseFiles_Click);
            // 
            // ConvertFiles
            // 
            this.ConvertFiles.Location = new System.Drawing.Point(122, 97);
            this.ConvertFiles.Name = "ConvertFiles";
            this.ConvertFiles.Size = new System.Drawing.Size(113, 23);
            this.ConvertFiles.TabIndex = 1;
            this.ConvertFiles.Text = "Convert to word doc";
            this.ConvertFiles.UseVisualStyleBackColor = true;
            this.ConvertFiles.Click += new System.EventHandler(this.ConvertFiles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 202);
            this.Controls.Add(this.ConvertFiles);
            this.Controls.Add(this.BrowseFiles);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BrowseFiles;
        private System.Windows.Forms.Button ConvertFiles;
    }
}

