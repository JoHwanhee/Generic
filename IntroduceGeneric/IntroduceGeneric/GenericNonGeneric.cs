using System;
using System.Diagnostics;

namespace IntroduceGeneric
{
    public class GenericNonGeneric
    {
        System.Collections.Generic.List<int> listGeneric = new System.Collections.Generic.List<int> { 5, 9, 1, 4 };
        System.Collections.ArrayList listNonGeneric = new System.Collections.ArrayList { 5, 9, 1, 4 };

        public void Run()
        {
            WhatTimeGenericSort(listGeneric);
            WhatTimeNonGenericSort(listNonGeneric);
        }

        public void WhatTimeNonGenericSort(System.Collections.ArrayList listNonGeneric)
        {
            Stopwatch s2 = Stopwatch.StartNew();
            listNonGeneric.Sort();
            s2.Stop();
            Console.WriteLine($"Non-Generic Sort: {listNonGeneric}  \n Time taken: {s2.Elapsed.TotalMilliseconds}ms");
        }

        public void WhatTimeGenericSort(System.Collections.Generic.List<int> listGeneric)
        {
            Stopwatch s = Stopwatch.StartNew();
            listGeneric.Sort();
            s.Stop();
            Console.WriteLine($"Generic Sort: {listGeneric}  \n Time taken: {s.Elapsed.TotalMilliseconds}ms");
        }
    }
}