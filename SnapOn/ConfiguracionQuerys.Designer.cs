namespace SnapOn
{
    partial class ConfiguracionQuerys
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTipo = new System.Windows.Forms.Panel();
            this.lblCuentaEntidad = new System.Windows.Forms.Label();
            this.txtCuentaEntidad = new System.Windows.Forms.TextBox();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rbSQL = new System.Windows.Forms.RadioButton();
            this.rbVistas = new System.Windows.Forms.RadioButton();
            this.rbCuentaEntidad = new System.Windows.Forms.RadioButton();
            this.btnSaveQuerys = new System.Windows.Forms.Button();
            this.btnSQLCompiller = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGrupos = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGrid2 = new System.Windows.Forms.Panel();
            this.lblTitlePnl = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.gvMain2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.pnlTipo.SuspendLayout();
            this.gbTipo.SuspendLayout();
            this.pnlGrid2.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 13);
            this.lblTitle.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlGrid2);
            this.panel1.Controls.Add(this.pnlTipo);
            this.panel1.Controls.Add(this.gbTipo);
            this.panel1.Controls.Add(this.btnSaveQuerys);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 587);
            this.panel1.TabIndex = 1;
            // 
            // pnlTipo
            // 
            this.pnlTipo.Controls.Add(this.lblCuentaEntidad);
            this.pnlTipo.Controls.Add(this.txtCuentaEntidad);
            this.pnlTipo.Location = new System.Drawing.Point(24, 92);
            this.pnlTipo.Name = "pnlTipo";
            this.pnlTipo.Size = new System.Drawing.Size(1105, 39);
            this.pnlTipo.TabIndex = 24;
            // 
            // lblCuentaEntidad
            // 
            this.lblCuentaEntidad.AutoSize = true;
            this.lblCuentaEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCuentaEntidad.Location = new System.Drawing.Point(245, 20);
            this.lblCuentaEntidad.Name = "lblCuentaEntidad";
            this.lblCuentaEntidad.Size = new System.Drawing.Size(116, 16);
            this.lblCuentaEntidad.TabIndex = 3;
            this.lblCuentaEntidad.Text = "Cuenta entidad:";
            // 
            // txtCuentaEntidad
            // 
            this.txtCuentaEntidad.Location = new System.Drawing.Point(383, 19);
            this.txtCuentaEntidad.Name = "txtCuentaEntidad";
            this.txtCuentaEntidad.Size = new System.Drawing.Size(393, 20);
            this.txtCuentaEntidad.TabIndex = 2;
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbSQL);
            this.gbTipo.Controls.Add(this.rbVistas);
            this.gbTipo.Controls.Add(this.rbCuentaEntidad);
            this.gbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbTipo.Location = new System.Drawing.Point(310, 21);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(454, 65);
            this.gbTipo.TabIndex = 23;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo de dato";
            // 
            // rbSQL
            // 
            this.rbSQL.AutoSize = true;
            this.rbSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbSQL.Location = new System.Drawing.Point(19, 28);
            this.rbSQL.Name = "rbSQL";
            this.rbSQL.Size = new System.Drawing.Size(77, 17);
            this.rbSQL.TabIndex = 2;
            this.rbSQL.TabStop = true;
            this.rbSQL.Text = "SQL Query";
            this.rbSQL.UseVisualStyleBackColor = true;
            this.rbSQL.CheckedChanged += new System.EventHandler(this.rbSQL_CheckedChanged);
            // 
            // rbVistas
            // 
            this.rbVistas.AutoSize = true;
            this.rbVistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbVistas.Location = new System.Drawing.Point(327, 28);
            this.rbVistas.Name = "rbVistas";
            this.rbVistas.Size = new System.Drawing.Size(53, 17);
            this.rbVistas.TabIndex = 1;
            this.rbVistas.TabStop = true;
            this.rbVistas.Text = "Vistas";
            this.rbVistas.UseVisualStyleBackColor = true;
            this.rbVistas.CheckedChanged += new System.EventHandler(this.rbVistas_CheckedChanged);
            // 
            // rbCuentaEntidad
            // 
            this.rbCuentaEntidad.AutoSize = true;
            this.rbCuentaEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbCuentaEntidad.Location = new System.Drawing.Point(164, 28);
            this.rbCuentaEntidad.Name = "rbCuentaEntidad";
            this.rbCuentaEntidad.Size = new System.Drawing.Size(97, 17);
            this.rbCuentaEntidad.TabIndex = 0;
            this.rbCuentaEntidad.TabStop = true;
            this.rbCuentaEntidad.Text = "Cuenta entidad";
            this.rbCuentaEntidad.UseVisualStyleBackColor = true;
            this.rbCuentaEntidad.CheckedChanged += new System.EventHandler(this.rbCuentaEntidad_CheckedChanged);
            // 
            // btnSaveQuerys
            // 
            this.btnSaveQuerys.Location = new System.Drawing.Point(1092, 532);
            this.btnSaveQuerys.Name = "btnSaveQuerys";
            this.btnSaveQuerys.Size = new System.Drawing.Size(75, 52);
            this.btnSaveQuerys.TabIndex = 22;
            this.btnSaveQuerys.Text = "Guardar";
            this.btnSaveQuerys.UseVisualStyleBackColor = true;
            this.btnSaveQuerys.Click += new System.EventHandler(this.btnSaveQuerys_Click);
            // 
            // btnSQLCompiller
            // 
            this.btnSQLCompiller.Location = new System.Drawing.Point(18, 347);
            this.btnSQLCompiller.Name = "btnSQLCompiller";
            this.btnSQLCompiller.Size = new System.Drawing.Size(75, 39);
            this.btnSQLCompiller.TabIndex = 21;
            this.btnSQLCompiller.Text = "Compilador SQL";
            this.btnSQLCompiller.UseVisualStyleBackColor = true;
            this.btnSQLCompiller.Click += new System.EventHandler(this.btnSQLCompiller_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(626, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Categoría:";
            // 
            // cmbGrupos
            // 
            this.cmbGrupos.FormattingEnabled = true;
            this.cmbGrupos.Location = new System.Drawing.Point(302, 36);
            this.cmbGrupos.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGrupos.Name = "cmbGrupos";
            this.cmbGrupos.Size = new System.Drawing.Size(247, 21);
            this.cmbGrupos.TabIndex = 14;
            this.cmbGrupos.SelectedIndexChanged += new System.EventHandler(this.cmbGrupos_SelectedIndexChanged);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(629, 38);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(247, 21);
            this.cmbCategoria.TabIndex = 15;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Grupo:";
            // 
            // pnlGrid2
            // 
            this.pnlGrid2.Controls.Add(this.lblTitlePnl);
            this.pnlGrid2.Controls.Add(this.pnlGrid);
            this.pnlGrid2.Controls.Add(this.label1);
            this.pnlGrid2.Controls.Add(this.cmbCategoria);
            this.pnlGrid2.Controls.Add(this.btnSQLCompiller);
            this.pnlGrid2.Controls.Add(this.cmbGrupos);
            this.pnlGrid2.Controls.Add(this.label2);
            this.pnlGrid2.Location = new System.Drawing.Point(24, 137);
            this.pnlGrid2.Name = "pnlGrid2";
            this.pnlGrid2.Size = new System.Drawing.Size(1119, 389);
            this.pnlGrid2.TabIndex = 25;
            // 
            // lblTitlePnl
            // 
            this.lblTitlePnl.AutoSize = true;
            this.lblTitlePnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitlePnl.Location = new System.Drawing.Point(15, 67);
            this.lblTitlePnl.Name = "lblTitlePnl";
            this.lblTitlePnl.Size = new System.Drawing.Size(37, 16);
            this.lblTitlePnl.TabIndex = 21;
            this.lblTitlePnl.Text = "Grid";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gvMain2);
            this.pnlGrid.Location = new System.Drawing.Point(18, 86);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1144, 255);
            this.pnlGrid.TabIndex = 22;
            // 
            // gvMain2
            // 
            this.gvMain2.AllowUserToAddRows = false;
            this.gvMain2.AllowUserToDeleteRows = false;
            this.gvMain2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvMain2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvMain2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvMain2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMain2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvMain2.Location = new System.Drawing.Point(0, 0);
            this.gvMain2.Name = "gvMain2";
            this.gvMain2.Size = new System.Drawing.Size(1144, 255);
            this.gvMain2.TabIndex = 1;
            // 
            // ConfiguracionQuerys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 587);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Name = "ConfiguracionQuerys";
            this.Text = "Configuracion Querys";
            this.panel1.ResumeLayout(false);
            this.pnlTipo.ResumeLayout(false);
            this.pnlTipo.PerformLayout();
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.pnlGrid2.ResumeLayout(false);
            this.pnlGrid2.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMain2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGrupos;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSQLCompiller;
        private System.Windows.Forms.Button btnSaveQuerys;
        private System.Windows.Forms.Panel pnlTipo;
        private System.Windows.Forms.Label lblCuentaEntidad;
        private System.Windows.Forms.TextBox txtCuentaEntidad;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton rbSQL;
        private System.Windows.Forms.RadioButton rbVistas;
        private System.Windows.Forms.RadioButton rbCuentaEntidad;
        private System.Windows.Forms.Panel pnlGrid2;
        private System.Windows.Forms.Label lblTitlePnl;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView gvMain2;
    }
}