namespace Phonebook
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.editbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.contactGrid = new System.Windows.Forms.DataGridView();
            this.namecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsergroupcomboBox = new System.Windows.Forms.ComboBox();
            this.addtolink = new System.Windows.Forms.LinkLabel();
            this.groupsLink = new System.Windows.Forms.LinkLabel();
            this.filterlabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.contactGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // editbutton
            // 
            this.editbutton.BackColor = System.Drawing.Color.Gainsboro;
            this.editbutton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbutton.ForeColor = System.Drawing.Color.White;
            this.editbutton.Location = new System.Drawing.Point(202, 528);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(150, 74);
            this.editbutton.TabIndex = 3;
            this.editbutton.Text = "Edit";
            this.editbutton.UseVisualStyleBackColor = false;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.Salmon;
            this.deletebutton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.ForeColor = System.Drawing.Color.White;
            this.deletebutton.Location = new System.Drawing.Point(48, 528);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(150, 74);
            this.deletebutton.TabIndex = 4;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.SpringGreen;
            this.addbutton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.Color.White;
            this.addbutton.Location = new System.Drawing.Point(358, 528);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(150, 74);
            this.addbutton.TabIndex = 5;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // contactGrid
            // 
            this.contactGrid.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.contactGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namecol,
            this.phonecol});
            this.contactGrid.Location = new System.Drawing.Point(48, 123);
            this.contactGrid.Name = "contactGrid";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactGrid.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.contactGrid.RowTemplate.Height = 24;
            this.contactGrid.Size = new System.Drawing.Size(460, 399);
            this.contactGrid.TabIndex = 7;
            this.contactGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contactGrid_CellClick);
            this.contactGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contactGrid_CellContentClick);
            // 
            // namecol
            // 
            this.namecol.FillWeight = 205F;
            this.namecol.HeaderText = "Name";
            this.namecol.MinimumWidth = 205;
            this.namecol.Name = "namecol";
            this.namecol.ReadOnly = true;
            this.namecol.Width = 205;
            // 
            // phonecol
            // 
            this.phonecol.FillWeight = 205F;
            this.phonecol.HeaderText = "Phone Number";
            this.phonecol.MinimumWidth = 205;
            this.phonecol.Name = "phonecol";
            this.phonecol.Width = 210;
            // 
            // UsergroupcomboBox
            // 
            this.UsergroupcomboBox.DisplayMember = "0";
            this.UsergroupcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsergroupcomboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsergroupcomboBox.FormattingEnabled = true;
            this.UsergroupcomboBox.ItemHeight = 18;
            this.UsergroupcomboBox.Items.AddRange(new object[] {
            "All Contacts"});
            this.UsergroupcomboBox.Location = new System.Drawing.Point(48, 77);
            this.UsergroupcomboBox.Name = "UsergroupcomboBox";
            this.UsergroupcomboBox.Size = new System.Drawing.Size(460, 26);
            this.UsergroupcomboBox.TabIndex = 8;
            this.UsergroupcomboBox.SelectedIndexChanged += new System.EventHandler(this.UsergroupcomboBox_SelectedIndexChanged);
            // 
            // addtolink
            // 
            this.addtolink.AutoSize = true;
            this.addtolink.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtolink.Location = new System.Drawing.Point(368, 9);
            this.addtolink.Name = "addtolink";
            this.addtolink.Size = new System.Drawing.Size(140, 21);
            this.addtolink.TabIndex = 9;
            this.addtolink.TabStop = true;
            this.addtolink.Text = "+ Add to group";
            this.addtolink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addtolink_LinkClicked);
            // 
            // groupsLink
            // 
            this.groupsLink.AutoSize = true;
            this.groupsLink.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsLink.Location = new System.Drawing.Point(44, 9);
            this.groupsLink.Name = "groupsLink";
            this.groupsLink.Size = new System.Drawing.Size(110, 21);
            this.groupsLink.TabIndex = 10;
            this.groupsLink.TabStop = true;
            this.groupsLink.Text = "User Groups";
            this.groupsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.groupsLink_LinkClicked);
            // 
            // filterlabel
            // 
            this.filterlabel.AutoSize = true;
            this.filterlabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterlabel.Location = new System.Drawing.Point(48, 54);
            this.filterlabel.Name = "filterlabel";
            this.filterlabel.Size = new System.Drawing.Size(192, 17);
            this.filterlabel.TabIndex = 11;
            this.filterlabel.Text = "filter contacts by usergroup";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 620);
            this.Controls.Add(this.filterlabel);
            this.Controls.Add(this.groupsLink);
            this.Controls.Add(this.addtolink);
            this.Controls.Add(this.UsergroupcomboBox);
            this.Controls.Add(this.contactGrid);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.editbutton);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phonebook";
            ((System.ComponentModel.ISupportInitialize)(this.contactGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.DataGridView contactGrid;
        private System.Windows.Forms.ComboBox UsergroupcomboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonecol;
        private System.Windows.Forms.LinkLabel addtolink;
        private System.Windows.Forms.LinkLabel groupsLink;
        private System.Windows.Forms.Label filterlabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}