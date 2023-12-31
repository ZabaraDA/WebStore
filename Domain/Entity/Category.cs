﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
