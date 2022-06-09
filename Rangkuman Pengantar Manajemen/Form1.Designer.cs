namespace Rangkuman_Pengantar_Manajemen
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMainSideMenu = new System.Windows.Forms.Panel();
            this.buttonPertemuan2 = new System.Windows.Forms.Button();
            this.panelSubMenuPertemuan1 = new System.Windows.Forms.Panel();
            this.panelSubMenuMekanisme = new System.Windows.Forms.Panel();
            this.buttonProsesdanFungsi = new System.Windows.Forms.Button();
            this.buttonMekanismePertemuan1 = new System.Windows.Forms.Button();
            this.panelSubMenuSubjek = new System.Windows.Forms.Panel();
            this.buttonManajer = new System.Windows.Forms.Button();
            this.buttonOrganisasi = new System.Windows.Forms.Button();
            this.buttonSubjekPertemuan1 = new System.Windows.Forms.Button();
            this.buttonDefinsiPertemuan1 = new System.Windows.Forms.Button();
            this.buttonPertemuan1 = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.userControlHome = new Rangkuman_Pengantar_Manajemen.userControlHome();
            this.userControlPertemuan1 = new Rangkuman_Pengantar_Manajemen.UserControlPertemuan1();
            this.userControl21 = new Rangkuman_Pengantar_Manajemen.UserControl2();
            this.menuStrip1.SuspendLayout();
            this.panelMainSideMenu.SuspendLayout();
            this.panelSubMenuPertemuan1.SuspendLayout();
            this.panelSubMenuMekanisme.SuspendLayout();
            this.panelSubMenuSubjek.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1357, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panelMainSideMenu
            // 
            this.panelMainSideMenu.AutoScroll = true;
            this.panelMainSideMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelMainSideMenu.Controls.Add(this.buttonPertemuan2);
            this.panelMainSideMenu.Controls.Add(this.panelSubMenuPertemuan1);
            this.panelMainSideMenu.Controls.Add(this.buttonPertemuan1);
            this.panelMainSideMenu.Controls.Add(this.buttonHome);
            this.panelMainSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainSideMenu.Location = new System.Drawing.Point(0, 24);
            this.panelMainSideMenu.Name = "panelMainSideMenu";
            this.panelMainSideMenu.Size = new System.Drawing.Size(200, 757);
            this.panelMainSideMenu.TabIndex = 1;
            // 
            // buttonPertemuan2
            // 
            this.buttonPertemuan2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPertemuan2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPertemuan2.FlatAppearance.BorderSize = 0;
            this.buttonPertemuan2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPertemuan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPertemuan2.ForeColor = System.Drawing.Color.White;
            this.buttonPertemuan2.Location = new System.Drawing.Point(0, 479);
            this.buttonPertemuan2.Name = "buttonPertemuan2";
            this.buttonPertemuan2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonPertemuan2.Size = new System.Drawing.Size(200, 60);
            this.buttonPertemuan2.TabIndex = 3;
            this.buttonPertemuan2.Text = "PERTEMUAN 2";
            this.buttonPertemuan2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPertemuan2.UseVisualStyleBackColor = true;
            this.buttonPertemuan2.Click += new System.EventHandler(this.buttonPertemuan2_Click);
            // 
            // panelSubMenuPertemuan1
            // 
            this.panelSubMenuPertemuan1.AutoSize = true;
            this.panelSubMenuPertemuan1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelSubMenuPertemuan1.Controls.Add(this.panelSubMenuMekanisme);
            this.panelSubMenuPertemuan1.Controls.Add(this.buttonMekanismePertemuan1);
            this.panelSubMenuPertemuan1.Controls.Add(this.panelSubMenuSubjek);
            this.panelSubMenuPertemuan1.Controls.Add(this.buttonSubjekPertemuan1);
            this.panelSubMenuPertemuan1.Controls.Add(this.buttonDefinsiPertemuan1);
            this.panelSubMenuPertemuan1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuPertemuan1.Location = new System.Drawing.Point(0, 120);
            this.panelSubMenuPertemuan1.Name = "panelSubMenuPertemuan1";
            this.panelSubMenuPertemuan1.Size = new System.Drawing.Size(200, 359);
            this.panelSubMenuPertemuan1.TabIndex = 2;
            this.panelSubMenuPertemuan1.Visible = false;
            // 
            // panelSubMenuMekanisme
            // 
            this.panelSubMenuMekanisme.AutoSize = true;
            this.panelSubMenuMekanisme.BackColor = System.Drawing.Color.Khaki;
            this.panelSubMenuMekanisme.Controls.Add(this.buttonProsesdanFungsi);
            this.panelSubMenuMekanisme.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuMekanisme.Location = new System.Drawing.Point(0, 299);
            this.panelSubMenuMekanisme.Name = "panelSubMenuMekanisme";
            this.panelSubMenuMekanisme.Size = new System.Drawing.Size(200, 60);
            this.panelSubMenuMekanisme.TabIndex = 6;
            this.panelSubMenuMekanisme.Visible = false;
            // 
            // buttonProsesdanFungsi
            // 
            this.buttonProsesdanFungsi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonProsesdanFungsi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProsesdanFungsi.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProsesdanFungsi.FlatAppearance.BorderSize = 0;
            this.buttonProsesdanFungsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProsesdanFungsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProsesdanFungsi.ForeColor = System.Drawing.Color.White;
            this.buttonProsesdanFungsi.Location = new System.Drawing.Point(0, 0);
            this.buttonProsesdanFungsi.Name = "buttonProsesdanFungsi";
            this.buttonProsesdanFungsi.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.buttonProsesdanFungsi.Size = new System.Drawing.Size(200, 60);
            this.buttonProsesdanFungsi.TabIndex = 2;
            this.buttonProsesdanFungsi.Text = "PROSES DAN FUNGSI";
            this.buttonProsesdanFungsi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProsesdanFungsi.UseVisualStyleBackColor = false;
            this.buttonProsesdanFungsi.Click += new System.EventHandler(this.buttonProsesdanFungsi_Click);
            // 
            // buttonMekanismePertemuan1
            // 
            this.buttonMekanismePertemuan1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMekanismePertemuan1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMekanismePertemuan1.FlatAppearance.BorderSize = 0;
            this.buttonMekanismePertemuan1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMekanismePertemuan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMekanismePertemuan1.ForeColor = System.Drawing.Color.White;
            this.buttonMekanismePertemuan1.Location = new System.Drawing.Point(0, 239);
            this.buttonMekanismePertemuan1.Name = "buttonMekanismePertemuan1";
            this.buttonMekanismePertemuan1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonMekanismePertemuan1.Size = new System.Drawing.Size(200, 60);
            this.buttonMekanismePertemuan1.TabIndex = 4;
            this.buttonMekanismePertemuan1.Text = "MEKANISME";
            this.buttonMekanismePertemuan1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMekanismePertemuan1.UseVisualStyleBackColor = true;
            this.buttonMekanismePertemuan1.Click += new System.EventHandler(this.buttonMekanismePertemuan1_Click);
            // 
            // panelSubMenuSubjek
            // 
            this.panelSubMenuSubjek.BackColor = System.Drawing.Color.Khaki;
            this.panelSubMenuSubjek.Controls.Add(this.buttonManajer);
            this.panelSubMenuSubjek.Controls.Add(this.buttonOrganisasi);
            this.panelSubMenuSubjek.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuSubjek.Location = new System.Drawing.Point(0, 120);
            this.panelSubMenuSubjek.Name = "panelSubMenuSubjek";
            this.panelSubMenuSubjek.Size = new System.Drawing.Size(200, 119);
            this.panelSubMenuSubjek.TabIndex = 5;
            this.panelSubMenuSubjek.Visible = false;
            // 
            // buttonManajer
            // 
            this.buttonManajer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonManajer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonManajer.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonManajer.FlatAppearance.BorderSize = 0;
            this.buttonManajer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManajer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManajer.ForeColor = System.Drawing.Color.White;
            this.buttonManajer.Location = new System.Drawing.Point(0, 60);
            this.buttonManajer.Name = "buttonManajer";
            this.buttonManajer.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.buttonManajer.Size = new System.Drawing.Size(200, 60);
            this.buttonManajer.TabIndex = 3;
            this.buttonManajer.Text = "MANAJER";
            this.buttonManajer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManajer.UseVisualStyleBackColor = false;
            this.buttonManajer.Click += new System.EventHandler(this.buttonManajer_Click);
            // 
            // buttonOrganisasi
            // 
            this.buttonOrganisasi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonOrganisasi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrganisasi.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOrganisasi.FlatAppearance.BorderSize = 0;
            this.buttonOrganisasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrganisasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrganisasi.ForeColor = System.Drawing.Color.White;
            this.buttonOrganisasi.Location = new System.Drawing.Point(0, 0);
            this.buttonOrganisasi.Name = "buttonOrganisasi";
            this.buttonOrganisasi.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.buttonOrganisasi.Size = new System.Drawing.Size(200, 60);
            this.buttonOrganisasi.TabIndex = 2;
            this.buttonOrganisasi.Text = "ORGANISASI";
            this.buttonOrganisasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrganisasi.UseVisualStyleBackColor = false;
            this.buttonOrganisasi.Click += new System.EventHandler(this.buttonOrganisasi_Click);
            // 
            // buttonSubjekPertemuan1
            // 
            this.buttonSubjekPertemuan1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubjekPertemuan1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSubjekPertemuan1.FlatAppearance.BorderSize = 0;
            this.buttonSubjekPertemuan1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubjekPertemuan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubjekPertemuan1.ForeColor = System.Drawing.Color.White;
            this.buttonSubjekPertemuan1.Location = new System.Drawing.Point(0, 60);
            this.buttonSubjekPertemuan1.Name = "buttonSubjekPertemuan1";
            this.buttonSubjekPertemuan1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonSubjekPertemuan1.Size = new System.Drawing.Size(200, 60);
            this.buttonSubjekPertemuan1.TabIndex = 3;
            this.buttonSubjekPertemuan1.Text = "SUBJEK";
            this.buttonSubjekPertemuan1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubjekPertemuan1.UseVisualStyleBackColor = true;
            this.buttonSubjekPertemuan1.Click += new System.EventHandler(this.buttonSubjekPertemuan1_Click);
            // 
            // buttonDefinsiPertemuan1
            // 
            this.buttonDefinsiPertemuan1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDefinsiPertemuan1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDefinsiPertemuan1.FlatAppearance.BorderSize = 0;
            this.buttonDefinsiPertemuan1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDefinsiPertemuan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDefinsiPertemuan1.ForeColor = System.Drawing.Color.White;
            this.buttonDefinsiPertemuan1.Location = new System.Drawing.Point(0, 0);
            this.buttonDefinsiPertemuan1.Name = "buttonDefinsiPertemuan1";
            this.buttonDefinsiPertemuan1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonDefinsiPertemuan1.Size = new System.Drawing.Size(200, 60);
            this.buttonDefinsiPertemuan1.TabIndex = 2;
            this.buttonDefinsiPertemuan1.Text = "DEFINISI";
            this.buttonDefinsiPertemuan1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDefinsiPertemuan1.UseVisualStyleBackColor = true;
            this.buttonDefinsiPertemuan1.Click += new System.EventHandler(this.buttonDefinsiPertemuan1_Click);
            // 
            // buttonPertemuan1
            // 
            this.buttonPertemuan1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPertemuan1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPertemuan1.FlatAppearance.BorderSize = 0;
            this.buttonPertemuan1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPertemuan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPertemuan1.ForeColor = System.Drawing.Color.White;
            this.buttonPertemuan1.Location = new System.Drawing.Point(0, 60);
            this.buttonPertemuan1.Name = "buttonPertemuan1";
            this.buttonPertemuan1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonPertemuan1.Size = new System.Drawing.Size(200, 60);
            this.buttonPertemuan1.TabIndex = 1;
            this.buttonPertemuan1.Text = "PERTEMUAN 1";
            this.buttonPertemuan1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPertemuan1.UseVisualStyleBackColor = true;
            this.buttonPertemuan1.Click += new System.EventHandler(this.buttonPertemuan1_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonHome.Size = new System.Drawing.Size(200, 60);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "HOME";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // userControlHome
            // 
            this.userControlHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlHome.Location = new System.Drawing.Point(199, 24);
            this.userControlHome.Name = "userControlHome";
            this.userControlHome.Size = new System.Drawing.Size(1158, 757);
            this.userControlHome.TabIndex = 2;
            // 
            // userControlPertemuan1
            // 
            this.userControlPertemuan1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlPertemuan1.AutoScroll = true;
            this.userControlPertemuan1.BackColor = System.Drawing.Color.White;
            this.userControlPertemuan1.Location = new System.Drawing.Point(199, 24);
            this.userControlPertemuan1.Name = "userControlPertemuan1";
            this.userControlPertemuan1.Size = new System.Drawing.Size(1158, 757);
            this.userControlPertemuan1.TabIndex = 3;
            // 
            // userControl21
            // 
            this.userControl21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl21.BackColor = System.Drawing.Color.White;
            this.userControl21.Location = new System.Drawing.Point(199, 24);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(1158, 757);
            this.userControl21.TabIndex = 4;
            this.userControl21.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1357, 781);
            this.Controls.Add(this.panelMainSideMenu);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.userControlHome);
            this.Controls.Add(this.userControlPertemuan1);
            this.Controls.Add(this.userControl21);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Rangkuman Pengantar Manajemen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMainSideMenu.ResumeLayout(false);
            this.panelMainSideMenu.PerformLayout();
            this.panelSubMenuPertemuan1.ResumeLayout(false);
            this.panelSubMenuPertemuan1.PerformLayout();
            this.panelSubMenuMekanisme.ResumeLayout(false);
            this.panelSubMenuSubjek.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panelMainSideMenu;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonPertemuan1;
        private System.Windows.Forms.Panel panelSubMenuPertemuan1;
        private System.Windows.Forms.Button buttonMekanismePertemuan1;
        private System.Windows.Forms.Button buttonSubjekPertemuan1;
        private System.Windows.Forms.Button buttonDefinsiPertemuan1;
        private System.Windows.Forms.Button buttonPertemuan2;
        private AboutBox1 aboutBox1 = new AboutBox1();
        private System.Windows.Forms.Panel panelSubMenuSubjek;
        private System.Windows.Forms.Button buttonManajer;
        private System.Windows.Forms.Button buttonOrganisasi;
        private System.Windows.Forms.Panel panelSubMenuMekanisme;
        private System.Windows.Forms.Button buttonProsesdanFungsi;
        public userControlHome userControlHome;
        public UserControlPertemuan1 userControlPertemuan1;
        public UserControl2 userControl21;
    }
}

