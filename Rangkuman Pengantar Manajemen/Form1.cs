using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rangkuman_Pengantar_Manajemen
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
            customDesign();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {

            userControlPertemuan1.Visible = false;
            userControl21.Visible = false;
            userControlHome.Visible = true;
            
        }

        private void buttonPertemuan1_Click(object sender, EventArgs e)
        {
            userControlHome.Visible=false;
            showSubMenu(panelSubMenuPertemuan1);
            showControl(userControlPertemuan1);
        }

        private void buttonPertemuan2_Click(object sender, EventArgs e)
        {
            userControl21.Visible = true;
            userControlHome.Visible = false;
            userControlPertemuan1.Visible=false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutBox1.ShowDialog();
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            } else if (subMenu.Visible == true && userControlPertemuan1.Visible == true)
            {
                subMenu.Visible = false;
            }
        }

        private void hideSubMenu()
        {
            if (panelSubMenuPertemuan1.Visible == true)
            {
                panelSubMenuPertemuan1.Visible = false;
            }
            if (panelSubMenuSubjek.Visible == true)
            {
                panelSubMenuSubjek.Visible = false;
            }
        }

        private void showControl(Control control)
        {
            if (control.Visible == false)
            {
                control.Visible = true;
            }
        }     

        private void buttonDefinsiPertemuan1_Click(object sender, EventArgs e)
        {
            if (userControlPertemuan1.Visible == true)
            {
                if (userControlPertemuan1.textBoxDefinisiManajemen.Visible == false)
                {
                    userControlPertemuan1.textBoxDefinisiManajemen.Visible = true;
                }
                else
                {
                    userControlPertemuan1.textBoxDefinisiManajemen.Visible = false;
                }
            }      
        }

        public void buttonHomePertemuan1()
        {
            userControlHome.Visible = false;
            userControlPertemuan1.Visible=true;
            userControl21.Visible=false;
        }

        public void buttonHomePertemuan2()
        {
            userControlHome.Visible = false;
            userControlPertemuan1.Visible = false;
            userControl21.Visible = true;
        }

        private void buttonSubjekPertemuan1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuSubjek);
            userControlPertemuan1.showNHideButtonOrganisasiNManajer();
            userControl21.Visible = false;
        }

        private void buttonManajer_Click(object sender, EventArgs e)
        {
            if (userControlPertemuan1.panelOrganisasi.Visible == true)
            {
                userControlPertemuan1.panelOrganisasi.Visible = false;
            }
            userControlPertemuan1.buttonSubjek.Visible = false;
            userControlPertemuan1.buttonPanel2Back.Visible = true;
            userControlPertemuan1.buttonOrganisasi.Visible = false;
            userControlPertemuan1.buttonManajer.Visible = false;

            userControlPertemuan1.panelManajer.Visible = true;
        }

        private void buttonOrganisasi_Click(object sender, EventArgs e)
        {
            if (userControlPertemuan1.panelOrganisasi.Visible == false)
            {
                
                userControlPertemuan1.hideButtonsSubjek();
        
                userControlPertemuan1.panelOrganisasi.Visible = true;

                userControlPertemuan1.buttonPanel2Back.Visible = true;
                userControlPertemuan1.buttonPanel2Back.BringToFront();

                userControlPertemuan1.panelManajer.Visible = false;

                userControlPertemuan1.panelLevelTingkatan.Visible = false;

                userControlPertemuan1.panelMekanismeOrganisasi.Visible=false;
                userControlPertemuan1.panelTopManagers.Visible = false;

                userControlPertemuan1.buttonSubjek.Visible = false;
            }

            if (userControlPertemuan1.panelManajer.Visible == true)
            {
                userControlPertemuan1.panelManajer.Visible = false;
            }
        }

        private void customDesign()
        {
            panelSubMenuPertemuan1.Visible = false;
            panelSubMenuSubjek.Visible = false;
            panelSubMenuMekanisme.Visible = false;
            userControlPertemuan1.Visible = false;
        }

        private void buttonMekanismePertemuan1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuMekanisme);
        }

        private void buttonHomePertemuan1_Click(object sender, EventArgs e)
        {
            userControlHome.Visible=false;
            userControlPertemuan1.Visible=true;
        }

        private void buttonProsesdanFungsi_Click(object sender, EventArgs e)
        {
            
            if (userControlPertemuan1.buttonProsesdanFungsi.Visible == false &&
                userControlPertemuan1.buttonProsesdanFungsi.Visible == false &&
                userControlPertemuan1.panelProsesManajemen.Visible == false)
            {
                userControlPertemuan1.buttonProsesdanFungsi.Visible=true;
            }
            else if (userControlPertemuan1.buttonProsesdanFungsi.Visible == true)
            {
                userControlPertemuan1.buttonProsesdanFungsi.Visible = false;
                userControlPertemuan1.panelProsesManajemen.Visible = true;

                userControlPertemuan1.buttonMekanisme.Visible=false;
                userControlPertemuan1.buttonPanel3Back.Visible=true;
            }
        }
    }
}
