using System;
using Microsoft.Extensions.DependencyInjection;
using sample_class_lib;

namespace sample_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from my sample console app!");

            var serviceProvider = new ServiceCollection()
                .AddSingleton<ICalculator, Calculator>()
                .AddSingleton<ICalculatorService, CalculatorService>()
                .BuildServiceProvider();

            var calculatorService 
              = serviceProvider.GetService<ICalculatorService>();
            var result = calculatorService.GetSum(10.5, 2.4);

            Console.WriteLine($"Total is : {result}");
        }
    }
}
