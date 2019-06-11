using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioPlayer
{
    public class Radio
    {
        public string nomeRadio { get; set; }
        public string IpRadio { get; set; }
        public string pais { get; set; }
        public string genero { get; set; }


        public Radio()
        {

        }     

        public Radio(string nomeRadio, string ipRadio, string pais, string genero)
        {
            this.nomeRadio = nomeRadio;
            IpRadio = ipRadio;
            this.pais = pais;
            this.genero = genero;
        }
    }
}
