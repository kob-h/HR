using System;
using BenchmarkDotNet.Running;
using HR.Application.BusinessService.Employees;

namespace Benchmarker
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run(typeof(GetAllEmployees));
        }
    }
}
