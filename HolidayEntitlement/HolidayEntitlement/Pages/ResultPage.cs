// Page Object for the results page
using Microsoft.Playwright;

namespace HolidayEntitlement.Pages
{
    public class ResultPage
    {
        private readonly IPage _browser;
        public ILocator ResultHoursDaysLocator => _browser.Locator("#result-info > div:nth-child(2) > div > div > div.summary > p");
        public ILocator ResultWeeksLocator => _browser.Locator("#result-info > div:nth-child(2) > div > div > p:nth-child(1)");
        public ILocator ResultCompressedLocator => _browser.Locator("#result-info > div:nth-child(2) > div > div > div.summary > p");
        public ResultPage(Hooks.Hooks hooks)
        {
            _browser = hooks.Browser;
        }
    }
}
