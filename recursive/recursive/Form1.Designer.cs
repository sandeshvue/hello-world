
namespace recursive
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
            this.pathstring = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Browsebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pathstring
            // 
            this.pathstring.Location = new System.Drawing.Point(162, 47);
            this.pathstring.Name = "pathstring";
            this.pathstring.Size = new System.Drawing.Size(256, 23);
            this.pathstring.TabIndex = 0;
            this.pathstring.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(162, 88);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(266, 403);
            this.treeView1.TabIndex = 1;
            // 
            // Browsebtn
            // 
            this.Browsebtn.Location = new System.Drawing.Point(179, 0);
            this.Browsebtn.Name = "Browsebtn";
            this.Browsebtn.Size = new System.Drawing.Size(218, 23);
            this.Browsebtn.TabIndex = 2;
            this.Browsebtn.Text = "BrowseFiles";
            this.Browsebtn.UseVisualStyleBackColor = true;
            this.Browsebtn.Click += new System.EventHandler(this.Browsefilesbtn);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 493);
            this.Controls.Add(this.Browsebtn);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.pathstring);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathstring;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button bjcckjb;
        private System.Windows.Forms.Button Browsebtn;
    }
}

