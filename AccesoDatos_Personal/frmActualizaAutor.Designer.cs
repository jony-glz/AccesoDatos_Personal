namespace AccesoDatos_Personal
{
    partial class frmActualizaAutor
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
            label1 = new Label();
            tbId = new TextBox();
            label2 = new Label();
            tbFN = new TextBox();
            label3 = new Label();
            tbLN = new TextBox();
            Phone = new Label();
            tbPhone = new TextBox();
            label4 = new Label();
            tbAddress = new TextBox();
            label5 = new Label();
            tbCity = new TextBox();
            label6 = new Label();
            tbState = new TextBox();
            label7 = new Label();
            tbZip = new TextBox();
            checkBox1 = new CheckBox();
            btnActualiza = new Button();
            btnBorrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 42);
            label1.Name = "label1";
            label1.Size = new Size(51, 48);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // tbId
            // 
            tbId.Location = new Point(121, 39);
            tbId.Name = "tbId";
            tbId.Size = new Size(300, 55);
            tbId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 169);
            label2.Name = "label2";
            label2.Size = new Size(192, 48);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            // 
            // tbFN
            // 
            tbFN.Location = new Point(55, 220);
            tbFN.Name = "tbFN";
            tbFN.Size = new Size(603, 55);
            tbFN.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(716, 169);
            label3.Name = "label3";
            label3.Size = new Size(187, 48);
            label3.TabIndex = 4;
            label3.Text = "Last Name";
            // 
            // tbLN
            // 
            tbLN.Location = new Point(716, 220);
            tbLN.Name = "tbLN";
            tbLN.Size = new Size(472, 55);
            tbLN.TabIndex = 5;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Location = new Point(1239, 169);
            Phone.Name = "Phone";
            Phone.Size = new Size(120, 48);
            Phone.TabIndex = 6;
            Phone.Text = "Phone";
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(1239, 220);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(388, 55);
            tbPhone.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 328);
            label4.Name = "label4";
            label4.Size = new Size(147, 48);
            label4.TabIndex = 8;
            label4.Text = "Address";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(55, 379);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(702, 55);
            tbAddress.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(859, 328);
            label5.Name = "label5";
            label5.Size = new Size(80, 48);
            label5.TabIndex = 10;
            label5.Text = "City";
            // 
            // tbCity
            // 
            tbCity.Location = new Point(859, 379);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(300, 55);
            tbCity.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1239, 328);
            label6.Name = "label6";
            label6.Size = new Size(99, 48);
            label6.TabIndex = 12;
            label6.Text = "State";
            // 
            // tbState
            // 
            tbState.Location = new Point(1239, 379);
            tbState.Name = "tbState";
            tbState.Size = new Size(300, 55);
            tbState.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1609, 328);
            label7.Name = "label7";
            label7.Size = new Size(71, 48);
            label7.TabIndex = 14;
            label7.Text = "Zip";
            // 
            // tbZip
            // 
            tbZip.Location = new Point(1609, 379);
            tbZip.Name = "tbZip";
            tbZip.Size = new Size(184, 55);
            tbZip.TabIndex = 15;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(55, 508);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(201, 52);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "Contract";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnActualiza
            // 
            btnActualiza.Location = new Point(1292, 508);
            btnActualiza.Name = "btnActualiza";
            btnActualiza.Size = new Size(225, 69);
            btnActualiza.TabIndex = 17;
            btnActualiza.Text = "Actualizar";
            btnActualiza.UseVisualStyleBackColor = true;
            btnActualiza.Click += btnActualiza_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(1031, 508);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(225, 69);
            btnBorrar.TabIndex = 18;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // frmActualizaAutor
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1805, 630);
            Controls.Add(btnBorrar);
            Controls.Add(btnActualiza);
            Controls.Add(checkBox1);
            Controls.Add(tbZip);
            Controls.Add(label7);
            Controls.Add(tbState);
            Controls.Add(label6);
            Controls.Add(tbCity);
            Controls.Add(label5);
            Controls.Add(tbAddress);
            Controls.Add(label4);
            Controls.Add(tbPhone);
            Controls.Add(Phone);
            Controls.Add(tbLN);
            Controls.Add(label3);
            Controls.Add(tbFN);
            Controls.Add(label2);
            Controls.Add(tbId);
            Controls.Add(label1);
            Name = "frmActualizaAutor";
            Text = "Actualiza Autor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbId;
        private Label label2;
        private TextBox tbFN;
        private Label label3;
        private TextBox tbLN;
        private Label Phone;
        private TextBox tbPhone;
        private Label label4;
        private TextBox tbAddress;
        private Label label5;
        private TextBox tbCity;
        private Label label6;
        private TextBox tbState;
        private Label label7;
        private TextBox tbZip;
        private CheckBox checkBox1;
        private Button btnActualiza;
        private Button btnBorrar;
    }
}