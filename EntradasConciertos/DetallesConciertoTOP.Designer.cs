namespace EntradasConciertos
{
    partial class DetallesConciertoTOP
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
            this.panelInfoConcierto = new System.Windows.Forms.Panel();
            this.numEntradas = new System.Windows.Forms.NumericUpDown();
            this.botonComprar = new System.Windows.Forms.Button();
            this.labelInfoConcierto = new System.Windows.Forms.Label();
            this.logoBanda = new System.Windows.Forms.PictureBox();
            this.botonVolver = new System.Windows.Forms.Button();
            this.labelEntradasAdquiridas = new System.Windows.Forms.Label();
            this.panelInfoConcierto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBanda)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfoConcierto
            // 
            this.panelInfoConcierto.Controls.Add(this.labelEntradasAdquiridas);
            this.panelInfoConcierto.Controls.Add(this.numEntradas);
            this.panelInfoConcierto.Controls.Add(this.botonComprar);
            this.panelInfoConcierto.Controls.Add(this.labelInfoConcierto);
            this.panelInfoConcierto.Controls.Add(this.logoBanda);
            this.panelInfoConcierto.Location = new System.Drawing.Point(155, 47);
            this.panelInfoConcierto.Name = "panelInfoConcierto";
            this.panelInfoConcierto.Size = new System.Drawing.Size(538, 410);
            this.panelInfoConcierto.TabIndex = 1;
            // 
            // numEntradas
            // 
            this.numEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEntradas.Location = new System.Drawing.Point(130, 342);
            this.numEntradas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numEntradas.Name = "numEntradas";
            this.numEntradas.Size = new System.Drawing.Size(52, 26);
            this.numEntradas.TabIndex = 12;
            // 
            // botonComprar
            // 
            this.botonComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonComprar.Location = new System.Drawing.Point(199, 336);
            this.botonComprar.Name = "botonComprar";
            this.botonComprar.Size = new System.Drawing.Size(155, 36);
            this.botonComprar.TabIndex = 11;
            this.botonComprar.Text = "Comprar entradas";
            this.botonComprar.UseVisualStyleBackColor = true;
            this.botonComprar.Click += new System.EventHandler(this.botonComprar_Click);
            // 
            // labelInfoConcierto
            // 
            this.labelInfoConcierto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoConcierto.Location = new System.Drawing.Point(113, 126);
            this.labelInfoConcierto.Name = "labelInfoConcierto";
            this.labelInfoConcierto.Size = new System.Drawing.Size(318, 195);
            this.labelInfoConcierto.TabIndex = 10;
            this.labelInfoConcierto.Text = "Como parte del Bandito Tour, tocarán los siguientes temas:\r\n1. Jumpsuit\r\n2. Nico " +
    "And The Niners\r\n3. Chlorine\r\n4. Holding On To You\r\n5. Fairly Local\r\n6. Car Radio" +
    "\r\n7. Trees";
            // 
            // logoBanda
            // 
            this.logoBanda.Image = global::EntradasConciertos.Properties.Resources._61489df2e8157300048d701b1;
            this.logoBanda.Location = new System.Drawing.Point(158, 16);
            this.logoBanda.Name = "logoBanda";
            this.logoBanda.Size = new System.Drawing.Size(227, 95);
            this.logoBanda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBanda.TabIndex = 9;
            this.logoBanda.TabStop = false;
            // 
            // botonVolver
            // 
            this.botonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVolver.Location = new System.Drawing.Point(728, 22);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(91, 31);
            this.botonVolver.TabIndex = 5;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // labelEntradasAdquiridas
            // 
            this.labelEntradasAdquiridas.AutoSize = true;
            this.labelEntradasAdquiridas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntradasAdquiridas.ForeColor = System.Drawing.Color.Green;
            this.labelEntradasAdquiridas.Location = new System.Drawing.Point(196, 384);
            this.labelEntradasAdquiridas.Name = "labelEntradasAdquiridas";
            this.labelEntradasAdquiridas.Size = new System.Drawing.Size(154, 17);
            this.labelEntradasAdquiridas.TabIndex = 13;
            this.labelEntradasAdquiridas.Text = "Entradas adquiridas";
            this.labelEntradasAdquiridas.Visible = false;
            // 
            // DetallesConciertoTOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EntradasConciertos.Properties.Resources.ticketport_main;
            this.ClientSize = new System.Drawing.Size(845, 507);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.panelInfoConcierto);
            this.Name = "DetallesConciertoTOP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concierto Twenty One Pilots";
            this.panelInfoConcierto.ResumeLayout(false);
            this.panelInfoConcierto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBanda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelInfoConcierto;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.PictureBox logoBanda;
        private System.Windows.Forms.Label labelInfoConcierto;
        private System.Windows.Forms.NumericUpDown numEntradas;
        private System.Windows.Forms.Button botonComprar;
        private System.Windows.Forms.Label labelEntradasAdquiridas;
    }
}