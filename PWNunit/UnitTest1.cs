using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PWNunit
{
    public class GHPTests:PageTest
    {
        [SetUp]
        public void Setup()
        {
        }
        /*
       //manual instance
        [Test]
       
        public async Task Test1()
        {
            //playwright startup 
           using  var playwright=await Playwright.CreateAsync();

            //launch browser
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless =false
                    });

            //page instance
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();

            Console.WriteLine("opened browser");
            await page.GotoAsync("https://www.google.com");
            Console.WriteLine("page loaded");
            string title = await page.TitleAsync();
            Console.WriteLine(title);


            //await page.GetByTitle("Search").FillAsync("hp laptop");

            await page.Locator("#APjFqb").FillAsync("selenium");
            Console.WriteLine("typed");
           await page.Locator("(//input[@value='Google Search'])[2]").ClickAsync();
            Console.WriteLine("clicked");

            title= await page.TitleAsync();
            Console.WriteLine(title);
        }
        */
        [Test]
        public async Task Test2()
        {

            Console.WriteLine("opened browser");
            await Page.GotoAsync("https://www.google.com");
            Console.WriteLine("page loaded");
            string title = await Page.TitleAsync();
            Console.WriteLine(title);


            //await page.GetByTitle("Search").FillAsync("hp laptop");

            await Page.Locator("#APjFqb").FillAsync("selenium");
            Console.WriteLine("typed");
            await Page.Locator("(//input[@value='Google Search'])[2]").ClickAsync();
            Console.WriteLine("clicked");

            //title=await Page.TitleAsync();
            //Console.WriteLine(title);

           // Assert.That(title.Contains("selenium"));
            await Expect(Page).ToHaveTitleAsync("selenium - Google Search");
          
        }

    }
}