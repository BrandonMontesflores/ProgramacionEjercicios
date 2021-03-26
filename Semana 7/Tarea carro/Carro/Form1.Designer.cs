
namespace Carro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonCA = new System.Windows.Forms.Button();
            this.buttonCM = new System.Windows.Forms.Button();
            this.buttonacelerar = new System.Windows.Forms.Button();
            this.buttonfrenar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.labelest = new System.Windows.Forms.Label();
            this.labelvel = new System.Windows.Forms.Label();
            this.buttoncambio = new System.Windows.Forms.Button();
            this.labelcam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(244, 252);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(226, 46);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // buttonCA
            // 
            this.buttonCA.BackColor = System.Drawing.Color.White;
            this.buttonCA.Location = new System.Drawing.Point(118, 64);
            this.buttonCA.Name = "buttonCA";
            this.buttonCA.Size = new System.Drawing.Size(75, 27);
            this.buttonCA.TabIndex = 1;
            this.buttonCA.Text = "Automático";
            this.buttonCA.UseVisualStyleBackColor = false;
            this.buttonCA.Click += new System.EventHandler(this.buttonCA_Click);
            // 
            // buttonCM
            // 
            this.buttonCM.BackColor = System.Drawing.Color.White;
            this.buttonCM.Location = new System.Drawing.Point(118, 104);
            this.buttonCM.Name = "buttonCM";
            this.buttonCM.Size = new System.Drawing.Size(75, 27);
            this.buttonCM.TabIndex = 2;
            this.buttonCM.Text = "Mecánico";
            this.buttonCM.UseVisualStyleBackColor = false;
            this.buttonCM.Click += new System.EventHandler(this.buttonCM_Click);
            // 
            // buttonacelerar
            // 
            this.buttonacelerar.BackColor = System.Drawing.Color.White;
            this.buttonacelerar.Location = new System.Drawing.Point(386, 97);
            this.buttonacelerar.Name = "buttonacelerar";
            this.buttonacelerar.Size = new System.Drawing.Size(75, 27);
            this.buttonacelerar.TabIndex = 3;
            this.buttonacelerar.Text = "Acelerar";
            this.buttonacelerar.UseVisualStyleBackColor = false;
            this.buttonacelerar.Click += new System.EventHandler(this.buttonacelerar_Click);
            // 
            // buttonfrenar
            // 
            this.buttonfrenar.BackColor = System.Drawing.Color.White;
            this.buttonfrenar.Location = new System.Drawing.Point(386, 163);
            this.buttonfrenar.Name = "buttonfrenar";
            this.buttonfrenar.Size = new System.Drawing.Size(75, 27);
            this.buttonfrenar.TabIndex = 4;
            this.buttonfrenar.Text = "Frenar";
            this.buttonfrenar.UseVisualStyleBackColor = false;
            this.buttonfrenar.Click += new System.EventHandler(this.buttonfrenar_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(386, 64);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 27);
            this.button5.TabIndex = 5;
            this.button5.Text = "Encender";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelest
            // 
            this.labelest.AutoSize = true;
            this.labelest.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelest.Location = new System.Drawing.Point(505, 72);
            this.labelest.Name = "labelest";
            this.labelest.Size = new System.Drawing.Size(0, 19);
            this.labelest.TabIndex = 6;
            // 
            // labelvel
            // 
            this.labelvel.AutoSize = true;
            this.labelvel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvel.Location = new System.Drawing.Point(505, 112);
            this.labelvel.Name = "labelvel";
            this.labelvel.Size = new System.Drawing.Size(0, 19);
            this.labelvel.TabIndex = 7;
            // 
            // buttoncambio
            // 
            this.buttoncambio.BackColor = System.Drawing.Color.White;
            this.buttoncambio.Location = new System.Drawing.Point(386, 130);
            this.buttoncambio.Name = "buttoncambio";
            this.buttoncambio.Size = new System.Drawing.Size(75, 27);
            this.buttoncambio.TabIndex = 8;
            this.buttoncambio.Text = "Cambio";
            this.buttoncambio.UseVisualStyleBackColor = false;
            this.buttoncambio.Click += new System.EventHandler(this.buttoncambio_Click);
            // 
            // labelcam
            // 
            this.labelcam.AutoSize = true;
            this.labelcam.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcam.Location = new System.Drawing.Point(505, 149);
            this.labelcam.Name = "labelcam";
            this.labelcam.Size = new System.Drawing.Size(0, 19);
            this.labelcam.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "1. CREA UN CARRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "2. ¡ES HORA DE MANEJARLO!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "3. ENCIENDE LA MUSICA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(735, 330);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelcam);
            this.Controls.Add(this.buttoncambio);
            this.Controls.Add(this.labelvel);
            this.Controls.Add(this.labelest);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonfrenar);
            this.Controls.Add(this.buttonacelerar);
            this.Controls.Add(this.buttonCM);
            this.Controls.Add(this.buttonCA);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button buttonCA;
        private System.Windows.Forms.Button buttonCM;
        private System.Windows.Forms.Button buttonacelerar;
        private System.Windows.Forms.Button buttonfrenar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label labelest;
        private System.Windows.Forms.Label labelvel;
        private System.Windows.Forms.Button buttoncambio;
        private System.Windows.Forms.Label labelcam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

