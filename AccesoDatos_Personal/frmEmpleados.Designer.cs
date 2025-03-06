namespace AccesoDatos_Personal
{
    partial class frmEmpleados
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
            dataGridViewEmpleados = new DataGridView();
            button1 = new Button();
            btnInsertar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpleados).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewEmpleados
            // 
            dataGridViewEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmpleados.Dock = DockStyle.Fill;
            dataGridViewEmpleados.Location = new Point(3, 82);
            dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            dataGridViewEmpleados.RowHeadersWidth = 123;
            dataGridViewEmpleados.Size = new Size(2268, 736);
            dataGridViewEmpleados.TabIndex = 0;
            dataGridViewEmpleados.CellContentClick += dataGridViewEmpleados_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(78, 12);
            button1.Name = "button1";
            button1.Size = new Size(19, 8);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnInsertar.Location = new Point(3, 3);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(2268, 73);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dataGridViewEmpleados, 0, 1);
            tableLayoutPanel1.Controls.Add(btnInsertar, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.622412F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.37759F));
            tableLayoutPanel1.Size = new Size(2274, 821);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2289, 822);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button1);
            Name = "frmEmpleados";
            Text = "Empleados";
            Activated += frmEmpleados_Activated;
            Load += frmEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpleados).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewEmpleados;
        private Button button1;
        private Button btnInsertar;
        private TableLayoutPanel tableLayoutPanel1;
    }
}