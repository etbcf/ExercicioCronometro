namespace ExercicioCronometro
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.TimerRelogio = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnOnOff
            // 
            this.btnOnOff.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnOnOff.Location = new System.Drawing.Point(237, 12);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(82, 66);
            this.btnOnOff.TabIndex = 0;
            this.btnOnOff.Text = "Ligar";
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContador.Location = new System.Drawing.Point(12, 38);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(104, 17);
            this.lblContador.TabIndex = 1;
            this.lblContador.Text = "00:00:00:000";
            // 
            // TimerRelogio
            // 
            this.TimerRelogio.Tick += new System.EventHandler(this.TimerRelogio_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 91);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnOnOff);
            this.Name = "frmPrincipal";
            this.Text = "Cronómetro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOnOff;
        private Label lblContador;
        private System.Windows.Forms.Timer TimerRelogio;
    }
}