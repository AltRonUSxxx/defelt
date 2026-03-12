namespace teacher
{
    partial class FormTeacherMain
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
            this.pictureBox_uppestPanel = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_close = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_register_new_student = new System.Windows.Forms.Button();
            this.panel_register_new_student = new System.Windows.Forms.Panel();
            this.label_rns_firstName = new System.Windows.Forms.Label();
            this.textBox_rns_firstName = new System.Windows.Forms.TextBox();
            this.label_rns_lastName = new System.Windows.Forms.Label();
            this.textBox_rns_lastName = new System.Windows.Forms.TextBox();
            this.label_rns_middleName = new System.Windows.Forms.Label();
            this.textBox_rns_middleName = new System.Windows.Forms.TextBox();
            this.label_rns_email = new System.Windows.Forms.Label();
            this.textBox_rns_email = new System.Windows.Forms.TextBox();
            this.label_rns_group = new System.Windows.Forms.Label();
            this.comboBox_rns_group = new System.Windows.Forms.ComboBox();
            this.label_rns_passwordCofirm = new System.Windows.Forms.Label();
            this.textBox_rns_passwordConfirm = new System.Windows.Forms.TextBox();
            this.label_rns_password = new System.Windows.Forms.Label();
            this.label_rns_login = new System.Windows.Forms.Label();
            this.textBox_rns_password = new System.Windows.Forms.TextBox();
            this.textBox_rns_login = new System.Windows.Forms.TextBox();
            this.button_groups = new System.Windows.Forms.Button();
            this.panel_groups = new System.Windows.Forms.Panel();
            this.dataGridView_groups = new System.Windows.Forms.DataGridView();
            this.button_groups_add = new System.Windows.Forms.Button();
            this.button_groups_remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_uppestPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_register_new_student.SuspendLayout();
            this.panel_groups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_groups)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_uppestPanel
            // 
            this.pictureBox_uppestPanel.BackColor = System.Drawing.Color.Black;
            this.pictureBox_uppestPanel.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_uppestPanel.Name = "pictureBox_uppestPanel";
            this.pictureBox_uppestPanel.Size = new System.Drawing.Size(800, 30);
            this.pictureBox_uppestPanel.TabIndex = 0;
            this.pictureBox_uppestPanel.TabStop = false;
            this.pictureBox_uppestPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_uppestPanel_MouseDown);
            this.pictureBox_uppestPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_uppestPanel_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "DefElt";
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_close.ForeColor = System.Drawing.Color.Red;
            this.label_close.Location = new System.Drawing.Point(772, 0);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(28, 30);
            this.label_close.TabIndex = 11;
            this.label_close.Text = "X";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(200, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 450);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 450);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // button_register_new_student
            // 
            this.button_register_new_student.BackColor = System.Drawing.Color.Silver;
            this.button_register_new_student.ForeColor = System.Drawing.Color.Black;
            this.button_register_new_student.Location = new System.Drawing.Point(6, 36);
            this.button_register_new_student.Name = "button_register_new_student";
            this.button_register_new_student.Size = new System.Drawing.Size(188, 57);
            this.button_register_new_student.TabIndex = 14;
            this.button_register_new_student.Text = "{Register_new_student}";
            this.button_register_new_student.UseVisualStyleBackColor = false;
            this.button_register_new_student.Click += new System.EventHandler(this.button_register_Click);
            // 
            // panel_register_new_student
            // 
            this.panel_register_new_student.Controls.Add(this.label_rns_firstName);
            this.panel_register_new_student.Controls.Add(this.textBox_rns_firstName);
            this.panel_register_new_student.Controls.Add(this.label_rns_lastName);
            this.panel_register_new_student.Controls.Add(this.textBox_rns_lastName);
            this.panel_register_new_student.Controls.Add(this.label_rns_middleName);
            this.panel_register_new_student.Controls.Add(this.textBox_rns_middleName);
            this.panel_register_new_student.Controls.Add(this.label_rns_email);
            this.panel_register_new_student.Controls.Add(this.textBox_rns_email);
            this.panel_register_new_student.Controls.Add(this.label_rns_group);
            this.panel_register_new_student.Controls.Add(this.comboBox_rns_group);
            this.panel_register_new_student.Controls.Add(this.label_rns_passwordCofirm);
            this.panel_register_new_student.Controls.Add(this.textBox_rns_passwordConfirm);
            this.panel_register_new_student.Controls.Add(this.label_rns_password);
            this.panel_register_new_student.Controls.Add(this.label_rns_login);
            this.panel_register_new_student.Controls.Add(this.textBox_rns_password);
            this.panel_register_new_student.Controls.Add(this.textBox_rns_login);
            this.panel_register_new_student.Location = new System.Drawing.Point(216, 33);
            this.panel_register_new_student.Name = "panel_register_new_student";
            this.panel_register_new_student.Size = new System.Drawing.Size(584, 417);
            this.panel_register_new_student.TabIndex = 15;
            this.panel_register_new_student.Visible = false;
            // 
            // label_rns_firstName
            // 
            this.label_rns_firstName.AutoSize = true;
            this.label_rns_firstName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_rns_firstName.Location = new System.Drawing.Point(285, 15);
            this.label_rns_firstName.Name = "label_rns_firstName";
            this.label_rns_firstName.Size = new System.Drawing.Size(122, 22);
            this.label_rns_firstName.TabIndex = 15;
            this.label_rns_firstName.Text = "{first_name}";
            // 
            // textBox_rns_firstName
            // 
            this.textBox_rns_firstName.Location = new System.Drawing.Point(290, 40);
            this.textBox_rns_firstName.Name = "textBox_rns_firstName";
            this.textBox_rns_firstName.Size = new System.Drawing.Size(194, 32);
            this.textBox_rns_firstName.TabIndex = 14;
            // 
            // label_rns_lastName
            // 
            this.label_rns_lastName.AutoSize = true;
            this.label_rns_lastName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_rns_lastName.Location = new System.Drawing.Point(285, 85);
            this.label_rns_lastName.Name = "label_rns_lastName";
            this.label_rns_lastName.Size = new System.Drawing.Size(119, 22);
            this.label_rns_lastName.TabIndex = 13;
            this.label_rns_lastName.Text = "{last_name}";
            // 
            // textBox_rns_lastName
            // 
            this.textBox_rns_lastName.Location = new System.Drawing.Point(290, 110);
            this.textBox_rns_lastName.Name = "textBox_rns_lastName";
            this.textBox_rns_lastName.Size = new System.Drawing.Size(194, 32);
            this.textBox_rns_lastName.TabIndex = 12;
            // 
            // label_rns_middleName
            // 
            this.label_rns_middleName.AutoSize = true;
            this.label_rns_middleName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_rns_middleName.Location = new System.Drawing.Point(285, 155);
            this.label_rns_middleName.Name = "label_rns_middleName";
            this.label_rns_middleName.Size = new System.Drawing.Size(148, 22);
            this.label_rns_middleName.TabIndex = 11;
            this.label_rns_middleName.Text = "{middle_name}";
            // 
            // textBox_rns_middleName
            // 
            this.textBox_rns_middleName.Location = new System.Drawing.Point(290, 180);
            this.textBox_rns_middleName.Name = "textBox_rns_middleName";
            this.textBox_rns_middleName.Size = new System.Drawing.Size(194, 32);
            this.textBox_rns_middleName.TabIndex = 10;
            // 
            // label_rns_email
            // 
            this.label_rns_email.AutoSize = true;
            this.label_rns_email.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_rns_email.Location = new System.Drawing.Point(25, 225);
            this.label_rns_email.Name = "label_rns_email";
            this.label_rns_email.Size = new System.Drawing.Size(75, 22);
            this.label_rns_email.TabIndex = 9;
            this.label_rns_email.Text = "{Email}";
            // 
            // textBox_rns_email
            // 
            this.textBox_rns_email.Location = new System.Drawing.Point(30, 250);
            this.textBox_rns_email.Name = "textBox_rns_email";
            this.textBox_rns_email.Size = new System.Drawing.Size(194, 32);
            this.textBox_rns_email.TabIndex = 8;
            // 
            // label_rns_group
            // 
            this.label_rns_group.AutoSize = true;
            this.label_rns_group.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_rns_group.Location = new System.Drawing.Point(285, 225);
            this.label_rns_group.Name = "label_rns_group";
            this.label_rns_group.Size = new System.Drawing.Size(83, 22);
            this.label_rns_group.TabIndex = 7;
            this.label_rns_group.Text = "{Group}";
            // 
            // comboBox_rns_group
            // 
            this.comboBox_rns_group.FormattingEnabled = true;
            this.comboBox_rns_group.Location = new System.Drawing.Point(290, 250);
            this.comboBox_rns_group.Name = "comboBox_rns_group";
            this.comboBox_rns_group.Size = new System.Drawing.Size(194, 32);
            this.comboBox_rns_group.TabIndex = 6;
            // 
            // label_rns_passwordCofirm
            // 
            this.label_rns_passwordCofirm.AutoSize = true;
            this.label_rns_passwordCofirm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_rns_passwordCofirm.Location = new System.Drawing.Point(25, 155);
            this.label_rns_passwordCofirm.Name = "label_rns_passwordCofirm";
            this.label_rns_passwordCofirm.Size = new System.Drawing.Size(199, 22);
            this.label_rns_passwordCofirm.TabIndex = 5;
            this.label_rns_passwordCofirm.Text = "{Password_confirm}";
            // 
            // textBox_rns_passwordConfirm
            // 
            this.textBox_rns_passwordConfirm.Location = new System.Drawing.Point(30, 180);
            this.textBox_rns_passwordConfirm.Name = "textBox_rns_passwordConfirm";
            this.textBox_rns_passwordConfirm.Size = new System.Drawing.Size(194, 32);
            this.textBox_rns_passwordConfirm.TabIndex = 4;
            // 
            // label_rns_password
            // 
            this.label_rns_password.AutoSize = true;
            this.label_rns_password.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_rns_password.Location = new System.Drawing.Point(25, 85);
            this.label_rns_password.Name = "label_rns_password";
            this.label_rns_password.Size = new System.Drawing.Size(117, 22);
            this.label_rns_password.TabIndex = 3;
            this.label_rns_password.Text = "{Password}";
            // 
            // label_rns_login
            // 
            this.label_rns_login.AutoSize = true;
            this.label_rns_login.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_rns_login.Location = new System.Drawing.Point(25, 15);
            this.label_rns_login.Name = "label_rns_login";
            this.label_rns_login.Size = new System.Drawing.Size(77, 22);
            this.label_rns_login.TabIndex = 2;
            this.label_rns_login.Text = "{Login}";
            // 
            // textBox_rns_password
            // 
            this.textBox_rns_password.Location = new System.Drawing.Point(30, 110);
            this.textBox_rns_password.Name = "textBox_rns_password";
            this.textBox_rns_password.Size = new System.Drawing.Size(194, 32);
            this.textBox_rns_password.TabIndex = 1;
            // 
            // textBox_rns_login
            // 
            this.textBox_rns_login.Location = new System.Drawing.Point(30, 40);
            this.textBox_rns_login.Name = "textBox_rns_login";
            this.textBox_rns_login.Size = new System.Drawing.Size(194, 32);
            this.textBox_rns_login.TabIndex = 0;
            // 
            // button_groups
            // 
            this.button_groups.BackColor = System.Drawing.Color.Silver;
            this.button_groups.ForeColor = System.Drawing.Color.Black;
            this.button_groups.Location = new System.Drawing.Point(6, 99);
            this.button_groups.Name = "button_groups";
            this.button_groups.Size = new System.Drawing.Size(188, 57);
            this.button_groups.TabIndex = 16;
            this.button_groups.Text = "{Make_new_group}";
            this.button_groups.UseVisualStyleBackColor = false;
            this.button_groups.Click += new System.EventHandler(this.button_groups_Click);
            // 
            // panel_groups
            // 
            this.panel_groups.Controls.Add(this.button_groups_remove);
            this.panel_groups.Controls.Add(this.button_groups_add);
            this.panel_groups.Controls.Add(this.dataGridView_groups);
            this.panel_groups.Location = new System.Drawing.Point(216, 33);
            this.panel_groups.Name = "panel_groups";
            this.panel_groups.Size = new System.Drawing.Size(584, 417);
            this.panel_groups.TabIndex = 16;
            this.panel_groups.Visible = false;
            // 
            // dataGridView_groups
            // 
            this.dataGridView_groups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_groups.Location = new System.Drawing.Point(15, 15);
            this.dataGridView_groups.Name = "dataGridView_groups";
            this.dataGridView_groups.Size = new System.Drawing.Size(557, 288);
            this.dataGridView_groups.TabIndex = 0;
            // 
            // button_groups_add
            // 
            this.button_groups_add.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_groups_add.Location = new System.Drawing.Point(384, 309);
            this.button_groups_add.Name = "button_groups_add";
            this.button_groups_add.Size = new System.Drawing.Size(91, 30);
            this.button_groups_add.TabIndex = 1;
            this.button_groups_add.Text = "{add}";
            this.button_groups_add.UseVisualStyleBackColor = true;
            // 
            // button_groups_remove
            // 
            this.button_groups_remove.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_groups_remove.Location = new System.Drawing.Point(481, 309);
            this.button_groups_remove.Name = "button_groups_remove";
            this.button_groups_remove.Size = new System.Drawing.Size(91, 30);
            this.button_groups_remove.TabIndex = 2;
            this.button_groups_remove.Text = "{remove}";
            this.button_groups_remove.UseVisualStyleBackColor = true;
            // 
            // FormTeacherMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_groups);
            this.Controls.Add(this.button_register_new_student);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_uppestPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel_groups);
            this.Controls.Add(this.panel_register_new_student);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormTeacherMain";
            this.Text = "DefElt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_uppestPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_register_new_student.ResumeLayout(false);
            this.panel_register_new_student.PerformLayout();
            this.panel_groups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_groups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_uppestPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_register_new_student;
        private System.Windows.Forms.Panel panel_register_new_student;
        private System.Windows.Forms.Label label_rns_password;
        private System.Windows.Forms.Label label_rns_login;
        private System.Windows.Forms.TextBox textBox_rns_password;
        private System.Windows.Forms.TextBox textBox_rns_login;
        private System.Windows.Forms.Label label_rns_passwordCofirm;
        private System.Windows.Forms.TextBox textBox_rns_passwordConfirm;
        private System.Windows.Forms.ComboBox comboBox_rns_group;
        private System.Windows.Forms.Label label_rns_group;
        private System.Windows.Forms.Label label_rns_email;
        private System.Windows.Forms.TextBox textBox_rns_email;
        private System.Windows.Forms.TextBox textBox_rns_middleName;
        private System.Windows.Forms.Label label_rns_middleName;
        private System.Windows.Forms.TextBox textBox_rns_lastName;
        private System.Windows.Forms.Label label_rns_lastName;
        private System.Windows.Forms.TextBox textBox_rns_firstName;
        private System.Windows.Forms.Label label_rns_firstName;
        private System.Windows.Forms.Button button_groups;
        private System.Windows.Forms.Panel panel_groups;
        private System.Windows.Forms.DataGridView dataGridView_groups;
        private System.Windows.Forms.Button button_groups_remove;
        private System.Windows.Forms.Button button_groups_add;
    }
}