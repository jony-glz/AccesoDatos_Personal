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
            menuStrip1 = new MenuStrip();
            formsToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            títulosToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAutores).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewAutores
            // 
            dataGridViewAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAutores.Location = new Point(0, 134);
            dataGridViewAutores.Name = "dataGridViewAutores";
            dataGridViewAutores.RowHeadersWidth = 123;
            dataGridViewAutores.Size = new Size(1632, 621);
            dataGridViewAutores.TabIndex = 0;
            dataGridViewAutores.CellContentClick += dataGridViewAutores_CellContentClick;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(0, 59);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(225, 69);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(48, 48);
            menuStrip1.Items.AddRange(new ToolStripItem[] { formsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1632, 56);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // formsToolStripMenuItem
            // 
            formsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { empleadosToolStripMenuItem, títulosToolStripMenuItem });
            formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            formsToolStripMenuItem.Size = new Size(146, 52);
            formsToolStripMenuItem.Text = "Forms";
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(538, 66);
            empleadosToolStripMenuItem.Text = "Empleados";
            empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
            // 
            // títulosToolStripMenuItem
            // 
            títulosToolStripMenuItem.Name = "títulosToolStripMenuItem";
            títulosToolStripMenuItem.Size = new Size(538, 66);
            títulosToolStripMenuItem.Text = "Títulos";
            títulosToolStripMenuItem.Click += títulosToolStripMenuItem_Click;
            // 
            // frmAutores
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1632, 773);
            Controls.Add(btnInsertar);
            Controls.Add(dataGridViewAutores);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmAutores";
            Text = "frmAutores";
            Activated += frmAutores_Activated;
            Load += frmAutores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAutores).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAutores;
        private Button btnInsertar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem formsToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem títulosToolStripMenuItem;
    }
}