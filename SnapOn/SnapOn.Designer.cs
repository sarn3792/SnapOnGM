namespace SnapOn
{
    partial class SnapOn
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
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbGrupos = new System.Windows.Forms.ComboBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlTipo = new System.Windows.Forms.Panel();
            this.lblSQL = new System.Windows.Forms.Label();
            this.lblCuentaEntidad = new System.Windows.Forms.Label();
            this.txtCuentaEntidad = new System.Windows.Forms.TextBox();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.lblTitlePnl = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.gvMain = new System.Windows.Forms.DataGridView();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rbSQL = new System.Windows.Forms.RadioButton();
            this.rbVistas = new System.Windows.Forms.RadioButton();
            this.rbCuentaEntidad = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.pnlTipo.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).BeginInit();
            this.gbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Location = new System.Drawing.Point(1028, 12);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(80, 39);
            this.btnConfiguracion.TabIndex = 0;
            this.btnConfiguracion.Text = "Configuración";
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(145, 22);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Ingresar datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Categoría:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Grupo:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(450, 44);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(247, 21);
            this.cmbCategoria.TabIndex = 6;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // cmbGrupos
            // 
            this.cmbGrupos.FormattingEnabled = true;
            this.cmbGrupos.Location = new System.Drawing.Point(123, 42);
            this.cmbGrupos.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGrupos.Name = "cmbGrupos";
            this.cmbGrupos.Size = new System.Drawing.Size(247, 21);
            this.cmbGrupos.TabIndex = 5;
            this.cmbGrupos.SelectedIndexChanged += new System.EventHandler(this.cmbGrupos_SelectedIndexChanged);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(803, 24);
            this.lblItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(41, 16);
            this.lblItem.TabIndex = 10;
            this.lblItem.Text = "Item:";
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(806, 44);
            this.cmbItem.Margin = new System.Windows.Forms.Padding(2);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(288, 21);
            this.cmbItem.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.pnlTipo);
            this.panel1.Controls.Add(this.lblTitlePnl);
            this.panel1.Controls.Add(this.pnlGrid);
            this.panel1.Controls.Add(this.gbTipo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblItem);
            this.panel1.Controls.Add(this.cmbGrupos);
            this.panel1.Controls.Add(this.cmbItem);
            this.panel1.Controls.Add(this.cmbCategoria);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 725);
            this.panel1.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(1082, 602);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 48);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlTipo
            // 
            this.pnlTipo.Controls.Add(this.lblSQL);
            this.pnlTipo.Controls.Add(this.lblCuentaEntidad);
            this.pnlTipo.Controls.Add(this.txtCuentaEntidad);
            this.pnlTipo.Controls.Add(this.txtQuery);
            this.pnlTipo.Location = new System.Drawing.Point(48, 433);
            this.pnlTipo.Name = "pnlTipo";
            this.pnlTipo.Size = new System.Drawing.Size(1144, 119);
            this.pnlTipo.TabIndex = 13;
            // 
            // lblSQL
            // 
            this.lblSQL.AutoSize = true;
            this.lblSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSQL.Location = new System.Drawing.Point(64, 35);
            this.lblSQL.Name = "lblSQL";
            this.lblSQL.Size = new System.Drawing.Size(80, 16);
            this.lblSQL.TabIndex = 4;
            this.lblSQL.Text = "SQL query";
            // 
            // lblCuentaEntidad
            // 
            this.lblCuentaEntidad.AutoSize = true;
            this.lblCuentaEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCuentaEntidad.Location = new System.Drawing.Point(32, 35);
            this.lblCuentaEntidad.Name = "lblCuentaEntidad";
            this.lblCuentaEntidad.Size = new System.Drawing.Size(112, 16);
            this.lblCuentaEntidad.TabIndex = 3;
            this.lblCuentaEntidad.Text = "Cuenta entidad";
            // 
            // txtCuentaEntidad
            // 
            this.txtCuentaEntidad.Location = new System.Drawing.Point(188, 29);
            this.txtCuentaEntidad.Name = "txtCuentaEntidad";
            this.txtCuentaEntidad.Size = new System.Drawing.Size(393, 20);
            this.txtCuentaEntidad.TabIndex = 2;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(188, 29);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(934, 88);
            this.txtQuery.TabIndex = 0;
            // 
            // lblTitlePnl
            // 
            this.lblTitlePnl.AutoSize = true;
            this.lblTitlePnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTitlePnl.Location = new System.Drawing.Point(45, 96);
            this.lblTitlePnl.Name = "lblTitlePnl";
            this.lblTitlePnl.Size = new System.Drawing.Size(37, 16);
            this.lblTitlePnl.TabIndex = 0;
            this.lblTitlePnl.Text = "Grid";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gvMain);
            this.pnlGrid.Location = new System.Drawing.Point(48, 115);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1144, 177);
            this.pnlGrid.TabIndex = 12;
            // 
            // gvMain
            // 
            this.gvMain.AllowUserToAddRows = false;
            this.gvMain.AllowUserToDeleteRows = false;
            this.gvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvMain.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvMain.Location = new System.Drawing.Point(0, 0);
            this.gvMain.Name = "gvMain";
            this.gvMain.Size = new System.Drawing.Size(1144, 177);
            this.gvMain.TabIndex = 1;
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbSQL);
            this.gbTipo.Controls.Add(this.rbVistas);
            this.gbTipo.Controls.Add(this.rbCuentaEntidad);
            this.gbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbTipo.Location = new System.Drawing.Point(348, 315);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(454, 101);
            this.gbTipo.TabIndex = 11;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo de dato";
            // 
            // rbSQL
            // 
            this.rbSQL.AutoSize = true;
            this.rbSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbSQL.Location = new System.Drawing.Point(325, 37);
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
            this.rbVistas.Location = new System.Drawing.Point(192, 37);
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
            this.rbCuentaEntidad.Location = new System.Drawing.Point(24, 37);
            this.rbCuentaEntidad.Name = "rbCuentaEntidad";
            this.rbCuentaEntidad.Size = new System.Drawing.Size(97, 17);
            this.rbCuentaEntidad.TabIndex = 0;
            this.rbCuentaEntidad.TabStop = true;
            this.rbCuentaEntidad.Text = "Cuenta entidad";
            this.rbCuentaEntidad.UseVisualStyleBackColor = true;
            this.rbCuentaEntidad.CheckedChanged += new System.EventHandler(this.rbCuentaEntidad_CheckedChanged);
            // 
            // SnapOn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 750);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnConfiguracion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "SnapOn";
            this.Text = "SnapOn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTipo.ResumeLayout(false);
            this.pnlTipo.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).EndInit();
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbGrupos;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton rbSQL;
        private System.Windows.Forms.RadioButton rbVistas;
        private System.Windows.Forms.RadioButton rbCuentaEntidad;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.TextBox txtCuentaEntidad;
        private System.Windows.Forms.DataGridView gvMain;
        private System.Windows.Forms.Label lblTitlePnl;
        private System.Windows.Forms.Panel pnlTipo;
        private System.Windows.Forms.Label lblCuentaEntidad;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label lblSQL;
        private System.Windows.Forms.Button btnSubmit;
    }
}