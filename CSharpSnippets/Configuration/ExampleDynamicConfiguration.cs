using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace CSharpSnippets.Configuration
{
    public class ExampleDynamicConfiguration : IDynamicConfiguration<ExampleConfigurationManager>
    {
        [DefaultSettingValue("True"), SettingsDescription("Turns the Example Feature on.")]
        public virtual bool EnableFeatureExample { get; set; }

        [DefaultSettingValue("30"), SettingsDescription("Gets an Example integer setting value.")]
        public virtual int ExampleIntegerSetting { get; set; }

        /// <summary>
        /// Back GetProperty with a call to a datastore
        /// </summary>
        /// <returns></returns>
        public ExampleConfigurationManager GetProperty()
        {
            return new ExampleConfigurationManager();//Depending on desired setting lifetime maybe make this a singleton.
        }
    }
}
