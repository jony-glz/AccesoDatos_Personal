namespace AccesoDatos_Personal
{
    partial class frmPublishers
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
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            dataGridViewEditorial = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEditorial).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridViewEditorial, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.8040972F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.1959F));
            tableLayoutPanel1.Size = new Size(1626, 696);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(3, 10);
            button1.Name = "button1";
            button1.Size = new Size(1620, 69);
            button1.TabIndex = 0;
            button1.Text = "Insertar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEditorial
            // 
            dataGridViewEditorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEditorial.Dock = DockStyle.Fill;
            dataGridViewEditorial.Location = new Point(3, 92);
            dataGridViewEditorial.Name = "dataGridViewEditorial";
            dataGridViewEditorial.RowHeadersWidth = 123;
            dataGridViewEditorial.Size = new Size(1620, 601);
            dataGridViewEditorial.TabIndex = 1;
            // 
            // frmPublishers
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1661, 720);
            Controls.Add(tableLayoutPanel1);
            Name = "frmPublishers";
            Text = "Editoriales";
            Activated += frmPublishers_Activated;
            Load += frmPublishers_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEditorial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private DataGridView dataGridViewEditorial;
    }
}