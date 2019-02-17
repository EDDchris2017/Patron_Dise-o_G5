using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDisenos.TemplateMethod
{
    class TokenId : Token
    {
        String lexema;

        public TokenId(String lexema)
        {
            this.lexema = lexema;
        }

        protected override string retornarLexema()
        {
            return this.lexema;
        }

        protected override string retornarTipo()
        {
            return "ID";
        }
    }
}
