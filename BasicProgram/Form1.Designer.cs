namespace BasicProgram
{
    partial class MainForm
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.btnCalcularEdad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEdadCalculada = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(107, 116);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(322, 18);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Por favor, ingrese su fecha de nacimiento:";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFechaNacimiento.BackColor = System.Drawing.SystemColors.Menu;
            this.txtFechaNacimiento.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNacimiento.Location = new System.Drawing.Point(435, 110);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(153, 24);
            this.txtFechaNacimiento.TabIndex = 1;
            // 
            // btnCalcularEdad
            // 
            this.btnCalcularEdad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalcularEdad.BackColor = System.Drawing.Color.LawnGreen;
            this.btnCalcularEdad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcularEdad.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularEdad.Location = new System.Drawing.Point(445, 276);
            this.btnCalcularEdad.Name = "btnCalcularEdad";
            this.btnCalcularEdad.Size = new System.Drawing.Size(134, 29);
            this.btnCalcularEdad.TabIndex = 2;
            this.btnCalcularEdad.Text = "Calcular Edad";
            this.btnCalcularEdad.UseVisualStyleBackColor = false;
            this.btnCalcularEdad.Click += new System.EventHandler(this.btnCalcularEdad_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Su edad actual es:";
            // 
            // lblEdadCalculada
            // 
            this.lblEdadCalculada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEdadCalculada.AutoSize = true;
            this.lblEdadCalculada.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadCalculada.Location = new System.Drawing.Point(431, 191);
            this.lblEdadCalculada.Name = "lblEdadCalculada";
            this.lblEdadCalculada.Size = new System.Drawing.Size(0, 19);
            this.lblEdadCalculada.TabIndex = 4;
            this.lblEdadCalculada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(292, 276);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 29);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(107, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(491, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "(Debe ingresar la fecha en uno de los siguientes formatos: \"dd/mm/yyyy\" o \"dd-mm-" +
    "yyyy\")";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblEdadCalculada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcularEdad);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.lblInfo);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Edad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.Button btnCalcularEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEdadCalculada;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label2;
    }
}

