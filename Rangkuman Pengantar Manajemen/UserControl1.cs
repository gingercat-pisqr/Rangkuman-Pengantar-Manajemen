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
    public partial class UserControlPertemuan1 : UserControl
    {
        
        public UserControlPertemuan1()
        {
            InitializeComponent();
            customDesign();
            
        }

        //
        // Panel 1
        //
        private void buttonDefinisi_Click(object sender, EventArgs e)
        {
            if (textBoxDefinisiManajemen.Visible == false)
            {
                textBoxDefinisiManajemen.Visible = true;

            }
            else
            {
                textBoxDefinisiManajemen.Visible = false;
            }

        }

        //
        // Panel 2
        //
        private void buttonSubjek_Click(object sender, EventArgs e)
        {
            showNHideButtonOrganisasiNManajer();
        }

        private void buttonPanel2Back_Click(object sender, EventArgs e)
        {
            if(panelOrganisasi.Visible == true)
            {
                if (textBoxDefinisiOrganisasi.Visible == true)
                {
                    textBoxDefinisiOrganisasi.Visible = false;
                    showButtonsOrganisasi();

                }
                else if (panelKarakteristikOrganisasi.Visible == true)
                {
                    panelKarakteristikOrganisasi.Visible = false;
                    showButtonsOrganisasi();
                }
                else if (panelMekanismeOrganisasi.Visible == true)
                {
                    if(textBoxResourceInputs.Visible == true)
                    {
                        textBoxResourceInputs.Visible = false;
                        showButtonsMekanismeOrganisasi();
                    }
                    else if (textBoxTransformationProcess.Visible == true)
                    {
                        textBoxTransformationProcess.Visible = false;
                        showButtonsMekanismeOrganisasi();
                    }
                    else if (textBoxProductOutputs.Visible == true)
                    {
                        textBoxProductOutputs.Visible = false;
                        showButtonsMekanismeOrganisasi();
                    }
                    else if (textBoxResourceInputs.Visible == false &&
                             textBoxTransformationProcess.Visible == false &&
                             textBoxProductOutputs.Visible == false)
                    {
                        panelMekanismeOrganisasi.Visible = false;
                        showButtonsOrganisasi();
                    }
                }
                else if (textBoxDefinisiOrganisasi.Visible == false &&
                     panelKarakteristikOrganisasi.Visible == false &&
                     panelMekanismeOrganisasi.Visible == false)
                {
                    panelOrganisasi.Visible = false;
                    buttonPanel2Back.Visible = false;

                    buttonOrganisasi.Visible = true;
                    buttonManajer.Visible = true;
                    buttonSubjek.Visible = true;
                }
            }
            else if (panelManajer.Visible == true)
            {
                if (textBoxDefinisiManajer.Visible == true)
                {
                    textBoxDefinisiManajer.Visible = false;
                    showButtonsManajer();
                }
                else if (panelLevelTingkatan.Visible == true)
                {
                    if (textBoxTopManagers.Visible == true)
                    {
                        textBoxTopManagers.Visible = false;

                        buttonTopManagers.Visible = true;
                        buttonMiddleManagers.Visible = true;
                        buttonFirstLineManagers.Visible = true;
                    }
                    else if (textBoxMiddleManagers.Visible == true)
                    {
                        textBoxMiddleManagers.Visible = false;


                        buttonTopManagers.Visible = true;
                        buttonMiddleManagers.Visible = true;
                        buttonFirstLineManagers.Visible =true;
                    }
                    else if (textBoxFirstLineManagers.Visible == true)
                    {
                        textBoxFirstLineManagers.Visible = false;

                        buttonTopManagers.Visible = true;
                        buttonMiddleManagers.Visible = true;
                        buttonFirstLineManagers.Visible = true;
                    }
                    else
                    {
                        panelLevelTingkatan.Visible = false;
                        showButtonsManajer();
                    }
                    
                }
                else if (textBoxMekanismeManajer.Visible == true)
                {
                    textBoxMekanismeManajer.Visible =false;
                    showButtonsManajer();
                }
                else if (textBoxDefinisiManajer.Visible == false &&
                         panelLevelTingkatan.Visible == false &&
                         textBoxMekanismeManajer.Visible == false)
                {
                    panelManajer.Visible = false;
                    buttonOrganisasi.Visible = true;
                    buttonManajer.Visible = true;

                    buttonPanel2Back.Visible=false;
                    buttonSubjek.Visible = true;
                }
            }
            
        }

            private void buttonOrganisasi_Click(object sender, EventArgs e)
            {
                panelOrganisasi.Visible = true;

                buttonPanel2Back.Visible = true;
                buttonPanel2Back.BringToFront();

                buttonOrganisasi.Visible = false;
                buttonManajer.Visible = false;

                buttonSubjek.Visible = false;
                buttonSubjek.BringToFront();
            }

            private void buttonManajer_Click(object sender, EventArgs e)
            {
                buttonOrganisasi.Visible=false;
                buttonManajer.Visible=false;
                buttonSubjek.Visible=false;

                panelManajer.Visible = true;

                buttonPanel2Back.Visible=true;
            }

        private void buttonDefinisiOrganisasi_Click(object sender, EventArgs e)
        {
                textBoxDefinisiOrganisasi.Visible = true;
                textBoxDefinisiOrganisasi.BringToFront();

            hideButtonsOrganisasi();
        }



        public void showNHideButtonOrganisasiNManajer()
        {
            if (buttonOrganisasi.Visible == false && buttonManajer.Visible == false)
            {
                buttonOrganisasi.Visible = true;
                buttonManajer.Visible = true;
            }
        }

        private void buttonKarakteristikOrganisasi_Click(object sender, EventArgs e)
        {
            buttonDefinisiOrganisasi.Visible = false;
            buttonMekanismeOrganisasi.Visible = false;
            buttonKarakteristikOrganisasi.Visible = false;

            panelKarakteristikOrganisasi.Visible = true;
            panelKarakteristikOrganisasi.BringToFront();


        }

        //
        // Panel 3
        //
            private void buttonMekanisme_Click(object sender, EventArgs e)
            {
                buttonProsesdanFungsi.Visible = true;
                
            }

            private void buttonProses_Click(object sender, EventArgs e)
            {
                buttonProsesdanFungsi.Visible = false;
                buttonMekanisme.Visible = false;

                buttonPanel3Back.Visible = true;

                panelProsesManajemen.Visible = true;
            }

            private void buttonFungsi_Click(object sender, EventArgs e)
            {

            }


        //
        // Misc
        //
        private void customDesign()
        {

            //  Panel 1
            textBoxDefinisiManajemen.Visible = false;
            

            //  Panel 2
            buttonOrganisasi.Visible = false;
                panelOrganisasi.Visible = false;
                textBoxDefinisiOrganisasi.Visible = false;

                panelKarakteristikOrganisasi.Visible = false;

                panelMekanismeOrganisasi.Visible = false;
                textBoxResourceInputs.Visible = false;
                textBoxTransformationProcess.Visible = false;
                textBoxProductOutputs.Visible = false;

            buttonManajer.Visible = false;
                panelManajer.Visible = false;
                    textBoxDefinisiManajer.Visible = false;
                    panelLevelTingkatan.Visible = false;
                    textBoxTopManagers.Visible = false;
                    textBoxMiddleManagers.Visible = false;
                    textBoxFirstLineManagers.Visible = false;
                    textBoxMekanismeManajer.Visible=false;


            buttonPanel2Back.Visible = false;

            
            

            //  Panel 3
            buttonProsesdanFungsi.Visible = false;
            buttonPanel3Back.Visible = false;
            panelProsesManajemen.Visible=false;

        }

        public void hideButtonsOrganisasi()
        {
            buttonDefinisiOrganisasi.Visible = false;
            buttonKarakteristikOrganisasi.Visible = false;
            buttonMekanismeOrganisasi.Visible = false;
        }

        public void showButtonsOrganisasi()
        {
            buttonDefinisiOrganisasi.Visible = true;
            buttonKarakteristikOrganisasi.Visible = true;
            buttonMekanismeOrganisasi.Visible = true;
        }

        public void showButtonsSubjek()
        {
            buttonOrganisasi.Visible = true;
            buttonManajer.Visible = true;
        }

        public void hideButtonsSubjek()
        {
            buttonOrganisasi.Visible = false;
            buttonManajer.Visible = false;
        }



        private void buttonMekanismeOrganisasi_Click(object sender, EventArgs e)
        {
            buttonDefinisiOrganisasi.Visible = false;
            buttonKarakteristikOrganisasi.Visible=false;
            buttonMekanismeOrganisasi.Visible = false;

            panelMekanismeOrganisasi.Visible = true;
            panelMekanismeOrganisasi.BringToFront();
        }

        private void buttonResourceInputs_Click(object sender, EventArgs e)
        {
            hideButtonsMekanismeOrganisasi();
            textBoxResourceInputs.Visible = true;
            textBoxResourceInputs.BringToFront();
        }

        private void hideButtonsMekanismeOrganisasi()
        {
            buttonResourceInputs.Visible = false;
            buttonTransformationProcess.Visible = false;
            buttonProductOutputs.Visible = false;
        }

        private void showButtonsMekanismeOrganisasi()
        {
            buttonResourceInputs.Visible = true;
            buttonTransformationProcess.Visible = true;
            buttonProductOutputs.Visible = true;
        }

        private void buttonTransformationProcess_Click(object sender, EventArgs e)
        {
            hideButtonsMekanismeOrganisasi();
            textBoxTransformationProcess.Visible = true;
            textBoxTransformationProcess.BringToFront();
        }

        private void buttonProductOutputs_Click(object sender, EventArgs e)
        {
            hideButtonsMekanismeOrganisasi();
            textBoxProductOutputs.Visible = true;
            textBoxProductOutputs.BringToFront();
        }

        private void buttonDefinisiManajer_Click(object sender, EventArgs e)
        {
            textBoxDefinisiManajer.Visible = true;
            hideButtonsManajer();
        }

        private void hideButtonsManajer()
        {
            buttonDefinisiManajer.Visible = false;
            buttonTingkatManajerial.Visible = false;
            buttonMekanismeManajer.Visible = false;
        }

        private void showButtonsManajer()
        {
            buttonDefinisiManajer.Visible = true;
            buttonTingkatManajerial.Visible = true;
            buttonMekanismeManajer.Visible = true;
        }

        private void buttonTingkatManajerial_Click(object sender, EventArgs e)
        {
            hideButtonsManajer();
            panelLevelTingkatan.Visible = true;
        }

        private void buttonTopManagers_Click(object sender, EventArgs e)
        {
            textBoxTopManagers.Visible = true;


            buttonTopManagers.Visible = false;
            buttonMiddleManagers.Visible = false;
            buttonFirstLineManagers.Visible = false;
        }

        private void buttonMiddleManagers_Click(object sender, EventArgs e)
        {
            textBoxMiddleManagers.Visible = true;

            buttonTopManagers.Visible = false;
            buttonMiddleManagers.Visible = false;
            buttonFirstLineManagers.Visible = false;
        }

        private void buttonFirstLineManagers_Click(object sender, EventArgs e)
        {
            textBoxFirstLineManagers.Visible = true;


            buttonTopManagers.Visible = false;
            buttonMiddleManagers.Visible = false;
            buttonFirstLineManagers.Visible = false;
        }

        private void buttonMekanismeManajer_Click(object sender, EventArgs e)
        {
            hideButtonsManajer();

            textBoxMekanismeManajer.Visible = true;
        }

        private void buttonPanel3Back_Click(object sender, EventArgs e)
        {
            panelProsesManajemen.Visible = false;

            buttonProsesdanFungsi.Visible = true;
            

            buttonPanel3Back.Visible = false;
            buttonMekanisme.Visible = true;
        }

    }
}
