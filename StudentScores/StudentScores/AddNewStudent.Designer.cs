namespace StudentScores
{
    partial class AddNewStudent
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
            lbltxtName = new Label();
            ansTxtBoxName = new TextBox();
            ansTxtBoxScore = new TextBox();
            lbltxtScore = new Label();
            lbltxtScores = new Label();
            lblScores = new Label();
            ansbtnAddScore = new Button();
            ansbtnClearScores = new Button();
            ansbtnCancel = new Button();
            ansbtnOK = new Button();
            SuspendLayout();
            // 
            // lbltxtName
            // 
            lbltxtName.AutoSize = true;
            lbltxtName.Location = new Point(12, 25);
            lbltxtName.Name = "lbltxtName";
            lbltxtName.Size = new Size(52, 20);
            lbltxtName.TabIndex = 0;
            lbltxtName.Text = "Name:";
            // 
            // ansTxtBoxName
            // 
            ansTxtBoxName.Location = new Point(83, 22);
            ansTxtBoxName.Name = "ansTxtBoxName";
            ansTxtBoxName.Size = new Size(269, 27);
            ansTxtBoxName.TabIndex = 1;
            // 
            // ansTxtBoxScore
            // 
            ansTxtBoxScore.Location = new Point(83, 71);
            ansTxtBoxScore.Name = "ansTxtBoxScore";
            ansTxtBoxScore.Size = new Size(160, 27);
            ansTxtBoxScore.TabIndex = 2;
            // 
            // lbltxtScore
            // 
            lbltxtScore.AutoSize = true;
            lbltxtScore.Location = new Point(12, 74);
            lbltxtScore.Name = "lbltxtScore";
            lbltxtScore.Size = new Size(49, 20);
            lbltxtScore.TabIndex = 4;
            lbltxtScore.Text = "Score:";
            // 
            // lbltxtScores
            // 
            lbltxtScores.AutoSize = true;
            lbltxtScores.Location = new Point(9, 117);
            lbltxtScores.Name = "lbltxtScores";
            lbltxtScores.Size = new Size(55, 20);
            lbltxtScores.TabIndex = 5;
            lbltxtScores.Text = "Scores:";
            // 
            // lblScores
            // 
            lblScores.BorderStyle = BorderStyle.Fixed3D;
            lblScores.Location = new Point(83, 116);
            lblScores.Name = "lblScores";
            lblScores.Size = new Size(269, 25);
            lblScores.TabIndex = 6;
            // 
            // ansbtnAddScore
            // 
            ansbtnAddScore.Location = new Point(249, 71);
            ansbtnAddScore.Name = "ansbtnAddScore";
            ansbtnAddScore.Size = new Size(103, 32);
            ansbtnAddScore.TabIndex = 7;
            ansbtnAddScore.Text = "Add Score";
            ansbtnAddScore.UseVisualStyleBackColor = true;
            ansbtnAddScore.Click += ansbtnAddScore_Click;
            // 
            // ansbtnClearScores
            // 
            ansbtnClearScores.Location = new Point(249, 144);
            ansbtnClearScores.Name = "ansbtnClearScores";
            ansbtnClearScores.Size = new Size(103, 32);
            ansbtnClearScores.TabIndex = 8;
            ansbtnClearScores.Text = "Clear Scores";
            ansbtnClearScores.UseVisualStyleBackColor = true;
            ansbtnClearScores.Click += ansbtnClearScores_Click;
            // 
            // ansbtnCancel
            // 
            ansbtnCancel.Location = new Point(249, 182);
            ansbtnCancel.Name = "ansbtnCancel";
            ansbtnCancel.Size = new Size(103, 32);
            ansbtnCancel.TabIndex = 9;
            ansbtnCancel.Text = "Cancel";
            ansbtnCancel.UseVisualStyleBackColor = true;
            ansbtnCancel.Click += ansbtnCancel_Click;
            // 
            // ansbtnOK
            // 
            ansbtnOK.Location = new Point(140, 182);
            ansbtnOK.Name = "ansbtnOK";
            ansbtnOK.Size = new Size(103, 32);
            ansbtnOK.TabIndex = 10;
            ansbtnOK.Text = "OK";
            ansbtnOK.UseVisualStyleBackColor = true;
            ansbtnOK.Click += ansbtnOK_Click;
            // 
            // AddNewStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 221);
            ControlBox = false;
            Controls.Add(ansbtnOK);
            Controls.Add(ansbtnCancel);
            Controls.Add(ansbtnClearScores);
            Controls.Add(ansbtnAddScore);
            Controls.Add(lblScores);
            Controls.Add(lbltxtScores);
            Controls.Add(lbltxtScore);
            Controls.Add(ansTxtBoxScore);
            Controls.Add(ansTxtBoxName);
            Controls.Add(lbltxtName);
            Name = "AddNewStudent";
            Text = "Add New Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltxtName;
        private TextBox ansTxtBoxName;
        private TextBox ansTxtBoxScore;
        private Label lbltxtScore;
        private Label lbltxtScores;
        private Label lblScores;
        private Button ansbtnAddScore;
        private Button ansbtnClearScores;
        private Button ansbtnCancel;
        private Button ansbtnOK;
    }
}