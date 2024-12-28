using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFromCSV
{
    internal class Iris
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public double Sepallenght { get; set; }
        [Required]
        public double SepalWight { get; set; }
        [Required]
        public double Petallenght { get; set; }
        [Required]
        public double PetalWight { get; set; }
        [Required]
        public string? Veriety { get; set; }

    }
}
