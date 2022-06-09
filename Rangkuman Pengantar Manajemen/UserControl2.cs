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
    public partial class UserControl2 : UserControl
    {

        private Panel currentPosition;
        public UserControl2()
        {
            InitializeComponent();
            disableAll();
        }

        private void buttonManajemenAwall_Click(object sender, EventArgs e)
        {
            if (textBoxManajemenAwal.Visible == false)
            {
                textBoxManajemenAwal.Visible = true;
                BringToFront();
                panelDefinisiPendekatanKlasik.Visible = false;
                panelTeoriPendekatanKlasik.Visible=false;
                textBoxPendekatanKuantitatif.Visible = false;
                textBoxPendekatanKontemporer.Visible = false;
            } else
            {
                textBoxManajemenAwal.Visible = false;
            }
        }

        private void buttonPendekatanKlasik_Click(object sender, EventArgs e)
        {
            if (panelDefinisiPendekatanKlasik.Visible == false &&
                panelTeoriManajemenIlmiah.Visible == false)
            {
                panelDefinisiPendekatanKlasik.Visible = true;
                panelTeoriPendekatanKlasik.Visible = true;
                textBoxManajemenAwal.Visible = false;
                textBoxPendekatanKuantitatif.Visible = false;
                textBoxPendekatanKontemporer.Visible = false;
                textBoxPendekatanPerilaku.Visible = false;

            }
            else if (panelTeoriPendekatanKlasik.Visible == true &&
                     panelTeoriPendekatanKlasik.Visible == true)
            {
                panelTeoriPendekatanKlasik.Visible = false;
                panelDefinisiPendekatanKlasik.Visible = false;

            }
            
        }

        private void buttonDefinisiPendekatanKlasik_Click(object sender, EventArgs e)
        {
            textBoxDefinisiPendekatanKlasik.Visible = true;
        }

        private void disableAll()
        {
            panelDefinisiPendekatanKlasik.Visible = false;
            panelTeoriManajemenIlmiah.Visible = false;
        }

        private void buttonDefinisiTeoriManajemenIlmiah_Click(object sender, EventArgs e)
        {
            textBoxDefinisiTeoriManajemenIlmiah.Visible=true;

            buttonDefinisiTeoriManajemenIlmiah.Visible = false;
            buttonPrinsip.Visible = false;
        }

        private void buttonTeoriManajemenIlmiah_Click(object sender, EventArgs e)
        {
            panelTeoriManajemenIlmiah.Visible = true;

            buttonPanelTeoriPendekatanKlasikBack.Visible = true;

            currentPosition = panelTeoriManajemenIlmiah;

            buttonTeori.Visible = false;
            buttonDefinisiTeoriManajemenIlmiah.Visible = true;
            buttonPrinsip.Visible = true;

            buttonTeoriManajemenIlmiah.Visible = false;
            buttonTeoriadministrasiUmum.Visible = false;
            
        }

        private void buttonTeori_Click(object sender, EventArgs e)
        {
            buttonTeoriManajemenIlmiah.Visible = true;
            buttonTeoriadministrasiUmum.Visible = true;
            currentPosition = panelTeoriPendekatanKlasik;
        }














        //*********************************************************************************
        //                                      BACK
        //*********************************************************************************
        private void buttonPanelTeoriPendekatanKlasikBack_Click(object sender, EventArgs e)
        {
            if (currentPosition == panelTeoriManajemenIlmiah)
            {
                if (textBoxDefinisiTeoriManajemenIlmiah.Visible == true &&
                    buttonDefinisiTeoriManajemenIlmiah.Visible == false)
                {
                    buttonDefinisiTeoriManajemenIlmiah.Visible = true;
                    buttonPrinsip.Visible=true;
                    textBoxDefinisiTeoriManajemenIlmiah.Visible = false;
                } else if (panelPrinsipTeoriManajemenIlmiah.Visible == true)
                {
                    if (textBoxTaylor.Visible == true)
                    {
                        textBoxTaylor.Visible = false;
                        buttonTaylor.Visible=true;
                        buttonFrankdanGilberth.Visible=true;

                    } 
                    else if (panelFrankdanGilberth.Visible == true)
                    {
                        if (buttonIdentifikasiGerakanDasar.Visible == true)
                        {
                            panelFrankdanGilberth.Visible = false;
                            buttonTaylor.Visible = true;
                            buttonFrankdanGilberth.Visible = true;
                        }
                        else if (buttonIdentifikasiGerakanDasar.Visible == false)
                        {
                            if (buttonEfektif.Visible == true &&
                                buttonTidakEfektif.Visible == true)
                            {
                                buttonEfektif.Visible = false;
                                buttonTidakEfektif.Visible = false;
                                buttonIdentifikasiGerakanDasar.Visible = true;
                            }
                            else
                            {
                                if (textBoxEfektif.Visible == true)
                                {
                                    textBoxEfektif.Visible = false;
                                    buttonEfektif.Visible = true;
                                    buttonTidakEfektif.Visible = true;
                                }
                                else if (textBoxTidakEfektif.Visible == true)
                                {
                                    textBoxTidakEfektif.Visible = false;
                                    buttonEfektif.Visible = true;
                                    buttonTidakEfektif.Visible = true;
                                }
                            }
                            
                        }

                    }
                    else
                    {
                        buttonTaylor.Visible = true;
                        buttonFrankdanGilberth.Visible = true;

                        panelPrinsipTeoriManajemenIlmiah.Visible=false;

                        buttonDefinisiTeoriManajemenIlmiah.Visible = true;
                        buttonPrinsip.Visible = true;
                    }
                } else
                {
                    panelTeoriManajemenIlmiah.Visible = false;
                    buttonTeoriManajemenIlmiah.Visible = true;
                    buttonTeoriadministrasiUmum.Visible = true;

                    buttonPanelTeoriPendekatanKlasikBack.Visible = false;
                    buttonTeori.Visible = true;
                }
            } 
            else if (currentPosition == panelTeoriAdministrasiUmum)
            {
                if (textBoxDefinisiTeoriAdministrasiUmum.Visible == true)
                {
                    buttonDefinisiTeoriAdministrasiUmum.Visible = true;
                    buttonMaxWeber.Visible = true;
                    buttonHenryFayol.Visible = true;

                    textBoxDefinisiTeoriAdministrasiUmum.Visible=false;
                } 
                else if (textBoxHenryFayol.Visible == true)
                {
                    textBoxHenryFayol.Visible = false;
                    buttonMaxWeber.Visible = true;
                    buttonHenryFayol.Visible = true;
                    buttonDefinisiTeoriAdministrasiUmum.Visible = true;
                }
                else if (textBoxMaxWeber.Visible == true)
                {
                    textBoxMaxWeber.Visible = false;
                    buttonMaxWeber.Visible = true;
                    buttonHenryFayol.Visible = true;
                    buttonDefinisiTeoriAdministrasiUmum.Visible = true;
                }
                else
                {
                    panelTeoriAdministrasiUmum.Visible = false;
                    buttonTeoriadministrasiUmum.Visible = true;
                    buttonTeoriManajemenIlmiah.Visible = true;
                }
            }
        }

        








        private void buttonTaylor_Click(object sender, EventArgs e)
        {
            textBoxTaylor.Visible = true;
            buttonFrankdanGilberth.Visible=false;
            buttonTaylor.Visible=false;
        }

        private void buttonTeoriadministrasiUmum_Click(object sender, EventArgs e)
        {
            currentPosition = panelTeoriAdministrasiUmum;

            buttonTeoriManajemenIlmiah.Visible = false;
            buttonTeoriadministrasiUmum.Visible = false;

            panelTeoriAdministrasiUmum.Visible=true;

            buttonTeori.Visible=false;
            buttonPanelTeoriPendekatanKlasikBack.Visible=true;
        }

        private void buttonPrinsip_Click(object sender, EventArgs e)
        {
            

            buttonPrinsip.Visible=false;
            buttonDefinisiTeoriManajemenIlmiah.Visible=false;

            panelPrinsipTeoriManajemenIlmiah.Visible = true;
        }

        private void buttonFrankdanGilberth_Click(object sender, EventArgs e)
        {
            buttonTaylor.Visible=false;

            panelFrankdanGilberth.Visible = true;
            buttonIdentifikasiGerakanDasar.Visible=true;

            buttonFrankdanGilberth.Visible = false;
        }

        private void buttonIdentifikasiGerakanDasar_Click(object sender, EventArgs e)
        {
            buttonIdentifikasiGerakanDasar.Visible = false;
            buttonEfektif.Visible = true;
            buttonTidakEfektif.Visible = true;
        }

        private void buttonEfektif_Click(object sender, EventArgs e)
        {
            textBoxEfektif.Visible=true;
            buttonEfektif.Visible = false;
            buttonTidakEfektif.Visible = false;
        }

        private void buttonTidakEfektif_Click(object sender, EventArgs e)
        {
            textBoxTidakEfektif.Visible = true;
            buttonEfektif.Visible = false;
            buttonTidakEfektif.Visible = false;
        }

        private void buttonDefinisiTeoriAdministrasiUmum_Click(object sender, EventArgs e)
        {
            textBoxDefinisiTeoriAdministrasiUmum.Visible = true;

            buttonDefinisiTeoriAdministrasiUmum.Visible = false;
            buttonMaxWeber.Visible = false;
            buttonHenryFayol.Visible = false;
        }

        private void buttonHenryFayol_Click(object sender, EventArgs e)
        {
            textBoxHenryFayol.Visible = true;
            buttonMaxWeber.Visible = false;
            buttonHenryFayol.Visible = false;
            buttonDefinisiTeoriAdministrasiUmum.Visible = false;
        }

        private void buttonMaxWeber_Click(object sender, EventArgs e)
        {
            textBoxMaxWeber.Visible = true;
            buttonMaxWeber.Visible = false;
            buttonHenryFayol.Visible = false;
            buttonDefinisiTeoriAdministrasiUmum.Visible=false;
        }

        private void buttonPendekatanPerilaku_Click(object sender, EventArgs e)
        {
            textBoxManajemenAwal.Visible = false;
            panelDefinisiPendekatanKlasik.Visible = false;
            panelTeoriPendekatanKlasik.Visible = false;
            textBoxPendekatanPerilaku.Visible = true;
            textBoxPendekatanKuantitatif.Visible = false;
            textBoxPendekatanKontemporer.Visible = false;
        }

        private void buttonPendekatanKuantitatif_Click(object sender, EventArgs e)
        {
            textBoxManajemenAwal.Visible = false;
            panelDefinisiPendekatanKlasik.Visible = false;
            panelTeoriPendekatanKlasik.Visible = false;
            textBoxPendekatanPerilaku.Visible = false;
            textBoxPendekatanKuantitatif.Visible = true;
            textBoxPendekatanKontemporer.Visible = false;
        }

        private void buttonPendekatanKontemporer_Click(object sender, EventArgs e)
        {
            textBoxManajemenAwal.Visible = false;
            panelDefinisiPendekatanKlasik.Visible = false;
            panelTeoriPendekatanKlasik.Visible = false;
            textBoxPendekatanPerilaku.Visible = false;
            textBoxPendekatanKuantitatif.Visible = false;
            textBoxPendekatanKontemporer.Visible = true;

        }
    }
}
