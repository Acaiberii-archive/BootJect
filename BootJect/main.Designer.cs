
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.x = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Label();
            this.procname = new System.Windows.Forms.TextBox();
            this.autoexit = new System.Windows.Forms.CheckBox();
            this.procpt = new System.Windows.Forms.RichTextBox();
            this.load = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funy = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.Location = new System.Drawing.Point(617, 9);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(26, 25);
            this.x.TabIndex = 2;
            this.x.Text = "X";
            this.x.Click += new System.EventHandler(this.Close);
            // 
            // Open
            // 
            this.Open.AutoSize = true;
            this.Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open.Location = new System.Drawing.Point(184, 71);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(48, 20);
            this.Open.TabIndex = 5;
            this.Open.Text = "Inject";
            this.Open.Click += new System.EventHandler(this.In);
            // 
            // procname
            // 
            this.procname.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.procname.ForeColor = System.Drawing.SystemColors.Menu;
            this.procname.Location = new System.Drawing.Point(19, 71);
            this.procname.Name = "procname";
            this.procname.Size = new System.Drawing.Size(159, 20);
            this.procname.TabIndex = 6;
            this.procname.Text = "Name";
            // 
            // autoexit
            // 
            this.autoexit.AutoSize = true;
            this.autoexit.Location = new System.Drawing.Point(19, 97);
            this.autoexit.Name = "autoexit";
            this.autoexit.Size = new System.Drawing.Size(68, 17);
            this.autoexit.TabIndex = 7;
            this.autoexit.Text = "NoTrace";
            this.autoexit.UseVisualStyleBackColor = true;
            // 
            // procpt
            // 
            this.procpt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.procpt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.procpt.ForeColor = System.Drawing.SystemColors.Window;
            this.procpt.Location = new System.Drawing.Point(19, 133);
            this.procpt.Name = "procpt";
            this.procpt.Size = new System.Drawing.Size(624, 126);
            this.procpt.TabIndex = 8;
            this.procpt.Text = "";
            // 
            // load
            // 
            this.load.AutoSize = true;
            this.load.Location = new System.Drawing.Point(158, 21);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(0, 13);
            this.load.TabIndex = 9;
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.Location = new System.Drawing.Point(592, 9);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(19, 25);
            this.min.TabIndex = 10;
            this.min.Text = "-";
            this.min.Click += new System.EventHandler(this.Min);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.minimizeToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(124, 48);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Close);
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.minimizeToolStripMenuItem.Text = "Minimize";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.Min);
            // 
            // funy
            // 
            this.funy.AutoSize = true;
            this.funy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funy.Location = new System.Drawing.Point(15, 32);
            this.funy.Name = "funy";
            this.funy.Size = new System.Drawing.Size(137, 24);
            this.funy.TabIndex = 11;
            this.funy.Text = "loading a funy..";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(655, 271);
            this.ContextMenuStrip = this.menu;
            this.Controls.Add(this.funy);
            this.Controls.Add(this.min);
            this.Controls.Add(this.load);
            this.Controls.Add(this.procpt);
            this.Controls.Add(this.autoexit);
            this.Controls.Add(this.procname);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.x);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BootJect";
            this.Load += new System.EventHandler(this.main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.main_MouseUp);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label Open;
        private System.Windows.Forms.TextBox procname;
        private System.Windows.Forms.CheckBox autoexit;
        private System.Windows.Forms.RichTextBox procpt;
        private System.Windows.Forms.Label load;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.Label funy;
    }
}

