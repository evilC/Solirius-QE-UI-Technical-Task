// Used to inject browser context into steps
using Microsoft.Playwright;

namespace HolidayEntitlement.Hooks
{
    [Binding]
    public class Hooks
    {
        public IPage Browser { get; private set; } = null!;

        [BeforeScenario]
        public async Task BeforeScenario()
        {
            //Initialise Playwright
            var playwright = await Playwright.CreateAsync();
            //Initialise a browser - 'Chromium' can be changed to 'Firefox' or 'Webkit'
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });
            //Setup a browser context
            var context = await browser.NewContextAsync();

            //Initialise a page on the browser context.
            Browser = await context.NewPageAsync();
        }
    }
}
