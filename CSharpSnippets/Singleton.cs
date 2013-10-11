using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpSnippets
{
    public sealed class Singleton
    {
        private static volatile Singleton _instance;
        private static readonly object SyncRoot = new object();

        private Singleton(){}

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (SyncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
