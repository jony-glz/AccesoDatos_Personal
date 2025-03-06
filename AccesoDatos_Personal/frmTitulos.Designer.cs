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
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTitulos).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnInsertar.Location = new Point(3, 3);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(2284, 72);
            btnInsertar.TabIndex = 0;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // dataGridViewTitulos
            // 
            dataGridViewTitulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTitulos.Dock = DockStyle.Fill;
            dataGridViewTitulos.Location = new Point(3, 81);
            dataGridViewTitulos.Name = "dataGridViewTitulos";
            dataGridViewTitulos.RowHeadersWidth = 123;
            dataGridViewTitulos.Size = new Size(2284, 746);
            dataGridViewTitulos.TabIndex = 1;
            dataGridViewTitulos.CellContentClick += dataGridViewTitulos_CellContentClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnInsertar, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridViewTitulos, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.397591F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.60241F));
            tableLayoutPanel1.Size = new Size(2290, 830);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // frmTitulos
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2314, 831);
            Controls.Add(tableLayoutPanel1);
            Name = "frmTitulos";
            Text = "Titulos";
            Activated += frmTitulos_Activated;
            Load += frmTitulos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTitulos).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnInsertar;
        private DataGridView dataGridViewTitulos;
        private TableLayoutPanel tableLayoutPanel1;
    }
}