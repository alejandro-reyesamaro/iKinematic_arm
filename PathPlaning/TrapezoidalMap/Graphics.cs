﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace PathPlaning
{
    public partial class Graphics : Form
    {
        private readonly Aplicador ap;

        public Graphics()
        {
            InitializeComponent();
            ap = new Aplicador(this.zedGraphControl1, this.treeView1, this.ProgressBar);
            //ap.CorrerEjemplo(this.zedGraphControl1, this.treeView1);
            botones(true);
            this.zedGraphControl1.GraphPane.Title.IsVisible = false;
            this.zedGraphControl1.GraphPane.XAxis.Title.IsVisible = false;
            this.zedGraphControl1.GraphPane.YAxis.Title.IsVisible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.zedGraphControl1.SaveAsBitmap();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            this.zedGraphControl1.GraphPane.CurveList.Clear();
            this.zedGraphControl1.Refresh();
            botones(false);
        }

        private void botones(bool enable)
        {
            this.button_rangos.Enabled = enable;
            this.button_trapMap.Enabled = enable;
            this.button_Trayectoria.Enabled = enable;            
            this.button_optimas.Enabled = enable;
        }

        private void ejemplo_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            botones(true);

            this.zedGraphControl1.GraphPane.CurveList.Clear();            
            var sub_menu = (ToolStripMenuItem)sender;
            
            string text = sub_menu.Text;
            this.treeView1.Nodes.Clear();
            switch (text)
            {
                case "Ejemplo 1":                        
                    this.ap.Cargar_Ejemplo1();
                    break;
                case "Ejemplo 2":
                    this.ap.Cargar_Ejemplo2();
                    break;
                case "Ejemplo 3":
                    this.ap.Cargar_Ejemplo3();
                    break;
                case "Ejemplo 4":
                    this.ap.Cargar_Ejemplo4();
                    break;
                case "Ejemplo 5":
                    this.ap.Cargar_Ejemplo5();
                    break;
                case "Ejemplo 6":
                    this.ap.Cargar_Ejemplo6();
                    break;
                case "Ejemplo 7":
                    this.ap.Cargar_Ejemplo7();
                    break;
                default:
                    break;
            }
            this.zedGraphControl1.Refresh();
        }

        private void button_trapMap_Click(object sender, EventArgs e)
        {
            this.ap.Publicar_Mapa_Trapezoidal();
            this.zedGraphControl1.Refresh();
        }

        private void button_Trayectoria_Click(object sender, EventArgs e)
        {
            this.ap.Publicar_Mapa_Trayectoria();
            this.zedGraphControl1.Refresh();
        }

        private void button_rangos_Click(object sender, EventArgs e)
        {
            this.ap.Publicar_Rango_Nodos();
            this.zedGraphControl1.Refresh();
        }

        private void button_optimas_Click(object sender, EventArgs e)
        {
            double d = this.ap.Publicar_Mapa_Trayectoria_Optima();
            MessageBox.Show(this, string.Format("Total optimal path distance: {0}", d));
            this.zedGraphControl1.Refresh();
        }

        private void button_secuencias_Click(object sender, EventArgs e)
        {
            this.listBoxDistancias.Items.Clear();
            this.listBoxIteraciones.Items.Clear();
            //this.th_pf.Start();
            Poner_proximas_Secuencias();
        }

        private void Poner_proximas_Secuencias()
        {
            int a = Environment.TickCount;
            string r = this.ap.Proximas_Secuencias_de_movimiento(this.listBoxDistancias, this.listBoxIteraciones);
            int b = Environment.TickCount;
            int segs = (b - a)/1000;
            this.zedGraphControl1.Refresh();
            MessageBox.Show(this, string.Format("Tiempo: {0} segundos.\n{1}", segs, r));
        }

        private void button_config_Click(object sender, EventArgs e)
        {
            var cf = new ConfigForm(this.ap.Configuracion);
            cf.ShowDialog(this);
        }

        private void ejemplo1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ap.Cargar_Obstaculo_Crecido();
        }
    }
}
