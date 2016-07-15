namespace SnapOn
{
    partial class SQL
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
            this.lblTitleSQL = new System.Windows.Forms.Label();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gvResults = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleSQL
            // 
            this.lblTitleSQL.AutoSize = true;
            this.lblTitleSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleSQL.Location = new System.Drawing.Point(23, 27);
            this.lblTitleSQL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleSQL.Name = "lblTitleSQL";
            this.lblTitleSQL.Size = new System.Drawing.Size(107, 16);
            this.lblTitleSQL.TabIndex = 8;
            this.lblTitleSQL.Text = "Ingrese query:";
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(26, 68);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(537, 72);
            this.txtQuery.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(488, 146);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 22);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Correr";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gvResults
            // 
            this.gvResults.AllowUserToAddRows = false;
            this.gvResults.AllowUserToDeleteRows = false;
            this.gvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvResults.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvResults.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvResults.Location = new System.Drawing.Point(0, 0);
            this.gvResults.Name = "gvResults";
            this.gvResults.Size = new System.Drawing.Size(537, 166);
            this.gvResults.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gvResults);
            this.panel1.Location = new System.Drawing.Point(26, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 166);
            this.panel1.TabIndex = 12;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(23, 206);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(83, 16);
            this.lblResultado.TabIndex = 13;
            this.lblResultado.Text = "Resultado:";
            // 
            // SQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(591, 439);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.lblTitleSQL);
            this.Name = "SQL";
            this.Text = "SQL";
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleSQL;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView gvResults;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResultado;
    }
}