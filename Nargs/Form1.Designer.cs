namespace Nargs
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
            this.nargsbtn = new System.Windows.Forms.Button();
            this.sairbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nargsbtn
            // 
            this.nargsbtn.Location = new System.Drawing.Point(45, 34);
            this.nargsbtn.Name = "nargsbtn";
            this.nargsbtn.Size = new System.Drawing.Size(206, 74);
            this.nargsbtn.TabIndex = 0;
            this.nargsbtn.Text = "E O NARGS?";
            this.nargsbtn.UseVisualStyleBackColor = true;
            this.nargsbtn.Click += new System.EventHandler(this.nargsbtn_Click);
            // 
            // sairbtn
            // 
            this.sairbtn.Location = new System.Drawing.Point(45, 124);
            this.sairbtn.Name = "sairbtn";
            this.sairbtn.Size = new System.Drawing.Size(206, 74);
            this.sairbtn.TabIndex = 1;
            this.sairbtn.Text = "SAIR";
            this.sairbtn.UseVisualStyleBackColor = true;
            this.sairbtn.Click += new System.EventHandler(this.sairbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 249);
            this.Controls.Add(this.sairbtn);
            this.Controls.Add(this.nargsbtn);
            this.Name = "Form1";
            this.Text = "NARGUILA";
            this.ResumeLayout(false);

        }

        #endregion

        private Button nargsbtn;
        private Button sairbtn;
    }
}