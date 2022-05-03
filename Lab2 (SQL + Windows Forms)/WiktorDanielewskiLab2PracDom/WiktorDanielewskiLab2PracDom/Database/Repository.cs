using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiktorDanielewskiLab2PracDom.Database
{
    /// <summary>
    /// Klasa abstrakcyjna mająca zmienne i/lub metody, które każde repozytorium powinno zawierać
    /// </summary>
    public class Repository
    {   

        /// <summary>
        /// Nawiązanie połączenia z naszą bazą danych zefiniowaną w ConnectionString
        /// </summary>
        private readonly SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString);


        /// <summary>
        /// Metoda zwracająca DataTable reprezentująca tabelę Shoes bazy danych
        /// </summary>
        /// <returns></returns>
        public System.Data.DataTable GetShoes() 
        {
            //utworzenie zapytania
            string query = "SELECT *" +
                           "FROM Shoes ;";
                        

            SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }


        /// <summary>
        /// Metoda umożliwiająca dodanie nowych butów do tabeli Shoes w bazie danych. Jeśli się powiedzie zwróci true, jeśli nie false.
        /// </summary>
        /// <param name="producent"></param>
        /// <param name="model"></param>
        /// <param name="size"></param>
        /// <param name="male"></param>
        /// <param name="availability"></param>
        public bool AddShoe(string producent, string model, int size, bool male, int availability, int price)
        {
            //przygotowanie zapytania, które sprawdzi, czy dany producent istnieje w tabeli Producents
            string queryGetProducent = "SELECT Name " +
                                       "FROM Producents " +
                                       $"WHERE Name = '{producent}';";



            string queryInsertShoes = "INSERT INTO Shoes " +
                                     $"VALUES ( '{producent}' , '{model}' , {size} , '{male}' , {availability} , {price} );";

            //otwarcie połączenia z bazą danych
            _connection.Open();

            SqlCommand commandSelectProducent = new SqlCommand(queryGetProducent, _connection);

            //jeśli nie znajdziemy w tablicy Producents nazwy danego producenta - zostanie zwrócony null
            if (commandSelectProducent.ExecuteScalar() == null) 
            {
                //zamknięcie połaczenia z bazą danych
                _connection.Close();
                //zwrócenie wartości false
                return false;
            }

            //dodanie nowego wiersza
            SqlCommand commandInserShoes = new SqlCommand(queryInsertShoes, _connection);
            commandInserShoes.ExecuteNonQuery();

            //zamknięcie połaczenia z bazą danych
            _connection.Close();

            return true;

        }


        /// <summary>
        /// Metoda usuwająca buty o podanym indeksie z tabeli Shoes w bazie danych
        /// </summary>
        public void DeleteShoe(int shoeID)
        {
            string queryDeleteShoe = "DELETE FROM Shoes " +
                                     $"WHERE Id = {shoeID};";
            _connection.Open();
            SqlCommand commandDeleteShoe = new SqlCommand(queryDeleteShoe, _connection);
            commandDeleteShoe.ExecuteNonQuery();

            _connection.Close();
        }


        /// <summary>
        /// Metoda odpowiedzialna za edytowanie atrybutów butów o wybranym indeksie
        /// </summary>
        /// <param name="shoeID"></param>
        /// <param name="producent"></param>
        /// <param name="model"></param>
        /// <param name="size"></param>
        /// <param name="male"></param>
        /// <param name="availability"></param>
        public bool EditShoe(int shoeID, string producent, string model, int size, bool male, int availability, int price) 
        {
            //przygotowanie zapytania, które sprawdzi, czy dany producent istnieje w tabeli Producents
            string queryGetProducent = "SELECT Name " +
                                       "FROM Producents " +
                                       $"WHERE Name = '{producent}';";

            //zapytanie aktualizujące dany wiersz
            string queryUpdate = "UPDATE Shoes " +
                                 $"SET ProducentName = '{producent}', Model = '{model}', Size = {size}, Male = '{male}', Availability = {availability}, Price = {price} " +
                                 $"WHERE ID = {shoeID};";

            //otwarcie połączenia z bazą danych
            _connection.Open();

            SqlCommand commandSelectProducent = new SqlCommand(queryGetProducent, _connection);

            //jeśli nie znajdziemy w tablicy Producents nazwy danego producenta - zostanie zwrócony null
            if (commandSelectProducent.ExecuteScalar() == null)
            {
                //zamknięcie połaczenia z bazą danych
                _connection.Close();
                //zwrócenie wartości false
                return false;
            }

            //aktualizacja danego wiersza
            SqlCommand commandUpdateShoe = new SqlCommand(queryUpdate, _connection);
            commandUpdateShoe.ExecuteNonQuery();

            //zamknięcie połaczenia z bazą danych
            _connection.Close();

            return true;

        }

    }
}
