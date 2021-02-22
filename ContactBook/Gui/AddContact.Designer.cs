namespace ContactBook.Gui
{
    partial class AddContact
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.butAddContact = new System.Windows.Forms.Button();
            this.labName = new System.Windows.Forms.Label();
            this.labPhone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.tableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 3;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayout.Controls.Add(this.butAddContact, 2, 1);
            this.tableLayout.Controls.Add(this.labName, 0, 0);
            this.tableLayout.Controls.Add(this.labPhone, 1, 0);
            this.tableLayout.Controls.Add(this.txtName, 0, 1);
            this.tableLayout.Controls.Add(this.txtPhone, 1, 1);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 2;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Size = new System.Drawing.Size(371, 80);
            this.tableLayout.TabIndex = 0;
            // 
            // butAddContact
            // 
            this.butAddContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butAddContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddContact.Location = new System.Drawing.Point(270, 48);
            this.butAddContact.Name = "butAddContact";
            this.butAddContact.Size = new System.Drawing.Size(88, 23);
            this.butAddContact.TabIndex = 0;
            this.butAddContact.Text = "Add Contact";
            this.butAddContact.UseVisualStyleBackColor = true;
            // 
            // labName
            // 
            this.labName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(34, 8);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(61, 24);
            this.labName.TabIndex = 1;
            this.labName.Text = "Name";
            // 
            // labPhone
            // 
            this.labPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labPhone.AutoSize = true;
            this.labPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPhone.Location = new System.Drawing.Point(160, 8);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(66, 24);
            this.labPhone.TabIndex = 2;
            this.labPhone.Text = "Phone";
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(3, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(123, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhone.Location = new System.Drawing.Point(132, 43);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(123, 20);
            this.txtPhone.TabIndex = 4;
            // 
            // AddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayout);
            this.Name = "AddContact";
            this.Size = new System.Drawing.Size(371, 80);
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Button butAddContact;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
    }
}
