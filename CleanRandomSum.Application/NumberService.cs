using CleanRandomSum.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanRandomSum.Application
{
    public class NumberService : INumberService
    {
        private readonly INumberRepository _numberRepository;
        public NumberService(INumberRepository numberRepository)
        {
            _numberRepository = numberRepository;
        }
        public List<Number> GetSum()
        {
            var numbers = _numberRepository.GetSum();
            return numbers;
        }
    }
}
