using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using RIMSW.Types;
namespace RIMSW.Specifications
{
    
    public class PersonSpecifications
    {
        [Fact]
        public void PersonShouldHaveFirstName()
        {
            //arrange
            var person = NSubstitute.Substitute.For<IPerson>();
            var testName = "Fred";
            //act
            person.FirstName = testName;

            //assert
            Assert.IsType<string>(person.FirstName);
            Assert.NotNull(person.FirstName);
        }

        [Fact]
        public void PersonShouldHaveSurname()
        {
            //arrange
            var person = NSubstitute.Substitute.For<IPerson>();
            var testName = "Fred";
            //act
            person.Surname = testName;

            //assert
            Assert.IsType<string>(person.Surname);
            Assert.NotNull(person.Surname);
        }
    }


}
