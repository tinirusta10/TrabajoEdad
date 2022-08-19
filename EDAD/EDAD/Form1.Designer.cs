namespace EDAD
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Btn_Persona = new System.Windows.Forms.Button();
            this.Txt_FechaNac = new System.Windows.Forms.TextBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.Txt_Dni = new System.Windows.Forms.TextBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.Btn_Edad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Edad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(120, 67);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(256, 66);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.Txt_Nombre.TabIndex = 1;

            // 
            // Btn_Persona
            // 
            this.Btn_Persona.Location = new System.Drawing.Point(434, 63);
            this.Btn_Persona.Name = "Btn_Persona";
            this.Btn_Persona.Size = new System.Drawing.Size(94, 23);
            this.Btn_Persona.TabIndex = 2;
            this.Btn_Persona.Text = "Btn_Persona";
            this.Btn_Persona.UseVisualStyleBackColor = true;
            this.Btn_Persona.Click += new System.EventHandler(this.Btn_Persona_Click);
            // 
            // Txt_FechaNac
            // 
            this.Txt_FechaNac.Location = new System.Drawing.Point(256, 180);
            this.Txt_FechaNac.Name = "Txt_FechaNac";
            this.Txt_FechaNac.Size = new System.Drawing.Size(100, 20);
            this.Txt_FechaNac.TabIndex = 4;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(120, 181);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(106, 13);
            this.lbl_fecha.TabIndex = 3;
            this.lbl_fecha.Text = "Fecha de nacimiento";
            // 
            // Txt_Dni
            // 
            this.Txt_Dni.Location = new System.Drawing.Point(256, 125);
            this.Txt_Dni.Name = "Txt_Dni";
            this.Txt_Dni.Size = new System.Drawing.Size(100, 20);
            this.Txt_Dni.TabIndex = 6;
            this.Txt_Dni.TextChanged += new System.EventHandler(this.Txt_Dni_TextChanged);
            this.Txt_Dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Dni_KeyPress);
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(120, 126);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(26, 13);
            this.lbl_dni.TabIndex = 5;
            this.lbl_dni.Text = "DNI";
            // 
            // Btn_Edad
            // 
            this.Btn_Edad.Location = new System.Drawing.Point(434, 116);
            this.Btn_Edad.Name = "Btn_Edad";
            this.Btn_Edad.Size = new System.Drawing.Size(94, 23);
            this.Btn_Edad.TabIndex = 7;
            this.Btn_Edad.Text = "Btn_Edad";
            this.Btn_Edad.UseVisualStyleBackColor = true;
            this.Btn_Edad.Click += new System.EventHandler(this.Btn_Edad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Edad:";
            // 
            // Lbl_Edad
            // 
            this.Lbl_Edad.AutoSize = true;
            this.Lbl_Edad.Location = new System.Drawing.Point(475, 187);
            this.Lbl_Edad.Name = "Lbl_Edad";
            this.Lbl_Edad.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Edad.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_Edad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Edad);
            this.Controls.Add(this.Txt_Dni);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.Txt_FechaNac);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.Btn_Persona);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Button Btn_Persona;
        private System.Windows.Forms.TextBox Txt_FechaNac;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.TextBox Txt_Dni;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Button Btn_Edad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Edad;
    }
}

