using System;
using System.ComponentModel.DataAnnotations;

namespace FavoriteFilmsMVC.ValidationAttributes
{
    public class ReleaseYearAttribute : ValidationAttribute
    {
        private readonly int _minYear;

        public ReleaseYearAttribute(int minYear = 1895)
        {
            _minYear = minYear;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is int year)
            {
                int currentYear = DateTime.Now.Year;
                if (year < _minYear || year > currentYear)
                {
                    return new ValidationResult(ErrorMessage ?? $"Рік має бути в межах від {_minYear} до {currentYear}.");
                }
            }
            return ValidationResult.Success;
        }
    }
}