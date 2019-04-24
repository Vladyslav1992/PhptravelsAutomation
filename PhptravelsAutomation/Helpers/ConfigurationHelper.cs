using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace PhptravelsAutomation.Helpers
{
    class ConfigurationHelper
    {
        public static string GetHomeUrl()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
                .Build();

            var generalSettings = configuration.GetSection("GeneralSettings");
            var homeUrl = generalSettings["homeurl"];

            return homeUrl;
        }
    }
}
