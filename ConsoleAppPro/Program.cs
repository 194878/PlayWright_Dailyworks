


//playwright startup
using Microsoft.Playwright;

using var playwright = await Playwright.CreateAsync();

await using var browser=await playwright.Chromium.LaunchAsync();