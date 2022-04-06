using CleanRandomSum.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanRandomSum.Application
{
    public interface INumberService
    {
        List<Number> GetSum();
    }
}
