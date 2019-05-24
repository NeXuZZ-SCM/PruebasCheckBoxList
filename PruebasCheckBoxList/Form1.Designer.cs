namespace PruebasCheckBoxList
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_prueba = new System.Windows.Forms.Label();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Permiso1",
            "Permiso2",
            "Permiso3",
            "Permiso4",
            "Permiso5"});
            this.checkedListBox1.Location = new System.Drawing.Point(266, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(165, 184);
            this.checkedListBox1.TabIndex = 0;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(23, 54);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(93, 33);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "label1";
            // 
            // lbl_prueba
            // 
            this.lbl_prueba.AutoSize = true;
            this.lbl_prueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prueba.Location = new System.Drawing.Point(23, 111);
            this.lbl_prueba.Name = "lbl_prueba";
            this.lbl_prueba.Size = new System.Drawing.Size(93, 33);
            this.lbl_prueba.TabIndex = 2;
            this.lbl_prueba.Text = "label2";
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Location = new System.Drawing.Point(12, 210);
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.Size = new System.Drawing.Size(419, 152);
            this.dgv_tabla.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 374);
            this.Controls.Add(this.dgv_tabla);
            this.Controls.Add(this.lbl_prueba);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_prueba;
        private System.Windows.Forms.DataGridView dgv_tabla;
    }
}

