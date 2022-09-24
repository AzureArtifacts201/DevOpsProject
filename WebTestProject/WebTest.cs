using System.Reflection.Metadata.Ecma335;
using WebApp.Module;
namespace WebTestProject
{
    public class WebTest
    {
        [Fact]
        public void WebTestMethod()
        {
            int i = 1;
            bool result = false;
            if (i == 1)
                result = true;
            Assert.True(result, "value should be equal to  1");
        }
        [Fact]
        public void CheckAddTest()
        {
            Functions func = new ();
            bool result = false;
            int y = func.AddNumber(4, 7);
            if (y == 11)
                result = true;
            Assert.True(result, "value should be equal to  1");
        }
    }
}