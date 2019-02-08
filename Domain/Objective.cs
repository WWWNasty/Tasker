using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Objective
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Задача")]
        [MaxLength(200)]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:U}")]
        public DateTime StarDate { get; set; } = DateTime.UtcNow;

        [DisplayName("Выполнено")]
        public bool Completed { get; set; }

        public override string ToString()
        {
            return $"{Id}. {Name} {StarDate.ToLocalTime()}";
        }
    }


}