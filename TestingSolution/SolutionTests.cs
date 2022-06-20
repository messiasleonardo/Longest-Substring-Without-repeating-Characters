using Xunit;

namespace TestingSolution
{
    public class SolutionTests
    {

        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData(" ", 1)]
        [InlineData("au", 2)]
        [InlineData("dvdf", 3)]
        [InlineData("inylowrotfvusctfijdsdggfnbxnbqsjfqwupokitgcmiwtthxlnfruvt", 14)]
        public void Test1(string s, int expected)
        {
            Solution solution = new Solution();
            //Arrage

            //Act
            int actual = solution.LengthOfLongestSubstring(s);
            //Assert
            Assert.Equal(expected,actual);
        }
    }
}