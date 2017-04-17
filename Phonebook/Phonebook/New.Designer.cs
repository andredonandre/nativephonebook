namespace Phonebook
{
    partial class New
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
            this.addCompanyButton = new System.Windows.Forms.Button();
            this.CompanyPhonetextBox = new System.Windows.Forms.TextBox();
            this.CompanyNtextBox = new System.Windows.Forms.TextBox();
            this.personTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ugcomboBox1 = new System.Windows.Forms.ComboBox();
            this.AddPbutton = new System.Windows.Forms.Button();
            this.PhonetextBox = new System.Windows.Forms.TextBox();
            this.LastNtextBox = new System.Windows.Forms.TextBox();
            this.FirstNtextBox = new System.Windows.Forms.TextBox();
            this.newTabControl = new System.Windows.Forms.TabControl();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.companyTab.SuspendLayout();
            this.personTab.SuspendLayout();
            this.newTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(20, 368);
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
            this.companyTab.Controls.Add(this.label7);
            this.companyTab.Controls.Add(this.label6);
            this.companyTab.Controls.Add(this.label5);
            this.companyTab.Controls.Add(this.ugcomboBox2);
            this.companyTab.Controls.Add(this.addCompanyButton);
            this.companyTab.Controls.Add(this.CompanyPhonetextBox);
            this.companyTab.Controls.Add(this.CompanyNtextBox);
            this.companyTab.Location = new System.Drawing.Point(4, 30);
            this.companyTab.Margin = new System.Windows.Forms.Padding(4);
            this.companyTab.Name = "companyTab";
            this.companyTab.Padding = new System.Windows.Forms.Padding(4);
            this.companyTab.Size = new System.Drawing.Size(465, 309);
            this.companyTab.TabIndex = 1;
            this.companyTab.Text = "Company";
            this.companyTab.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 160);
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
            this.ugcomboBox2.Location = new System.Drawing.Point(26, 185);
            this.ugcomboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.ugcomboBox2.Name = "ugcomboBox2";
            this.ugcomboBox2.Size = new System.Drawing.Size(406, 29);
            this.ugcomboBox2.TabIndex = 5;
            // 
            // addCompanyButton
            // 
            this.addCompanyButton.Location = new System.Drawing.Point(272, 257);
            this.addCompanyButton.Margin = new System.Windows.Forms.Padding(4);
            this.addCompanyButton.Name = "addCompanyButton";
            this.addCompanyButton.Size = new System.Drawing.Size(160, 32);
            this.addCompanyButton.TabIndex = 4;
            this.addCompanyButton.Text = "Add";
            this.addCompanyButton.UseVisualStyleBackColor = true;
            this.addCompanyButton.Click += new System.EventHandler(this.addCompanyButton_Click);
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
            this.personTab.Controls.Add(this.label4);
            this.personTab.Controls.Add(this.label3);
            this.personTab.Controls.Add(this.label2);
            this.personTab.Controls.Add(this.label1);
            this.personTab.Controls.Add(this.ugcomboBox1);
            this.personTab.Controls.Add(this.AddPbutton);
            this.personTab.Controls.Add(this.PhonetextBox);
            this.personTab.Controls.Add(this.LastNtextBox);
            this.personTab.Controls.Add(this.FirstNtextBox);
            this.personTab.Location = new System.Drawing.Point(4, 30);
            this.personTab.Margin = new System.Windows.Forms.Padding(4);
            this.personTab.Name = "personTab";
            this.personTab.Padding = new System.Windows.Forms.Padding(4);
            this.personTab.Size = new System.Drawing.Size(465, 309);
            this.personTab.TabIndex = 0;
            this.personTab.Text = "Person";
            this.personTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "user group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "phone number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
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
            this.ugcomboBox1.Location = new System.Drawing.Point(21, 211);
            this.ugcomboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ugcomboBox1.Name = "ugcomboBox1";
            this.ugcomboBox1.Size = new System.Drawing.Size(406, 28);
            this.ugcomboBox1.TabIndex = 4;
            // 
            // AddPbutton
            // 
            this.AddPbutton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPbutton.Location = new System.Drawing.Point(267, 259);
            this.AddPbutton.Margin = new System.Windows.Forms.Padding(4);
            this.AddPbutton.Name = "AddPbutton";
            this.AddPbutton.Size = new System.Drawing.Size(160, 32);
            this.AddPbutton.TabIndex = 3;
            this.AddPbutton.Text = "Add";
            this.AddPbutton.UseVisualStyleBackColor = true;
            this.AddPbutton.Click += new System.EventHandler(this.AddPbutton_Click);
            // 
            // PhonetextBox
            // 
            this.PhonetextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhonetextBox.Location = new System.Drawing.Point(21, 156);
            this.PhonetextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhonetextBox.Name = "PhonetextBox";
            this.PhonetextBox.Size = new System.Drawing.Size(406, 26);
            this.PhonetextBox.TabIndex = 2;
            this.PhonetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhonetextBox_KeyPress);
            // 
            // LastNtextBox
            // 
            this.LastNtextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNtextBox.Location = new System.Drawing.Point(21, 101);
            this.LastNtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LastNtextBox.Name = "LastNtextBox";
            this.LastNtextBox.Size = new System.Drawing.Size(406, 26);
            this.LastNtextBox.TabIndex = 1;
            // 
            // FirstNtextBox
            // 
            this.FirstNtextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNtextBox.Location = new System.Drawing.Point(21, 46);
            this.FirstNtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FirstNtextBox.Name = "FirstNtextBox";
            this.FirstNtextBox.Size = new System.Drawing.Size(406, 26);
            this.FirstNtextBox.TabIndex = 0;
            // 
            // newTabControl
            // 
            this.newTabControl.Controls.Add(this.personTab);
            this.newTabControl.Controls.Add(this.companyTab);
            this.newTabControl.Location = new System.Drawing.Point(15, 16);
            this.newTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.newTabControl.Name = "newTabControl";
            this.newTabControl.SelectedIndex = 0;
            this.newTabControl.Size = new System.Drawing.Size(473, 343);
            this.newTabControl.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(511, 409);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.newTabControl);
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
            this.newTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.TabPage companyTab;
        private System.Windows.Forms.ComboBox ugcomboBox2;
        private System.Windows.Forms.Button addCompanyButton;
        private System.Windows.Forms.TextBox CompanyPhonetextBox;
        private System.Windows.Forms.TextBox CompanyNtextBox;
        private System.Windows.Forms.TabPage personTab;
        private System.Windows.Forms.ComboBox ugcomboBox1;
        private System.Windows.Forms.Button AddPbutton;
        private System.Windows.Forms.TextBox PhonetextBox;
        private System.Windows.Forms.TextBox LastNtextBox;
        private System.Windows.Forms.TextBox FirstNtextBox;
        private System.Windows.Forms.TabControl newTabControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}