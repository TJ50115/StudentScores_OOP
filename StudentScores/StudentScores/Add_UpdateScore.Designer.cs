namespace StudentScores
{
    partial class Add_UpdateScore
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
            aslbltxtScore = new Label();
            astxtboxScore = new TextBox();
            asbtnAdd = new Button();
            asbtnCancel = new Button();
            SuspendLayout();
            // 
            // aslbltxtScore
            // 
            aslbltxtScore.AutoSize = true;
            aslbltxtScore.Location = new Point(12, 31);
            aslbltxtScore.Name = "aslbltxtScore";
            aslbltxtScore.Size = new Size(49, 20);
            aslbltxtScore.TabIndex = 0;
            aslbltxtScore.Text = "Score:";
            // 
            // astxtboxScore
            // 
            astxtboxScore.Location = new Point(67, 28);
            astxtboxScore.Name = "astxtboxScore";
            astxtboxScore.Size = new Size(181, 27);
            astxtboxScore.TabIndex = 1;
            // 
            // asbtnAdd
            // 
            asbtnAdd.Location = new Point(49, 75);
            asbtnAdd.Name = "asbtnAdd";
            asbtnAdd.Size = new Size(94, 29);
            asbtnAdd.TabIndex = 2;
            asbtnAdd.Text = "Add";
            asbtnAdd.UseVisualStyleBackColor = true;
            asbtnAdd.Click += asbtnAdd_Click;
            // 
            // asbtnCancel
            // 
            asbtnCancel.Location = new Point(154, 75);
            asbtnCancel.Name = "asbtnCancel";
            asbtnCancel.Size = new Size(94, 29);
            asbtnCancel.TabIndex = 3;
            asbtnCancel.Text = "Cancel";
            asbtnCancel.UseVisualStyleBackColor = true;
            asbtnCancel.Click += asbtnCancel_Click;
            // 
            // Add_UpdateScore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 114);
            ControlBox = false;
            Controls.Add(asbtnCancel);
            Controls.Add(asbtnAdd);
            Controls.Add(astxtboxScore);
            Controls.Add(aslbltxtScore);
            Name = "Add_UpdateScore";
            Text = "Add Score";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label aslbltxtScore;
        private TextBox astxtboxScore;
        private Button asbtnAdd;
        private Button asbtnCancel;
    }
}