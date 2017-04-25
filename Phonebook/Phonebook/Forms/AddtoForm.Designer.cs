namespace Phonebook
{
    partial class AddtoForm
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
            this.components = new System.ComponentModel.Container();
            this.Usercombobox = new System.Windows.Forms.ComboBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Valuelabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Usercombobox
            // 
            this.Usercombobox.FormattingEnabled = true;
            this.Usercombobox.Location = new System.Drawing.Point(23, 39);
            this.Usercombobox.Name = "Usercombobox";
            this.Usercombobox.Size = new System.Drawing.Size(374, 28);
            this.Usercombobox.TabIndex = 0;
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.Location = new System.Drawing.Point(237, 97);
            this.savebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(160, 32);
            this.savebutton.TabIndex = 4;
            this.savebutton.Text = "Add";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton.Location = new System.Drawing.Point(23, 97);
            this.cancelbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(160, 32);
            this.cancelbutton.TabIndex = 5;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "contact(s) selected";
            // 
            // Valuelabel
            // 
            this.Valuelabel.AutoSize = true;
            this.Valuelabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valuelabel.Location = new System.Drawing.Point(223, 9);
            this.Valuelabel.Name = "Valuelabel";
            this.Valuelabel.Size = new System.Drawing.Size(55, 19);
            this.Valuelabel.TabIndex = 7;
            this.Valuelabel.Text = "value";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddtoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 152);
            this.Controls.Add(this.Valuelabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.Usercombobox);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddtoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select User Group";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Usercombobox;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Valuelabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}