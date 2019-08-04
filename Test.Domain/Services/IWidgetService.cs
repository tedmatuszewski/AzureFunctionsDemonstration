using System.Collections.Generic;
using Test.DTO.Types;

namespace Test.Domain.Services
{
    public partial interface ITestService
    {
        List<WeatherDTO> SendAllWidgetEmails();
    }
}
