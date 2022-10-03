using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiagoDonasVieira_d7_avaliacao.Data
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UserLogin { get; set; }
        public string Password { get; set; }
    }
}
