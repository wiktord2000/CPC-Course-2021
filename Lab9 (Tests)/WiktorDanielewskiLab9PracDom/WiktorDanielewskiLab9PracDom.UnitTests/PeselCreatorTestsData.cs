using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WiktorDanielewskiLab9PracDom.UnitTests
{
    class PeselCreatorTestsData
    {

        public static IEnumerable<object[]> GetPersons()
        {
            yield return new object[]{
                new List<Person>{
                    new Person(new DateTime(1899,12,1), true , 55151, "01129955151", "41129955151" ),
                    new Person(new DateTime(1999,2,20), false, 25047, "20029925047", "60029925047"),
                    new Person(new DateTime(2020,6,27), false, 52037, "27062052037", "67062052037"),
                    new Person(new DateTime(2020,6,27), true, 52118, "27062052118", "67062052118")
                },
            };


    }
}
}
