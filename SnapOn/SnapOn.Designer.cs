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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTitlePnl = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.gvMain = new System.Windows.Forms.DataGridView();
            this.btnConfigQuerys = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Location = new System.Drawing.Point(1090, 12);
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
            this.label2.Location = new System.Drawing.Point(573, 18);
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
            this.label1.Location = new System.Drawing.Point(246, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Grupo:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(576, 36);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(247, 21);
            this.cmbCategoria.TabIndex = 6;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // cmbGrupos
            // 
            this.cmbGrupos.FormattingEnabled = true;
            this.cmbGrupos.Location = new System.Drawing.Point(249, 34);
            this.cmbGrupos.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGrupos.Name = "cmbGrupos";
            this.cmbGrupos.Size = new System.Drawing.Size(247, 21);
            this.cmbGrupos.TabIndex = 5;
            this.cmbGrupos.SelectedIndexChanged += new System.EventHandler(this.cmbGrupos_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.lblTitlePnl);
            this.panel1.Controls.Add(this.pnlGrid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbGrupos);
            this.panel1.Controls.Add(this.cmbCategoria);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 725);
            this.panel1.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(1104, 318);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 48);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
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
            this.gvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvMain.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvMain.Location = new System.Drawing.Point(0, 0);
            this.gvMain.Name = "gvMain";
            this.gvMain.Size = new System.Drawing.Size(1144, 177);
            this.gvMain.TabIndex = 0;
            // 
            // btnConfigQuerys
            // 
            this.btnConfigQuerys.Location = new System.Drawing.Point(966, 12);
            this.btnConfigQuerys.Name = "btnConfigQuerys";
            this.btnConfigQuerys.Size = new System.Drawing.Size(80, 39);
            this.btnConfigQuerys.TabIndex = 12;
            this.btnConfigQuerys.Text = "Configuración querys";
            this.btnConfigQuerys.UseVisualStyleBackColor = true;
            this.btnConfigQuerys.Click += new System.EventHandler(this.btnConfigQuerys_Click);
            // 
            // SnapOn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 426);
            this.Controls.Add(this.btnConfigQuerys);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnConfiguracion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "SnapOn";
            this.Text = "SnapOn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMain)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Label lblTitlePnl;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnConfigQuerys;
        private System.Windows.Forms.DataGridView gvMain;
    }
}