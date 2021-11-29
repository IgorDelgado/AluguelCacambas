using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aluguel.Models.Consulta
{
    public class AlugaGrup
    {
        public int ID { get; set; }

        public string NomeColaborador { get; set; }
        public string Cacamba { get; set; }
        public string CodigoCacamba { get; set; }

        public DateTime Data_aluguel { get; set; }
        public DateTime Data_devolucao { get; set; }

       

        
    }
}
