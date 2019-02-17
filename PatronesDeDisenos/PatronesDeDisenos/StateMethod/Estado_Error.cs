using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDisenos.TemplateMethod;
namespace PatronesDeDisenos.StateMethod
{
    class Estado_Error : Estado
    {
        int indice;
        String cadena;
        String lexema;
        public Estado_Error(int indice, String cadena, String lexema)
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

                Token t = new TokenError(lexema);

                Estatico.t.Text += t.mostrarToken();

                lexema = "";
                Estado_0 e0 = new Estado_0(indice + 1, cadena, lexema);
                e0.Reconocer(context);
            }
            catch(Exception e)
            {
                Token t = new TokenError(lexema);

                Estatico.t.Text += t.mostrarToken();
            }
        }
    }
}
