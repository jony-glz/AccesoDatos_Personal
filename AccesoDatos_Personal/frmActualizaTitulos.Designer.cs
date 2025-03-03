namespace AccesoDatos_Personal
{
    partial class frmActualizaTitulos
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
            components = new System.ComponentModel.Container();
            btnEliminar = new Button();
            btnActualizar = new Button();
            label7 = new Label();
            tbRoyalty = new TextBox();
            label6 = new Label();
            tbAdvance = new TextBox();
            label5 = new Label();
            tbPrice = new TextBox();
            label4 = new Label();
            tbPubId = new TextBox();
            Phone = new Label();
            tbType = new TextBox();
            label3 = new Label();
            tbName = new TextBox();
            label2 = new Label();
            tbId = new TextBox();
            label1 = new Label();
            tbYTDSales = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label8 = new Label();
            rtbNotes = new RichTextBox();
            dtpDate = new DateTimePicker();
            label9 = new Label();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(436, 693);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(225, 69);
            btnEliminar.TabIndex = 90;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(57, 693);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(225, 69);
            btnActualizar.TabIndex = 88;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(673, 300);
            label7.Name = "label7";
            label7.Size = new Size(177, 48);
            label7.TabIndex = 87;
            label7.Text = "Year Sales";
            // 
            // tbRoyalty
            // 
            tbRoyalty.Location = new Point(427, 351);
            tbRoyalty.Name = "tbRoyalty";
            tbRoyalty.Size = new Size(188, 55);
            tbRoyalty.TabIndex = 86;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(427, 300);
            label6.Name = "label6";
            label6.Size = new Size(135, 48);
            label6.TabIndex = 85;
            label6.Text = "Royalty";
            // 
            // tbAdvance
            // 
            tbAdvance.Location = new Point(212, 351);
            tbAdvance.Name = "tbAdvance";
            tbAdvance.Size = new Size(166, 55);
            tbAdvance.TabIndex = 84;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(212, 300);
            label5.Name = "label5";
            label5.Size = new Size(155, 48);
            label5.TabIndex = 83;
            label5.Text = "Advance";
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(12, 351);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(159, 55);
            tbPrice.TabIndex = 82;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 300);
            label4.Name = "label4";
            label4.Size = new Size(98, 48);
            label4.TabIndex = 81;
            label4.Text = "Price";
            // 
            // tbPubId
            // 
            tbPubId.Location = new Point(1583, 188);
            tbPubId.Name = "tbPubId";
            tbPubId.Size = new Size(202, 55);
            tbPubId.TabIndex = 80;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Location = new Point(1583, 125);
            Phone.Name = "Phone";
            Phone.Size = new Size(150, 48);
            Phone.TabIndex = 79;
            Phone.Text = "Editorial";
            // 
            // tbType
            // 
            tbType.Location = new Point(1125, 188);
            tbType.Name = "tbType";
            tbType.Size = new Size(413, 55);
            tbType.TabIndex = 78;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1125, 137);
            label3.Name = "label3";
            label3.Size = new Size(94, 48);
            label3.TabIndex = 77;
            label3.Text = "Type";
            // 
            // tbName
            // 
            tbName.Location = new Point(12, 192);
            tbName.Name = "tbName";
            tbName.Size = new Size(976, 55);
            tbName.TabIndex = 76;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 141);
            label2.Name = "label2";
            label2.Size = new Size(115, 48);
            label2.TabIndex = 75;
            label2.Text = "Name";
            // 
            // tbId
            // 
            tbId.Enabled = false;
            tbId.Location = new Point(78, 11);
            tbId.Name = "tbId";
            tbId.Size = new Size(300, 55);
            tbId.TabIndex = 74;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(51, 48);
            label1.TabIndex = 73;
            label1.Text = "Id";
            // 
            // tbYTDSales
            // 
            tbYTDSales.Location = new Point(688, 351);
            tbYTDSales.Name = "tbYTDSales";
            tbYTDSales.Size = new Size(300, 55);
            tbYTDSales.TabIndex = 91;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(48, 48);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1131, 300);
            label8.Name = "label8";
            label8.Size = new Size(114, 48);
            label8.TabIndex = 93;
            label8.Text = "Notes";
            // 
            // rtbNotes
            // 
            rtbNotes.Location = new Point(1131, 367);
            rtbNotes.Name = "rtbNotes";
            rtbNotes.Size = new Size(626, 288);
            rtbNotes.TabIndex = 94;
            rtbNotes.Text = "";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(388, 476);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(698, 55);
            dtpDate.TabIndex = 95;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(98, 483);
            label9.Name = "label9";
            label9.Size = new Size(280, 48);
            label9.TabIndex = 96;
            label9.Text = "Date Publication";
            // 
            // frmActualizaTitulos
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1861, 873);
            Controls.Add(label9);
            Controls.Add(dtpDate);
            Controls.Add(rtbNotes);
            Controls.Add(label8);
            Controls.Add(tbYTDSales);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(label7);
            Controls.Add(tbRoyalty);
            Controls.Add(label6);
            Controls.Add(tbAdvance);
            Controls.Add(label5);
            Controls.Add(tbPrice);
            Controls.Add(label4);
            Controls.Add(tbPubId);
            Controls.Add(Phone);
            Controls.Add(tbType);
            Controls.Add(label3);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(tbId);
            Controls.Add(label1);
            Name = "frmActualizaTitulos";
            Text = "Actualizar Titulos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnActualizar;
        private Label label7;
        private TextBox tbRoyalty;
        private Label label6;
        private TextBox tbAdvance;
        private Label label5;
        private TextBox tbPrice;
        private Label label4;
        private TextBox tbPubId;
        private Label Phone;
        private TextBox tbType;
        private Label label3;
        private TextBox tbName;
        private Label label2;
        private TextBox tbId;
        private Label label1;
        private TextBox tbYTDSales;
        private ContextMenuStrip contextMenuStrip1;
        private Label label8;
        private RichTextBox rtbNotes;
        private DateTimePicker dtpDate;
        private Label label9;
    }
}