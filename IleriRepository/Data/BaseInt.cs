﻿using System.ComponentModel.DataAnnotations;

namespace IleriRepository.Data
{
    public class BaseInt
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
