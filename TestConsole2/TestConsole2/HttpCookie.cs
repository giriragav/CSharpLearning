using System;
using System.Collections.Generic;

namespace TestConsole2
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public string this[string key]
        {
            get
            {
                return this.dictionary[key];
            }
            set
            {
                this.dictionary[key] = value;
            }
        }
    }
}
