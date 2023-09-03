using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core.Tests;

[TestClass]
public class UtmTests
{
    private const string ValidUrl = "https://www.example.com";
    private const string Result = $"{ValidUrl}?utm_source=src&utm_medium=med&utm_campaign=nme&utm_id=id&utm_term=term&utm_content=cnt";
    private readonly Url _url = new(ValidUrl);
    private readonly Campaign _campaign = new("src", "med", "nme", "id", "term", "cnt");
    
    [TestMethod]
    public void ShouldReturnUrlFromUtm()
    {
        var utm = new Utm(_url, _campaign);
        Assert.AreEqual(Result, utm.ToString());
        Assert.AreEqual(Result, (string)utm);
        
    }
    
    [TestMethod]
    public void ShouldReturnUtmFromUrl()
    {
        Utm utm = Result;
        Assert.AreEqual(ValidUrl, utm.Url.Address);
        Assert.AreEqual("src", utm.Campaign.Source);
        Assert.AreEqual("med", utm.Campaign.Medium);
        Assert.AreEqual("nme", utm.Campaign.Name);
        Assert.AreEqual("id", utm.Campaign.Id);
        Assert.AreEqual("term", utm.Campaign.Term);
        Assert.AreEqual("cnt", utm.Campaign.Content);
    }

}