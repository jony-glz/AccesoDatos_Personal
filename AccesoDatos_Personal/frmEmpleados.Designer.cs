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
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEmpleados
            // 
            dataGridViewEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmpleados.Location = new Point(12, 87);
            dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            dataGridViewEmpleados.RowHeadersWidth = 123;
            dataGridViewEmpleados.Size = new Size(1425, 723);
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
            btnInsertar.Location = new Point(12, 12);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(225, 69);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 822);
            Controls.Add(btnInsertar);
            Controls.Add(button1);
            Controls.Add(dataGridViewEmpleados);
            Name = "frmEmpleados";
            Text = "Empleados";
            Activated += frmEmpleados_Activated;
            Load += frmEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewEmpleados;
        private Button button1;
        private Button btnInsertar;
    }
}