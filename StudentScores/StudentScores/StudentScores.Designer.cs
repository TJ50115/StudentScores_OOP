namespace StudentScores
{
    partial class StudentScores
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sslblStudents = new Label();
            ListBox = new ListBox();
            ssbtnAddNew = new Button();
            ssbtnUpdate = new Button();
            ssbtnDelete = new Button();
            lblScoretotal = new Label();
            lblScoreCount = new Label();
            lblAverage = new Label();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // sslblStudents
            // 
            sslblStudents.AutoSize = true;
            sslblStudents.Location = new Point(12, 9);
            sslblStudents.Name = "sslblStudents";
            sslblStudents.Size = new Size(66, 20);
            sslblStudents.TabIndex = 0;
            sslblStudents.Text = "Students";
            // 
            // ListBox
            // 
            ListBox.FormattingEnabled = true;
            ListBox.Location = new Point(12, 32);
            ListBox.Name = "ListBox";
            ListBox.Size = new Size(293, 104);
            ListBox.TabIndex = 1;
            ListBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
            // 
            // ssbtnAddNew
            // 
            ssbtnAddNew.Location = new Point(311, 32);
            ssbtnAddNew.Name = "ssbtnAddNew";
            ssbtnAddNew.Size = new Size(94, 29);
            ssbtnAddNew.TabIndex = 12;
            ssbtnAddNew.Text = "Add New";
            ssbtnAddNew.Click += ssbtnAddNew_Click_1;
            // 
            // ssbtnUpdate
            // 
            ssbtnUpdate.Location = new Point(311, 67);
            ssbtnUpdate.Name = "ssbtnUpdate";
            ssbtnUpdate.Size = new Size(94, 29);
            ssbtnUpdate.TabIndex = 3;
            ssbtnUpdate.Text = "Update";
            ssbtnUpdate.UseVisualStyleBackColor = true;
            ssbtnUpdate.Click += ssbtnUpdate_Click;
            // 
            // ssbtnDelete
            // 
            ssbtnDelete.Location = new Point(311, 102);
            ssbtnDelete.Name = "ssbtnDelete";
            ssbtnDelete.Size = new Size(94, 34);
            ssbtnDelete.TabIndex = 4;
            ssbtnDelete.Text = "Delete";
            ssbtnDelete.UseVisualStyleBackColor = true;
            ssbtnDelete.Click += ssbtnDelete_Click;
            // 
            // lblScoretotal
            // 
            lblScoretotal.BorderStyle = BorderStyle.Fixed3D;
            lblScoretotal.Location = new Point(243, 139);
            lblScoretotal.Name = "lblScoretotal";
            lblScoretotal.Size = new Size(62, 40);
            lblScoretotal.TabIndex = 5;
            // 
            // lblScoreCount
            // 
            lblScoreCount.BorderStyle = BorderStyle.Fixed3D;
            lblScoreCount.Location = new Point(243, 179);
            lblScoreCount.Name = "lblScoreCount";
            lblScoreCount.Size = new Size(62, 40);
            lblScoreCount.TabIndex = 6;
            // 
            // lblAverage
            // 
            lblAverage.BorderStyle = BorderStyle.Fixed3D;
            lblAverage.Location = new Point(243, 219);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(62, 40);
            lblAverage.TabIndex = 7;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(311, 219);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 40);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 150);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 9;
            label1.Text = "Score Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 190);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 10;
            label2.Text = "Score Count:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 229);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 11;
            label3.Text = "Average:";
            // 
            // StudentScores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 264);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(lblAverage);
            Controls.Add(lblScoreCount);
            Controls.Add(lblScoretotal);
            Controls.Add(ssbtnDelete);
            Controls.Add(ssbtnUpdate);
            Controls.Add(ssbtnAddNew);
            Controls.Add(ListBox);
            Controls.Add(sslblStudents);
            Name = "StudentScores";
            Text = "Student Scores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sslblStudents;
        private ListBox ListBox;
        private Button ssbtnAddNew;
        private Button ssbtnUpdate;
        private Button ssbtnDelete;
        private Label lblScoretotal;
        private Label lblScoreCount;
        private Label lblAverage;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
