using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAgil.WebAPI.Model
{
    public class Teste
    {
        public int TesteId { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdPerguntas { get; set; }
        public string LotePerguntas { get; set; }
    }
}
