

namespace WiktorDanielewskiLab4PracDom.Models 
{
    public class CountryViewModel {

        public CountryViewModel() { }
        public CountryViewModel(string name, string capital, bool firstEmpty) {

            this.Capital = capital;
            this.Name = name;
            this.FirstEmpty = firstEmpty;
        
        }


        /// <summary>
        /// Nazwa pa�stwa
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Nazwa stolicy pa�stwa
        /// </summary>
        public string Capital { get; set; }
        /// <summary>
        /// Okre�la, kt�re pola ma zosta� pozostawione do wype�nienia. Gdy FirstEmpty = true - pierwsze pole b�dzie wy�wietlane jako puste i b�dzie trzeba je wype�ni�.
        /// </summary>
        public bool FirstEmpty { get; set; }




    }





}