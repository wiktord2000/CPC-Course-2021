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

    public partial class FormPopulacja : Form
    {
        /// <summary>
        /// Zmienna przechowująca liczbę złota, jaką trzeba zapewnić na jedną jednostkę populacji 
        /// </summary>
        private int kosztLiczbaZlota = 100;
        /// <summary>
        /// Zmienna przechowująca liczbę drewna, jaką trzeba zapewnić na jedną jednostkę populacji 
        /// </summary>
        private int kosztLiczbaDrewna = 75;
        /// <summary>
        /// Zmienna przechowująca liczbę kamienia, jaką trzeba zapewnić na jedną jednostkę populacji 
        /// </summary>
        private int kosztLiczbaKamienia = 50;


        public FormPopulacja()
        {
            InitializeComponent();
            //Przypisanie wartości do labelPolaczoneKoszty.Text
            labelPolaczoneKoszty.Text = kosztLiczbaZlota.ToString() + " złota\n" + kosztLiczbaDrewna.ToString() + " drewna\n" + kosztLiczbaKamienia.ToString() + " kamienia";
        }

        /// <summary>
        /// Powoduje zwiększenie limitu populacji, jeśli posiadamy wystarczającą liczbę zasobów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonKup_Click(object sender, EventArgs e)
        {
            //jeśli nic nie zostanie wpisane - nic nie robimy
            if (textBoxLiczbaJednostek.TextLength != 0) {

                //zamieniamy Stringa na Int32
                Int32 liczbaJednostek = Int32.Parse(textBoxLiczbaJednostek.Text);
                //obliczamy całkowitą wartość zakupu
                int liczbaZlota = kosztLiczbaZlota * liczbaJednostek;
                int liczbaDrewna = kosztLiczbaDrewna * liczbaJednostek;
                int liczbaKamienia = kosztLiczbaKamienia * liczbaJednostek;

                //jeśli posiadamy wymaganą liczbę zasobów to pomniejszamy posiadane zasoby kosztem powiększenia limitu populacji
                if ((MainForm.liczbaZlota >= liczbaZlota) && (MainForm.liczbaDrewna >= liczbaDrewna) && (MainForm.liczbaKamienia >= liczbaKamienia))
                {
                    //aktualizujemy wartości zmiennych statycznych okna głównego
                    MainForm.liczbaZlota -= liczbaZlota;
                    MainForm.liczbaDrewna -= liczbaDrewna;
                    MainForm.liczbaKamienia -= liczbaKamienia;
                    MainForm.limitPopulacji += liczbaJednostek;

                }
                else
                {
                    //jeślni nie posiadamy wystarczająco zasobów - wyświetlamy o tym komunikat
                    MessageBox.Show("Masz za mało zasobów!", "Niepowodzenie", MessageBoxButtons.OK);
                }
            }
        }
    }
}
