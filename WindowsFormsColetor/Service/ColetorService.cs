using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace WindowsFormsColetor.Service
{
    class ColetorService
    {

        public String getURL() {

            return ConfigurationManager.AppSettings.Get("URL");
        }
    }
}
