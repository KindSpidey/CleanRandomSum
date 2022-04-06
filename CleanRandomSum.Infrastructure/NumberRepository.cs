using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanRandomSum.Application;
using CleanRandomSum.Domain;

namespace CleanRandomSum.Infrastructure
{
    public class NumberRepository : INumberRepository
    {
        public static List<Number> numbers = new List<Number>()
        {
            new Number{Digit = new Random().Next(-100, 100), DigitName = "First Digit"},
            new Number{Digit = new Random().Next(-100, 100), DigitName = "Second Digit" },
            new Number{Digit = new Random().Next(-100, 100), DigitName = "Third Digit" }
        };
        public List<Number> GetSum()
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number.Digit;
            }
            numbers.Add(new Number { Digit = sum, DigitName = "Sum" });
            return numbers;
        }
    }
}
