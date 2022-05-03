using System;
using System.Collections.Generic;
using Xunit;

namespace WiktorDanielewskiLab9PracDom.UnitTests
{
    public class PeselCreatorTests
    {
        public static PeselCreator peselCreator;

        public PeselCreatorTests() {
            peselCreator = new PeselCreator();
        }



        [Theory]
        [MemberData(nameof(PeselCreatorTestsData.GetPersons), MemberType = typeof(PeselCreatorTestsData))]
        public void GetPeselTest(List<Person> persons) {

            //Arrange
            PeselCreator.CurrentMaleNumberInFstSection = 551;
            PeselCreator.CurrentFamaleNumberInSndSection = 250;
            PeselCreator.CurrentFamaleNumberInTrdSection = 520;
            PeselCreator.CurrentMaleNumberInTrdSection = 521;

            foreach (Person person in persons)
            {

                //Act
                string resultPesel = peselCreator.GetPesel(person, false);

                //Assert
                Assert.Equal(person.ExpectedPesel, resultPesel);
            }

        }



        [Theory]
        [MemberData(nameof(PeselCreatorTestsData.GetPersons), MemberType = typeof(PeselCreatorTestsData))]
        public void GetPeselTypeDTest(List<Person> persons)
        {

            //Arrange
            PeselCreator.CurrentMaleNumberInFstSection = 551;
            PeselCreator.CurrentFamaleNumberInSndSection = 250;
            PeselCreator.CurrentFamaleNumberInTrdSection = 520;
            PeselCreator.CurrentMaleNumberInTrdSection = 521;

            foreach (Person person in persons)
            {

                //Act
                string resultPeselTypeD = peselCreator.GetPesel(person, true);

                //Assert
                Assert.Equal(person.ExpectedPeselTypeD, resultPeselTypeD);
            }

        }



        [Theory]
        [InlineData("12-01-2020", 11220)]
        [InlineData("12-11-2020", 111220)]
        [InlineData("03-09-1999", 90399)]
        public void GetFormatedDateToPeselTest(DateTime dateOfBirth, int expectedNumber) {

            int result = peselCreator.GetFormatedDateToPesel(dateOfBirth);
            Assert.Equal(expectedNumber, result);
        }



        [Theory]
        [MemberData(nameof(PeselCreatorTestsData.GetPersons), MemberType = typeof(PeselCreatorTestsData))]
        public void GetPersonalNumberTest(List<Person> persons)
        {
            //Arrange
            PeselCreator.CurrentMaleNumberInFstSection = 551;
            PeselCreator.CurrentFamaleNumberInSndSection = 250;
            PeselCreator.CurrentFamaleNumberInTrdSection = 520;
            PeselCreator.CurrentMaleNumberInTrdSection = 521;

            foreach(Person person in persons){

                //Act
                int result = peselCreator.GetPersonalNumber(person);

                //Assert
                Assert.Equal(person.ExpectedPersonalNumber, result);
            }
        }



        [Theory]
        [InlineData("12-01-1899", 551, 51)]
        [InlineData("02-20-1999", 250, 47)]
        [InlineData("06-27-2020", 520, 37)]
        [InlineData("06-27-2020", 521, 18)]
        public void GetControlDigitsTest(DateTime dateOfBirth, int idividualNumber, int expectedNumber)
        {
           /* //Arrange
            var peselCreator = new PeselCreator();*/

            //Act
            int result = peselCreator.GetControlDigits(dateOfBirth, idividualNumber);

            //Assert
            Assert.Equal(expectedNumber, result);
        }



        [Theory]
        [InlineData(1854, true)]
        [InlineData(1854, false)]
        [InlineData(1899, true)]
        [InlineData(1899, false)]
        [InlineData(1870, true)]
        [InlineData(1870, false)]
        public void GetIndividualNumberCheckSectionFrom1854To1899Test(int year, bool isMale) {
            
            // Arrange
            //var peselCreator = new PeselCreator();
            int result;
            // Act
            result = peselCreator.GetIndividualNumber(year, isMale);

            // Assert
            // Sprawdzenie, czy zwrócony numer mieœci siê w odpowiednim przedziale
            Assert.True(result >= 500 && result <= 749);
            if (isMale)
            {
                // Sprawdzamy, czy nieparzysty
                Assert.True(result % 2 == 1);
            }
            else {
                // Sprawdzamy, czy parzysty
                Assert.True(result % 2 == 0);
            }
        }



        [Theory]
        [InlineData(1900, true)]
        [InlineData(1900, false)]
        [InlineData(1999, true)]
        [InlineData(1999, false)]
        [InlineData(1951, true)]
        [InlineData(1951, false)]
        public void GetIndividualNumberCheckSectionFrom1900To1999Test(int year, bool isMale)
        {

            // Arrange
            //var peselCreator = new PeselCreator();
            int result;
            // Act
            result = peselCreator.GetIndividualNumber(year, isMale);

            // Assert
            // Sprawdzenie, czy zwrócony numer mieœci siê w odpowiednim przedziale
            Assert.True(result >= 0 && result <= 499);
            if (isMale)
            {
                // Sprawdzamy, czy nieparzysty
                Assert.True(result % 2 == 1);
            }
            else
            {
                // Sprawdzamy, czy parzysty
                Assert.True(result % 2 == 0);
            }
        }



        [Theory]
        [InlineData(2000, true)]
        [InlineData(2000, false)]
        [InlineData(2039, true)]
        [InlineData(2039, false)]
        [InlineData(2020, true)]
        [InlineData(2020, false)]
        public void GetIndividualNumberCheckSectionFrom2000To2039Test(int year, bool isMale)
        {
            // Arrange
            //var peselCreator = new PeselCreator();
            int result;
            // Act
            result = peselCreator.GetIndividualNumber(year, isMale);

            // Assert
            // Sprawdzenie, czy zwrócony numer mieœci siê w odpowiednim przedziale
            Assert.True(result >= 500 && result <= 999);
            if (isMale)
            {
                // Sprawdzamy, czy nieparzysty
                Assert.True(result % 2 == 1);
            }
            else
            {
                // Sprawdzamy, czy parzysty
                Assert.True(result % 2 == 0);
            }
        }



        [Theory]
        [InlineData(1853, true)]
        [InlineData(2040, true)]
        [InlineData(3000, false)]
        [InlineData(1000, false)]
        public void GetIndividualNumberExceptionCheck(int year, bool isMale)
        {
            Assert.Throws<ArgumentException>(() => peselCreator.GetIndividualNumber(year, isMale));
        }
    }

    
}
