namespace Phonebook
{
    partial class NewContactForm
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
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.companyTab = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ugcomboBox2 = new System.Windows.Forms.ComboBox();
            this.CompanyPhonetextBox = new System.Windows.Forms.TextBox();
            this.CompanyNtextBox = new System.Windows.Forms.TextBox();
            this.personTab = new System.Windows.Forms.TabPage();
            this.personaddresstextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ugcomboBox1 = new System.Windows.Forms.ComboBox();
            this.PhonetextBox = new System.Windows.Forms.TextBox();
            this.LastNtextBox = new System.Windows.Forms.TextBox();
            this.FirstNtextBox = new System.Windows.Forms.TextBox();
            this.addContactTabControl = new System.Windows.Forms.TabControl();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.addresslabel = new System.Windows.Forms.Label();
            this.companyaddresslabel = new System.Windows.Forms.Label();
            this.companyaddresstextBox = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.companyTab.SuspendLayout();
            this.personTab.SuspendLayout();
            this.addContactTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(19, 429);
            this.Cancelbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(166, 30);
            this.Cancelbutton.TabIndex = 6;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // companyTab
            // 
            this.companyTab.Controls.Add(this.companyaddresslabel);
            this.companyTab.Controls.Add(this.companyaddresstextBox);
            this.companyTab.Controls.Add(this.label7);
            this.companyTab.Controls.Add(this.label6);
            this.companyTab.Controls.Add(this.label5);
            this.companyTab.Controls.Add(this.ugcomboBox2);
            this.companyTab.Controls.Add(this.CompanyPhonetextBox);
            this.companyTab.Controls.Add(this.CompanyNtextBox);
            this.companyTab.Location = new System.Drawing.Point(4, 30);
            this.companyTab.Margin = new System.Windows.Forms.Padding(4);
            this.companyTab.Name = "companyTab";
            this.companyTab.Padding = new System.Windows.Forms.Padding(4);
            this.companyTab.Size = new System.Drawing.Size(454, 365);
            this.companyTab.TabIndex = 1;
            this.companyTab.Text = "Company";
            this.companyTab.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "user group";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "phone number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "name";
            // 
            // ugcomboBox2
            // 
            this.ugcomboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ugcomboBox2.FormattingEnabled = true;
            this.ugcomboBox2.Location = new System.Drawing.Point(26, 275);
            this.ugcomboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.ugcomboBox2.Name = "ugcomboBox2";
            this.ugcomboBox2.Size = new System.Drawing.Size(406, 29);
            this.ugcomboBox2.TabIndex = 5;
            // 
            // CompanyPhonetextBox
            // 
            this.CompanyPhonetextBox.Location = new System.Drawing.Point(26, 116);
            this.CompanyPhonetextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CompanyPhonetextBox.Name = "CompanyPhonetextBox";
            this.CompanyPhonetextBox.Size = new System.Drawing.Size(406, 28);
            this.CompanyPhonetextBox.TabIndex = 2;
            this.CompanyPhonetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CompanyPhonetextBox_KeyPress);
            // 
            // CompanyNtextBox
            // 
            this.CompanyNtextBox.Location = new System.Drawing.Point(26, 54);
            this.CompanyNtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CompanyNtextBox.Name = "CompanyNtextBox";
            this.CompanyNtextBox.Size = new System.Drawing.Size(406, 28);
            this.CompanyNtextBox.TabIndex = 1;
            // 
            // personTab
            // 
            this.personTab.Controls.Add(this.addresslabel);
            this.personTab.Controls.Add(this.personaddresstextBox);
            this.personTab.Controls.Add(this.label4);
            this.personTab.Controls.Add(this.label3);
            this.personTab.Controls.Add(this.label2);
            this.personTab.Controls.Add(this.label1);
            this.personTab.Controls.Add(this.ugcomboBox1);
            this.personTab.Controls.Add(this.PhonetextBox);
            this.personTab.Controls.Add(this.LastNtextBox);
            this.personTab.Controls.Add(this.FirstNtextBox);
            this.personTab.Location = new System.Drawing.Point(4, 30);
            this.personTab.Margin = new System.Windows.Forms.Padding(4);
            this.personTab.Name = "personTab";
            this.personTab.Padding = new System.Windows.Forms.Padding(4);
            this.personTab.Size = new System.Drawing.Size(454, 354);
            this.personTab.TabIndex = 0;
            this.personTab.Text = "Person";
            this.personTab.UseVisualStyleBackColor = true;
            // 
            // personaddresstextBox
            // 
            this.personaddresstextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personaddresstextBox.Location = new System.Drawing.Point(26, 208);
            this.personaddresstextBox.Margin = new System.Windows.Forms.Padding(4);
            this.personaddresstextBox.Multiline = true;
            this.personaddresstextBox.Name = "personaddresstextBox";
            this.personaddresstextBox.Size = new System.Drawing.Size(406, 72);
            this.personaddresstextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "user group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "phone number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "first name";
            // 
            // ugcomboBox1
            // 
            this.ugcomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ugcomboBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ugcomboBox1.FormattingEnabled = true;
            this.ugcomboBox1.Location = new System.Drawing.Point(26, 309);
            this.ugcomboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ugcomboBox1.Name = "ugcomboBox1";
            this.ugcomboBox1.Size = new System.Drawing.Size(406, 28);
            this.ugcomboBox1.TabIndex = 4;
            // 
            // PhonetextBox
            // 
            this.PhonetextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhonetextBox.Location = new System.Drawing.Point(26, 153);
            this.PhonetextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhonetextBox.Name = "PhonetextBox";
            this.PhonetextBox.Size = new System.Drawing.Size(406, 26);
            this.PhonetextBox.TabIndex = 2;
            this.PhonetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhonetextBox_KeyPress);
            // 
            // LastNtextBox
            // 
            this.LastNtextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNtextBox.Location = new System.Drawing.Point(26, 98);
            this.LastNtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LastNtextBox.Name = "LastNtextBox";
            this.LastNtextBox.Size = new System.Drawing.Size(406, 26);
            this.LastNtextBox.TabIndex = 1;
            // 
            // FirstNtextBox
            // 
            this.FirstNtextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNtextBox.Location = new System.Drawing.Point(26, 43);
            this.FirstNtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FirstNtextBox.Name = "FirstNtextBox";
            this.FirstNtextBox.Size = new System.Drawing.Size(406, 26);
            this.FirstNtextBox.TabIndex = 0;
            // 
            // addContactTabControl
            // 
            this.addContactTabControl.Controls.Add(this.personTab);
            this.addContactTabControl.Controls.Add(this.companyTab);
            this.addContactTabControl.Location = new System.Drawing.Point(15, 16);
            this.addContactTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.addContactTabControl.Name = "addContactTabControl";
            this.addContactTabControl.SelectedIndex = 0;
            this.addContactTabControl.Size = new System.Drawing.Size(462, 388);
            this.addContactTabControl.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // addresslabel
            // 
            this.addresslabel.AutoSize = true;
            this.addresslabel.Location = new System.Drawing.Point(22, 183);
            this.addresslabel.Name = "addresslabel";
            this.addresslabel.Size = new System.Drawing.Size(76, 21);
            this.addresslabel.TabIndex = 10;
            this.addresslabel.Text = "address";
            // 
            // companyaddresslabel
            // 
            this.companyaddresslabel.AutoSize = true;
            this.companyaddresslabel.Location = new System.Drawing.Point(22, 148);
            this.companyaddresslabel.Name = "companyaddresslabel";
            this.companyaddresslabel.Size = new System.Drawing.Size(76, 21);
            this.companyaddresslabel.TabIndex = 12;
            this.companyaddresslabel.Text = "address";
            // 
            // companyaddresstextBox
            // 
            this.companyaddresstextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyaddresstextBox.Location = new System.Drawing.Point(26, 174);
            this.companyaddresstextBox.Margin = new System.Windows.Forms.Padding(4);
            this.companyaddresstextBox.Multiline = true;
            this.companyaddresstextBox.Name = "companyaddresstextBox";
            this.companyaddresstextBox.Size = new System.Drawing.Size(406, 72);
            this.companyaddresstextBox.TabIndex = 11;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(313, 429);
            this.addbutton.Margin = new System.Windows.Forms.Padding(4);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(160, 32);
            this.addbutton.TabIndex = 7;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(493, 480);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.addContactTabControl);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New";
            this.companyTab.ResumeLayout(false);
            this.companyTab.PerformLayout();
            this.personTab.ResumeLayout(false);
            this.personTab.PerformLayout();
            this.addContactTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.TabPage companyTab;
        private System.Windows.Forms.ComboBox ugcomboBox2;
        private System.Windows.Forms.TextBox CompanyPhonetextBox;
        private System.Windows.Forms.TextBox CompanyNtextBox;
        private System.Windows.Forms.TabPage personTab;
        private System.Windows.Forms.ComboBox ugcomboBox1;
        private System.Windows.Forms.TextBox PhonetextBox;
        private System.Windows.Forms.TextBox LastNtextBox;
        private System.Windows.Forms.TextBox FirstNtextBox;
        private System.Windows.Forms.TabControl addContactTabControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox personaddresstextBox;
        private System.Windows.Forms.Label companyaddresslabel;
        private System.Windows.Forms.TextBox companyaddresstextBox;
        private System.Windows.Forms.Label addresslabel;
        private System.Windows.Forms.Button addbutton;
    }
}