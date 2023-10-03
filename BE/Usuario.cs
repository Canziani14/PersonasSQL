using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {

        public delegate void esMenorDelegate(int edad);
        public event esMenorDelegate esMenor;

        public int ID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string domicilio { get; set; }

        private int _edad;
        public int edad
        {
            get { return _edad; }
            set
            {
                if (value < 18)
                {

                    if (esMenor != null)
                    {
                        esMenor(value);
                    }
                }
                else 
                {
                    _edad = value;
                }
                
                   
                    
                
            }
        }




    }
}
