using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDisenos.StateMethod
{
    class Context
    {
        private Estado estado;

        public Context()
        {
            this.estado = null;
        }

        public void setEstado(Estado estado)
        {
            this.estado = estado;
        }

        public Estado getState()
        {
            return this.estado;
        }
    }
}
