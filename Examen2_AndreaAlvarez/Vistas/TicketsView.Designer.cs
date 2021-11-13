
namespace Examen2_AndreaAlvarez.Vistas
{
    partial class Tickets
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
            this.label1 = new System.Windows.Forms.Label();
            this.NombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TipoSoporteTextBox = new System.Windows.Forms.TextBox();
            this.CantidadaTikectsTextBox = new System.Windows.Forms.TextBox();
            this.EstadoTicketsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre cliente:";
            // 
            // NombreClienteTextBox
            // 
            this.NombreClienteTextBox.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreClienteTextBox.Location = new System.Drawing.Point(142, 37);
            this.NombreClienteTextBox.Name = "NombreClienteTextBox";
            this.NombreClienteTextBox.Size = new System.Drawing.Size(281, 21);
            this.NombreClienteTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de soporte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad de tickets:";
            // 
            // TipoSoporteTextBox
            // 
            this.TipoSoporteTextBox.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoSoporteTextBox.Location = new System.Drawing.Point(142, 81);
            this.TipoSoporteTextBox.Name = "TipoSoporteTextBox";
            this.TipoSoporteTextBox.Size = new System.Drawing.Size(281, 21);
            this.TipoSoporteTextBox.TabIndex = 4;
            // 
            // CantidadaTikectsTextBox
            // 
            this.CantidadaTikectsTextBox.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadaTikectsTextBox.Location = new System.Drawing.Point(142, 174);
            this.CantidadaTikectsTextBox.Name = "CantidadaTikectsTextBox";
            this.CantidadaTikectsTextBox.Size = new System.Drawing.Size(281, 21);
            this.CantidadaTikectsTextBox.TabIndex = 5;
            // 
            // EstadoTicketsTextBox
            // 
            this.EstadoTicketsTextBox.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoTicketsTextBox.Location = new System.Drawing.Point(142, 135);
            this.EstadoTicketsTextBox.Name = "EstadoTicketsTextBox";
            this.EstadoTicketsTextBox.Size = new System.Drawing.Size(281, 21);
            this.EstadoTicketsTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estado:";
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 364);
            this.Controls.Add(this.EstadoTicketsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CantidadaTikectsTextBox);
            this.Controls.Add(this.TipoSoporteTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreClienteTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Tickets";
            this.Text = "TicketsView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox EstadoTicketsTextBox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox NombreClienteTextBox;
        public System.Windows.Forms.TextBox TipoSoporteTextBox;
        public System.Windows.Forms.TextBox CantidadaTikectsTextBox;
    }
}