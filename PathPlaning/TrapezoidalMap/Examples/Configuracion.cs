using System;

namespace PathPlaning
{
    public class Configuracion
    {
        public double PF_Media_Gausiana { get; set; }
        public int PF_Maximo_iteraciones { get; set; }
        public double PF_Epsilon { get; set; }
        public int PF_Numero_muestras { get; set; }
        public double OPT_Gradiente_EPS { get; set; }
        public double OPT_Funcion_EPS { get; set; }
        public double OPT_Punto_EPS { get; set; }
        public int OPT_Maximo_iteraciones { get; set; }
        public double TR_Separacion_Obstaculos { get; set; }
        public double TR_Separacion_entre_nodos { get; set; }

        public Configuracion()
        {
            valores_por_defecto();
        }

        internal void valores_por_defecto()
        {
            this.PF_Media_Gausiana = 0.03;
            this.PF_Maximo_iteraciones = 50;
            this.PF_Epsilon = 0.1;
            this.PF_Numero_muestras = 25;
            this.OPT_Gradiente_EPS = Math.Pow(10, -8);
            this.OPT_Funcion_EPS = Math.Pow(10, -8);
            this.OPT_Punto_EPS = Math.Pow(10, -8);
            this.OPT_Maximo_iteraciones = 50;
            this.TR_Separacion_Obstaculos = 3;
            this.TR_Separacion_entre_nodos = 2;
        }
    }
}
