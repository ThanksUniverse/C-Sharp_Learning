using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
public class UrlTests
{
    private const string InvalidUrl = "pedro";
    private const string ValidUrl = "https://pedro.com";

    [TestMethod("Should return exception when url is invalid")]
    [TestCategory("Teste de URL")]
    [ExpectedException(typeof(InvalidUrlException))]
    public void ShouldReturnExceptionWhenUrlIsInvalid()
    {
        new Url(InvalidUrl);
    }

    [TestMethod("Should not return exception when url is valid")]
    [TestCategory("Teste de URL")]
    public void ShouldNotReturnExceptionWhenUrlIsValid()
    {
        new Url(ValidUrl);
        Assert.IsTrue(true);
    }

    [TestMethod]
    [DataRow("", true)]
    [DataRow("http", true)]
    [DataRow("banana", true)]
    [DataRow(ValidUrl, false)]
    public void TestUrl(string link, bool expectException)
    {
        if (expectException)
        {
            try
            {
                new Url(link);
                Assert.Fail();
            }
            catch (InvalidUrlException)
            {
                Assert.IsTrue(true);
            }
        }
    }
}