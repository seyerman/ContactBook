namespace ContactBook.Gui
{
    partial class ContactBookWindow
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.addContact = new ContactBook.Gui.AddContact();
            this.SuspendLayout();
            // 
            // addContact
            // 
            this.addContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.addContact.Location = new System.Drawing.Point(0, 0);
            this.addContact.Name = "addContact";
            this.addContact.Size = new System.Drawing.Size(477, 80);
            this.addContact.TabIndex = 0;
            // 
            // ContactBookWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 401);
            this.Controls.Add(this.addContact);
            this.Name = "ContactBookWindow";
            this.Text = "Contact Book :: CB Ready";
            this.ResumeLayout(false);

        }

        #endregion

        private AddContact addContact;
    }
}

