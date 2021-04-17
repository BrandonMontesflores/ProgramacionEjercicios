
namespace parcial2
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
            this.buttonCargar = new System.Windows.Forms.Button();
            this.buttonNombres = new System.Windows.Forms.Button();
            this.buttonPromedioA = new System.Windows.Forms.Button();
            this.buttonPromedioG = new System.Windows.Forms.Button();
            this.buttonNotasD = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.buttonPromGS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(12, 12);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(75, 39);
            this.buttonCargar.TabIndex = 0;
            this.buttonCargar.Text = "Cargar Archivo";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // buttonNombres
            // 
            this.buttonNombres.Location = new System.Drawing.Point(12, 57);
            this.buttonNombres.Name = "buttonNombres";
            this.buttonNombres.Size = new System.Drawing.Size(75, 23);
            this.buttonNombres.TabIndex = 1;
            this.buttonNombres.Text = "Nombres";
            this.buttonNombres.UseVisualStyleBackColor = true;
            this.buttonNombres.Click += new System.EventHandler(this.buttonNombres_Click);
            // 
            // buttonPromedioA
            // 
            this.buttonPromedioA.Location = new System.Drawing.Point(12, 102);
            this.buttonPromedioA.Name = "buttonPromedioA";
            this.buttonPromedioA.Size = new System.Drawing.Size(75, 39);
            this.buttonPromedioA.TabIndex = 2;
            this.buttonPromedioA.Text = "Promedio Alumnos";
            this.buttonPromedioA.UseVisualStyleBackColor = true;
            this.buttonPromedioA.Click += new System.EventHandler(this.buttonPromedioA_Click);
            // 
            // buttonPromedioG
            // 
            this.buttonPromedioG.Location = new System.Drawing.Point(12, 144);
            this.buttonPromedioG.Name = "buttonPromedioG";
            this.buttonPromedioG.Size = new System.Drawing.Size(75, 39);
            this.buttonPromedioG.TabIndex = 3;
            this.buttonPromedioG.Text = "Promedio General";
            this.buttonPromedioG.UseVisualStyleBackColor = true;
            this.buttonPromedioG.Click += new System.EventHandler(this.buttonPromedioG_Click);
            // 
            // buttonNotasD
            // 
            this.buttonNotasD.Location = new System.Drawing.Point(12, 278);
            this.buttonNotasD.Name = "buttonNotasD";
            this.buttonNotasD.Size = new System.Drawing.Size(75, 39);
            this.buttonNotasD.TabIndex = 5;
            this.buttonNotasD.Text = "Nota Destacada";
            this.buttonNotasD.UseVisualStyleBackColor = true;
            this.buttonNotasD.Click += new System.EventHandler(this.buttonNotasD_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(156, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(357, 121);
            this.listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(156, 171);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(124, 69);
            this.listBox2.TabIndex = 7;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(286, 151);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(85, 121);
            this.listBox3.TabIndex = 8;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(389, 171);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(124, 69);
            this.listBox4.TabIndex = 9;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(265, 295);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(124, 43);
            this.listBox5.TabIndex = 10;
            // 
            // buttonPromGS
            // 
            this.buttonPromGS.Location = new System.Drawing.Point(12, 233);
            this.buttonPromGS.Name = "buttonPromGS";
            this.buttonPromGS.Size = new System.Drawing.Size(75, 39);
            this.buttonPromGS.TabIndex = 11;
            this.buttonPromGS.Text = "Promedio General S.";
            this.buttonPromGS.UseVisualStyleBackColor = true;
            this.buttonPromGS.Click += new System.EventHandler(this.buttonPromGS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(558, 352);
            this.Controls.Add(this.buttonPromGS);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonNotasD);
            this.Controls.Add(this.buttonPromedioG);
            this.Controls.Add(this.buttonPromedioA);
            this.Controls.Add(this.buttonNombres);
            this.Controls.Add(this.buttonCargar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button buttonNombres;
        private System.Windows.Forms.Button buttonPromedioA;
        private System.Windows.Forms.Button buttonPromedioG;
        private System.Windows.Forms.Button buttonNotasD;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Button buttonPromGS;
    }
}

