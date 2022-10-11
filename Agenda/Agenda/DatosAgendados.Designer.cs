namespace Agenda
{
    partial class frmDatosAgendados
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
            this.rbtAgendaSimple = new System.Windows.Forms.RadioButton();
            this.rbtAgendaCompleta = new System.Windows.Forms.RadioButton();
            this.dtgResultado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtAgendaSimple
            // 
            this.rbtAgendaSimple.AutoSize = true;
            this.rbtAgendaSimple.Location = new System.Drawing.Point(94, 73);
            this.rbtAgendaSimple.Name = "rbtAgendaSimple";
            this.rbtAgendaSimple.Size = new System.Drawing.Size(94, 17);
            this.rbtAgendaSimple.TabIndex = 0;
            this.rbtAgendaSimple.TabStop = true;
            this.rbtAgendaSimple.Text = "Agenda simple";
            this.rbtAgendaSimple.UseVisualStyleBackColor = true;
            this.rbtAgendaSimple.CheckedChanged += new System.EventHandler(this.rbtAgendaSimple_CheckedChanged);
            // 
            // rbtAgendaCompleta
            // 
            this.rbtAgendaCompleta.AutoSize = true;
            this.rbtAgendaCompleta.Location = new System.Drawing.Point(94, 111);
            this.rbtAgendaCompleta.Name = "rbtAgendaCompleta";
            this.rbtAgendaCompleta.Size = new System.Drawing.Size(109, 17);
            this.rbtAgendaCompleta.TabIndex = 1;
            this.rbtAgendaCompleta.TabStop = true;
            this.rbtAgendaCompleta.Text = "Agenda Completa";
            this.rbtAgendaCompleta.UseVisualStyleBackColor = true;
            this.rbtAgendaCompleta.CheckedChanged += new System.EventHandler(this.rbtAgendaCompleta_CheckedChanged);
            // 
            // dtgResultado
            // 
            this.dtgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultado.Location = new System.Drawing.Point(94, 166);
            this.dtgResultado.Name = "dtgResultado";
            this.dtgResultado.Size = new System.Drawing.Size(501, 219);
            this.dtgResultado.TabIndex = 2;
            this.dtgResultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmDatosAgendados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgResultado);
            this.Controls.Add(this.rbtAgendaCompleta);
            this.Controls.Add(this.rbtAgendaSimple);
            this.Name = "frmDatosAgendados";
            this.Text = "DatosAgendados";
            this.Load += new System.EventHandler(this.DatosAgendados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtAgendaSimple;
        private System.Windows.Forms.RadioButton rbtAgendaCompleta;
        private System.Windows.Forms.DataGridView dtgResultado;
    }
}