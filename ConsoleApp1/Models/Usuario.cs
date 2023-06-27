using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Usuario
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(20)")]

        public string Name { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(20)")]

        public string Lastname { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(20)")]

        public string Direccion { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(40)")]

        public string Phone { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(10)")]

        public string Birthday { get; set; }
        [Required]
        [Column(TypeName = "VARCHAR(10)")]

        public Boolean Status { get; set; }

    }
}

