namespace Database
{
    partial class Form4
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
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.DeptName = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(377, 259);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(114, 22);
            this.txtDeptName.TabIndex = 25;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(377, 185);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(114, 22);
            this.txtSalary.TabIndex = 24;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(377, 119);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(114, 22);
            this.txtName.TabIndex = 23;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(377, 53);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(114, 22);
            this.txtId.TabIndex = 22;
            // 
            // DeptName
            // 
            this.DeptName.AutoSize = true;
            this.DeptName.Location = new System.Drawing.Point(285, 259);
            this.DeptName.Name = "DeptName";
            this.DeptName.Size = new System.Drawing.Size(76, 16);
            this.DeptName.TabIndex = 21;
            this.DeptName.Text = "Dept Name";
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Location = new System.Drawing.Point(285, 191);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(46, 16);
            this.Salary.TabIndex = 20;
            this.Salary.Text = "Salary";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(285, 122);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(75, 16);
            this.Name.TabIndex = 19;
            this.Name.Text = "Emp Name";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(285, 56);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(49, 16);
            this.Id.TabIndex = 18;
            this.Id.Text = "Emp Id";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(377, 391);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(222, 391);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(346, 323);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(213, 323);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.DeptName);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label DeptName;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
    }
}