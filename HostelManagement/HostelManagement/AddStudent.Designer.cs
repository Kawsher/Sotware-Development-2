namespace HostelManagement
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.lblId = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFather = new System.Windows.Forms.TextBox();
            this.txtMother = new System.Windows.Forms.TextBox();
            this.txtPhn = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFare = new System.Windows.Forms.TextBox();
            this.joinDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblId.Location = new System.Drawing.Point(59, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.ForeColor = System.Drawing.Color.Green;
            this.btnAdd.Location = new System.Drawing.Point(348, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.Location = new System.Drawing.Point(78, 6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(179, 20);
            this.txtId.TabIndex = 1;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            this.txtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(78, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 20);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // txtFather
            // 
            this.txtFather.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFather.Location = new System.Drawing.Point(78, 57);
            this.txtFather.Name = "txtFather";
            this.txtFather.Size = new System.Drawing.Size(179, 20);
            this.txtFather.TabIndex = 5;
            this.txtFather.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtFather.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFather_KeyDown);
            // 
            // txtMother
            // 
            this.txtMother.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMother.Location = new System.Drawing.Point(78, 81);
            this.txtMother.Name = "txtMother";
            this.txtMother.Size = new System.Drawing.Size(179, 20);
            this.txtMother.TabIndex = 7;
            this.txtMother.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txtMother.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMother_KeyDown);
            // 
            // txtPhn
            // 
            this.txtPhn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhn.Location = new System.Drawing.Point(348, 6);
            this.txtPhn.Name = "txtPhn";
            this.txtPhn.Size = new System.Drawing.Size(179, 20);
            this.txtPhn.TabIndex = 13;
            this.txtPhn.TextChanged += new System.EventHandler(this.txtPhn_TextChanged);
            this.txtPhn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhn_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(348, 32);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(179, 20);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.Location = new System.Drawing.Point(348, 84);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(179, 67);
            this.txtAddress.TabIndex = 19;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddress_KeyDown);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkKhaki;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(300, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Address";
            // 
            // txtRoom
            // 
            this.txtRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRoom.Location = new System.Drawing.Point(78, 106);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(179, 20);
            this.txtRoom.TabIndex = 9;
            this.txtRoom.TextChanged += new System.EventHandler(this.txtRoom_TextChanged);
            this.txtRoom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRoom_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkKhaki;
            this.label2.Location = new System.Drawing.Point(23, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Room No";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblName.Location = new System.Drawing.Point(40, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkKhaki;
            this.label6.Location = new System.Drawing.Point(266, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkKhaki;
            this.label4.Location = new System.Drawing.Point(4, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mother Name";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkKhaki;
            this.label3.Location = new System.Drawing.Point(7, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Father Name";
            // 
            // lblSection
            // 
            this.lblSection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSection.AutoSize = true;
            this.lblSection.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblSection.Location = new System.Drawing.Point(23, 133);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(52, 13);
            this.lblSection.TabIndex = 10;
            this.lblSection.Text = "Join Date";
            this.lblSection.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkKhaki;
            this.label7.Location = new System.Drawing.Point(313, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Email";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Location = new System.Drawing.Point(452, 161);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 22;
            this.btnHome.Text = "Back";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkKhaki;
            this.label1.Location = new System.Drawing.Point(285, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Room Fare";
            // 
            // txtFare
            // 
            this.txtFare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFare.Location = new System.Drawing.Point(348, 57);
            this.txtFare.Name = "txtFare";
            this.txtFare.Size = new System.Drawing.Size(179, 20);
            this.txtFare.TabIndex = 17;
            this.txtFare.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFare_KeyDown);
            // 
            // joinDate
            // 
            this.joinDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.joinDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.joinDate.Location = new System.Drawing.Point(78, 131);
            this.joinDate.Name = "joinDate";
            this.joinDate.Size = new System.Drawing.Size(179, 20);
            this.joinDate.TabIndex = 11;
            this.joinDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.joinDate_KeyDown);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(544, 196);
            this.Controls.Add(this.joinDate);
            this.Controls.Add(this.txtFare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhn);
            this.Controls.Add(this.txtMother);
            this.Controls.Add(this.txtFather);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblId);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(560, 235);
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFather;
        private System.Windows.Forms.TextBox txtMother;
        private System.Windows.Forms.TextBox txtPhn;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFare;
        private System.Windows.Forms.DateTimePicker joinDate;
    }
}