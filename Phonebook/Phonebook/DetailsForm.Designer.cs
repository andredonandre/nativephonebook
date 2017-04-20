namespace Phonebook
{
    partial class DetailsForm
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
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.PhonetextBox = new System.Windows.Forms.TextBox();
            this.editbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.UgcomboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.callbutton = new System.Windows.Forms.Button();
            this.addresstextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(25, 31);
            this.NametextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(326, 26);
            this.NametextBox.TabIndex = 0;
            // 
            // PhonetextBox
            // 
            this.PhonetextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhonetextBox.Location = new System.Drawing.Point(25, 76);
            this.PhonetextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PhonetextBox.Name = "PhonetextBox";
            this.PhonetextBox.Size = new System.Drawing.Size(327, 26);
            this.PhonetextBox.TabIndex = 1;
            this.PhonetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhonetextBox_KeyPress);
            // 
            // editbutton
            // 
            this.editbutton.Location = new System.Drawing.Point(25, 276);
            this.editbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(160, 32);
            this.editbutton.TabIndex = 2;
            this.editbutton.Text = "Edit";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.Location = new System.Drawing.Point(191, 276);
            this.savebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(160, 32);
            this.savebutton.TabIndex = 3;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // UgcomboBox
            // 
            this.UgcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UgcomboBox.FormattingEnabled = true;
            this.UgcomboBox.Location = new System.Drawing.Point(26, 229);
            this.UgcomboBox.Name = "UgcomboBox";
            this.UgcomboBox.Size = new System.Drawing.Size(326, 28);
            this.UgcomboBox.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // callbutton
            // 
            this.callbutton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callbutton.ForeColor = System.Drawing.Color.Green;
            this.callbutton.Location = new System.Drawing.Point(192, 276);
            this.callbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.callbutton.Name = "callbutton";
            this.callbutton.Size = new System.Drawing.Size(160, 32);
            this.callbutton.TabIndex = 5;
            this.callbutton.Text = "Call";
            this.callbutton.UseVisualStyleBackColor = true;
            this.callbutton.Click += new System.EventHandler(this.callbutton_Click);
            // 
            // addresstextBox
            // 
            this.addresstextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addresstextBox.Location = new System.Drawing.Point(26, 125);
            this.addresstextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addresstextBox.Multiline = true;
            this.addresstextBox.Name = "addresstextBox";
            this.addresstextBox.Size = new System.Drawing.Size(325, 85);
            this.addresstextBox.TabIndex = 6;
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 330);
            this.Controls.Add(this.addresstextBox);
            this.Controls.Add(this.callbutton);
            this.Controls.Add(this.UgcomboBox);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.PhonetextBox);
            this.Controls.Add(this.NametextBox);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox PhonetextBox;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.ComboBox UgcomboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button callbutton;
        private System.Windows.Forms.TextBox addresstextBox;
    }
}