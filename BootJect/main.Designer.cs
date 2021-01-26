
namespace BootJect
{
    partial class main
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
            this.title = new System.Windows.Forms.Label();
            this.div = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(139, 39);
            this.title.TabIndex = 0;
            this.title.Text = "bootject";
            // 
            // div
            // 
            this.div.AutoSize = true;
            this.div.Location = new System.Drawing.Point(157, 21);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(61, 13);
            this.div.TabIndex = 1;
            this.div.Text = "_________";
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.Location = new System.Drawing.Point(224, 21);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(26, 25);
            this.x.TabIndex = 2;
            this.x.Text = "X";
            this.x.Click += new System.EventHandler(this.Close);
            // 
            // Open
            // 
            this.Open.AutoSize = true;
            this.Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open.Location = new System.Drawing.Point(13, 48);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(80, 31);
            this.Open.TabIndex = 5;
            this.Open.Text = "Inject";
            this.Open.Click += new System.EventHandler(this.In);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(261, 102);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.x);
            this.Controls.Add(this.div);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BootJect";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label div;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label Open;
    }
}

