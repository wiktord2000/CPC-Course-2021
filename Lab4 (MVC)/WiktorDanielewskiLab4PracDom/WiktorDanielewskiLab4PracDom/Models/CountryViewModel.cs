

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
        /// Nazwa pañstwa
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Nazwa stolicy pañstwa
        /// </summary>
        public string Capital { get; set; }
        /// <summary>
        /// Okreœla, które pola ma zostaæ pozostawione do wype³nienia. Gdy FirstEmpty = true - pierwsze pole bêdzie wyœwietlane jako puste i bêdzie trzeba je wype³niæ.
        /// </summary>
        public bool FirstEmpty { get; set; }




    }





}