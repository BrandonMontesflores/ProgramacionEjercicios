
namespace lista
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
            this.buttonarreglo = new System.Windows.Forms.Button();
            this.listBoxresultado = new System.Windows.Forms.ListBox();
            this.buttonCargararchivo = new System.Windows.Forms.Button();
            this.buttonnombres = new System.Windows.Forms.Button();
            this.buttonpromedio = new System.Windows.Forms.Button();
            this.listBoxresultado2 = new System.Windows.Forms.ListBox();
            this.buttonPromedioG = new System.Windows.Forms.Button();
            this.listBoxresultado3 = new System.Windows.Forms.ListBox();
            this.listBoxresultado4 = new System.Windows.Forms.ListBox();
            this.listBoxresultado5 = new System.Windows.Forms.ListBox();
            this.buttonND = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonarreglo
            // 
            this.buttonarreglo.Location = new System.Drawing.Point(652, 101);
            this.buttonarreglo.Name = "buttonarreglo";
            this.buttonarreglo.Size = new System.Drawing.Size(79, 39);
            this.buttonarreglo.TabIndex = 0;
            this.buttonarreglo.Text = "Arreglo Simple";
            this.buttonarreglo.UseVisualStyleBackColor = true;
            this.buttonarreglo.Click += new System.EventHandler(this.buttonarreglo_Click);
            // 
            // listBoxresultado
            // 
            this.listBoxresultado.FormattingEnabled = true;
            this.listBoxresultado.Location = new System.Drawing.Point(75, 71);
            this.listBoxresultado.Name = "listBoxresultado";
            this.listBoxresultado.Size = new System.Drawing.Size(380, 147);
            this.listBoxresultado.TabIndex = 1;
            // 
            // buttonCargararchivo
            // 
            this.buttonCargararchivo.Location = new System.Drawing.Point(153, 16);
            this.buttonCargararchivo.Name = "buttonCargararchivo";
            this.buttonCargararchivo.Size = new System.Drawing.Size(78, 38);
            this.buttonCargararchivo.TabIndex = 2;
            this.buttonCargararchivo.Text = "Cargar Archivo";
            this.buttonCargararchivo.UseVisualStyleBackColor = true;
            this.buttonCargararchivo.Click += new System.EventHandler(this.buttonCargararchivo_Click);
            // 
            // buttonnombres
            // 
            this.buttonnombres.Location = new System.Drawing.Point(284, 15);
            this.buttonnombres.Name = "buttonnombres";
            this.buttonnombres.Size = new System.Drawing.Size(78, 39);
            this.buttonnombres.TabIndex = 4;
            this.buttonnombres.Text = "Lista Alumnos";
            this.buttonnombres.UseVisualStyleBackColor = true;
            this.buttonnombres.Click += new System.EventHandler(this.buttonnombres_Click);
            // 
            // buttonpromedio
            // 
            this.buttonpromedio.Location = new System.Drawing.Point(511, 12);
            this.buttonpromedio.Name = "buttonpromedio";
            this.buttonpromedio.Size = new System.Drawing.Size(78, 42);
            this.buttonpromedio.TabIndex = 5;
            this.buttonpromedio.Text = "Promedio Alumnos";
            this.buttonpromedio.UseVisualStyleBackColor = true;
            this.buttonpromedio.Click += new System.EventHandler(this.buttonpromedio_Click);
            // 
            // listBoxresultado2
            // 
            this.listBoxresultado2.FormattingEnabled = true;
            this.listBoxresultado2.Location = new System.Drawing.Point(496, 71);
            this.listBoxresultado2.Name = "listBoxresultado2";
            this.listBoxresultado2.Size = new System.Drawing.Size(113, 147);
            this.listBoxresultado2.TabIndex = 6;
            // 
            // buttonPromedioG
            // 
            this.buttonPromedioG.Location = new System.Drawing.Point(111, 231);
            this.buttonPromedioG.Name = "buttonPromedioG";
            this.buttonPromedioG.Size = new System.Drawing.Size(77, 44);
            this.buttonPromedioG.TabIndex = 7;
            this.buttonPromedioG.Text = "Promedio General";
            this.buttonPromedioG.UseVisualStyleBackColor = true;
            this.buttonPromedioG.Click += new System.EventHandler(this.buttonPromedioG_Click);
            // 
            // listBoxresultado3
            // 
            this.listBoxresultado3.FormattingEnabled = true;
            this.listBoxresultado3.Location = new System.Drawing.Point(56, 290);
            this.listBoxresultado3.Name = "listBoxresultado3";
            this.listBoxresultado3.Size = new System.Drawing.Size(191, 56);
            this.listBoxresultado3.TabIndex = 8;
            // 
            // listBoxresultado4
            // 
            this.listBoxresultado4.FormattingEnabled = true;
            this.listBoxresultado4.Location = new System.Drawing.Point(394, 260);
            this.listBoxresultado4.Name = "listBoxresultado4";
            this.listBoxresultado4.Size = new System.Drawing.Size(337, 43);
            this.listBoxresultado4.TabIndex = 9;
            // 
            // listBoxresultado5
            // 
            this.listBoxresultado5.FormattingEnabled = true;
            this.listBoxresultado5.Location = new System.Drawing.Point(394, 339);
            this.listBoxresultado5.Name = "listBoxresultado5";
            this.listBoxresultado5.Size = new System.Drawing.Size(337, 43);
            this.listBoxresultado5.TabIndex = 10;
            // 
            // buttonND
            // 
            this.buttonND.Location = new System.Drawing.Point(293, 290);
            this.buttonND.Name = "buttonND";
            this.buttonND.Size = new System.Drawing.Size(79, 41);
            this.buttonND.TabIndex = 11;
            this.buttonND.Text = "Notas Destacadas";
            this.buttonND.UseVisualStyleBackColor = true;
            this.buttonND.Click += new System.EventHandler(this.buttonND_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(667, 149);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(49, 69);
            this.listBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "MEJOR NOTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "NOTA MAS BAJA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(759, 406);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonND);
            this.Controls.Add(this.listBoxresultado5);
            this.Controls.Add(this.listBoxresultado4);
            this.Controls.Add(this.listBoxresultado3);
            this.Controls.Add(this.buttonPromedioG);
            this.Controls.Add(this.listBoxresultado2);
            this.Controls.Add(this.buttonpromedio);
            this.Controls.Add(this.buttonnombres);
            this.Controls.Add(this.buttonCargararchivo);
            this.Controls.Add(this.listBoxresultado);
            this.Controls.Add(this.buttonarreglo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonarreglo;
        private System.Windows.Forms.ListBox listBoxresultado;
        private System.Windows.Forms.Button buttonCargararchivo;
        private System.Windows.Forms.Button buttonnombres;
        private System.Windows.Forms.Button buttonpromedio;
        private System.Windows.Forms.ListBox listBoxresultado2;
        private System.Windows.Forms.Button buttonPromedioG;
        private System.Windows.Forms.ListBox listBoxresultado3;
        private System.Windows.Forms.ListBox listBoxresultado4;
        private System.Windows.Forms.ListBox listBoxresultado5;
        private System.Windows.Forms.Button buttonND;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

