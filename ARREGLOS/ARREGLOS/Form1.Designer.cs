
namespace ARREGLOS
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
            this.buttonNota1 = new System.Windows.Forms.Button();
            this.buttonNombres = new System.Windows.Forms.Button();
            this.listBoxNota1 = new System.Windows.Forms.ListBox();
            this.listBoxNota2 = new System.Windows.Forms.ListBox();
            this.listBoxNota3 = new System.Windows.Forms.ListBox();
            this.buttonNota2 = new System.Windows.Forms.Button();
            this.buttonNota3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.buttonPromedio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNota1
            // 
            this.buttonNota1.Location = new System.Drawing.Point(21, 102);
            this.buttonNota1.Name = "buttonNota1";
            this.buttonNota1.Size = new System.Drawing.Size(75, 23);
            this.buttonNota1.TabIndex = 0;
            this.buttonNota1.Text = "Parcial 1";
            this.buttonNota1.UseVisualStyleBackColor = true;
            this.buttonNota1.Click += new System.EventHandler(this.buttonNota1_Click_1);
            // 
            // buttonNombres
            // 
            this.buttonNombres.Location = new System.Drawing.Point(21, 73);
            this.buttonNombres.Name = "buttonNombres";
            this.buttonNombres.Size = new System.Drawing.Size(75, 23);
            this.buttonNombres.TabIndex = 4;
            this.buttonNombres.Text = "Nombres";
            this.buttonNombres.UseVisualStyleBackColor = true;
            this.buttonNombres.Click += new System.EventHandler(this.buttonNombres_Click);
            // 
            // listBoxNota1
            // 
            this.listBoxNota1.FormattingEnabled = true;
            this.listBoxNota1.Location = new System.Drawing.Point(338, 50);
            this.listBoxNota1.Name = "listBoxNota1";
            this.listBoxNota1.Size = new System.Drawing.Size(101, 173);
            this.listBoxNota1.TabIndex = 5;
            // 
            // listBoxNota2
            // 
            this.listBoxNota2.FormattingEnabled = true;
            this.listBoxNota2.Location = new System.Drawing.Point(447, 50);
            this.listBoxNota2.Name = "listBoxNota2";
            this.listBoxNota2.Size = new System.Drawing.Size(92, 173);
            this.listBoxNota2.TabIndex = 6;
            // 
            // listBoxNota3
            // 
            this.listBoxNota3.FormattingEnabled = true;
            this.listBoxNota3.Location = new System.Drawing.Point(546, 50);
            this.listBoxNota3.Name = "listBoxNota3";
            this.listBoxNota3.Size = new System.Drawing.Size(95, 173);
            this.listBoxNota3.TabIndex = 7;
            // 
            // buttonNota2
            // 
            this.buttonNota2.Location = new System.Drawing.Point(21, 131);
            this.buttonNota2.Name = "buttonNota2";
            this.buttonNota2.Size = new System.Drawing.Size(75, 23);
            this.buttonNota2.TabIndex = 8;
            this.buttonNota2.Text = "Parcial 2";
            this.buttonNota2.UseVisualStyleBackColor = true;
            this.buttonNota2.Click += new System.EventHandler(this.buttonNota2_Click);
            // 
            // buttonNota3
            // 
            this.buttonNota3.Location = new System.Drawing.Point(21, 160);
            this.buttonNota3.Name = "buttonNota3";
            this.buttonNota3.Size = new System.Drawing.Size(75, 23);
            this.buttonNota3.TabIndex = 9;
            this.buttonNota3.Text = "Parcial 3";
            this.buttonNota3.UseVisualStyleBackColor = true;
            this.buttonNota3.Click += new System.EventHandler(this.buttonNota3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "NOMBRES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "NOTA PARCIAL 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "NOTA PARCIAL 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "NOTA PARCIAL 3";
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.Location = new System.Drawing.Point(124, 50);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(208, 173);
            this.listBoxResultado.TabIndex = 20;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(124, 230);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(208, 167);
            this.textBoxResultado.TabIndex = 22;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(21, 46);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(75, 23);
            this.buttonCargar.TabIndex = 23;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click_1);
            // 
            // buttonPromedio
            // 
            this.buttonPromedio.Location = new System.Drawing.Point(21, 189);
            this.buttonPromedio.Name = "buttonPromedio";
            this.buttonPromedio.Size = new System.Drawing.Size(75, 49);
            this.buttonPromedio.TabIndex = 24;
            this.buttonPromedio.Text = "Promedio General";
            this.buttonPromedio.UseVisualStyleBackColor = true;
            this.buttonPromedio.Click += new System.EventHandler(this.buttonPromedio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPromedio);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNota3);
            this.Controls.Add(this.buttonNota2);
            this.Controls.Add(this.listBoxNota3);
            this.Controls.Add(this.listBoxNota2);
            this.Controls.Add(this.listBoxNota1);
            this.Controls.Add(this.buttonNombres);
            this.Controls.Add(this.buttonNota1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNota1;
        private System.Windows.Forms.Button buttonNombres;
        private System.Windows.Forms.ListBox listBoxNota1;
        private System.Windows.Forms.ListBox listBoxNota2;
        private System.Windows.Forms.ListBox listBoxNota3;
        private System.Windows.Forms.Button buttonNota2;
        private System.Windows.Forms.Button buttonNota3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button buttonPromedio;
    }
}

