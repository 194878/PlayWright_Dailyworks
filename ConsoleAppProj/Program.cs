

using Microsoft.Playwright;


 
    //playwright startup
    using var playwright = await Playwright.CreateAsync();

    //launch browser
    await using var browser = await playwright.Chromium.LaunchAsync();

    //page instance
    var context = await browser.NewContextAsync();
    var page = await context.NewPageAsync();

    Console.WriteLine("opened browser");
    await page.GotoAsync("https://www.google.com");
    Console.WriteLine("page loaded");
string title=await page.TitleAsync();

//await page.GetByTitle("Search").FillAsync("hp laptop");

await page.Locator("#APjFqb").FillAsync("selenium");
Console.WriteLine("typed");
await page.Locator("//input[@value='Google Search'])[2]").ClickAsync();
Console.WriteLine("clicked");