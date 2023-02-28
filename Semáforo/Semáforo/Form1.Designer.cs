namespace Semáforo
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
            this.rojoPB = new System.Windows.Forms.PictureBox();
            this.amarilloPB = new System.Windows.Forms.PictureBox();
            this.verdePB = new System.Windows.Forms.PictureBox();
            this.cambiaFaseB = new System.Windows.Forms.Button();
            this.mensajeL = new System.Windows.Forms.Label();
            this.permitirCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.rojoPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amarilloPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdePB)).BeginInit();
            this.SuspendLayout();
            // 
            // rojoPB
            // 
            this.rojoPB.BackColor = System.Drawing.Color.Red;
            this.rojoPB.Location = new System.Drawing.Point(51, 115);
            this.rojoPB.Name = "rojoPB";
            this.rojoPB.Size = new System.Drawing.Size(167, 135);
            this.rojoPB.TabIndex = 0;
            this.rojoPB.TabStop = false;
            // 
            // amarilloPB
            // 
            this.amarilloPB.BackColor = System.Drawing.Color.Yellow;
            this.amarilloPB.Location = new System.Drawing.Point(247, 115);
            this.amarilloPB.Name = "amarilloPB";
            this.amarilloPB.Size = new System.Drawing.Size(168, 135);
            this.amarilloPB.TabIndex = 1;
            this.amarilloPB.TabStop = false;
            // 
            // verdePB
            // 
            this.verdePB.BackColor = System.Drawing.Color.Black;
            this.verdePB.Location = new System.Drawing.Point(443, 116);
            this.verdePB.Name = "verdePB";
            this.verdePB.Size = new System.Drawing.Size(168, 134);
            this.verdePB.TabIndex = 2;
            this.verdePB.TabStop = false;
            // 
            // cambiaFaseB
            // 
            this.cambiaFaseB.Location = new System.Drawing.Point(639, 116);
            this.cambiaFaseB.Name = "cambiaFaseB";
            this.cambiaFaseB.Size = new System.Drawing.Size(149, 134);
            this.cambiaFaseB.TabIndex = 3;
            this.cambiaFaseB.Text = "Cambia de fase";
            this.cambiaFaseB.UseVisualStyleBackColor = true;
            this.cambiaFaseB.Click += new System.EventHandler(this.cambiaFaseB_Click);
            // 
            // mensajeL
            // 
            this.mensajeL.AutoSize = true;
            this.mensajeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensajeL.ForeColor = System.Drawing.Color.Blue;
            this.mensajeL.Location = new System.Drawing.Point(168, 382);
            this.mensajeL.Name = "mensajeL";
            this.mensajeL.Size = new System.Drawing.Size(334, 20);
            this.mensajeL.TabIndex = 4;
            this.mensajeL.Text = "Mi primera aplicación de Windowa Forms";
            // 
            // permitirCB
            // 
            this.permitirCB.AutoSize = true;
            this.permitirCB.Location = new System.Drawing.Point(172, 329);
            this.permitirCB.Name = "permitirCB";
            this.permitirCB.Size = new System.Drawing.Size(304, 24);
            this.permitirCB.TabIndex = 5;
            this.permitirCB.Text = "Habilitado para poder cambiar de fase";
            this.permitirCB.UseVisualStyleBackColor = true;
            this.permitirCB.CheckedChanged += new System.EventHandler(this.permitirCB_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.permitirCB);
            this.Controls.Add(this.mensajeL);
            this.Controls.Add(this.cambiaFaseB);
            this.Controls.Add(this.verdePB);
            this.Controls.Add(this.amarilloPB);
            this.Controls.Add(this.rojoPB);
            this.Name = "Form1";
            this.Text = "Semáforo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rojoPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amarilloPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rojoPB;
        private System.Windows.Forms.PictureBox amarilloPB;
        private System.Windows.Forms.PictureBox verdePB;
        private System.Windows.Forms.Button cambiaFaseB;
        private System.Windows.Forms.Label mensajeL;
        private System.Windows.Forms.CheckBox permitirCB;
    }
}

