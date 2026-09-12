namespace Csharp_student_information_system
{
    partial class AddScoreForm
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
            this.DataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.TextBoxStudentID = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.ComboBoxCourse = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBoxScore = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.ButtonAddScore = new System.Windows.Forms.Button();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewStudents
            // 
            this.DataGridViewStudents.AllowUserToAddRows = false;
            this.DataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewStudents.Location = new System.Drawing.Point(556, 30);
            this.DataGridViewStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridViewStudents.Name = "DataGridViewStudents";
            this.DataGridViewStudents.RowHeadersWidth = 51;
            this.DataGridViewStudents.Size = new System.Drawing.Size(440, 363);
            this.DataGridViewStudents.TabIndex = 48;
            this.DataGridViewStudents.Click += new System.EventHandler(this.DataGridViewStudents_Click);
            // 
            // TextBoxStudentID
            // 
            this.TextBoxStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxStudentID.Location = new System.Drawing.Point(205, 26);
            this.TextBoxStudentID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxStudentID.Name = "TextBoxStudentID";
            this.TextBoxStudentID.ReadOnly = true;
            this.TextBoxStudentID.Size = new System.Drawing.Size(314, 30);
            this.TextBoxStudentID.TabIndex = 47;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(53, 30);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(121, 25);
            this.Label2.TabIndex = 46;
            this.Label2.Text = "Student ID:";
            // 
            // ComboBoxCourse
            // 
            this.ComboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCourse.FormattingEnabled = true;
            this.ComboBoxCourse.Location = new System.Drawing.Point(205, 85);
            this.ComboBoxCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxCourse.Name = "ComboBoxCourse";
            this.ComboBoxCourse.Size = new System.Drawing.Size(316, 33);
            this.ComboBoxCourse.TabIndex = 45;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(21, 89);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(156, 25);
            this.Label1.TabIndex = 44;
            this.Label1.Text = "Select Course:";
            // 
            // TextBoxScore
            // 
            this.TextBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxScore.Location = new System.Drawing.Point(204, 145);
            this.TextBoxScore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxScore.Name = "TextBoxScore";
            this.TextBoxScore.Size = new System.Drawing.Size(315, 30);
            this.TextBoxScore.TabIndex = 43;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(109, 149);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(76, 25);
            this.Label4.TabIndex = 42;
            this.Label4.Text = "Score:";
            // 
            // ButtonAddScore
            // 
            this.ButtonAddScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(106)))));
            this.ButtonAddScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddScore.ForeColor = System.Drawing.Color.White;
            this.ButtonAddScore.Location = new System.Drawing.Point(27, 343);
            this.ButtonAddScore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonAddScore.Name = "ButtonAddScore";
            this.ButtonAddScore.Size = new System.Drawing.Size(493, 49);
            this.ButtonAddScore.TabIndex = 41;
            this.ButtonAddScore.Text = "Add Score";
            this.ButtonAddScore.UseVisualStyleBackColor = false;
            this.ButtonAddScore.Click += new System.EventHandler(this.ButtonAddScore_Click);
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDescription.Location = new System.Drawing.Point(204, 207);
            this.TextBoxDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(315, 98);
            this.TextBoxDescription.TabIndex = 40;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(47, 207);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(127, 25);
            this.Label3.TabIndex = 39;
            this.Label3.Text = "Description:";
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(1021, 428);
            this.Controls.Add(this.DataGridViewStudents);
            this.Controls.Add(this.TextBoxStudentID);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.ComboBoxCourse);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TextBoxScore);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.ButtonAddScore);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.Label3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView DataGridViewStudents;
        internal System.Windows.Forms.TextBox TextBoxStudentID;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox ComboBoxCourse;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TextBoxScore;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button ButtonAddScore;
        internal System.Windows.Forms.TextBox TextBoxDescription;
        internal System.Windows.Forms.Label Label3;
    }
}