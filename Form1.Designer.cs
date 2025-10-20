namespace EstacionMeteorologica
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
            this.components = new System.ComponentModel.Container();
            this.lblPMS5003 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblBME680 = new System.Windows.Forms.Label();
            this.lblFS300A = new System.Windows.Forms.Label();
            this.lblYL83 = new System.Windows.Forms.Label();
            this.lblML8511 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPMS5003
            // 
            this.lblPMS5003.AutoSize = true;
            this.lblPMS5003.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMS5003.Location = new System.Drawing.Point(120, 76);
            this.lblPMS5003.Name = "lblPMS5003";
            this.lblPMS5003.Size = new System.Drawing.Size(79, 20);
            this.lblPMS5003.TabIndex = 0;
            this.lblPMS5003.Text = "PMS5003";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(167, 9);
            this.lbl.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(503, 50);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "🌦️ Estación metereologica";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lblBME680
            // 
            this.lblBME680.AutoSize = true;
            this.lblBME680.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBME680.Location = new System.Drawing.Point(120, 133);
            this.lblBME680.Name = "lblBME680";
            this.lblBME680.Size = new System.Drawing.Size(71, 20);
            this.lblBME680.TabIndex = 3;
            this.lblBME680.Text = "BME680";
            // 
            // lblFS300A
            // 
            this.lblFS300A.AutoSize = true;
            this.lblFS300A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFS300A.Location = new System.Drawing.Point(120, 187);
            this.lblFS300A.Name = "lblFS300A";
            this.lblFS300A.Size = new System.Drawing.Size(68, 20);
            this.lblFS300A.TabIndex = 4;
            this.lblFS300A.Text = "FS300A";
            // 
            // lblYL83
            // 
            this.lblYL83.AutoSize = true;
            this.lblYL83.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYL83.Location = new System.Drawing.Point(120, 243);
            this.lblYL83.Name = "lblYL83";
            this.lblYL83.Size = new System.Drawing.Size(52, 20);
            this.lblYL83.TabIndex = 5;
            this.lblYL83.Text = "YL-83";
            // 
            // lblML8511
            // 
            this.lblML8511.AutoSize = true;
            this.lblML8511.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblML8511.Location = new System.Drawing.Point(120, 302);
            this.lblML8511.Name = "lblML8511";
            this.lblML8511.Size = new System.Drawing.Size(67, 20);
            this.lblML8511.TabIndex = 6;
            this.lblML8511.Text = "ML8511";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(439, 302);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(119, 35);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Salir ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblML8511);
            this.Controls.Add(this.lblYL83);
            this.Controls.Add(this.lblFS300A);
            this.Controls.Add(this.lblBME680);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblPMS5003);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPMS5003;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblBME680;
        private System.Windows.Forms.Label lblFS300A;
        private System.Windows.Forms.Label lblYL83;
        private System.Windows.Forms.Label lblML8511;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

