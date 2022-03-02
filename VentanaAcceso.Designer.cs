namespace CONTROL_DE_ENTRADAS_Y_SALIDAS
{
    partial class VentanaAcceso
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ModoNúmeroControl = new System.Windows.Forms.TabPage();
            this.RelojEtiquetado = new System.Windows.Forms.Label();
            this.ModoDatosAlumno = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.ModoNúmeroControl.SuspendLayout();
            this.ModoDatosAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PROGRAMACIÓN",
            "SERVICIOS DE HOTELERÍA",
            "PROCESOS DE GESTIÓN ADMINISTRATIVA"});
            this.comboBox1.Location = new System.Drawing.Point(9, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(210, 19);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(142, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Carrera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grupo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Número de lista";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(358, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(360, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Número de control:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ModoNúmeroControl);
            this.tabControl1.Controls.Add(this.ModoDatosAlumno);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 240);
            this.tabControl1.TabIndex = 10;
            // 
            // ModoNúmeroControl
            // 
            this.ModoNúmeroControl.Controls.Add(this.RelojEtiquetado);
            this.ModoNúmeroControl.Controls.Add(this.label4);
            this.ModoNúmeroControl.Controls.Add(this.textBox1);
            this.ModoNúmeroControl.Location = new System.Drawing.Point(4, 22);
            this.ModoNúmeroControl.Name = "ModoNúmeroControl";
            this.ModoNúmeroControl.Padding = new System.Windows.Forms.Padding(3);
            this.ModoNúmeroControl.Size = new System.Drawing.Size(755, 214);
            this.ModoNúmeroControl.TabIndex = 0;
            this.ModoNúmeroControl.Text = "Número de control";
            this.ModoNúmeroControl.UseVisualStyleBackColor = true;
            // 
            // RelojEtiquetado
            // 
            this.RelojEtiquetado.AutoSize = true;
            this.RelojEtiquetado.BackColor = System.Drawing.Color.Red;
            this.RelojEtiquetado.Location = new System.Drawing.Point(101, 80);
            this.RelojEtiquetado.Name = "RelojEtiquetado";
            this.RelojEtiquetado.Size = new System.Drawing.Size(117, 13);
            this.RelojEtiquetado.TabIndex = 10;
            this.RelojEtiquetado.Text = "Si ves esto, el reloj falla";
            // 
            // ModoDatosAlumno
            // 
            this.ModoDatosAlumno.Controls.Add(this.label1);
            this.ModoDatosAlumno.Controls.Add(this.comboBox2);
            this.ModoDatosAlumno.Controls.Add(this.comboBox1);
            this.ModoDatosAlumno.Controls.Add(this.label2);
            this.ModoDatosAlumno.Controls.Add(this.comboBox3);
            this.ModoDatosAlumno.Controls.Add(this.label3);
            this.ModoDatosAlumno.Location = new System.Drawing.Point(4, 22);
            this.ModoDatosAlumno.Name = "ModoDatosAlumno";
            this.ModoDatosAlumno.Padding = new System.Windows.Forms.Padding(3);
            this.ModoDatosAlumno.Size = new System.Drawing.Size(755, 214);
            this.ModoDatosAlumno.TabIndex = 1;
            this.ModoDatosAlumno.Text = "Datos del alumno";
            this.ModoDatosAlumno.UseVisualStyleBackColor = true;
            // 
            // VentanaAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 245);
            this.Controls.Add(this.tabControl1);
            this.Name = "VentanaAcceso";
            this.Text = "Control de entradas y salidas";
            this.Load += new System.EventHandler(this.VentanaAcceso_Load);
            this.tabControl1.ResumeLayout(false);
            this.ModoNúmeroControl.ResumeLayout(false);
            this.ModoNúmeroControl.PerformLayout();
            this.ModoDatosAlumno.ResumeLayout(false);
            this.ModoDatosAlumno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ModoNúmeroControl;
        private System.Windows.Forms.TabPage ModoDatosAlumno;
        private System.Windows.Forms.Label RelojEtiquetado;
    }
}

