using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDisenos.StateMethod
{
    class Estado_0 : Estado
    {
        int indice;
        String cadena;
        String lexema;

        public Estado_0(int indice, String cadena, String lexema)
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

                if (caracter > 96 && caracter < 123)
                {
                    //LETRA
                    lexema += this.cadena[indice];
                    Estado_1 e1 = new Estado_1(indice + 1, cadena, lexema);
                    e1.Reconocer(context);
                }
                else if (caracter > 47 && caracter < 58)
                {
                    lexema += this.cadena[indice];
                    Estado_2 e2 = new Estado_2(indice + 1, cadena, lexema);
                    e2.Reconocer(context);
                }
                else if (caracter == 32)
                {
                    lexema = "";
                    Estado_0 e0 = new Estado_0(indice + 1, cadena, lexema);
                    e0.Reconocer(context);
                }
                else
                {
                    lexema += this.cadena[indice];
                    Estado_Error err = new Estado_Error(indice + 1, cadena, lexema);
                    err.Reconocer(context);
                }
            }
            catch(Exception e)
            {

            }
        }
    }
}
