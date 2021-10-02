using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace HR.Application.BusinessService
{
    [MemoryDiagnoser]
    public class Class1
    {
        [Benchmark]
        public void Method()
        {

        }
    }
}
