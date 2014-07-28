using System;

namespace MvcSample.Web.Services
{
    public class TestContext : ITestContext
    {
        public string GetDate()
        {
            return DateTime.Now.ToString();
        }
    }
}
