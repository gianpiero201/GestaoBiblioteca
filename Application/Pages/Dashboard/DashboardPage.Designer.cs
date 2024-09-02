namespace Application.Pages.Dashboard
{
    partial class DashboardPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DgvAcervos = new DataGridView();
            GdcId = new DataGridViewTextBoxColumn();
            DgcTitulo = new DataGridViewTextBoxColumn();
            DgcAutor = new DataGridViewTextBoxColumn();
            DgcGenero = new DataGridViewTextBoxColumn();
            DgcIsbn = new DataGridViewTextBoxColumn();
            DgcAno = new DataGridViewTextBoxColumn();
            BtnAdicionar = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvAcervos).BeginInit();
            SuspendLayout();
            // 
            // DgvAcervos
            // 
            DgvAcervos.AllowUserToAddRows = false;
            DgvAcervos.AllowUserToDeleteRows = false;
            DgvAcervos.BackgroundColor = SystemColors.Control;
            DgvAcervos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvAcervos.Columns.AddRange(new DataGridViewColumn[] { GdcId, DgcTitulo, DgcAutor, DgcGenero, DgcIsbn, DgcAno });
            DgvAcervos.GridColor = SystemColors.Control;
            DgvAcervos.Location = new Point(12, 41);
            DgvAcervos.Name = "DgvAcervos";
            DgvAcervos.ReadOnly = true;
            DgvAcervos.RowHeadersVisible = false;
            DgvAcervos.Size = new Size(776, 397);
            DgvAcervos.TabIndex = 0;
            // 
            // GdcId
            // 
            GdcId.DataPropertyName = "Id";
            GdcId.Frozen = true;
            GdcId.HeaderText = "Id";
            GdcId.Name = "GdcId";
            GdcId.ReadOnly = true;
            GdcId.Visible = false;
            // 
            // DgcTitulo
            // 
            DgcTitulo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DgcTitulo.DataPropertyName = "Titulo";
            DgcTitulo.Frozen = true;
            DgcTitulo.HeaderText = "Titulo";
            DgcTitulo.Name = "DgcTitulo";
            DgcTitulo.ReadOnly = true;
            DgcTitulo.Resizable = DataGridViewTriState.False;
            DgcTitulo.Width = 178;
            // 
            // DgcAutor
            // 
            DgcAutor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgcAutor.DataPropertyName = "Autor";
            DgcAutor.HeaderText = "Autor";
            DgcAutor.Name = "DgcAutor";
            DgcAutor.ReadOnly = true;
            DgcAutor.Resizable = DataGridViewTriState.False;
            // 
            // DgcGenero
            // 
            DgcGenero.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgcGenero.DataPropertyName = "Genero";
            DgcGenero.HeaderText = "Genero";
            DgcGenero.Name = "DgcGenero";
            DgcGenero.ReadOnly = true;
            DgcGenero.Resizable = DataGridViewTriState.False;
            // 
            // DgcIsbn
            // 
            DgcIsbn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgcIsbn.DataPropertyName = "Isbn";
            DgcIsbn.HeaderText = "ISBN";
            DgcIsbn.Name = "DgcIsbn";
            DgcIsbn.ReadOnly = true;
            DgcIsbn.Resizable = DataGridViewTriState.False;
            // 
            // DgcAno
            // 
            DgcAno.DataPropertyName = "Ano";
            DgcAno.HeaderText = "Ano";
            DgcAno.Name = "DgcAno";
            DgcAno.ReadOnly = true;
            DgcAno.Resizable = DataGridViewTriState.False;
            DgcAno.Width = 60;
            // 
            // BtnAdicionar
            // 
            BtnAdicionar.Location = new Point(12, 12);
            BtnAdicionar.Name = "BtnAdicionar";
            BtnAdicionar.Size = new Size(75, 23);
            BtnAdicionar.TabIndex = 1;
            BtnAdicionar.Text = "Adicionar";
            BtnAdicionar.UseVisualStyleBackColor = true;
            BtnAdicionar.Click += BtnAdicionar_Click;
            // 
            // DashboardPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnAdicionar);
            Controls.Add(DgvAcervos);
            Name = "DashboardPage";
            Text = "Dashboard";
            Load += DashboardPage_Load;
            ((System.ComponentModel.ISupportInitialize)DgvAcervos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvAcervos;
        private DataGridViewTextBoxColumn GdcId;
        private DataGridViewTextBoxColumn DgcTitulo;
        private DataGridViewTextBoxColumn DgcAutor;
        private DataGridViewTextBoxColumn DgcGenero;
        private DataGridViewTextBoxColumn DgcIsbn;
        private DataGridViewTextBoxColumn DgcAno;
        private Button BtnAdicionar;
    }
}
