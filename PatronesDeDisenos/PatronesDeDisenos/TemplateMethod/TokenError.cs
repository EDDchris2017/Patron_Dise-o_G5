using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDisenos.TemplateMethod
{
    class TokenError : Token
    {
        string lexema;

        public TokenError(string lexema)
        {
            this.lexema = lexema;
        }

        protected override string retornarLexema()
        {
            return this.lexema;
        }

        protected override string retornarTipo()
        {
            return "Error";
        }
    }
}
