﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Implementation.Models
{
    public class CategoryDTO
    {
        public int? CategoryId { get; set; }
        public string Name { get; set; }
        public IList<TypeDTO> Types;

        public CategoryDTO()
        {
            Types = new List<TypeDTO>();
        }    
    }
}