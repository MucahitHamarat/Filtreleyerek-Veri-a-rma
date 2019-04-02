using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF1.Data.Entity
{
    class Personel
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DepartmanID { get; set; }
        public Departman departman { get; set; }
    }
}
