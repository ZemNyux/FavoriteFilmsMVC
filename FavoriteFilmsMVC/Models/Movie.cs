using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using FavoriteFilmsMVC.ValidationAttributes;

namespace FavoriteFilmsMVC.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Назва фільму є обов'язковою.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Назва має містити від 2 до 100 символів.")]
        [Display(Name = "Назва фільму")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Режисер є обов'язковим.")]
        [StringLength(100, ErrorMessage = "Ім'я режисера не повинно перевищувати 100 символів.")]
        [Display(Name = "Режисер")]
        public string Director { get; set; } = string.Empty;

        [Required(ErrorMessage = "Жанр є обов'язковим.")]
        [StringLength(50, ErrorMessage = "Жанр не повинен перевищувати 50 символів.")]
        [Display(Name = "Жанр")]
        public string Genre { get; set; } = string.Empty;

        [Required(ErrorMessage = "Вкажіть рік випуску.")]
        [ReleaseYear(1895, ErrorMessage = "Рік випуску некоректний.")]
        [Display(Name = "Рік випуску")]
        public int ReleaseYear { get; set; }

        [Required(ErrorMessage = "Вкажіть рейтинг.")]
        [Range(1.0, 10.0, ErrorMessage = "Рейтинг має бути від 1.0 до 10.0.")]
        [Display(Name = "Рейтинг")]
        public double Rating { get; set; }

        [StringLength(1000, ErrorMessage = "Опис не повинен перевищувати 1000 символів.")]
        [Display(Name = "Опис")]
        public string? Description { get; set; }

        [Display(Name = "Посилання на постер")]
        public string? PosterUrl { get; set; }

        [NotMapped]
        [Display(Name = "Файл постера")]
        public IFormFile? PosterFile { get; set; }
    }
}