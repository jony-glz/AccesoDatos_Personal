namespace AccesoDatos_Personal
{
    partial class frmActualizaEmpleados
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
            dtpHireDate = new DateTimePicker();
            btnActualizar = new Button();
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
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(686, 354);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(645, 55);
            dtpHireDate.TabIndex = 71;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(91, 589);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(225, 69);
            btnActualizar.TabIndex = 70;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(686, 303);
            label7.Name = "label7";
            label7.Size = new Size(171, 48);
            label7.TabIndex = 69;
            label7.Text = "Hire Date";
            // 
            // tbIDPub
            // 
            tbIDPub.Location = new Point(440, 354);
            tbIDPub.Name = "tbIDPub";
            tbIDPub.Size = new Size(188, 55);
            tbIDPub.TabIndex = 68;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(440, 303);
            label6.Name = "label6";
            label6.Size = new Size(126, 48);
            label6.TabIndex = 67;
            label6.Text = "ID Pub";
            // 
            // tbLVJob
            // 
            tbLVJob.Location = new Point(225, 354);
            tbLVJob.Name = "tbLVJob";
            tbLVJob.Size = new Size(166, 55);
            tbLVJob.TabIndex = 66;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(225, 303);
            label5.Name = "label5";
            label5.Size = new Size(166, 48);
            label5.TabIndex = 65;
            label5.Text = "Level Job";
            // 
            // tbIDJob
            // 
            tbIDJob.Location = new Point(25, 354);
            tbIDJob.Name = "tbIDJob";
            tbIDJob.Size = new Size(159, 55);
            tbIDJob.TabIndex = 64;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 303);
            label4.Name = "label4";
            label4.Size = new Size(120, 48);
            label4.TabIndex = 63;
            label4.Text = "ID Job";
            // 
            // tbLN
            // 
            tbLN.Location = new Point(874, 195);
            tbLN.Name = "tbLN";
            tbLN.Size = new Size(540, 55);
            tbLN.TabIndex = 62;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Location = new Point(874, 144);
            Phone.Name = "Phone";
            Phone.Size = new Size(187, 48);
            Phone.TabIndex = 61;
            Phone.Text = "Last Name";
            // 
            // tbMinit
            // 
            tbMinit.Location = new Point(686, 195);
            tbMinit.Name = "tbMinit";
            tbMinit.Size = new Size(133, 55);
            tbMinit.TabIndex = 60;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(686, 144);
            label3.Name = "label3";
            label3.Size = new Size(102, 48);
            label3.TabIndex = 59;
            label3.Text = "Minit";
            // 
            // tbFN
            // 
            tbFN.Location = new Point(25, 195);
            tbFN.Name = "tbFN";
            tbFN.Size = new Size(603, 55);
            tbFN.TabIndex = 58;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 144);
            label2.Name = "label2";
            label2.Size = new Size(192, 48);
            label2.TabIndex = 57;
            label2.Text = "First Name";
            // 
            // tbId
            // 
            tbId.Location = new Point(91, 14);
            tbId.Name = "tbId";
            tbId.Size = new Size(300, 55);
            tbId.TabIndex = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 17);
            label1.Name = "label1";
            label1.Size = new Size(51, 48);
            label1.TabIndex = 55;
            label1.Text = "Id";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(701, 589);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(225, 69);
            btnEliminar.TabIndex = 72;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmActualizaEmpleados
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 760);
            Controls.Add(btnEliminar);
            Controls.Add(dtpHireDate);
            Controls.Add(btnActualizar);
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
            Name = "frmActualizaEmpleados";
            Text = "Actualizar Empleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpHireDate;
        private Button btnActualizar;
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
        private Button btnEliminar;
    }
}