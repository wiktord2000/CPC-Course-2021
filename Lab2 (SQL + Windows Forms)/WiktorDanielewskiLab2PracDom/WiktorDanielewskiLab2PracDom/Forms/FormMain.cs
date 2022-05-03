using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WiktorDanielewskiLab2PracDom.Database;

namespace WiktorDanielewskiLab2PracDom
{
    public partial class MainForm : Form
    {

        /// <summary>
        /// Wskaźnik na instancję klasy Repository
        /// </summary>
        private readonly Repository _repository = new Repository();



        /// <summary>
        /// Konstruktor głównego okna aplikacji
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            //Ustawienie okna, żeby pojawiało się na środku ekranu
            StartPosition = FormStartPosition.CenterScreen;
           
        }

 

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Aktualizacja danych w DataGridViewBooks przy ładowaniu okna
            RefreshDataGridViewBooks();
        }


        /// <summary>
        /// Metoda czyszcząca zawartości komponentów
        /// </summary>
        private void ClearTextBoxes()
        {
            textBoxID.Text = "";
            textBoxProducentName.Text = "";
            textBoxModel.Text = "";
            textBoxSize.Text = "";
            comboBoxMale.SelectedIndex = -1;
            textBoxAvailability.Text = "";
            textBoxPrice.Text = "";

        }

        /// <summary>
        /// Metoda odświeżająca dane w DataGridViewBooks
        /// </summary>
        private void RefreshDataGridViewBooks()
        {
            //Pobranie aktualnego stanu tabeli Shoes z bazy danych
            DataTable table = _repository.GetShoes();

            //Przypisanie aktualnej tabeli do atrybutu DataSource
            dataGridViewShoes.DataSource = table;
           
        }

        private void buttonDodajButy_Click(object sender, EventArgs e)
        {
            //sprawdzenie, czy wszystkie niezbędne pola zostały uzupełnione
            if ((textBoxProducentName.Text != "") && (textBoxModel.Text != "") && (textBoxSize.Text != "") && (textBoxAvailability.Text != "") && (textBoxPrice.Text != ""))
            {
                //sprawdzenie, czy możemy dodać nowe buty
                if (textBoxID.Text != "")
                {
                    labelStatus.Text = "Status: Aby dodać nowe buty pole ID musi być puste!";
                }
                else 
                {
                    //pobranie wartości z komponentów
                    string producentName = textBoxProducentName.Text;
                    string model = textBoxModel.Text;
                    int size = int.Parse(textBoxSize.Text);
                    bool male = bool.Parse(comboBoxMale.Text);
                    int availability = int.Parse(textBoxAvailability.Text);
                    int price = int.Parse(textBoxPrice.Text);

                    //sprawdzenie, jaką warość zwróci funkcja AddShoe. Jeśli true - powodzenie, false - niepowodzenie.
                    if (_repository.AddShoe(producentName, model, size, male, availability, price) == false)
                    {
                        labelStatus.Text = "Status: Nie ma takiego producenta!";
                    }
                    else
                    {
                        labelStatus.Text = "Status: Dodano pomyślnie!";
                        RefreshDataGridViewBooks();
                        ClearTextBoxes();
                    }
                    
                }
                
            }
            else 
            {
                labelStatus.Text = "Status: Nie podałeś wszystkich danych!";            
            }
            

        }

        private void buttonUsunButy_Click(object sender, EventArgs e)
        {
            //sprawdzenie, czy pole tekstowe nie jest puste
            if (textBoxID.Text != "") {

                //pobranie zawartości textBoxID.Text
                int shoeId = int.Parse(textBoxID.Text);

                //użycie metody DeleteShoe klasy Repository
                _repository.DeleteShoe(shoeId);

                //odświeżenie komponentu
                RefreshDataGridViewBooks();

                //wyczyszczenie pól
                ClearTextBoxes();

                //wpisanie nowej wartości do etykiety
                labelStatus.Text = "Usunięto buty!";
            }
        }

        private void dataGridViewShoes_SelectionChanged(object sender, EventArgs e)
        {

            int rowCount = dataGridViewShoes.SelectedRows.Count;
            if (rowCount == 0 || rowCount > 1)
            {
                return;
            }

            DataGridViewRow row = dataGridViewShoes.SelectedRows[0];

            //pobranie wartości z zazanczonego wiersza
            int id = int.Parse(row.Cells[0].Value.ToString());
            string producentName = row.Cells[1].Value.ToString();
            string model = row.Cells[2].Value.ToString();
            int size = int.Parse(row.Cells[3].Value.ToString());
            bool male = bool.Parse(row.Cells[4].Value.ToString());
            int availability = int.Parse(row.Cells[5].Value.ToString());
            int price = int.Parse(row.Cells[6].Value.ToString());

            //przypisanie wartości
            textBoxID.Text = id.ToString();
            textBoxProducentName.Text = producentName;
            textBoxModel.Text = model;
            textBoxSize.Text = size.ToString();
            comboBoxMale.Text = male.ToString();
            textBoxAvailability.Text = availability.ToString();
            textBoxPrice.Text = price.ToString();

            labelStatus.Text = "Status: Wybrano buty!";

        }

        private void buttonWyczyscPola_Click(object sender, EventArgs e)
        {
            //czyszczenie pól
            ClearTextBoxes();
            //zmiana zawartości labelStatus
            labelStatus.Text = "Status: Wyczyszczono pola!";
        }

        private void buttonEdytujButy_Click(object sender, EventArgs e)
        {
            //sprawdzamy, czy mamy wybrany jakis wiersz, jeśli nie to warunek nie zostanie spełniony - nie edytujemy wiersza
            if (textBoxID.Text != "") {


                //pobranie wartości z komponentów
                int ID = int.Parse(textBoxID.Text);
                string producent = textBoxProducentName.Text;
                string model = textBoxModel.Text;
                int size = int.Parse(textBoxSize.Text);
                bool male = bool.Parse(comboBoxMale.Text);
                int availability = int.Parse(textBoxAvailability.Text);
                int price = int.Parse(textBoxPrice.Text);


                //użycie metody EditShoe wraz z instrukcją warunkową
                if (_repository.EditShoe(ID, producent, model, size, male, availability, price) == true)
                {
                    //czyszczenie pól
                    ClearTextBoxes();
                    //odświeżenie komponentu
                    RefreshDataGridViewBooks();
                    //aktualizacja etykiety
                    labelStatus.Text = "Status: Zaktualizowano dane butów!";

                }
                else 
                {
                    //aktualizacja etykiety
                    labelStatus.Text = "Status: Wprowadzono niepoprawną nazwę producenta!";
                }
            
            }
        }
    }
}
