﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mvc_project1.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(10)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="Display Order Must Be Between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
