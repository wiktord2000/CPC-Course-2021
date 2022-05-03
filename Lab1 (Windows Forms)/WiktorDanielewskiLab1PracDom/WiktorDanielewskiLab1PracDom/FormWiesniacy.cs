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
    public partial class FormWiesniacy : Form
    {
        /// <summary>
        /// Zmienna zawierająca liczbę wszystkich wieśniaków
        /// </summary>
        private int liczbaWszystkichWiesniakow = 5;
        /// <summary>
        /// Zmienna zawierająca liczbę wieśniaków pracujących przy zlocie
        /// </summary>
        private int liczbaWiesniakowPrzyZlocie = 2;
        /// <summary>
        /// Zmienna zawierająca liczbę wieśniaków pracujących przy kamieniu
        /// </summary>
        private int liczbaWiesnikaowPrzyKamieniu = 1;
        /// <summary>
        /// Zmienna zawierająca liczbę wieśniaków pracujących przy drewnie
        /// </summary>
        private int liczbaWiesniakowPrzyDrewnie = 1;
        /// <summary>
        /// Zmienna zawierająca liczbę wieśniaków pracujących przy jedzeniu
        /// </summary>
        private int liczbaWiesniakowPrzyJedzeniu = 1;
        /// <summary>
        /// Zmienna zawierająca liczbę nieprzypisanych jeszcze wieśniaków
        /// </summary>
        private int liczbaNieprzypisanychWiesniakow = 5;
        /// <summary>
        /// Zmienna zawierająca cenę wieśniaka
        /// </summary>
        private int cenaWiesniaka = 50;



        public FormWiesniacy()
        {
            InitializeComponent();
        }

        private void timerOknoWiesniakow_Tick(object sender, EventArgs e)
        {
            //co tik zegara aktualizujemy poniższe etykiety
            labelZloto.Text = "Złoto: " + liczbaWiesniakowPrzyZlocie.ToString();
            labelKamien.Text = "Kamień: " + liczbaWiesnikaowPrzyKamieniu.ToString();
            labelDrewno.Text = "Drewno: " + liczbaWiesniakowPrzyDrewnie.ToString();
            labelJedzenie.Text = "Jedzenie: " + liczbaWiesniakowPrzyJedzeniu.ToString();
            //wyznaczenie liczby nieprzypisanych wieśniaków
            liczbaNieprzypisanychWiesniakow = liczbaWszystkichWiesniakow;
            liczbaNieprzypisanychWiesniakow -= liczbaWiesniakowPrzyDrewnie;
            liczbaNieprzypisanychWiesniakow -= liczbaWiesniakowPrzyJedzeniu;
            liczbaNieprzypisanychWiesniakow -= liczbaWiesniakowPrzyZlocie;
            liczbaNieprzypisanychWiesniakow -= liczbaWiesnikaowPrzyKamieniu;
            //uzupełnienie etykiety 'labelLiczbaNieprzypisanychWiesniakow'
            labelLiczbaNieprzypisanychWiesniakow.Text = "Liczba nieprzypisanych wieśniaków:\n" + liczbaNieprzypisanychWiesniakow.ToString();
            //liczba przypisanych wieśniaków do danego zasobu odpowiada przyrostowi danego zasobu na sekundę, a więc
            //aktualizując rozkład wieśniaków musimy zaktualizować przyrost zasobów
            MainForm.przyrostZlota = liczbaWiesniakowPrzyZlocie;
            MainForm.przyrostDrewna = liczbaWiesniakowPrzyDrewnie;
            MainForm.przyrostJedzenia = liczbaWiesniakowPrzyJedzeniu;
            MainForm.przyrostKamienia = liczbaWiesnikaowPrzyKamieniu;
        }

        private void FormWiesniacy_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ukrycie okna
            this.Hide();
            //odrzucenie zdarzenia - instancja okna nie zostanie usunięta
            e.Cancel = true;
        }


        private void buttonDokupWiesniaka_Click(object sender, EventArgs e)
        {

            //jeśli aktualna populacja jest równa limitowi populacji wypiszemy informujący o tym komunikat
            if (MainForm.limitPopulacji == MainForm.populacja)
            {
                MessageBox.Show("Osiągnąłeś limit populacji!");
            }
            //jeśli liczba złota jest mniejsza, niż cena wieśniaka wypisujemy informujący o tym komunikat
            else if (MainForm.liczbaZlota < cenaWiesniaka)
            {
                MessageBox.Show("Nie masz wystarczająco złota!");
            }
            //jeśli wcześniejsze warunki nie są spełnione
            else {
                //zwiększamy liczbę wszystkich wieśniaków
                liczbaWszystkichWiesniakow++;
                //zwiększamy aktualną populację
                MainForm.populacja++;
                //zmniejszamy liczbę złota o cenę wieśniaka
                MainForm.liczbaZlota -= cenaWiesniaka;
            }
        }

        /// <summary>
        /// Klik powodujący dodanie wieśniaka do zbierania złota, jeśli jest to możliwe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxDodajDoZlota_Click(object sender, EventArgs e)
        {
            //jeśli mamy jakiś nieprzypisanych wieśniaków
            if (liczbaNieprzypisanychWiesniakow > 0) {
                //zwiększamy liczbę wieśniaków przy złocie o 1
                liczbaWiesniakowPrzyZlocie++;
                //zmniejszamy liczbę nieprzypisanych wieśniaków o 1
                liczbaNieprzypisanychWiesniakow--;
            }
        }
        /// <summary>
        /// Klik powodujący odesłanie wieśniaka od zbierania złota, jeśli jest to możliwe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxOdejmnijOdZlota_Click(object sender, EventArgs e)
        {   
            //jeśli liczba wieśniaków przy złocie jest większa od 0
            if (liczbaWiesniakowPrzyZlocie > 0) {
                //zmniejszamy liczbę wieśniaków przy złocie o 1
                liczbaWiesniakowPrzyZlocie--;
                //zwiększamy liczbę nieprzypisanych wieśniaków o 1
                liczbaNieprzypisanychWiesniakow++;
            }
        }
        /// <summary>
        /// Klik powodujący dodanie wieśniaka do zbierania drewna, jeśli jest to możliwe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxDodajDoDrewna_Click(object sender, EventArgs e)
        {
            if (liczbaNieprzypisanychWiesniakow > 0) {
                liczbaWiesniakowPrzyDrewnie++;
                liczbaNieprzypisanychWiesniakow--;
            }
        }
        /// <summary>
        /// Klik powodujący odesłanie wieśniaka od zbierania drewna, jeśli jest to możliwe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxOdejmnijOdDrewna_Click(object sender, EventArgs e)
        {
            if (liczbaWiesniakowPrzyDrewnie > 0) {
                liczbaWiesniakowPrzyDrewnie--;
                liczbaNieprzypisanychWiesniakow++;
            }
        }
        /// <summary>
        /// Klik powodujący dodanie wieśniaka do zbierania kamienia, jeśli jest to możliwe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxDodajDoKamienia_Click(object sender, EventArgs e)
        {
            if (liczbaNieprzypisanychWiesniakow > 0) {
                liczbaNieprzypisanychWiesniakow--;
                liczbaWiesnikaowPrzyKamieniu++;
            }
        }
        /// <summary>
        /// Klik powodujący odesłanie wieśniaka od zbierania kamienia, jeśli jest to możliwe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxOdejmnijOdKamienia_Click(object sender, EventArgs e)
        {
            if (liczbaWiesnikaowPrzyKamieniu > 0) {
                liczbaWiesnikaowPrzyKamieniu--;
                liczbaNieprzypisanychWiesniakow++;
            }
        }
        /// <summary>
        /// Klik powodujący dodanie wieśniaka do zbierania jedzenia, jeśli jest to możliwe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxDodajDoJedzenia_Click(object sender, EventArgs e)
        {
            if (liczbaNieprzypisanychWiesniakow > 0) {
                liczbaWiesniakowPrzyJedzeniu++;
                liczbaNieprzypisanychWiesniakow--;
            }
        }
        /// <summary>
        /// Klik powodujący odesłanie wieśniaka od zbierania jedzenia, jeśli jest to możliwe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxOdejmnijOdJedzenia_Click(object sender, EventArgs e)
        {
            if (liczbaWiesniakowPrzyJedzeniu > 0) {
                liczbaWiesniakowPrzyJedzeniu--;
                liczbaNieprzypisanychWiesniakow++;
            }
        }
    }
}
