
namespace Presentacion
{
    partial class FrmPaciente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboxSexo = new System.Windows.Forms.ComboBox();
            this.cboxDistrito = new System.Windows.Forms.ComboBox();
            this.txtFechaN = new System.Windows.Forms.TextBox();
            this.txtFechaR = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnMayorTiempo = new System.Windows.Forms.Button();
            this.btnCantV = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Distrito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Registro";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(79, 29);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(139, 22);
            this.txtDNI.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(102, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(139, 22);
            this.txtNombre.TabIndex = 7;
            // 
            // cboxSexo
            // 
            this.cboxSexo.FormattingEnabled = true;
            this.cboxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cboxSexo.Location = new System.Drawing.Point(79, 121);
            this.cboxSexo.Name = "cboxSexo";
            this.cboxSexo.Size = new System.Drawing.Size(139, 24);
            this.cboxSexo.TabIndex = 8;
            // 
            // cboxDistrito
            // 
            this.cboxDistrito.FormattingEnabled = true;
            this.cboxDistrito.Items.AddRange(new object[] {
            "Cercado",
            "Barranco",
            "Surco",
            "Callao"});
            this.cboxDistrito.Location = new System.Drawing.Point(79, 167);
            this.cboxDistrito.Name = "cboxDistrito";
            this.cboxDistrito.Size = new System.Drawing.Size(139, 24);
            this.cboxDistrito.TabIndex = 9;
            // 
            // txtFechaN
            // 
            this.txtFechaN.Location = new System.Drawing.Point(155, 215);
            this.txtFechaN.Name = "txtFechaN";
            this.txtFechaN.Size = new System.Drawing.Size(139, 22);
            this.txtFechaN.TabIndex = 10;
            // 
            // txtFechaR
            // 
            this.txtFechaR.Location = new System.Drawing.Point(155, 271);
            this.txtFechaR.Name = "txtFechaR";
            this.txtFechaR.Size = new System.Drawing.Size(139, 22);
            this.txtFechaR.TabIndex = 11;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(55, 329);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(186, 34);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(55, 376);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(186, 38);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(55, 430);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(186, 40);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnMayorTiempo
            // 
            this.btnMayorTiempo.Location = new System.Drawing.Point(578, 29);
            this.btnMayorTiempo.Name = "btnMayorTiempo";
            this.btnMayorTiempo.Size = new System.Drawing.Size(186, 58);
            this.btnMayorTiempo.TabIndex = 15;
            this.btnMayorTiempo.Text = "Mayor Tiempo Atendiendose";
            this.btnMayorTiempo.UseVisualStyleBackColor = true;
            this.btnMayorTiempo.Click += new System.EventHandler(this.btnMayorTiempo_Click);
            // 
            // btnCantV
            // 
            this.btnCantV.Location = new System.Drawing.Point(578, 103);
            this.btnCantV.Name = "btnCantV";
            this.btnCantV.Size = new System.Drawing.Size(186, 58);
            this.btnCantV.TabIndex = 16;
            this.btnCantV.Text = "Menor Cantidad Varones";
            this.btnCantV.UseVisualStyleBackColor = true;
            this.btnCantV.Click += new System.EventHandler(this.btnCantV_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 58);
            this.button1.TabIndex = 17;
            this.button1.Text = "Cantidad de pacientes por distrito";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(353, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(527, 223);
            this.dataGridView1.TabIndex = 18;
            // 
            // FrmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 499);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCantV);
            this.Controls.Add(this.btnMayorTiempo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtFechaR);
            this.Controls.Add(this.txtFechaN);
            this.Controls.Add(this.cboxDistrito);
            this.Controls.Add(this.cboxSexo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPaciente";
            this.Text = "FrmPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboxSexo;
        private System.Windows.Forms.ComboBox cboxDistrito;
        private System.Windows.Forms.TextBox txtFechaN;
        private System.Windows.Forms.TextBox txtFechaR;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnMayorTiempo;
        private System.Windows.Forms.Button btnCantV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}