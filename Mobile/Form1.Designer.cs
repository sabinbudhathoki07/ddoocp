namespace Mobile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pRICEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWMOVIEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dISPLAYMOVIEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bRANDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWGENREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dISPLAYGENREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pRICEToolStripMenuItem,
            this.bRANDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pRICEToolStripMenuItem
            // 
            this.pRICEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWMOVIEToolStripMenuItem,
            this.dISPLAYMOVIEToolStripMenuItem});
            this.pRICEToolStripMenuItem.Name = "pRICEToolStripMenuItem";
            this.pRICEToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.pRICEToolStripMenuItem.Text = "MOVIE";
            // 
            // nEWMOVIEToolStripMenuItem
            // 
            this.nEWMOVIEToolStripMenuItem.Name = "nEWMOVIEToolStripMenuItem";
            this.nEWMOVIEToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.nEWMOVIEToolStripMenuItem.Text = "NEW MOVIE";
            this.nEWMOVIEToolStripMenuItem.Click += new System.EventHandler(this.NEWMOVIEToolStripMenuItem_Click);
            // 
            // dISPLAYMOVIEToolStripMenuItem
            // 
            this.dISPLAYMOVIEToolStripMenuItem.Name = "dISPLAYMOVIEToolStripMenuItem";
            this.dISPLAYMOVIEToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.dISPLAYMOVIEToolStripMenuItem.Text = "DISPLAY MOVIE";
            this.dISPLAYMOVIEToolStripMenuItem.Click += new System.EventHandler(this.DISPLAYMOVIEToolStripMenuItem_Click);
            // 
            // bRANDToolStripMenuItem
            // 
            this.bRANDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWGENREToolStripMenuItem,
            this.dISPLAYGENREToolStripMenuItem});
            this.bRANDToolStripMenuItem.Name = "bRANDToolStripMenuItem";
            this.bRANDToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.bRANDToolStripMenuItem.Text = "GENRE";
            // 
            // nEWGENREToolStripMenuItem
            // 
            this.nEWGENREToolStripMenuItem.Name = "nEWGENREToolStripMenuItem";
            this.nEWGENREToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.nEWGENREToolStripMenuItem.Text = "NEW GENRE";
            this.nEWGENREToolStripMenuItem.Click += new System.EventHandler(this.NEWGENREToolStripMenuItem_Click);
            // 
            // dISPLAYGENREToolStripMenuItem
            // 
            this.dISPLAYGENREToolStripMenuItem.Name = "dISPLAYGENREToolStripMenuItem";
            this.dISPLAYGENREToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.dISPLAYGENREToolStripMenuItem.Text = "DISPLAY GENRE";
            this.dISPLAYGENREToolStripMenuItem.Click += new System.EventHandler(this.DISPLAYGENREToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MOVIE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pRICEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bRANDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWMOVIEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dISPLAYMOVIEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWGENREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dISPLAYGENREToolStripMenuItem;
    }
}

