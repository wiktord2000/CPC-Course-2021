using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiktorDanielewskiLab1PracDom
{
    public partial class FormNagrody : Form
    {
        /// <summary>
        /// Zmienna przechowująca wartość czasu, który musi upłynąc, żeby odebrać nagrodę
        /// </summary>
        private int czasDoNagrody = 60;
        /// <summary>
        /// Wskaźnik na instancję klasy Random
        /// </summary>
        Random random;



        public FormNagrody()
        {
            InitializeComponent();
            //Utworzenie instancji klasy Random
            random = new Random();
        }



        /// <summary>
        /// Klik powoduje odebranie nagrody (otrzymanie komuniaktu i powiększenie liczby złota), jeśli jest to możliwe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOdbierz_Click(object sender, EventArgs e)
        {   
            //losujemy liczbę z zakresu od <1 ; 10>
            int losowyNumer = random.Next(1, 11);

            //wyznaczamy wartość równą: (losowyNumer*liczbaZlota)/10 - reprezentuje ona ułamek obecnie posiadanego złota
            losowyNumer *= MainForm.liczbaZlota;
            losowyNumer /= 10;

            //wyświetlamy okno informacyjne oraz zapisujemy jego rezultat w zmiennej 'result'
            var result = MessageBox.Show("Wygrywasz: " + losowyNumer.ToString() + " złota", "Gratulacje!", MessageBoxButtons.OK);
            if (result == DialogResult.OK) {
                //dodanie wartości 'losowyNumer' do statycznej zmiennej 'liczbaZlota' poprzez metodę 'dodajZloto(...)'
                MainForm.liczbaZlota += losowyNumer;
                //ustawiamy na nowo czas do ponownego odebrania nagrody
                czasDoNagrody = 60;
                //zamiana obrazka z OpenCase na ClosedCase
                pictureBoxNagroda.Image = Properties.Resources.ClosedCase;
                //zablokowanie przycisku
                buttonOdbierz.Enabled = false;

            }
        }



        /// <summary>
        /// Timer, którego tik odbywa się, co 1 sekundę. Działa on niezależnie od timera okna głównego (MainForm)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerOknaNagrody_Tick(object sender, EventArgs e)
        {
            //dopóki czas do nagrody jest większy od 0 to zmniejszamy wartość zmiennej 'czasDoNagrody' i wyświetlamy ją w 'labelCzasOczekiwania'
            if (czasDoNagrody > 0)
            {
                czasDoNagrody--;
                labelCzasOczekiwania.Text = "Czas do nagrody: " + czasDoNagrody.ToString();
            }
            //gdy zmienna 'czasDoNagrody' będzie równa 0 to zmieniamy wartość etykiety na "Gotowe!", aktywujemy przycisk oraz zmieniamy obrazek na OpenCase 
            else if(czasDoNagrody == 0){

                labelCzasOczekiwania.Text = "Gotowe!";
                buttonOdbierz.Enabled = true;
                pictureBoxNagroda.Image = Properties.Resources.OpenCase;
                //ustawiamy wartość 'czasDoNagrody' na -1, aby ponownie nie ustawiać powyższych parametrów wraz z tikiem timera
                czasDoNagrody--;
            }

        }

        /// <summary>
        /// Operacja wykonywana przed zamknięciem okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormNagrody_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ukrycie okna
            this.Hide();
            //odrzucenie zdarzenia - instancja okna nie zostanie usunięta
            e.Cancel = true;
        }

    }
}
