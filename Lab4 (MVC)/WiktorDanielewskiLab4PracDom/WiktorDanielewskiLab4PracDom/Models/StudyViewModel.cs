using System.Collections.Generic;

namespace WiktorDanielewskiLab4PracDom.Models
{
    public class StudyViewModel
    {

        public StudyViewModel() {
            CountryList = new List<CountryViewModel>();
            Answers = new List<string>();
        
        }
       /// <summary>
       /// Zawiera informacje w jaki sposób maj¹ byæ wyœwietlone pola tekstowe oraz etykiety
       /// </summary>
        public List<CountryViewModel> CountryList { get; set; }
        /// <summary>
        /// Bêdzie przechowywaæ odpowiedzi u¿ytkownika
        /// </summary>
        public List<string> Answers { get; set; }

    }

}

