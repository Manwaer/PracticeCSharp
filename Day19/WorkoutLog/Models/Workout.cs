using System;
using System.ComponentModel.DataAnnotations;

namespace WorkoutLog.Models
{
    public class Workout
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Дата обязательна")]
        [Display(Name = "Дата тренировки")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Тип тренировки обязателен")]
        [Display(Name = "Тип тренировки")]
        [StringLength(100)]
        public string Type { get; set; }

        [Required(ErrorMessage = "Продолжительность обязательна")]
        [Display(Name = "Продолжительность (минуты)")]
        [Range(1, 500, ErrorMessage = "Продолжительность должна быть от 1 до 500 минут")]
        public int Duration { get; set; }
    }
}