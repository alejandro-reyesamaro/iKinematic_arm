using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathPlaning
{
    public class Configuracion
    {
        private double media_gausiana;
        public double PF_Media_Gausiana 
        {
            get{ return this.media_gausiana; }
            set{ this.media_gausiana = value; }
        }
        private int maximo_iteraciones;
        public int PF_Maximo_iteraciones
        {
            get { return this.maximo_iteraciones; }
            set { this.maximo_iteraciones = value; }
        }
        private double epsilon;
        public double PF_Epsilon
        {
            get { return this.epsilon; }
            set { this.epsilon = value; }
        }
        private int numero_samples;
        public int PF_Numero_muestras
        {
            get { return this.numero_samples; }
            set { this.numero_samples = value; }
        }

        private double g_eps;
        public double OPT_Gradiente_EPS
        {
            get { return this.g_eps; }
            set { this.g_eps = value; }
        }
        private double f_eps;
        public double OPT_Funcion_EPS
        {
            get { return this.f_eps; }
            set { this.f_eps = value; }
        }
        private double x_eps;
        public double OPT_Punto_EPS
        {
            get { return this.x_eps; }
            set { this.x_eps = value; }
        }
        private int opt_maximo_iteraciones;
        public int OPT_Maximo_iteraciones
        {
            get { return this.opt_maximo_iteraciones; }
            set { this.opt_maximo_iteraciones = value; }
        }
        private double separacion_Obstaculos;
        public double TR_Separacion_Obstaculos
        {
            get { return this.separacion_Obstaculos; }
            set { this.separacion_Obstaculos = value; }
        }
        private double separacion_entre_nodos;
        public double TR_Separacion_entre_nodos
        {
            get { return this.separacion_entre_nodos; }
            set { this.separacion_entre_nodos = value; }
        }

        public Configuracion()
        {
            valores_por_defecto();
        }

        internal void valores_por_defecto()
        {
            this.media_gausiana = 0.03;
            this.maximo_iteraciones = 50;
            this.epsilon = 0.1;
            this.numero_samples = 25;
            this.g_eps = Math.Pow(10, -8);
            this.f_eps = Math.Pow(10, -8);
            this.x_eps = Math.Pow(10, -8);
            this.opt_maximo_iteraciones = 50;
            this.separacion_Obstaculos = 3;
            this.separacion_entre_nodos = 2;
        }
    }
}
