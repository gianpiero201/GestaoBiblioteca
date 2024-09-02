namespace Application.Pages.Dashboard.ModalAddEdit
{
    partial class AddEdit
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
            TxtTitulo = new TextBox();
            TxtAno = new TextBox();
            TxtGenero = new TextBox();
            TxtAutor = new TextBox();
            TxtIsbn = new TextBox();
            BtnSalvar = new Button();
            SuspendLayout();
            // 
            // TxtTitulo
            // 
            TxtTitulo.Location = new Point(12, 47);
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.PlaceholderText = "Titulo";
            TxtTitulo.Size = new Size(237, 23);
            TxtTitulo.TabIndex = 0;
            // 
            // TxtAno
            // 
            TxtAno.Location = new Point(199, 89);
            TxtAno.Name = "TxtAno";
            TxtAno.PlaceholderText = "Ano";
            TxtAno.RightToLeft = RightToLeft.Yes;
            TxtAno.Size = new Size(50, 23);
            TxtAno.TabIndex = 1;
            // 
            // TxtGenero
            // 
            TxtGenero.Location = new Point(12, 174);
            TxtGenero.Name = "TxtGenero";
            TxtGenero.PlaceholderText = "Genero";
            TxtGenero.Size = new Size(237, 23);
            TxtGenero.TabIndex = 3;
            // 
            // TxtAutor
            // 
            TxtAutor.Location = new Point(12, 132);
            TxtAutor.Name = "TxtAutor";
            TxtAutor.PlaceholderText = "Autor";
            TxtAutor.Size = new Size(237, 23);
            TxtAutor.TabIndex = 2;
            // 
            // TxtIsbn
            // 
            TxtIsbn.Location = new Point(12, 89);
            TxtIsbn.Name = "TxtIsbn";
            TxtIsbn.PlaceholderText = "ISBN";
            TxtIsbn.Size = new Size(181, 23);
            TxtIsbn.TabIndex = 4;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(93, 229);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(75, 23);
            BtnSalvar.TabIndex = 5;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // AddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 264);
            Controls.Add(BtnSalvar);
            Controls.Add(TxtIsbn);
            Controls.Add(TxtGenero);
            Controls.Add(TxtAutor);
            Controls.Add(TxtAno);
            Controls.Add(TxtTitulo);
            Name = "AddEdit";
            Text = "AddEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtTitulo;
        private TextBox TxtAno;
        private TextBox TxtGenero;
        private TextBox TxtAutor;
        private TextBox TxtIsbn;
        private Button BtnSalvar;
    }
}