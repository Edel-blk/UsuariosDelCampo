using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosDelCampo
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime BornDate { get; set; }
        public string Direction { get; set; }
        public string Country { get; set; }
        public char Genre { get; set; }
        public string ImagePath { get; set; }
        public bool Active { get; set; }
    }
}
