using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDisenos.TemplateMethod;

namespace PatronesDeDisenos.StateMethod
{
    class Estado_1 : Estado
    {
        int indice;
        String cadena;
        String lexema;

        public Estado_1(int indice, String cadena, string lexema)
        {
            this.indice = indice;
            this.cadena = cadena;
            this.lexema = lexema;
        }

        public void Reconocer(Context context)
        {
            try
            {
                int caracter = (int)this.cadena[indice];

                if((caracter > 96 && caracter < 123) || (caracter > 47 && caracter < 58))
                {
                    lexema += this.cadena[indice];
                    Estado_1 e1 = new Estado_1(indice + 1, cadena, lexema);
                    e1.Reconocer(context);
                }
                else
                {
                    Token t = new TokenId(lexema);

                    Estatico.t.Text +=  t.mostrarToken();

                    lexema = "";
                    Estado_0 e0 = new Estado_0(indice, cadena, lexema);
                    e0.Reconocer(context);
                }

            }
            catch(Exception e)
            {
                Token t = new TokenId(lexema);

                Estatico.t.Text += t.mostrarToken();
            }
        }
    }
}
