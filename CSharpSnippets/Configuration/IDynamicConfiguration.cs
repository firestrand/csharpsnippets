using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpSnippets.Configuration
{
    public interface IDynamicConfiguration<out T>
	{
		T GetProperty();
	}
}
