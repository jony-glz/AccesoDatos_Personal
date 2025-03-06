namespace AccesoDatos_Personal
{
    partial class frmInsertarEmpleados
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
            label7 = new Label();
            tbIDPub = new TextBox();
            label6 = new Label();
            tbLVJob = new TextBox();
            label5 = new Label();
            tbIDJob = new TextBox();
            label4 = new Label();
            tbLN = new TextBox();
            Phone = new Label();
            tbMinit = new TextBox();
            label3 = new Label();
            tbFN = new TextBox();
            label2 = new Label();
            tbId = new TextBox();
            label1 = new Label();
            dtpHireDate = new DateTimePicker();
            SuspendLayout();
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(333, 654);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(225, 69);
            btnInsertar.TabIndex = 53;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInserta_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 506);
            label7.Name = "label7";
            label7.Size = new Size(171, 48);
            label7.TabIndex = 51;
            label7.Text = "Hire Date";
            // 
            // tbIDPub
            // 
            tbIDPub.Location = new Point(432, 401);
            tbIDPub.Name = "tbIDPub";
            tbIDPub.Size = new Size(188, 55);
            tbIDPub.TabIndex = 50;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(432, 350);
            label6.Name = "label6";
            label6.Size = new Size(126, 48);
            label6.TabIndex = 49;
            label6.Text = "ID Pub";
            // 
            // tbLVJob
            // 
            tbLVJob.Location = new Point(217, 401);
            tbLVJob.Name = "tbLVJob";
            tbLVJob.Size = new Size(166, 55);
            tbLVJob.TabIndex = 48;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(217, 350);
            label5.Name = "label5";
            label5.Size = new Size(166, 48);
            label5.TabIndex = 47;
            label5.Text = "Level Job";
            // 
            // tbIDJob
            // 
            tbIDJob.Location = new Point(17, 401);
            tbIDJob.Name = "tbIDJob";
            tbIDJob.Size = new Size(159, 55);
            tbIDJob.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 350);
            label4.Name = "label4";
            label4.Size = new Size(120, 48);
            label4.TabIndex = 45;
            label4.Text = "ID Job";
            // 
            // tbLN
            // 
            tbLN.Location = new Point(295, 260);
            tbLN.Name = "tbLN";
            tbLN.Size = new Size(603, 55);
            tbLN.TabIndex = 44;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Location = new Point(12, 267);
            Phone.Name = "Phone";
            Phone.Size = new Size(187, 48);
            Phone.TabIndex = 43;
            Phone.Text = "Last Name";
            // 
            // tbMinit
            // 
            tbMinit.Location = new Point(295, 179);
            tbMinit.Name = "tbMinit";
            tbMinit.Size = new Size(133, 55);
            tbMinit.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 179);
            label3.Name = "label3";
            label3.Size = new Size(102, 48);
            label3.TabIndex = 41;
            label3.Text = "Minit";
            // 
            // tbFN
            // 
            tbFN.Location = new Point(295, 96);
            tbFN.Name = "tbFN";
            tbFN.Size = new Size(603, 55);
            tbFN.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 99);
            label2.Name = "label2";
            label2.Size = new Size(192, 48);
            label2.TabIndex = 39;
            label2.Text = "First Name";
            // 
            // tbId
            // 
            tbId.Location = new Point(295, 8);
            tbId.Name = "tbId";
            tbId.Size = new Size(300, 55);
            tbId.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(51, 48);
            label1.TabIndex = 37;
            label1.Text = "Id";
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(217, 501);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(645, 55);
            dtpHireDate.TabIndex = 54;
            // 
            // frmInsertarEmpleados
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 777);
            Controls.Add(dtpHireDate);
            Controls.Add(btnInsertar);
            Controls.Add(label7);
            Controls.Add(tbIDPub);
            Controls.Add(label6);
            Controls.Add(tbLVJob);
            Controls.Add(label5);
            Controls.Add(tbIDJob);
            Controls.Add(label4);
            Controls.Add(tbLN);
            Controls.Add(Phone);
            Controls.Add(tbMinit);
            Controls.Add(label3);
            Controls.Add(tbFN);
            Controls.Add(label2);
            Controls.Add(tbId);
            Controls.Add(label1);
            Name = "frmInsertarEmpleados";
            Text = "Insertar Empleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsertar;
        private TextBox tbZip;
        private Label label7;
        private TextBox tbIDPub;
        private Label label6;
        private TextBox tbLVJob;
        private Label label5;
        private TextBox tbIDJob;
        private Label label4;
        private TextBox tbLN;
        private Label Phone;
        private TextBox tbMinit;
        private Label label3;
        private TextBox tbFN;
        private Label label2;
        private TextBox tbId;
        private Label label1;
        private DateTimePicker dtpHireDate;
    }
}