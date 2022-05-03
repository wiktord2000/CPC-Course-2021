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
    
    public partial class FormStatystyki : Form
    {
        /// <summary>
        /// Zmienna zawierająca liczbę produkowanego złota na minute
        /// </summary>
        private int liczbaZlotaNaMinute;
        /// <summary>
        /// Zmienna zawierająca liczbę produkowanego drewna na minute
        /// </summary>
        private int liczbaDrewnaNaMinute;
        /// <summary>
        /// Zmienna zawierająca liczbę produkowanego kamienia na minute
        /// </summary>
        private int liczbaKamieniaNaMinute;
        /// <summary>
        /// Zmienna zawierająca liczbę produkowanego jedzenia na minute
        /// </summary>
        private int liczbaJedzeniaNaMinute;


        public FormStatystyki()
        {
            InitializeComponent();
        }

        /// <summary>
        /// W każdym tiku timera aktualizujemy zmienne do statystyk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerOknaStatystyki_Tick(object sender, EventArgs e)
        {   
            //co 0,1 sekundy, obliczamy nowe wartości dla poniższych zmiennych
            liczbaDrewnaNaMinute = MainForm.przyrostDrewna * 60;
            liczbaKamieniaNaMinute = MainForm.przyrostKamienia * 60;
            liczbaJedzeniaNaMinute = MainForm.przyrostJedzenia * 60;
            liczbaZlotaNaMinute = MainForm.przyrostZlota * 60;
            //umieszamy dane w etykiecie
            labelStatystyki.Text = "Produktywność:\n\n" + liczbaDrewnaNaMinute.ToString() + " drewna/min\n" + liczbaJedzeniaNaMinute.ToString() + " jedzenia/min\n" + liczbaZlotaNaMinute.ToString() + " złota/min\n" + liczbaKamieniaNaMinute.ToString() + " kamienia/min";


        }

        /// <summary>
        /// Operacje wykonywane podczas zamykania okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormStatystyki_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ukrycie okna
            this.Hide();
            //odrzucenie zdarzenia - instancja okna nie zostanie usunięta
            e.Cancel = true;
        }
    }
}
