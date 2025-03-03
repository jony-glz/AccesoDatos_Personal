namespace AccesoDatos_Personal
{
    partial class frmTitulos
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
            btnInsertar = new Button();
            dataGridViewTitulos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTitulos).BeginInit();
            SuspendLayout();
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(30, 15);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(225, 69);
            btnInsertar.TabIndex = 0;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // dataGridViewTitulos
            // 
            dataGridViewTitulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTitulos.Location = new Point(12, 106);
            dataGridViewTitulos.Name = "dataGridViewTitulos";
            dataGridViewTitulos.RowHeadersWidth = 123;
            dataGridViewTitulos.Size = new Size(1723, 635);
            dataGridViewTitulos.TabIndex = 1;
            dataGridViewTitulos.CellContentClick += dataGridViewTitulos_CellContentClick;
            // 
            // frmTitulos
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1747, 753);
            Controls.Add(dataGridViewTitulos);
            Controls.Add(btnInsertar);
            Name = "frmTitulos";
            Text = "Titulos";
            Activated += frmTitulos_Activated;
            Load += frmTitulos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTitulos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnInsertar;
        private DataGridView dataGridViewTitulos;
    }
}