using System;
using System.Collections.Generic;

namespace ThreadStackTest
{
    class Program
    {
        static void Recursive(int value)
        {
            // Write call number and call this method again.
            // ... The stack will eventually overflow.
            //Console.WriteLine(value);
            while (true)
            {
                object o = new object();
            }
        }

        public int Counter { get; set; }
        public int Counter1 { get; set; }
        public int Counter2 { get; set; }
        public int Counter3 { get; set; }
        public int Counter4 { get; set; }

        public List<object> MyPropertyTest { get; set; }

        public List<object> MyProperty
        {
            get
            {
                if (_Property == null)
                {
                    _Property = new List<object>();
                }
                Console.WriteLine(++Counter);
                return MyProperty;
            }
        }

        public List<object> _Property;

        /// <summary>
        /// Care about the things you have to return: Production-run real sample
        /// </summary>
        static void Main()
        {
            var test = new Program().MyProperty;
            // Begin the infinite recursion.
        }
    }
}
