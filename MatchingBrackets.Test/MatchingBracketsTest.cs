namespace MatchingBrackets.Test
{
    public class MatchingBracketsTest
    {
        [Fact]
        public void IsMatchingBracketsTest() { 
            var matchingBrackets = new MatchingBrackets();

            Assert.True(matchingBrackets.IsMatchingBrackets("{}"));
            Assert.False(matchingBrackets.IsMatchingBrackets("}{"));
            Assert.False(matchingBrackets.IsMatchingBrackets("{{}"));
            Assert.False(matchingBrackets.IsMatchingBrackets("{}}"));
            Assert.True(matchingBrackets.IsMatchingBrackets(""));
            Assert.True(matchingBrackets.IsMatchingBrackets("{abc...xyz}"));
        }
    }
}
