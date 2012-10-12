using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;

namespace CSharpSnippets.Configuration
{
    public class ExampleConfigurationManager
    {
        public virtual NameValueCollection AppSettings
        {
            get
            {
                return ConfigurationManager.AppSettings;
            }
        }

        public virtual ConnectionStringSettingsCollection ConnectionStrings
        {
            get
            {
                return ConfigurationManager.ConnectionStrings;
            }
        }
    }
}
