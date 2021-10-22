using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{
    public class Animal
    {
        private string _name;
        public string name { get { return this._name; } set { this._name = value.ToUpper(); } }

        private string _type;

        public string type
        {
            get { return this._type; }
            set
            {
                if (value == "CACHORRO" || value == "GATO" || value == "PEIXE")
                {
                    _type = value.ToUpper();
                }
                else
                {
                    _type = "Peixe".ToUpper();
                }
            }
        }

    }
}
