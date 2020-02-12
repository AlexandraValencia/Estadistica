namespace estadistica
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
            this.lblserie = new System.Windows.Forms.Label();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.btnmediaaritmetrica = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblrespuesta_ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblrespuesta_serie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblserie
            // 
            this.lblserie.AutoSize = true;
            this.lblserie.Location = new System.Drawing.Point(12, 45);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(31, 13);
            this.lblserie.TabIndex = 0;
            this.lblserie.Text = "Serie";
            // 
            // txtserie
            // 
            this.txtserie.Location = new System.Drawing.Point(53, 42);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(100, 20);
            this.txtserie.TabIndex = 1;
            // 
            // btnmediaaritmetrica
            // 
            this.btnmediaaritmetrica.Location = new System.Drawing.Point(43, 124);
            this.btnmediaaritmetrica.Name = "btnmediaaritmetrica";
            this.btnmediaaritmetrica.Size = new System.Drawing.Size(75, 23);
            this.btnmediaaritmetrica.TabIndex = 2;
            this.btnmediaaritmetrica.Text = "Calcular X";
            this.btnmediaaritmetrica.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // lblrespuesta_
            // 
            this.lblrespuesta_.AutoSize = true;
            this.lblrespuesta_.Location = new System.Drawing.Point(206, 56);
            this.lblrespuesta_.Name = "lblrespuesta_";
            this.lblrespuesta_.Size = new System.Drawing.Size(0, 13);
            this.lblrespuesta_.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // lblrespuesta_serie
            // 
            this.lblrespuesta_serie.AutoSize = true;
            this.lblrespuesta_serie.Location = new System.Drawing.Point(12, 80);
            this.lblrespuesta_serie.Name = "lblrespuesta_serie";
            this.lblrespuesta_serie.Size = new System.Drawing.Size(14, 13);
            this.lblrespuesta_serie.TabIndex = 6;
            this.lblrespuesta_serie.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblrespuesta_serie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblrespuesta_);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnmediaaritmetrica);
            this.Controls.Add(this.txtserie);
            this.Controls.Add(this.lblserie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblserie;
        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.Button btnmediaaritmetrica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblrespuesta_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblrespuesta_serie;
    }
}

