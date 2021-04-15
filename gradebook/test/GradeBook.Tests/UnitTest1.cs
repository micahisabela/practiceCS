using System;
using Xunit; // contains types and APIs to use when using xunit

namespace GradeBook.Tests
{
    public class UnitTest1
    {
        [Fact] // this is an attribute - a piece of data that is attached the symbol that follows it. in this case, it is attached to Test1 (below)
        public void Test1()
        {
            // arrange:
            var x = 5;
            var y = 2;
            var expected = 7;

            // act
            var actual = x + y;
            
            // assert 
            Assert.Equal(expected, actual);
        }
    }
}
