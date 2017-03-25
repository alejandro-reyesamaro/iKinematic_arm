namespace PathPlaning
{
    partial class ConfigForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_media_gausiana = new System.Windows.Forms.NumericUpDown();
            this.nud_pf_maximo_iteraciones = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_pf_eps = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_numero_particulas = new System.Windows.Forms.NumericUpDown();
            this.nud_separacion_nodos = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nud_separacion_obstaculos = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nud_opt_maximo_iteraciones = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nud_g_eps = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_f_eps = new System.Windows.Forms.NumericUpDown();
            this.nud_x_eps = new System.Windows.Forms.NumericUpDown();
            this.button_Aceptar = new System.Windows.Forms.Button();
            this.button_por_defecto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_media_gausiana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pf_maximo_iteraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pf_eps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_numero_particulas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_separacion_nodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_separacion_obstaculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_opt_maximo_iteraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_g_eps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_f_eps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_x_eps)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nud_numero_particulas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nud_pf_eps);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nud_pf_maximo_iteraciones);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nud_media_gausiana);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Filtro de Partículas ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nud_separacion_obstaculos);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.nud_separacion_nodos);
            this.groupBox2.Location = new System.Drawing.Point(215, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 137);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Mapa de trayectoria ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nud_opt_maximo_iteraciones);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.nud_x_eps);
            this.groupBox3.Controls.Add(this.nud_f_eps);
            this.groupBox3.Controls.Add(this.nud_g_eps);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(418, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 137);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Optimización";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Media gausiana: ";
            // 
            // nud_media_gausiana
            // 
            this.nud_media_gausiana.DecimalPlaces = 2;
            this.nud_media_gausiana.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_media_gausiana.Location = new System.Drawing.Point(135, 24);
            this.nud_media_gausiana.Name = "nud_media_gausiana";
            this.nud_media_gausiana.Size = new System.Drawing.Size(56, 20);
            this.nud_media_gausiana.TabIndex = 1;
            // 
            // nud_pf_maximo_iteraciones
            // 
            this.nud_pf_maximo_iteraciones.Location = new System.Drawing.Point(135, 50);
            this.nud_pf_maximo_iteraciones.Name = "nud_pf_maximo_iteraciones";
            this.nud_pf_maximo_iteraciones.Size = new System.Drawing.Size(56, 20);
            this.nud_pf_maximo_iteraciones.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Máximo de iteraciones: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Epsilon (10^-eps): ";
            // 
            // nud_pf_eps
            // 
            this.nud_pf_eps.Location = new System.Drawing.Point(135, 76);
            this.nud_pf_eps.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.nud_pf_eps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_pf_eps.Name = "nud_pf_eps";
            this.nud_pf_eps.Size = new System.Drawing.Size(56, 20);
            this.nud_pf_eps.TabIndex = 3;
            this.nud_pf_eps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numero de partículas: ";
            // 
            // nud_numero_particulas
            // 
            this.nud_numero_particulas.Location = new System.Drawing.Point(135, 102);
            this.nud_numero_particulas.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_numero_particulas.Name = "nud_numero_particulas";
            this.nud_numero_particulas.Size = new System.Drawing.Size(56, 20);
            this.nud_numero_particulas.TabIndex = 3;
            // 
            // nud_separacion_nodos
            // 
            this.nud_separacion_nodos.DecimalPlaces = 2;
            this.nud_separacion_nodos.Location = new System.Drawing.Point(133, 50);
            this.nud_separacion_nodos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_separacion_nodos.Name = "nud_separacion_nodos";
            this.nud_separacion_nodos.Size = new System.Drawing.Size(58, 20);
            this.nud_separacion_nodos.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Separación nodos: ";
            // 
            // nud_separacion_obstaculos
            // 
            this.nud_separacion_obstaculos.DecimalPlaces = 2;
            this.nud_separacion_obstaculos.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_separacion_obstaculos.Location = new System.Drawing.Point(133, 24);
            this.nud_separacion_obstaculos.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_separacion_obstaculos.Name = "nud_separacion_obstaculos";
            this.nud_separacion_obstaculos.Size = new System.Drawing.Size(58, 20);
            this.nud_separacion_obstaculos.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Separación obstáculos: ";
            // 
            // nud_opt_maximo_iteraciones
            // 
            this.nud_opt_maximo_iteraciones.Location = new System.Drawing.Point(135, 24);
            this.nud_opt_maximo_iteraciones.Name = "nud_opt_maximo_iteraciones";
            this.nud_opt_maximo_iteraciones.Size = new System.Drawing.Size(56, 20);
            this.nud_opt_maximo_iteraciones.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Máximo de iteraciones: ";
            // 
            // nud_g_eps
            // 
            this.nud_g_eps.Location = new System.Drawing.Point(135, 50);
            this.nud_g_eps.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.nud_g_eps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_g_eps.Name = "nud_g_eps";
            this.nud_g_eps.Size = new System.Drawing.Size(56, 20);
            this.nud_g_eps.TabIndex = 5;
            this.nud_g_eps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "G-epsilon (10^-eps): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "F-epsilon (10^-eps): ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "X-epsilon (10^-eps): ";
            // 
            // nud_f_eps
            // 
            this.nud_f_eps.Location = new System.Drawing.Point(135, 76);
            this.nud_f_eps.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.nud_f_eps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_f_eps.Name = "nud_f_eps";
            this.nud_f_eps.Size = new System.Drawing.Size(56, 20);
            this.nud_f_eps.TabIndex = 5;
            this.nud_f_eps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_x_eps
            // 
            this.nud_x_eps.Location = new System.Drawing.Point(135, 102);
            this.nud_x_eps.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.nud_x_eps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_x_eps.Name = "nud_x_eps";
            this.nud_x_eps.Size = new System.Drawing.Size(56, 20);
            this.nud_x_eps.TabIndex = 5;
            this.nud_x_eps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Aceptar.Location = new System.Drawing.Point(418, 159);
            this.button_Aceptar.Name = "button_Aceptar";
            this.button_Aceptar.Size = new System.Drawing.Size(197, 23);
            this.button_Aceptar.TabIndex = 1;
            this.button_Aceptar.Text = "Aceptar";
            this.button_Aceptar.UseVisualStyleBackColor = true;
            this.button_Aceptar.Click += new System.EventHandler(this.button_Aceptar_Click);
            // 
            // button_por_defecto
            // 
            this.button_por_defecto.Location = new System.Drawing.Point(12, 159);
            this.button_por_defecto.Name = "button_por_defecto";
            this.button_por_defecto.Size = new System.Drawing.Size(197, 23);
            this.button_por_defecto.TabIndex = 1;
            this.button_por_defecto.Text = "Valores por defecto";
            this.button_por_defecto.UseVisualStyleBackColor = true;
            this.button_por_defecto.Click += new System.EventHandler(this.button_por_defecto_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 194);
            this.Controls.Add(this.button_por_defecto);
            this.Controls.Add(this.button_Aceptar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfigForm";
            this.Text = "Configuración de los parámetros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_media_gausiana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pf_maximo_iteraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pf_eps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_numero_particulas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_separacion_nodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_separacion_obstaculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_opt_maximo_iteraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_g_eps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_f_eps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_x_eps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nud_media_gausiana;
        private System.Windows.Forms.NumericUpDown nud_pf_maximo_iteraciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_numero_particulas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_pf_eps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_separacion_obstaculos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nud_separacion_nodos;
        private System.Windows.Forms.NumericUpDown nud_opt_maximo_iteraciones;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nud_g_eps;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_x_eps;
        private System.Windows.Forms.NumericUpDown nud_f_eps;
        private System.Windows.Forms.Button button_Aceptar;
        private System.Windows.Forms.Button button_por_defecto;
    }
}