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
    public partial class MainForm : Form
    {
        /// <summary>
        /// Wskaźnik na okno wyświetlające nagrody
        /// </summary>
        private FormNagrody formNagrody = new FormNagrody();
        /// <summary>
        /// Wskaźnik na okno wyświetlające sprawy związane z murami
        /// </summary>
        private FormMury formMury = new FormMury();
        /// <summary>
        /// Wskaźnik na instancję klasy FormPopulacja
        /// </summary>
        private FormPopulacja formPopulacja;
        /// <summary>
        /// Wskaźnik na instancję klasy FormWiesniacy
        /// </summary>
        private FormWiesniacy formWiesniacy = new FormWiesniacy();
        /// <summary>
        /// Wskaźnik na instancję klasy FormWojsko
        /// </summary>
        private FormWojsko formWojsko = new FormWojsko();
        /// <summary>
        /// Wskaźnik na instancję klasy FormStatystyki
        /// </summary>
        private FormStatystyki formStatystyki = new FormStatystyki();



        /// <summary>
        /// Zmienna przechowująca informację o aktualnej liczbie złota
        /// </summary>
        public static int liczbaZlota = 0;
        /// <summary>
        /// Zmienna definiująca, o ile zwiększy się wartość zmiennej 'liczbaZlota' po upływie sekundy
        /// </summary>
        public static int przyrostZlota = 2;
        

        
        /// <summary>
        /// Zmienna przechowująca informację o aktualnej liczbie drewna
        /// </summary>
        public static int liczbaDrewna = 0;
        /// <summary>
        /// Zmienna definiująca, o ile zwiększy się wartość zmiennej 'liczbaDrewna' po upływie sekundy
        /// </summary>
        public static int przyrostDrewna = 1;



        /// <summary>
        /// Zmienna przechowująca informację o aktualnej liczbie kamienia
        /// </summary>
        public static int liczbaKamienia = 0;
        /// <summary>
        /// Zmienna definiująca, o ile zwiększy się wartość zmiennej 'przyrostKamienia' po upływie sekundy
        /// </summary>
        public static int przyrostKamienia = 1;



        /// <summary>
        /// Zmienna przechowująca informację o aktualnej liczbie jedzenia
        /// </summary>
        public static int liczbaJedzenia = 0;
        /// <summary>
        /// Zmienna definiująca, o ile zwiększy się wartość zmiennej 'przyrostJedzenia' po upływie sekundy
        /// </summary>
        public static int przyrostJedzenia = 1;



        /// <summary>
        /// Zmienna przechowująca informację o aktualnej liczbie populacji
        /// </summary>
        public static int populacja = 5;
        /// <summary>
        /// Zmienna przechowująca maksymalną liczbę populacji
        /// </summary>
        public static int limitPopulacji = 10;

        /// <summary>
        /// Zmienna przechowująca informację o aktualnym czasie liczonym od rozpoczęcia gry
        /// </summary>
        public static int czas = 0;



        public MainForm()
        {
            InitializeComponent();

        }



        /// <summary>
        /// Tik zegara odbywający się co 1 sekundę, w którym modyfikowane są parametry gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerLicznikSekund_Tick(object sender, EventArgs e)
        {
            //na każdy tik timer'a zwiększamy poniższe zmienne
            czas++;
            liczbaZlota += przyrostZlota;
            liczbaDrewna += przyrostDrewna;
            liczbaJedzenia += przyrostJedzenia;
            liczbaKamienia += przyrostKamienia;

            //aktualizujemy wartości wyświetlane przez etykiety
            labelZloto.Text = "Złoto: " + liczbaZlota.ToString();
            labelDrewno.Text = "Drewno: " + liczbaDrewna.ToString();
            labelKamien.Text = "Kamień: " + liczbaKamienia.ToString();
            labelJedzenie.Text = "Jedzenie: " + liczbaJedzenia.ToString();
            labelPopulacja.Text = "Populacja: " + populacja.ToString() + "/" + limitPopulacji.ToString();
            //przypisanie do etykiety String'a zwracanego przez funkcję 'konertujCzas(int czasWSekundach)'
            labelCzas.Text = konwertujCzas(czas);


        }




        /// <summary>
        /// Klik przycisku 'buttonNagrody' powoduje wyświetlenie okna "Nagrody"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNagrody_Click(object sender, EventArgs e)
        {
            formNagrody.Show();
        }




        /// <summary>
        /// Klik wyświetla okno związane z Murami
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMury_Click(object sender, EventArgs e)
        {
            //wyświetlenie okna formMury
            formMury.Show();
        }




        /// <summary>
        /// Przycis otwierający okno dialogowe związane z powiększeniem populacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonZamek_Click(object sender, EventArgs e)
        {
            //wyświetlanie komunikatu i przechowanie jego rezultatu w zmiennej 'result'
            var result = MessageBox.Show("Chcesz powiększyć limit populacji?", "Zamek",  MessageBoxButtons.YesNo);

            //jeśli wybierzemy przycisk 'Yes' utworzymy instancję klasy FormPopulacja i ją wyświetlimy, gdy 'No' okno zamknie się
            if (result == DialogResult.Yes) {

                formPopulacja = new FormPopulacja();
                formPopulacja.Show();
            }
        }

        /// <summary>
        /// Funkcja zamienia czas w sekundach na Stringa o formacie "Czas: [minuty]:[sekundy]" 
        /// </summary>
        /// <param name="czasWSekundach"></param>
        /// <returns></returns>
        private String konwertujCzas(int czasWSekundach) {

            //wyznaczanie minut i sekund
            int minuty = czasWSekundach / 60;
            int sekundy = czasWSekundach % 60;
            if (sekundy < 10)
            {
                //jeśli sekundy są mniejsze od 10 (są jednocyfrowe) dodajemy przed ich wypisaniem zamiast ":" ciąg znaków ":0"
                return "Czas: " + minuty.ToString() + ":0" + sekundy.ToString();
            }
            else
            {
                return "Czas: " + minuty.ToString() + ":" + sekundy.ToString();
            }
        }

        /// <summary>
        /// Klik wyświetla okno formWiesniacy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWiesniacy_Click(object sender, EventArgs e)
        {
            formWiesniacy.Show();
        }

        /// <summary>
        /// Klik wyświetla okno formWojsko
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWojsko_Click(object sender, EventArgs e)
        {
            formWojsko.Show();
        }

        /// <summary>
        /// Klik wyświetlający okno statystyk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStatystyki_Click(object sender, EventArgs e)
        {
            formStatystyki.Show();
        }
    }
}
