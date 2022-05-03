using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiktorDanielewskiLab9PracDom
{
    public class PeselCreator
    {

        public static int CurrentMaleNumberInFstSection = 501;
        public static int CurrentFamaleNumberInFstSection = 500;

        public static int CurrentMaleNumberInSndSection = 1;
        public static int CurrentFamaleNumberInSndSection = 0;

        public static int CurrentMaleNumberInTrdSection = 501;
        public static int CurrentFamaleNumberInTrdSection = 500;



        /// <summary>
        /// Zwraca pesel na podstawie daty i płci obywatela
        /// </summary>
        /// <param name="date"></param>
        /// <param name="isMale"></param>
        /// <returns></returns>
        public string GetPesel(Person person, bool isDType) {

            int date = GetFormatedDateToPesel(person.DateOfBirth);

            if (isDType)
            {
                date += 40 * 10000;
            }

            // Zamiana liczy reprezentującej datę na string
            StringBuilder sb = new StringBuilder();

            string dateInString = Convert.ToString(date);
            int zeroesAtStart = 6 - dateInString.Length;

            for (int i = 0; i < zeroesAtStart; i++) {
                sb.Append("0");
            }
            sb.Append(dateInString);
            dateInString = sb.ToString();
            sb.Clear();

            // Zmiana liczby reprezentującej numer osobity na string
            int personalNumber = GetPersonalNumber(person);

            string personalNumberInString = Convert.ToString(personalNumber);
            zeroesAtStart = 5 - personalNumberInString.Length;

            for (int i = 0; i < zeroesAtStart; i++)
            {
                sb.Append("0");
            }
            sb.Append(personalNumberInString);
            personalNumberInString = sb.ToString();
            sb.Clear();

            sb.Append(dateInString).Append(personalNumberInString);

            return sb.ToString();
        }



        public int GetFormatedDateToPesel(DateTime dateOfBirth) {

            int day = dateOfBirth.Day;
            int month = dateOfBirth.Month;
            int year = dateOfBirth.Year;

            return day*10000 + month*100 + (year%100);
        }



        /// <summary>
        /// Zwrca numer indywidualny wraz z liczbą kontrolną
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public int GetPersonalNumber(Person person) {

            int individualNumber = GetIndividualNumber(person.DateOfBirth.Year, person.IsMale);
            int controlNumbers = GetControlDigits(person.DateOfBirth, individualNumber);

            int personalNumber = individualNumber * 100 + controlNumbers;

            return personalNumber;
        }



        /// <summary>
        /// Zwraca indywidualny numer do peselu na podstawie roku urodzenia obywatela
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public int GetIndividualNumber(int year, bool isMale){
            
            int individualNumber;

            if (year < 1854 || year > 2039)
            {
                throw new ArgumentException("Inserted year isn't valid!");
            }

            if (year >= 1854 && year <= 1899) {

                if (isMale)
                {
                    individualNumber = CurrentMaleNumberInFstSection;
                    CurrentMaleNumberInFstSection +=2;
                    if (CurrentMaleNumberInFstSection == 751) CurrentMaleNumberInFstSection = 501;
                    return individualNumber;
                }
                else
                {
                    individualNumber = CurrentFamaleNumberInFstSection;
                    CurrentFamaleNumberInFstSection +=2;
                    if (CurrentMaleNumberInFstSection == 750) CurrentMaleNumberInFstSection = 500;
                    return individualNumber;
                }
            }
            else if (year >= 1900 && year <= 1999) {

                if (isMale)
                {
                    individualNumber = CurrentMaleNumberInSndSection;
                    CurrentMaleNumberInSndSection += 2;
                    if (CurrentMaleNumberInSndSection == 501) CurrentMaleNumberInSndSection = 1;
                    return individualNumber;
                }
                else
                {
                    individualNumber = CurrentFamaleNumberInSndSection;
                    CurrentFamaleNumberInSndSection += 2;
                    if (CurrentFamaleNumberInSndSection == 500) CurrentFamaleNumberInSndSection = 0;
                    return individualNumber;
                }
            }
            else {

                if (isMale)
                {
                    individualNumber = CurrentMaleNumberInTrdSection;
                    CurrentMaleNumberInTrdSection += 2;
                    if (CurrentMaleNumberInTrdSection == 1001) CurrentMaleNumberInTrdSection = 501;
                    return individualNumber;
                }
                else
                {
                    individualNumber = CurrentFamaleNumberInTrdSection;
                    CurrentFamaleNumberInTrdSection += 2;
                    if (CurrentFamaleNumberInTrdSection == 1000) CurrentFamaleNumberInTrdSection = 500;
                    return individualNumber;
                }
            }
        }



        /// <summary>
        /// Zwraca liczbę kontrolną składającą sie z 2 cyfr
        /// </summary>
        /// <returns></returns>
        public int GetControlDigits(DateTime dateOfBirth, int idividualNumber)
        {
            int day = dateOfBirth.Day;
            int d1,d2;
            int month = dateOfBirth.Month;
            int m1, m2;
            int year = dateOfBirth.Year;
            int y1, y2;

            // Rozłożenie individualNumber na cyfry
            int i1 = idividualNumber / 100;
            int i2 = (idividualNumber / 10) % 10;
            int i3 = idividualNumber % 10;

            // Rozkładanie liczby dni na dwie cyfry
            if (day % 10 == day)
            {
                d1 = 0;
                d2 = day % 10;
            }
            else
            {
                d1 = day / 10;
                d2 = day % 10;
            }

            // Rozkładanie liczby miesięcy na dwie cyfry
            if (month % 10 == month)
            {
                m1 = 0;
                m2 = month % 10;
            }
            else
            {
                m1 = month / 10;
                m2 = month % 10;
            }

            // Konwertowanie roku tylko na dwa ostatnie znaki i ich rozdzielenie
            year %= 100;
            if (year % 10 == year)
            {
                y1 = 0;
                y2 = year % 10;
            }
            else
            {
                y1 = year / 10;
                y2 = year % 10;
            }

            int k1 = 11 - ((3*d1 + 7*d2 + 6*m1 + 1*m2 + 8*y1 + 9*y2 + 4*i1 + 5*i2 + 2*i3) % 11);
            int k2 = 11 - ((5*d1 + 4*d2 + 3*m1 + 2*m2 + 7*y1 + 6*y2 + 5*i1 + 4*i2 + 3*i3 + 2*k1) % 11);

            return k1*10 + k2;
        }
    }







}
