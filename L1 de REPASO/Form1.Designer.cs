
namespace L1_de_REPASO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Cargar = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_nombre = new System.Windows.Forms.TextBox();
            this.tx_sueldohora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_codi2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_horasmes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_mes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btn_ingreso1 = new System.Windows.Forms.Button();
            this.Ingreso2 = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lab_nom = new System.Windows.Forms.Label();
            this.lab_sueldo = new System.Windows.Forms.Label();
            this.lab_mes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(539, 172);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(60, 250);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(539, 176);
            this.dataGridView2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(666, 611);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(326, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // btn_Cargar
            // 
            this.btn_Cargar.Location = new System.Drawing.Point(239, 450);
            this.btn_Cargar.Name = "btn_Cargar";
            this.btn_Cargar.Size = new System.Drawing.Size(148, 46);
            this.btn_Cargar.TabIndex = 3;
            this.btn_Cargar.Text = "Cargar Datos";
            this.btn_Cargar.UseVisualStyleBackColor = true;
            this.btn_Cargar.Click += new System.EventHandler(this.btn_Cargar_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(666, 539);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(167, 34);
            this.btn_Calcular.TabIndex = 4;
            this.btn_Calcular.Text = "Calcular Sueldos";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "No. Empleado";
            // 
            // tx_codigo
            // 
            this.tx_codigo.Location = new System.Drawing.Point(766, 36);
            this.tx_codigo.Name = "tx_codigo";
            this.tx_codigo.Size = new System.Drawing.Size(246, 22);
            this.tx_codigo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre:";
            // 
            // tx_nombre
            // 
            this.tx_nombre.Location = new System.Drawing.Point(766, 76);
            this.tx_nombre.Name = "tx_nombre";
            this.tx_nombre.Size = new System.Drawing.Size(246, 22);
            this.tx_nombre.TabIndex = 9;
            // 
            // tx_sueldohora
            // 
            this.tx_sueldohora.Location = new System.Drawing.Point(872, 115);
            this.tx_sueldohora.Name = "tx_sueldohora";
            this.tx_sueldohora.Size = new System.Drawing.Size(140, 22);
            this.tx_sueldohora.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(663, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sueldo por hora:";
            // 
            // tx_codi2
            // 
            this.tx_codi2.Location = new System.Drawing.Point(786, 265);
            this.tx_codi2.Name = "tx_codi2";
            this.tx_codi2.Size = new System.Drawing.Size(226, 22);
            this.tx_codi2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(663, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "No. Empleado:";
            // 
            // tx_horasmes
            // 
            this.tx_horasmes.Location = new System.Drawing.Point(786, 304);
            this.tx_horasmes.Name = "tx_horasmes";
            this.tx_horasmes.Size = new System.Drawing.Size(226, 22);
            this.tx_horasmes.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(663, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Horas del mes:";
            // 
            // tx_mes
            // 
            this.tx_mes.Location = new System.Drawing.Point(786, 347);
            this.tx_mes.Name = "tx_mes";
            this.tx_mes.Size = new System.Drawing.Size(226, 22);
            this.tx_mes.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(663, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mes:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(60, 539);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(539, 176);
            this.dataGridView3.TabIndex = 18;
            // 
            // btn_ingreso1
            // 
            this.btn_ingreso1.Location = new System.Drawing.Point(822, 177);
            this.btn_ingreso1.Name = "btn_ingreso1";
            this.btn_ingreso1.Size = new System.Drawing.Size(111, 31);
            this.btn_ingreso1.TabIndex = 19;
            this.btn_ingreso1.Text = "Ingresar";
            this.btn_ingreso1.UseVisualStyleBackColor = true;
            this.btn_ingreso1.Click += new System.EventHandler(this.btn_ingreso1_Click);
            // 
            // Ingreso2
            // 
            this.Ingreso2.Location = new System.Drawing.Point(822, 406);
            this.Ingreso2.Name = "Ingreso2";
            this.Ingreso2.Size = new System.Drawing.Size(111, 31);
            this.Ingreso2.TabIndex = 20;
            this.Ingreso2.Text = "Ingresar";
            this.Ingreso2.UseVisualStyleBackColor = true;
            this.Ingreso2.Click += new System.EventHandler(this.Ingreso2_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(1022, 611);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(81, 25);
            this.btn_buscar.TabIndex = 21;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lab_nom
            // 
            this.lab_nom.AutoSize = true;
            this.lab_nom.Location = new System.Drawing.Point(679, 718);
            this.lab_nom.Name = "lab_nom";
            this.lab_nom.Size = new System.Drawing.Size(16, 17);
            this.lab_nom.TabIndex = 22;
            this.lab_nom.Text = "0";
            // 
            // lab_sueldo
            // 
            this.lab_sueldo.AutoSize = true;
            this.lab_sueldo.Location = new System.Drawing.Point(955, 718);
            this.lab_sueldo.Name = "lab_sueldo";
            this.lab_sueldo.Size = new System.Drawing.Size(16, 17);
            this.lab_sueldo.TabIndex = 23;
            this.lab_sueldo.Text = "0";
            // 
            // lab_mes
            // 
            this.lab_mes.AutoSize = true;
            this.lab_mes.Location = new System.Drawing.Point(819, 718);
            this.lab_mes.Name = "lab_mes";
            this.lab_mes.Size = new System.Drawing.Size(16, 17);
            this.lab_mes.TabIndex = 24;
            this.lab_mes.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 773);
            this.Controls.Add(this.lab_mes);
            this.Controls.Add(this.lab_sueldo);
            this.Controls.Add(this.lab_nom);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.Ingreso2);
            this.Controls.Add(this.btn_ingreso1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.tx_mes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tx_horasmes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx_codi2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_sueldohora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.btn_Cargar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Cargar;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_nombre;
        private System.Windows.Forms.TextBox tx_sueldohora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_codi2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_horasmes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_mes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btn_ingreso1;
        private System.Windows.Forms.Button Ingreso2;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lab_nom;
        private System.Windows.Forms.Label lab_sueldo;
        private System.Windows.Forms.Label lab_mes;
    }
}

