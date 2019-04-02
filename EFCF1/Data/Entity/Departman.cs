using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF1.Data.Entity
{
    class Departman
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public List<Personel>  personels{ get; set; }
    }
}
