
namespace multithreading
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
            this.GetDirectory = new System.Windows.Forms.Button();
            this.LoadDirectory = new System.Windows.Forms.Button();
            this.DirectoryString = new System.Windows.Forms.TextBox();
            this.ViewDirectory = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // GetDirectory
            // 
            this.GetDirectory.Location = new System.Drawing.Point(455, 37);
            this.GetDirectory.Name = "GetDirectory";
            this.GetDirectory.Size = new System.Drawing.Size(96, 23);
            this.GetDirectory.TabIndex = 0;
            this.GetDirectory.Text = "Get Directory";
            this.GetDirectory.UseVisualStyleBackColor = true;
            this.GetDirectory.Click += new System.EventHandler(this.GetDirectoryBtn);
            // 
            // LoadDirectory
            // 
            this.LoadDirectory.Location = new System.Drawing.Point(455, 86);
            this.LoadDirectory.Name = "LoadDirectory";
            this.LoadDirectory.Size = new System.Drawing.Size(96, 23);
            this.LoadDirectory.TabIndex = 1;
            this.LoadDirectory.Text = "Load Directory";
            this.LoadDirectory.UseVisualStyleBackColor = true;
            this.LoadDirectory.Click += new System.EventHandler(this.LoadDirectoryBtn);
            // 
            // DirectoryString
            // 
            this.DirectoryString.Location = new System.Drawing.Point(64, 37);
            this.DirectoryString.Name = "DirectoryString";
            this.DirectoryString.Size = new System.Drawing.Size(364, 23);
            this.DirectoryString.TabIndex = 2;
            // 
            // ViewDirectory
            // 
            this.ViewDirectory.Location = new System.Drawing.Point(64, 86);
            this.ViewDirectory.Name = "ViewDirectory";
            this.ViewDirectory.Size = new System.Drawing.Size(364, 352);
            this.ViewDirectory.TabIndex = 3;
            this.ViewDirectory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ViewDirectory_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewDirectory);
            this.Controls.Add(this.DirectoryString);
            this.Controls.Add(this.LoadDirectory);
            this.Controls.Add(this.GetDirectory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetDirectory;
        private System.Windows.Forms.Button LoadDirectory;
        private System.Windows.Forms.TextBox DirectoryString;
        private System.Windows.Forms.TreeView ViewDirectory;
    }
}

