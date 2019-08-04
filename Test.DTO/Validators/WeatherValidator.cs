using FluentValidation;
using FluentValidation.Results;
using Test.DTO.Types;

namespace Test.DTO.Validators
{
    public class WeatherValidator : AbstractValidator<WeatherDTO>
    {
        public static ValidationResult IsValid(WeatherDTO dto)
        {
            var validator = new WeatherValidator();
            var validation = validator.Validate(dto);

            return validation;
        }

        public WeatherValidator()
        {

        }
    }
}
