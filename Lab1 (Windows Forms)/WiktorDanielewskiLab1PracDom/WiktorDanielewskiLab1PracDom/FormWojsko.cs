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
    public partial class FormWojsko : Form
    {
        /// <summary>
        /// Zmienna przechowująca liczbę Cavalery Archers
        /// </summary>
        private int liczbaCavaleryArcher = 0;
        /// <summary>
        /// Zmienna przechowująca liczbę Crossbowmans
        /// </summary>
        private int liczbaCrossbowman = 0;
        /// <summary>
        /// Zmienna przechowująca liczbę Knights
        /// </summary>
        private int liczbaKnight = 0;
        /// <summary>
        /// Zmienna przechowująca liczbę Long Swordsmans
        /// </summary>
        private int liczbaLongSwordsman = 0;
        /// <summary>
        /// Zmienna przechowująca liczbę Mangonels
        /// </summary>
        private int liczbaMangonel = 0;
        /// <summary>
        /// Zmienna przechowująca liczbę Pikemans
        /// </summary>
        private int liczbaPikeman = 0;


        public FormWojsko()
        {
            InitializeComponent();
        }

        private void FormWojsko_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ukrycie okna
            this.Hide();
            //odrzucenie zdarzenia - instancja okna nie zostanie usunięta
            e.Cancel = true;
        }

        private void listViewWojownicy_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listViewWojownicy.SelectedItems.Count > 0)
            {
                //przypisane indeksu zaznaczonego obrazka do zmiennej 'selected'
                int selected = listViewWojownicy.SelectedItems[0].Index;

                //wykonanie odpowiedniej akcji w zależności od indeksu wybranego obrazka
                switch (selected) {
                    case 0:
                        //wyświetlenie aktualnej liczby posiadanych CavaleryArchers
                        labelPosiadani.Text = "Posiadani: " + liczbaCavaleryArcher.ToString();
                        //wyświetlenie kosztów związanych z zakupem danego wojownika
                        labelKoszt.Text = "Koszt:\n100 złota\n100 jedzenia";
                        break;
                    case 1:
                        labelPosiadani.Text = "Posiadani: " + liczbaCrossbowman.ToString();
                        labelKoszt.Text = "Koszt:\n70 złota\n40 jedzenia";
                        break;
                    case 2:
                        labelPosiadani.Text = "Posiadani: " + liczbaKnight.ToString();
                        labelKoszt.Text = "Koszt:\n150 złota\n100 jedzenia";
                        break;
                    case 3:
                        labelPosiadani.Text = "Posiadani: " + liczbaLongSwordsman.ToString();
                        labelKoszt.Text = "Koszt:\n80 złota\n60 jedzenia";
                        break;
                    case 4:
                        labelPosiadani.Text = "Posiadani: " + liczbaPikeman.ToString();
                        labelKoszt.Text = "Koszt:\n60 złota\n50 jedzenia";
                        break;
                    case 5:
                        labelPosiadani.Text = "Posiadani: " + liczbaMangonel.ToString();
                        labelKoszt.Text = "Koszt:\n300 złota\n100 drewna\n50 kamienia";
                        break;

                }
            }
            //pominięcie zdarzenia, gdy SelectedItems jest puste
            else
            {
                return;            
            }
            
        }

        private void buttonKup_Click(object sender, EventArgs e)
        {
            if (listViewWojownicy.SelectedItems.Count > 0)
            {
                //przypisane indeksu zaznaczonego obrazka do zmiennej 'selected'
                int selected = listViewWojownicy.SelectedItems[0].Index;

                //sprawdzamy, czy populacja nie osiągnęła limitu, jeśli tak to wyświetlamy odpowiedni komunikat
                if (MainForm.populacja == MainForm.limitPopulacji)
                {
                    MessageBox.Show("Osiągnąłeś limit populacji!");
                }
                else {
                    //wykonanie odpowiedniej akcji w zależności od indeksu wybranego obrazka
                    switch (selected)
                    {
                        case 0:
                            //pomniejszamy zasoby wyłącznie wtedy, gdy są one większe bądź równe wartości, o którą pomniejszamy
                            if ((MainForm.liczbaZlota >= 100) && (MainForm.liczbaJedzenia >= 100))
                            {
                                MainForm.liczbaZlota -= 100;
                                MainForm.liczbaJedzenia -= 100;
                                MainForm.populacja++;
                                liczbaCavaleryArcher++;
                                //aktualizowanie zawartości etykiety
                                labelPosiadani.Text = "Posiadani: " + liczbaCavaleryArcher.ToString();

                            }
                            //jeśli nie mamy wystarczająco zasobów to wyświetlamy komunikat o tym informujący
                            else {
                                MessageBox.Show("Nie masz wystarczająco zasobów!");
                            }
                            break;
                        case 1:
                            if ((MainForm.liczbaZlota >= 70) && (MainForm.liczbaJedzenia >= 40))
                            {
                                MainForm.liczbaZlota -= 70;
                                MainForm.liczbaJedzenia -= 40;
                                MainForm.populacja++;
                                liczbaCrossbowman++;
                                labelPosiadani.Text = "Posiadani: " + liczbaCrossbowman.ToString();
                            }
                            else { 
                                MessageBox.Show("Nie masz wystarczająco zasobów!");
                            }
                            break;
                        case 2:
                            if ((MainForm.liczbaZlota >= 150) && (MainForm.liczbaJedzenia >= 100))
                            {

                                MainForm.liczbaZlota -= 150;
                                MainForm.liczbaJedzenia -= 100;
                                MainForm.populacja++;
                                liczbaKnight++;
                                labelPosiadani.Text = "Posiadani: " + liczbaKnight.ToString();
                            }
                            else {
                                MessageBox.Show("Nie masz wystarczająco zasobów!");
                            }
                            break;
                        case 3:
                            if ((MainForm.liczbaZlota >= 80) && (MainForm.liczbaJedzenia >= 60))
                            {

                                MainForm.liczbaZlota -= 80;
                                MainForm.liczbaJedzenia -= 60;
                                MainForm.populacja++;
                                liczbaLongSwordsman++;
                                labelPosiadani.Text = "Posiadani: " + liczbaLongSwordsman.ToString();
                            }
                            else {
                                MessageBox.Show("Nie masz wystarczająco zasobów!");
                            }
                            break;
                        case 4:
                            if ((MainForm.liczbaZlota >= 60) && (MainForm.liczbaJedzenia >= 50))
                            {
                                MainForm.liczbaZlota -= 60;
                                MainForm.liczbaJedzenia -= 50;
                                MainForm.populacja++;
                                liczbaPikeman++;
                                labelPosiadani.Text = "Posiadani: " + liczbaPikeman.ToString();
                            }
                            else {
                                MessageBox.Show("Nie masz wystarczająco zasobów!");
                            }
                            break;
                        case 5:
                            if ((MainForm.liczbaZlota >= 300) && (MainForm.liczbaKamienia >= 100)&&(MainForm.liczbaKamienia>=50))
                            {
                                MainForm.liczbaZlota -= 300;
                                MainForm.liczbaDrewna -= 100;
                                MainForm.liczbaKamienia -= 50;
                                MainForm.populacja++;
                                liczbaMangonel++;
                                labelPosiadani.Text = "Posiadani: " + liczbaMangonel.ToString();
                            }
                            else { 
                            
                            }
                            
                            break;
                    }
                }
            }
            //pominięcie zdarzenia, gdy SelectedItems jest puste
            else
            {
                return;
            }
        }
    }
}
