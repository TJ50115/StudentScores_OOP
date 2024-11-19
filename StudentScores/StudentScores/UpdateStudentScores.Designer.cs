namespace StudentScores
{
    partial class UpdateStudentScores
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
            usslistBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            ussTxtName = new TextBox();
            ussbtnAdd = new Button();
            ussbtnUpdate = new Button();
            ussbtnRemove = new Button();
            ussbtnClearScores = new Button();
            ussbtnCancel = new Button();
            ussbtnOk = new Button();
            SuspendLayout();
            // 
            // usslistBox
            // 
            usslistBox.FormattingEnabled = true;
            usslistBox.Location = new Point(71, 66);
            usslistBox.Name = "usslistBox";
            usslistBox.Size = new Size(162, 164);
            usslistBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 66);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 1;
            label1.Text = "Scores:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 29);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // ussTxtName
            // 
            ussTxtName.Location = new Point(71, 29);
            ussTxtName.Name = "ussTxtName";
            ussTxtName.Size = new Size(280, 27);
            ussTxtName.TabIndex = 3;
            ussTxtName.TextChanged += ussTxtName_TextChanged;
            // 
            // ussbtnAdd
            // 
            ussbtnAdd.Location = new Point(239, 66);
            ussbtnAdd.Name = "ussbtnAdd";
            ussbtnAdd.Size = new Size(112, 38);
            ussbtnAdd.TabIndex = 4;
            ussbtnAdd.Text = "Add";
            ussbtnAdd.UseVisualStyleBackColor = true;
            ussbtnAdd.Click += ussbtnAdd_Click;
            // 
            // ussbtnUpdate
            // 
            ussbtnUpdate.Location = new Point(239, 110);
            ussbtnUpdate.Name = "ussbtnUpdate";
            ussbtnUpdate.Size = new Size(112, 38);
            ussbtnUpdate.TabIndex = 5;
            ussbtnUpdate.Text = "Update";
            ussbtnUpdate.UseVisualStyleBackColor = true;
            ussbtnUpdate.Click += ussbtnUpdate_Click;
            // 
            // ussbtnRemove
            // 
            ussbtnRemove.Location = new Point(239, 154);
            ussbtnRemove.Name = "ussbtnRemove";
            ussbtnRemove.Size = new Size(112, 38);
            ussbtnRemove.TabIndex = 6;
            ussbtnRemove.Text = "Remove";
            ussbtnRemove.UseVisualStyleBackColor = true;
            ussbtnRemove.Click += ussbtnRemove_Click;
            // 
            // ussbtnClearScores
            // 
            ussbtnClearScores.Location = new Point(239, 198);
            ussbtnClearScores.Name = "ussbtnClearScores";
            ussbtnClearScores.Size = new Size(112, 38);
            ussbtnClearScores.TabIndex = 7;
            ussbtnClearScores.Text = "Clear Scores";
            ussbtnClearScores.UseVisualStyleBackColor = true;
            ussbtnClearScores.Click += ussbtnClearScores_Click;
            // 
            // ussbtnCancel
            // 
            ussbtnCancel.Location = new Point(239, 263);
            ussbtnCancel.Name = "ussbtnCancel";
            ussbtnCancel.Size = new Size(112, 38);
            ussbtnCancel.TabIndex = 8;
            ussbtnCancel.Text = "Cancel";
            ussbtnCancel.UseVisualStyleBackColor = true;
            ussbtnCancel.Click += ussbtnCancel_Click;
            // 
            // ussbtnOk
            // 
            ussbtnOk.Location = new Point(121, 263);
            ussbtnOk.Name = "ussbtnOk";
            ussbtnOk.Size = new Size(112, 38);
            ussbtnOk.TabIndex = 9;
            ussbtnOk.Text = "OK";
            ussbtnOk.UseVisualStyleBackColor = true;
            ussbtnOk.Click += ussbtnOk_Click;
            // 
            // UpdateStudentScores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 315);
            ControlBox = false;
            Controls.Add(ussbtnOk);
            Controls.Add(ussbtnCancel);
            Controls.Add(ussbtnClearScores);
            Controls.Add(ussbtnRemove);
            Controls.Add(ussbtnUpdate);
            Controls.Add(ussbtnAdd);
            Controls.Add(ussTxtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usslistBox);
            Name = "UpdateStudentScores";
            Text = "Update Student Scores";
            Load += UpdateStudentScores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox usslistBox;
        private Label label1;
        private Label label2;
        private TextBox ussTxtName;
        private Button ussbtnAdd;
        private Button ussbtnUpdate;
        private Button ussbtnRemove;
        private Button ussbtnClearScores;
        private Button ussbtnCancel;
        private Button ussbtnOk;
    }
}