using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WiktorDanielewskiLab4PracDom.Models;

namespace WiktorDanielewskiLab4PracDom.Controllers
{
    public class HomeController : Controller
    {

         
        /// <summary>
        /// Zmienna przechowująca wskaźnik na listę z miastami. Jest statyczna, ponieważ nie chcemy, aby za każdym razem, gdy utworzymy nową instancję klasy HomeController była ona przywracana do stanu początkowego.
        /// </summary>
        public static List<CountryViewModel> AllCountries { get; set; }
        /// <summary>
        /// Zmienna statyczna przechowująca wskaźnik na listę z odpowiedziami.
        /// </summary>
        public static List<string> UserAnswers { get; set; }



        /// <summary>
        /// Konstruktor klasy HomeController
        /// </summary>
        /// <param name="logger"></param>
        public HomeController()
        {
            //jeśli będzie to pierwsze utworzenie instancji klasy HomeController - zainicjalizujemy listę z miastami i uzupełnimy ją przykładowymi wartościami oraz przygotujemy miejsce na odpowiedzi
            if (AllCountries == null) {

                //Wstępna inicjalizacja zmiennych statycznych
                AllCountries = new List<CountryViewModel>();
                UserAnswers = new List<string>();

                //Dodanie miast
                AllCountries.Add(new CountryViewModel("Polska", "Warszawa", true));
                AllCountries.Add(new CountryViewModel("Niemcy", "Berlin", false));
                AllCountries.Add(new CountryViewModel("Rosja", "Moskwa", true));
                AllCountries.Add(new CountryViewModel("Belgia", "Bruksela", false));
                AllCountries.Add(new CountryViewModel("Francja", "Paryż", true));
                AllCountries.Add(new CountryViewModel("Włochy", "Rzym", false));
                AllCountries.Add(new CountryViewModel("Finlandia", "Helsinki", true));

                //Dodanie pustych stringów (przygotowanie miejsca na odpowiedzi)
                for (int i = 0; i < AllCountries.Count; i++)
                {
                    UserAnswers.Add("");
                }
            }
        }










        [HttpGet]
        /// <summary>
        /// Metoda mająca na celu losowe zmienienie atrybutów obiektów znajdujących się na liscie 'AllCountries'.
        /// </summary>
        public IActionResult ReverseAllCountryList() {

            //losujemy liczbę z przedziału od <0.0; 1.0)
            Random random = new Random();
            double randomNumber;
            randomNumber = random.NextDouble();

            //jeśli wylosowana liczba spełni, któreś z kryteriów odpowiednio zmieniamy kolejność elementów na liście
            if (randomNumber <= 0.5)
            {
                //zmiana kolejności elementów
                AllCountries.Reverse(0, 2);
                AllCountries.Reverse(2, 2);
            }
            else
            {
                //inna zmiana kolejności elementów
                AllCountries.Reverse(0, 3);
                AllCountries.Reverse(1, 3);
            }


            //zamiana atrybutu 'firstEmpty' na przeciwny, gdy wylosowany numer będzie >= 0.5
            foreach (CountryViewModel country in AllCountries)
            {
                randomNumber = random.NextDouble();

                if (randomNumber >= 0.5)
                {
                    if (country.FirstEmpty == false)
                    {
                        country.FirstEmpty = true;
                    }
                    else if (country.FirstEmpty == true)
                    {
                        country.FirstEmpty = false;
                    }
                }
            }

            //wyczyszczenie wszystkich wcześniejszych odpowiedzi, które były rozwiązaniem dla wcześniejszego problemu
            for (int i = 0; i < UserAnswers.Count; i++)
            {
                UserAnswers[i] = "";
            }

            //tworzenie nowej instancji 'StudyViewModel'
            StudyViewModel newSVM = new StudyViewModel();

            //przypisanie wskaźnika na zmodyfikowaną listę miast
            newSVM.CountryList = AllCountries;

            //przypisanie wskaźnika na zmodyfikowaną listę odpowiedzi
            newSVM.Answers = UserAnswers;

            //zwrócenie widoku z nowym modelem
            return View("StudyPage", newSVM);
        }





        [HttpGet]
        public IActionResult StudyPage()
        {
            //przygotowanie obiektu klasy StudyViewModel
            StudyViewModel svm = new StudyViewModel();
            
            //przypisanie wskaźnika na obecny stan listy UserAnswers
            svm.Answers = UserAnswers;
            //przypisanie wskaźnika na obecny stan listy AllCountries
            svm.CountryList = AllCountries;

            return View(svm);
        }





        [HttpPost]
        public IActionResult StudyPage(StudyViewModel svm)   //Uwaga: otrzymamy wypełnioną listę z odpowiedziami, ale pustą listę z miastami
        {
            int correct = 0;
            int iterator = 0;

            //obliczanie wyniku
            foreach (var s in AllCountries)
            {

                if (s.FirstEmpty == true)
                {
                    //sprawdzenie, czy nazwa państwa się zgadza
                    if (String.Compare(svm.Answers[iterator], s.Name) == 0)
                    {
                        correct++;
                    }
                }
                else
                {
                    //sprawdzenie, czy nazwa stolicy się zgadza
                    if (String.Compare(svm.Answers[iterator], s.Capital) == 0)
                    {
                        correct++;
                    }
                }

                //dodatkowo będziemy zapamiętywać wszystkie odpowiedzi użytkownika (nawet błędne) w naszej statycznej liście, aby móc je wyświetlić ponownie po powrocie do strony.
                UserAnswers[iterator] = svm.Answers[iterator];

                iterator++;
            }

            //przekazanie informacji o wyniku poprzez instancję klasy 'ResultViewModel'
            ResultViewModel result = new ResultViewModel();
            result.Points = correct;
            result.MaxPoints = svm.Answers.Count;

            return View("ResultPage", result);

        }





        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }





        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }





        [HttpGet]
        public IActionResult Subscription()
        {
            return View();
        }





        [HttpPost]
        public IActionResult Subscription(EmailViewModel emailViewModel)
        {
            //przekazanie do ViewBag atrybutu email, który jest typu string
            ViewBag.Email = emailViewModel.Email;

            return View("SubscriptionResponse");
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
