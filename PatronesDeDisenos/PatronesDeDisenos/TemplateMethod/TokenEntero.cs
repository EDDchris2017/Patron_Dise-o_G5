using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDisenos.TemplateMethod
{
    class TokenEntero : Token
    {
        String lexema;
        public TokenEntero(String lexema)
        {
            this.lexema = lexema;
        }

        protected override string retornarLexema()
        {
            return this.lexema;
        }

        protected override string retornarTipo()
        {
            return "Entero";
        }
    }
}
