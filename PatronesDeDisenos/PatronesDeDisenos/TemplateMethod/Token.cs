using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDisenos.TemplateMethod
{
    abstract class Token
    {
        /*
         * METODOS ABSTRACTOS QUE SE IMPLEMENTAN EN SUBCLASES
         */
        abstract protected string retornarLexema();
        abstract protected string retornarTipo();
        
        /*
         * METODO TEMPLATE QUE SE USA PARA LLAMAR
         * **/
        public string mostrarToken()
        {
            return "Lexema: " + retornarLexema() + " | Tipo: " + retornarTipo() + "\n";
        }
    }
}
