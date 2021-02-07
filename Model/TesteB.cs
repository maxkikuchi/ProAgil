using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProAgil.WebAPI.Model
{
    public class TesteB
    {
        [Key]
        public int TesteId { get; set; }
        public string Nome { get; set; }
    }
}
