using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiktorDanielewskiLab1PracDom
{
    public partial class FormMury : Form
    {

        private int poziomMurow = 0;

        public FormMury()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Operacja wykonywana przed zamknięciem okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMury_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ukrycie okna
            this.Hide();
            //odrzucenie zdarzenia - instancja okna nie zostanie usunięta
            e.Cancel = true;
        }

        /// <summary>
        /// Tik timera okna 'formMury', odbywa się co 0,1s.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerOknaMury_Tick(object sender, EventArgs e)
        {
            //warunek sprawdzający, czy przycisk nie jest dostępny oraz, czy poziom murów nie jest równy 3
            if ((buttonUlepsz.Enabled != true)&&(poziomMurow != 3)) {

                //dopóki 'poziomMurow' nie osiągnie wartości 3, w każdym tiku sprawdzamy, czy wymagana wartość surowca 
                //jest już osiągnięta (wartość i rodzaj surowca jest zależna od poziomu), jeśli tak to zmieniamy wartość Enabled
                //na true
                //spowoduje to, że dpokóki wartość ta z powrotem nie zostanie zamieniona na false (,co się stanie po kliknięciu przycisku 'Ulepsz',)
                //-wcześniejszy warunek nie zostanie spełniony, a więc nie przejdziemy do swich'a

                switch (poziomMurow)
                {
                    case 0:
                        if (MainForm.liczbaDrewna >= 1000)
                        {
                            buttonUlepsz.Enabled = true;
                        }
                        break;
                    case 1:
                        if (MainForm.liczbaKamienia >= 2000)
                        {
                            buttonUlepsz.Enabled = true;
                        }
                        break;
                    case 2:
                        if (MainForm.liczbaKamienia >= 4000)
                        {
                            buttonUlepsz.Enabled = true;
                        }
                        break;
                }
            }
            
        }

        private void buttonUlepsz_Click(object sender, EventArgs e)
        {
            //gdy przycisk stanie się aktwny, w zależności od wartości zmiennej 'poziomMurow' zostaną wykonane odpowiednie instrukcje
            switch (poziomMurow)
            {
                case 0:
                    //zmniejszenie liczby surowca
                    MainForm.liczbaDrewna -= 1000;
                    //zwiększenie poziomu
                    poziomMurow++;
                    //zmiana obrazka
                    pictureBoxMur.Image = Properties.Resources.StoneWall;
                    //zmiana etykiet
                    labelPoziomMurow.Text = "LVL: 2";
                    labelKosztMurow.Text = "Koszt:\n2000 kamienia";
                    break;
                case 1:
                    MainForm.liczbaKamienia -= 2000;
                    poziomMurow++;
                    pictureBoxMur.Image = Properties.Resources.FortifiedWall;
                    labelPoziomMurow.Text = "LVL: 3";
                    labelKosztMurow.Text = "Koszt:\n4000 kamienia";
                    break;
                case 2:
                    MainForm.liczbaKamienia -= 4000;
                    poziomMurow++;
                    labelKosztMurow.Text = "Maksymalny poziom!";
                    break;
            }
            //ustawienie przycisku na nieaktywny
            buttonUlepsz.Enabled = false;
        }
    }
}
