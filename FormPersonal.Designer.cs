namespace RepairShop
{
    partial class FormPersonal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 250);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление сотрудника";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtBirth);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtSub);
            this.panel2.Controls.Add(this.txtPost);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtNumber);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtLastName);
            this.panel2.Location = new System.Drawing.Point(12, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1202, 843);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 558);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 41);
            this.label7.TabIndex = 22;
            this.label7.Text = "Подразделение";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 41);
            this.label6.TabIndex = 21;
            this.label6.Text = "Должность";
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(246, 555);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(796, 47);
            this.txtSub.TabIndex = 20;
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(246, 450);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(796, 47);
            this.txtPost.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSave.Location = new System.Drawing.Point(484, 744);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(197, 73);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 41);
            this.label5.TabIndex = 16;
            this.label5.Text = "телефон";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(246, 351);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(796, 47);
            this.txtNumber.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 41);
            this.label2.TabIndex = 10;
            this.label2.Text = "Имя";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(246, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(796, 47);
            this.txtName.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(246, 247);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(796, 47);
            this.txtEmail.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 41);
            this.label3.TabIndex = 12;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 41);
            this.label4.TabIndex = 14;
            this.label4.Text = "email";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(246, 144);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(796, 47);
            this.txtLastName.TabIndex = 13;
            // 
            // txtBirth
            // 
            this.txtBirth.Location = new System.Drawing.Point(246, 658);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(796, 47);
            this.txtBirth.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 661);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 41);
            this.label8.TabIndex = 24;
            this.label8.Text = "Год р.";
            // 
            // FormPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 1127);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnSave;
        private Label label5;
        private TextBox txtNumber;
        private Label label2;
        private TextBox txtName;
        private TextBox txtEmail;
        private Label label3;
        private Label label4;
        private TextBox txtLastName;
        private Label label7;
        private Label label6;
        private TextBox txtSub;
        private TextBox txtPost;
        private Label label8;
        private TextBox txtBirth;
    }
}