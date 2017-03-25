namespace PathPlaning
{
    partial class Graphics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private ZedGraph.ZedGraphControl zedGraphControl1;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxDistancias = new System.Windows.Forms.ListBox();
            this.listBoxIteraciones = new System.Windows.Forms.ListBox();
            this.button_secuencias = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button_optimas = new System.Windows.Forms.Button();
            this.button_rangos = new System.Windows.Forms.Button();
            this.button_Trayectoria = new System.Windows.Forms.Button();
            this.button_trapMap = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_config = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cargarEjemploToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplo3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplo4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.cargarEjemploAlcanzableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplo5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplo6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplo7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControl1.IsSynchronizeXAxes = true;
            this.zedGraphControl1.IsZoomOnMouseCenter = true;
            this.zedGraphControl1.Location = new System.Drawing.Point(12, 31);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0;
            this.zedGraphControl1.ScrollMaxX = 0;
            this.zedGraphControl1.ScrollMaxY = 0;
            this.zedGraphControl1.ScrollMaxY2 = 0;
            this.zedGraphControl1.ScrollMinX = 0;
            this.zedGraphControl1.ScrollMinY = 0;
            this.zedGraphControl1.ScrollMinY2 = 0;
            this.zedGraphControl1.Size = new System.Drawing.Size(632, 422);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.ZoomButtons2 = System.Windows.Forms.MouseButtons.Middle;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Controls.Add(this.button_optimas);
            this.groupBox1.Controls.Add(this.button_rangos);
            this.groupBox1.Controls.Add(this.button_Trayectoria);
            this.groupBox1.Controls.Add(this.button_trapMap);
            this.groupBox1.Controls.Add(this.button_clear);
            this.groupBox1.Controls.Add(this.button_config);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(650, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(6, 187);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.treeView1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(257, 233);
            this.splitContainer1.SplitterDistance = 140;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.listBoxDistancias);
            this.groupBox2.Controls.Add(this.listBoxIteraciones);
            this.groupBox2.Controls.Add(this.button_secuencias);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 140);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Brazo ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Distancia alcanzada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Iteraciones:";
            // 
            // listBoxDistancias
            // 
            this.listBoxDistancias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxDistancias.FormattingEnabled = true;
            this.listBoxDistancias.Location = new System.Drawing.Point(130, 61);
            this.listBoxDistancias.Name = "listBoxDistancias";
            this.listBoxDistancias.Size = new System.Drawing.Size(121, 56);
            this.listBoxDistancias.TabIndex = 4;
            // 
            // listBoxIteraciones
            // 
            this.listBoxIteraciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxIteraciones.FormattingEnabled = true;
            this.listBoxIteraciones.Location = new System.Drawing.Point(6, 61);
            this.listBoxIteraciones.Name = "listBoxIteraciones";
            this.listBoxIteraciones.Size = new System.Drawing.Size(118, 56);
            this.listBoxIteraciones.TabIndex = 3;
            // 
            // button_secuencias
            // 
            this.button_secuencias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_secuencias.Location = new System.Drawing.Point(6, 19);
            this.button_secuencias.Name = "button_secuencias";
            this.button_secuencias.Size = new System.Drawing.Size(245, 23);
            this.button_secuencias.TabIndex = 2;
            this.button_secuencias.Text = "Siguiente secuencia de movimiento >>";
            this.button_secuencias.UseVisualStyleBackColor = true;
            this.button_secuencias.Click += new System.EventHandler(this.button_secuencias_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(257, 89);
            this.treeView1.TabIndex = 0;
            // 
            // button_optimas
            // 
            this.button_optimas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_optimas.Enabled = false;
            this.button_optimas.Location = new System.Drawing.Point(6, 100);
            this.button_optimas.Name = "button_optimas";
            this.button_optimas.Size = new System.Drawing.Size(257, 23);
            this.button_optimas.TabIndex = 1;
            this.button_optimas.Text = "Trayectoria óptima";
            this.button_optimas.UseVisualStyleBackColor = true;
            this.button_optimas.Click += new System.EventHandler(this.button_optimas_Click);
            // 
            // button_rangos
            // 
            this.button_rangos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_rangos.Enabled = false;
            this.button_rangos.Location = new System.Drawing.Point(6, 71);
            this.button_rangos.Name = "button_rangos";
            this.button_rangos.Size = new System.Drawing.Size(257, 23);
            this.button_rangos.TabIndex = 1;
            this.button_rangos.Text = "Rango de movimiento de los nodos";
            this.button_rangos.UseVisualStyleBackColor = true;
            this.button_rangos.Click += new System.EventHandler(this.button_rangos_Click);
            // 
            // button_Trayectoria
            // 
            this.button_Trayectoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Trayectoria.Enabled = false;
            this.button_Trayectoria.Location = new System.Drawing.Point(6, 42);
            this.button_Trayectoria.Name = "button_Trayectoria";
            this.button_Trayectoria.Size = new System.Drawing.Size(257, 23);
            this.button_Trayectoria.TabIndex = 1;
            this.button_Trayectoria.Text = "Mapa de Trayectorias";
            this.button_Trayectoria.UseVisualStyleBackColor = true;
            this.button_Trayectoria.Click += new System.EventHandler(this.button_Trayectoria_Click);
            // 
            // button_trapMap
            // 
            this.button_trapMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_trapMap.Enabled = false;
            this.button_trapMap.Location = new System.Drawing.Point(6, 13);
            this.button_trapMap.Name = "button_trapMap";
            this.button_trapMap.Size = new System.Drawing.Size(257, 23);
            this.button_trapMap.TabIndex = 1;
            this.button_trapMap.Text = "Mapa Trapezoidal";
            this.button_trapMap.UseVisualStyleBackColor = true;
            this.button_trapMap.Click += new System.EventHandler(this.button_trapMap_Click);
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear.Location = new System.Drawing.Point(139, 129);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(124, 23);
            this.button_clear.TabIndex = 1;
            this.button_clear.Text = "Limpiar";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_config
            // 
            this.button_config.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_config.Location = new System.Drawing.Point(6, 158);
            this.button_config.Name = "button_config";
            this.button_config.Size = new System.Drawing.Size(124, 23);
            this.button_config.TabIndex = 1;
            this.button_config.Text = "Configuracion ...";
            this.button_config.UseVisualStyleBackColor = true;
            this.button_config.Click += new System.EventHandler(this.button_config_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(6, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salvar Gráfico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarEjemploToolStripMenuItem,
            this.cargarEjemploAlcanzableToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cargarEjemploToolStripMenuItem
            // 
            this.cargarEjemploToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejemplo1ToolStripMenuItem,
            this.ejemplo2ToolStripMenuItem,
            this.ejemplo3ToolStripMenuItem,
            this.ejemplo4ToolStripMenuItem});
            this.cargarEjemploToolStripMenuItem.Name = "cargarEjemploToolStripMenuItem";
            this.cargarEjemploToolStripMenuItem.Size = new System.Drawing.Size(162, 20);
            this.cargarEjemploToolStripMenuItem.Text = "Cargar Ejemplo No Alcanzable";
            // 
            // ejemplo1ToolStripMenuItem
            // 
            this.ejemplo1ToolStripMenuItem.Name = "ejemplo1ToolStripMenuItem";
            this.ejemplo1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ejemplo1ToolStripMenuItem.Text = "Ejemplo 1";
            this.ejemplo1ToolStripMenuItem.Click += new System.EventHandler(this.ejemplo_ToolStripMenuItem_Click);
            // 
            // ejemplo2ToolStripMenuItem
            // 
            this.ejemplo2ToolStripMenuItem.Name = "ejemplo2ToolStripMenuItem";
            this.ejemplo2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ejemplo2ToolStripMenuItem.Text = "Ejemplo 2";
            this.ejemplo2ToolStripMenuItem.Click += new System.EventHandler(this.ejemplo_ToolStripMenuItem_Click);
            // 
            // ejemplo3ToolStripMenuItem
            // 
            this.ejemplo3ToolStripMenuItem.Name = "ejemplo3ToolStripMenuItem";
            this.ejemplo3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ejemplo3ToolStripMenuItem.Text = "Ejemplo 3";
            this.ejemplo3ToolStripMenuItem.Click += new System.EventHandler(this.ejemplo_ToolStripMenuItem_Click);
            // 
            // ejemplo4ToolStripMenuItem
            // 
            this.ejemplo4ToolStripMenuItem.Name = "ejemplo4ToolStripMenuItem";
            this.ejemplo4ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ejemplo4ToolStripMenuItem.Text = "Ejemplo 4";
            this.ejemplo4ToolStripMenuItem.Click += new System.EventHandler(this.ejemplo_ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar,
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 456);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(931, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 16);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.Visible = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(29, 17);
            this.StatusLabel.Text = "Listo";
            // 
            // cargarEjemploAlcanzableToolStripMenuItem
            // 
            this.cargarEjemploAlcanzableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejemplo5ToolStripMenuItem,
            this.ejemplo6ToolStripMenuItem,
            this.ejemplo7ToolStripMenuItem});
            this.cargarEjemploAlcanzableToolStripMenuItem.Name = "cargarEjemploAlcanzableToolStripMenuItem";
            this.cargarEjemploAlcanzableToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.cargarEjemploAlcanzableToolStripMenuItem.Text = "Cargar Ejemplo Alcanzable";
            // 
            // ejemplo5ToolStripMenuItem
            // 
            this.ejemplo5ToolStripMenuItem.Name = "ejemplo5ToolStripMenuItem";
            this.ejemplo5ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ejemplo5ToolStripMenuItem.Text = "Ejemplo 5";
            this.ejemplo5ToolStripMenuItem.Click += new System.EventHandler(this.ejemplo_ToolStripMenuItem_Click);
            // 
            // ejemplo6ToolStripMenuItem
            // 
            this.ejemplo6ToolStripMenuItem.Name = "ejemplo6ToolStripMenuItem";
            this.ejemplo6ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ejemplo6ToolStripMenuItem.Text = "Ejemplo 6";
            this.ejemplo6ToolStripMenuItem.Click += new System.EventHandler(this.ejemplo_ToolStripMenuItem_Click);
            // 
            // ejemplo7ToolStripMenuItem
            // 
            this.ejemplo7ToolStripMenuItem.Name = "ejemplo7ToolStripMenuItem";
            this.ejemplo7ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ejemplo7ToolStripMenuItem.Text = "Ejemplo 7";
            this.ejemplo7ToolStripMenuItem.Click += new System.EventHandler(this.ejemplo_ToolStripMenuItem_Click);
            // 
            // Graphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 478);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Graphics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Path-Planning";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_rangos;
        private System.Windows.Forms.Button button_Trayectoria;
        private System.Windows.Forms.Button button_trapMap;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cargarEjemploToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplo1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplo2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplo3ToolStripMenuItem;
        private System.Windows.Forms.Button button_secuencias;
        private System.Windows.Forms.Button button_optimas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxDistancias;
        private System.Windows.Forms.ListBox listBoxIteraciones;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripMenuItem ejemplo4ToolStripMenuItem;
        private System.Windows.Forms.Button button_config;
        private System.Windows.Forms.ToolStripMenuItem cargarEjemploAlcanzableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplo5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplo6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplo7ToolStripMenuItem;

    }
}

