namespace Phonebook
{
    partial class groupsForm
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
            this.uglistBox = new System.Windows.Forms.ListBox();
            this.ugtextbox = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // uglistBox
            // 
            this.uglistBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uglistBox.FormattingEnabled = true;
            this.uglistBox.ItemHeight = 21;
            this.uglistBox.Location = new System.Drawing.Point(12, 72);
            this.uglistBox.Name = "uglistBox";
            this.uglistBox.Size = new System.Drawing.Size(455, 109);
            this.uglistBox.TabIndex = 0;
            this.uglistBox.SelectedIndexChanged += new System.EventHandler(this.uglistBox_SelectedIndexChanged);
            // 
            // ugtextbox
            // 
            this.ugtextbox.Location = new System.Drawing.Point(12, 29);
            this.ugtextbox.Name = "ugtextbox";
            this.ugtextbox.Size = new System.Drawing.Size(269, 26);
            this.ugtextbox.TabIndex = 1;
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.Location = new System.Drawing.Point(307, 29);
            this.addbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(160, 26);
            this.addbutton.TabIndex = 5;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.Location = new System.Drawing.Point(12, 200);
            this.deletebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(160, 26);
            this.deletebutton.TabIndex = 6;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Visible = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // editbutton
            // 
            this.editbutton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbutton.Location = new System.Drawing.Point(307, 200);
            this.editbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(160, 26);
            this.editbutton.TabIndex = 7;
            this.editbutton.Text = "Edit";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Visible = false;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.Location = new System.Drawing.Point(307, 29);
            this.savebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(160, 26);
            this.savebutton.TabIndex = 8;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Visible = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton.Location = new System.Drawing.Point(12, 197);
            this.cancelbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(160, 26);
            this.cancelbutton.TabIndex = 9;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Visible = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 237);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.ugtextbox);
            this.Controls.Add(this.uglistBox);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "groupsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Groups";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox uglistBox;
        private System.Windows.Forms.TextBox ugtextbox;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}