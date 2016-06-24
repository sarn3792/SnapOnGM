namespace SnapOn
{
    partial class Configuracion
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabColumna = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcionColumna = new System.Windows.Forms.TextBox();
            this.btnAgregarColumna = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.cmbGrupos = new System.Windows.Forms.ComboBox();
            this.lblAgregarFilas = new System.Windows.Forms.Label();
            this.tabFilas = new System.Windows.Forms.TabPage();
            this.txtDescripcionFila = new System.Windows.Forms.TextBox();
            this.txtIDFila = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCategoriaFila = new System.Windows.Forms.ComboBox();
            this.cmbGrupoFila = new System.Windows.Forms.ComboBox();
            this.btnAgregarFila = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.tabColumna.SuspendLayout();
            this.tabFilas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabColumna);
            this.tabs.Controls.Add(this.tabFilas);
            this.tabs.Location = new System.Drawing.Point(12, 41);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(724, 337);
            this.tabs.TabIndex = 0;
            // 
            // tabColumna
            // 
            this.tabColumna.Controls.Add(this.label5);
            this.tabColumna.Controls.Add(this.txtDescripcionColumna);
            this.tabColumna.Controls.Add(this.btnAgregarColumna);
            this.tabColumna.Controls.Add(this.label2);
            this.tabColumna.Controls.Add(this.label1);
            this.tabColumna.Controls.Add(this.cmbItems);
            this.tabColumna.Controls.Add(this.cmbGrupos);
            this.tabColumna.Controls.Add(this.lblAgregarFilas);
            this.tabColumna.Location = new System.Drawing.Point(4, 22);
            this.tabColumna.Name = "tabColumna";
            this.tabColumna.Padding = new System.Windows.Forms.Padding(3);
            this.tabColumna.Size = new System.Drawing.Size(716, 311);
            this.tabColumna.TabIndex = 0;
            this.tabColumna.Text = "Columna";
            this.tabColumna.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Descripción:";
            // 
            // txtDescripcionColumna
            // 
            this.txtDescripcionColumna.Location = new System.Drawing.Point(279, 191);
            this.txtDescripcionColumna.Name = "txtDescripcionColumna";
            this.txtDescripcionColumna.Size = new System.Drawing.Size(175, 20);
            this.txtDescripcionColumna.TabIndex = 10;
            // 
            // btnAgregarColumna
            // 
            this.btnAgregarColumna.Location = new System.Drawing.Point(586, 251);
            this.btnAgregarColumna.Name = "btnAgregarColumna";
            this.btnAgregarColumna.Size = new System.Drawing.Size(75, 41);
            this.btnAgregarColumna.TabIndex = 9;
            this.btnAgregarColumna.Text = "Agregar columna";
            this.btnAgregarColumna.UseVisualStyleBackColor = true;
            this.btnAgregarColumna.Click += new System.EventHandler(this.btnAgregarColumnas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categoría:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Grupo:";
            // 
            // cmbItems
            // 
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Location = new System.Drawing.Point(415, 92);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(246, 21);
            this.cmbItems.TabIndex = 2;
            this.cmbItems.SelectedIndexChanged += new System.EventHandler(this.cmbItems_SelectedIndexChanged);
            // 
            // cmbGrupos
            // 
            this.cmbGrupos.FormattingEnabled = true;
            this.cmbGrupos.Location = new System.Drawing.Point(37, 92);
            this.cmbGrupos.Name = "cmbGrupos";
            this.cmbGrupos.Size = new System.Drawing.Size(240, 21);
            this.cmbGrupos.TabIndex = 1;
            this.cmbGrupos.SelectedIndexChanged += new System.EventHandler(this.cmbGrupos_SelectedIndexChanged);
            // 
            // lblAgregarFilas
            // 
            this.lblAgregarFilas.AutoSize = true;
            this.lblAgregarFilas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarFilas.Location = new System.Drawing.Point(16, 20);
            this.lblAgregarFilas.Name = "lblAgregarFilas";
            this.lblAgregarFilas.Size = new System.Drawing.Size(170, 22);
            this.lblAgregarFilas.TabIndex = 0;
            this.lblAgregarFilas.Text = "Agregar columna";
            // 
            // tabFilas
            // 
            this.tabFilas.Controls.Add(this.btnAgregarFila);
            this.tabFilas.Controls.Add(this.label7);
            this.tabFilas.Controls.Add(this.label8);
            this.tabFilas.Controls.Add(this.cmbCategoriaFila);
            this.tabFilas.Controls.Add(this.cmbGrupoFila);
            this.tabFilas.Controls.Add(this.label6);
            this.tabFilas.Controls.Add(this.txtDescripcionFila);
            this.tabFilas.Controls.Add(this.txtIDFila);
            this.tabFilas.Controls.Add(this.label4);
            this.tabFilas.Controls.Add(this.label3);
            this.tabFilas.Location = new System.Drawing.Point(4, 22);
            this.tabFilas.Name = "tabFilas";
            this.tabFilas.Padding = new System.Windows.Forms.Padding(3);
            this.tabFilas.Size = new System.Drawing.Size(716, 311);
            this.tabFilas.TabIndex = 1;
            this.tabFilas.Text = "Filas";
            this.tabFilas.UseVisualStyleBackColor = true;
            // 
            // txtDescripcionFila
            // 
            this.txtDescripcionFila.Location = new System.Drawing.Point(425, 191);
            this.txtDescripcionFila.Name = "txtDescripcionFila";
            this.txtDescripcionFila.Size = new System.Drawing.Size(246, 20);
            this.txtDescripcionFila.TabIndex = 12;
            // 
            // txtIDFila
            // 
            this.txtIDFila.Location = new System.Drawing.Point(50, 192);
            this.txtIDFila.Name = "txtIDFila";
            this.txtIDFila.Size = new System.Drawing.Size(115, 20);
            this.txtIDFila.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Agregar fila";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(422, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Categoría:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Grupo:";
            // 
            // cmbCategoriaFila
            // 
            this.cmbCategoriaFila.FormattingEnabled = true;
            this.cmbCategoriaFila.Location = new System.Drawing.Point(425, 93);
            this.cmbCategoriaFila.Name = "cmbCategoriaFila";
            this.cmbCategoriaFila.Size = new System.Drawing.Size(246, 21);
            this.cmbCategoriaFila.TabIndex = 15;
            this.cmbCategoriaFila.SelectedIndexChanged += new System.EventHandler(this.cmbCategoriaFila_SelectedIndexChanged);
            // 
            // cmbGrupoFila
            // 
            this.cmbGrupoFila.FormattingEnabled = true;
            this.cmbGrupoFila.Location = new System.Drawing.Point(47, 93);
            this.cmbGrupoFila.Name = "cmbGrupoFila";
            this.cmbGrupoFila.Size = new System.Drawing.Size(240, 21);
            this.cmbGrupoFila.TabIndex = 14;
            this.cmbGrupoFila.SelectedIndexChanged += new System.EventHandler(this.cmbGrupoFila_SelectedIndexChanged);
            // 
            // btnAgregarFila
            // 
            this.btnAgregarFila.Location = new System.Drawing.Point(596, 252);
            this.btnAgregarFila.Name = "btnAgregarFila";
            this.btnAgregarFila.Size = new System.Drawing.Size(75, 41);
            this.btnAgregarFila.TabIndex = 18;
            this.btnAgregarFila.Text = "Agregar fila";
            this.btnAgregarFila.UseVisualStyleBackColor = true;
            this.btnAgregarFila.Click += new System.EventHandler(this.btnAgregarFila_Click);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 403);
            this.Controls.Add(this.tabs);
            this.Name = "Configuracion";
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.tabs.ResumeLayout(false);
            this.tabColumna.ResumeLayout(false);
            this.tabColumna.PerformLayout();
            this.tabFilas.ResumeLayout(false);
            this.tabFilas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabColumna;
        private System.Windows.Forms.Label lblAgregarFilas;
        private System.Windows.Forms.TabPage tabFilas;
        private System.Windows.Forms.ComboBox cmbGrupos;
        private System.Windows.Forms.ComboBox cmbItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarColumna;
        private System.Windows.Forms.TextBox txtDescripcionFila;
        private System.Windows.Forms.TextBox txtIDFila;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcionColumna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregarFila;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCategoriaFila;
        private System.Windows.Forms.ComboBox cmbGrupoFila;

    }
}

