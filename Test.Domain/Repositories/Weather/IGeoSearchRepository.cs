using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.Repositories.Weather
{
    public interface IGeoSearchRepository
    {
        Task<string> Get(string city, string state, string country, double? days);
    }
}
