namespace AccesoDatos_Personal
{
    partial class frmAutores
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
            dataGridViewAutores = new DataGridView();
            btnInsertar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAutores).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewAutores
            // 
            dataGridViewAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAutores.Dock = DockStyle.Fill;
            dataGridViewAutores.Location = new Point(3, 84);
            dataGridViewAutores.Name = "dataGridViewAutores";
            dataGridViewAutores.RowHeadersWidth = 123;
            dataGridViewAutores.Size = new Size(2244, 728);
            dataGridViewAutores.TabIndex = 0;
            dataGridViewAutores.CellContentClick += dataGridViewAutores_CellContentClick;
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnInsertar.Location = new Point(3, 3);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(2244, 75);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dataGridViewAutores, 0, 1);
            tableLayoutPanel1.Controls.Add(btnInsertar, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.93865F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.06135F));
            tableLayoutPanel1.Size = new Size(2250, 815);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // frmAutores
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2255, 828);
            Controls.Add(tableLayoutPanel1);
            Name = "frmAutores";
            Text = "frmAutores";
            Activated += frmAutores_Activated;
            Load += frmAutores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAutores).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewAutores;
        private Button btnInsertar;
        private TableLayoutPanel tableLayoutPanel1;
    }
}