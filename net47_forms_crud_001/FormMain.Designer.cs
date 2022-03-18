
namespace net47_forms_crud_001
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.a_paternoTextBox = new System.Windows.Forms.TextBox();
            this.a_maternoTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.nro_documentoTextBox = new System.Windows.Forms.TextBox();
            this.nro_contactoTextBox = new System.Windows.Forms.TextBox();
            this.guardarButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.clientesDataGridView = new System.Windows.Forms.DataGridView();
            this.reporteButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "A. Paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "A. Materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nro. Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nro. Contacto";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(113, 51);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(124, 20);
            this.nombreTextBox.TabIndex = 6;
            // 
            // a_paternoTextBox
            // 
            this.a_paternoTextBox.Location = new System.Drawing.Point(113, 77);
            this.a_paternoTextBox.Name = "a_paternoTextBox";
            this.a_paternoTextBox.Size = new System.Drawing.Size(124, 20);
            this.a_paternoTextBox.TabIndex = 7;
            // 
            // a_maternoTextBox
            // 
            this.a_maternoTextBox.Location = new System.Drawing.Point(113, 108);
            this.a_maternoTextBox.Name = "a_maternoTextBox";
            this.a_maternoTextBox.Size = new System.Drawing.Size(124, 20);
            this.a_maternoTextBox.TabIndex = 8;
            // 
            // correoTextBox
            // 
            this.correoTextBox.Location = new System.Drawing.Point(113, 142);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(124, 20);
            this.correoTextBox.TabIndex = 9;
            // 
            // nro_documentoTextBox
            // 
            this.nro_documentoTextBox.Location = new System.Drawing.Point(113, 169);
            this.nro_documentoTextBox.Name = "nro_documentoTextBox";
            this.nro_documentoTextBox.Size = new System.Drawing.Size(124, 20);
            this.nro_documentoTextBox.TabIndex = 10;
            // 
            // nro_contactoTextBox
            // 
            this.nro_contactoTextBox.Location = new System.Drawing.Point(113, 195);
            this.nro_contactoTextBox.Name = "nro_contactoTextBox";
            this.nro_contactoTextBox.Size = new System.Drawing.Size(124, 20);
            this.nro_contactoTextBox.TabIndex = 11;
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(12, 234);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(63, 32);
            this.guardarButton.TabIndex = 12;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // editarButton
            // 
            this.editarButton.Enabled = false;
            this.editarButton.Location = new System.Drawing.Point(94, 235);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(63, 32);
            this.editarButton.TabIndex = 13;
            this.editarButton.Text = "Editar";
            this.editarButton.UseVisualStyleBackColor = true;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Enabled = false;
            this.cancelarButton.Location = new System.Drawing.Point(174, 235);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(63, 31);
            this.cancelarButton.TabIndex = 14;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // clientesDataGridView
            // 
            this.clientesDataGridView.AllowUserToAddRows = false;
            this.clientesDataGridView.AllowUserToDeleteRows = false;
            this.clientesDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.clientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGridView.Location = new System.Drawing.Point(302, 51);
            this.clientesDataGridView.Name = "clientesDataGridView";
            this.clientesDataGridView.ReadOnly = true;
            this.clientesDataGridView.ShowCellErrors = false;
            this.clientesDataGridView.ShowCellToolTips = false;
            this.clientesDataGridView.ShowEditingIcon = false;
            this.clientesDataGridView.ShowRowErrors = false;
            this.clientesDataGridView.Size = new System.Drawing.Size(291, 215);
            this.clientesDataGridView.TabIndex = 15;
            this.clientesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientesDataGridView_CellClick);
            // 
            // reporteButton
            // 
            this.reporteButton.Location = new System.Drawing.Point(530, 12);
            this.reporteButton.Name = "reporteButton";
            this.reporteButton.Size = new System.Drawing.Size(63, 31);
            this.reporteButton.TabIndex = 16;
            this.reporteButton.Text = "Reporte";
            this.reporteButton.UseVisualStyleBackColor = true;
            this.reporteButton.Click += new System.EventHandler(this.reporteButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Clientes";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 279);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reporteButton);
            this.Controls.Add(this.clientesDataGridView);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.nro_contactoTextBox);
            this.Controls.Add(this.nro_documentoTextBox);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(this.a_maternoTextBox);
            this.Controls.Add(this.a_paternoTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox a_paternoTextBox;
        private System.Windows.Forms.TextBox a_maternoTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox nro_documentoTextBox;
        private System.Windows.Forms.TextBox nro_contactoTextBox;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.Button editarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.DataGridView clientesDataGridView;
        private System.Windows.Forms.Button reporteButton;
        private System.Windows.Forms.Label label7;
    }
}

