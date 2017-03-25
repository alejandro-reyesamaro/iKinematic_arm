using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PathPlaning
{
    public partial class ConfigForm : Form
    {
        Configuracion config;
        public ConfigForm(Configuracion config)
        {
            InitializeComponent();
            this.config = config;
            cargar_valores();
        }

        private void button_por_defecto_Click(object sender, EventArgs e)
        {
            config.valores_por_defecto();
            cargar_valores();
        }

        private void cargar_valores()
        {
            this.nud_media_gausiana.Value = new Decimal(config.PF_Media_Gausiana);
            this.nud_pf_maximo_iteraciones.Value = new Decimal(config.PF_Maximo_iteraciones);
            this.nud_pf_eps.Value = new Decimal(-Math.Floor(Math.Log10(config.PF_Epsilon)));
            this.nud_numero_particulas.Value = new Decimal(config.PF_Numero_muestras);
            this.nud_g_eps.Value = new Decimal(-Math.Floor(Math.Log10(config.OPT_Gradiente_EPS)));
            this.nud_f_eps.Value = new Decimal(-Math.Floor(Math.Log10(config.OPT_Funcion_EPS)));
            this.nud_x_eps.Value = new Decimal(-Math.Floor(Math.Log10(config.OPT_Punto_EPS)));
            this.nud_opt_maximo_iteraciones.Value = new Decimal(config.OPT_Maximo_iteraciones);
            this.nud_separacion_obstaculos.Value = new Decimal(config.TR_Separacion_Obstaculos);
            this.nud_separacion_nodos.Value = new Decimal(config.TR_Separacion_entre_nodos);
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            config.PF_Media_Gausiana = (double)this.nud_media_gausiana.Value;
            config.PF_Maximo_iteraciones = (int)this.nud_pf_maximo_iteraciones.Value;
            config.PF_Epsilon = Math.Pow(10, -(int)this.nud_pf_eps.Value);
            config.PF_Numero_muestras = (int)this.nud_numero_particulas.Value;
            config.OPT_Gradiente_EPS = Math.Pow(10, -(int)this.nud_g_eps.Value);
            config.OPT_Funcion_EPS = Math.Pow(10, -(int)this.nud_f_eps.Value);
            config.OPT_Punto_EPS = Math.Pow(10, -(int)this.nud_x_eps.Value);
            config.OPT_Maximo_iteraciones = (int)this.nud_opt_maximo_iteraciones.Value;
            config.TR_Separacion_Obstaculos = (double)this.nud_separacion_obstaculos.Value;
            config.TR_Separacion_entre_nodos = (double)this.nud_separacion_nodos.Value;
            this.Close();
        }
    }
}
