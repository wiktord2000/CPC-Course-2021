using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WiktorDanielewskiLab9PracDom
{

    
    public class Person
    {
        public DateTime DateOfBirth { get; set; }
        public bool IsMale { get; set; }

        public int ExpectedPersonalNumber { get; set; }

        public string ExpectedPesel { get; set; }

        public string ExpectedPeselTypeD { get; set; }

        public Person(DateTime dateOfBirth, bool isMale, int expectedPersonalNumber, string expectedPesel, string expectedPeselTypeD)
        {
            DateOfBirth = dateOfBirth;
            IsMale = isMale;
            ExpectedPersonalNumber = expectedPersonalNumber;
            ExpectedPesel = expectedPesel;
            ExpectedPeselTypeD = expectedPeselTypeD;
        }
    }
}
