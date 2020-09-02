using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System;

namespace Classes.Heranca
{
    public class Ponto
    {
        public int x, y;
        
        private int distancia;

        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected void CalcularDistancia()
        {

        }

        private void CalcularDistancia2()
        {
            
        }

        public virtual void CalcularDistancia3()
        {
            
        }


    }
}