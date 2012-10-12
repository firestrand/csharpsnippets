using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpSnippets.Configuration
{
    /// <summary>
    /// Wrapper around the ConfigurationManager so the configuration manager can be mocked for unit testing.
    /// </summary>
    public class ExampleConfigurationManagerWrapper
    {
        public static Func<ExampleConfigurationManager> Current = () => new ExampleConfigurationManager();

        public static void Reset()
        {
            Current = () => new ExampleConfigurationManager();
        }
    }
}
