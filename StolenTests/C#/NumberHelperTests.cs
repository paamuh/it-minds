using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace StolenTests
{
    public class NumberHelperTests
    {
        /*
        * This section contains a very basic test example.
        * The test in this document should be re-written, as it does not represent best practices
        */


        [Fact]
        public void TestFindNumberWhenInList()
        {
            //Arrange
            var haystackExample = new List<int> { 1, 2, 3 };
            const int needle = 1;
            const int numbersReturned = 1;

            var helper = new NumberHelper();

            int expected = 1;

            //Act
            var result = helper.FindClosestNumbers(needle, haystackExample, numbersReturned);

            
            //Assert
            Assert.Equal(expected, result.Single());
        }

        [Fact]
        public void TestFindTwoClosestNumbersWhenInList()
        {
            //Arrange
            var haystackExample = new List<int> { 1, 2, 5, 3 };
            const int needle = 1;
            const int numbersReturned = 2;

            var helper = new NumberHelper();

            var expected = new List<int> { 1, 2 };
            var result = new List<int>();
            //Act
            result = helper.FindClosestNumbers(needle, haystackExample, numbersReturned).ToList();


            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestFindClosestNumberWhenNotInList()
        {
            //Arrange
            var haystackExample = new List<int> { 4, 5 };
            const int needle = 6;
            const int numbersReturned = 1;

            var helper = new NumberHelper();

            int expected = 5;

            //Act
            var result = helper.FindClosestNumbers(needle, haystackExample, numbersReturned);

            //Assert
            Assert.Equal(expected, result.Single());
        }

        [Fact]
        public void TestFindTwoClosestNumberWhenNotInList()
        {
            var haystackExample = new List<int> { 2, 3, 10 };
            const int needle = 11;
            const int numbersReturned = 2;

            var helper = new NumberHelper();

            var expected = new List<int> { 10, 3 };

            var result = helper.FindClosestNumbers(needle, haystackExample, numbersReturned);

            Assert.Equal(expected, result);

        }

    }
}
