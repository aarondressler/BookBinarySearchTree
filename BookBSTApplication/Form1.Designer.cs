namespace BookBSTApplication
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_isbn = new System.Windows.Forms.TextBox();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.tb_author = new System.Windows.Forms.TextBox();
            this.tb_year = new System.Windows.Forms.TextBox();
            this.num_rating = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_AddNew = new System.Windows.Forms.Button();
            this.grp_AddNew = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Find = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.tb_Remove = new System.Windows.Forms.TextBox();
            this.lbl_ErrorMessage = new System.Windows.Forms.Label();
            this.lbl_SuccessMessage = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.num_rating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grp_AddNew.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ISBN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book Author:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Book Rating:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Book Year:";
            // 
            // tb_isbn
            // 
            this.tb_isbn.Location = new System.Drawing.Point(96, 19);
            this.tb_isbn.Name = "tb_isbn";
            this.tb_isbn.Size = new System.Drawing.Size(189, 20);
            this.tb_isbn.TabIndex = 5;
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(96, 54);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(189, 20);
            this.tb_title.TabIndex = 6;
            // 
            // tb_author
            // 
            this.tb_author.Location = new System.Drawing.Point(96, 88);
            this.tb_author.Name = "tb_author";
            this.tb_author.Size = new System.Drawing.Size(189, 20);
            this.tb_author.TabIndex = 7;
            // 
            // tb_year
            // 
            this.tb_year.Location = new System.Drawing.Point(96, 154);
            this.tb_year.Name = "tb_year";
            this.tb_year.Size = new System.Drawing.Size(60, 20);
            this.tb_year.TabIndex = 9;
            // 
            // num_rating
            // 
            this.num_rating.Location = new System.Drawing.Point(96, 122);
            this.num_rating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_rating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_rating.Name = "num_rating";
            this.num_rating.Size = new System.Drawing.Size(33, 20);
            this.num_rating.TabIndex = 8;
            this.num_rating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(339, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 459);
            this.dataGridView1.TabIndex = 10;
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.Location = new System.Drawing.Point(175, 152);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(110, 23);
            this.btn_AddNew.TabIndex = 10;
            this.btn_AddNew.Text = "Add New Book";
            this.btn_AddNew.UseVisualStyleBackColor = true;
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // grp_AddNew
            // 
            this.grp_AddNew.Controls.Add(this.tb_isbn);
            this.grp_AddNew.Controls.Add(this.btn_AddNew);
            this.grp_AddNew.Controls.Add(this.label1);
            this.grp_AddNew.Controls.Add(this.label2);
            this.grp_AddNew.Controls.Add(this.label3);
            this.grp_AddNew.Controls.Add(this.num_rating);
            this.grp_AddNew.Controls.Add(this.label4);
            this.grp_AddNew.Controls.Add(this.tb_year);
            this.grp_AddNew.Controls.Add(this.label5);
            this.grp_AddNew.Controls.Add(this.tb_author);
            this.grp_AddNew.Controls.Add(this.tb_title);
            this.grp_AddNew.Location = new System.Drawing.Point(12, 23);
            this.grp_AddNew.Name = "grp_AddNew";
            this.grp_AddNew.Size = new System.Drawing.Size(306, 188);
            this.grp_AddNew.TabIndex = 13;
            this.grp_AddNew.TabStop = false;
            this.grp_AddNew.Text = "Add New Book";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Find);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_Find);
            this.groupBox1.Location = new System.Drawing.Point(13, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 63);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Book";
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(256, 24);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(43, 23);
            this.btn_Find.TabIndex = 2;
            this.btn_Find.TabStop = false;
            this.btn_Find.Text = "Go";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "ISBN to Find:";
            // 
            // tb_Find
            // 
            this.tb_Find.Location = new System.Drawing.Point(83, 25);
            this.tb_Find.Name = "tb_Find";
            this.tb_Find.Size = new System.Drawing.Size(176, 20);
            this.tb_Find.TabIndex = 0;
            this.tb_Find.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Remove);
            this.groupBox2.Controls.Add(this.tb_Remove);
            this.groupBox2.Location = new System.Drawing.Point(12, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 66);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove by ISBN";
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(201, 27);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 1;
            this.btn_Remove.TabStop = false;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // tb_Remove
            // 
            this.tb_Remove.Location = new System.Drawing.Point(29, 29);
            this.tb_Remove.Name = "tb_Remove";
            this.tb_Remove.Size = new System.Drawing.Size(176, 20);
            this.tb_Remove.TabIndex = 0;
            this.tb_Remove.TabStop = false;
            // 
            // lbl_ErrorMessage
            // 
            this.lbl_ErrorMessage.AutoSize = true;
            this.lbl_ErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorMessage.Location = new System.Drawing.Point(12, 392);
            this.lbl_ErrorMessage.Name = "lbl_ErrorMessage";
            this.lbl_ErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.lbl_ErrorMessage.TabIndex = 16;
            // 
            // lbl_SuccessMessage
            // 
            this.lbl_SuccessMessage.AutoSize = true;
            this.lbl_SuccessMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SuccessMessage.ForeColor = System.Drawing.Color.Green;
            this.lbl_SuccessMessage.Location = new System.Drawing.Point(12, 421);
            this.lbl_SuccessMessage.Name = "lbl_SuccessMessage";
            this.lbl_SuccessMessage.Size = new System.Drawing.Size(0, 13);
            this.lbl_SuccessMessage.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 499);
            this.Controls.Add(this.lbl_SuccessMessage);
            this.Controls.Add(this.lbl_ErrorMessage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grp_AddNew);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Aaron Dressler\'s Binary Search Tree O\' Books";
            ((System.ComponentModel.ISupportInitialize)(this.num_rating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grp_AddNew.ResumeLayout(false);
            this.grp_AddNew.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_isbn;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.TextBox tb_author;
        private System.Windows.Forms.TextBox tb_year;
        private System.Windows.Forms.NumericUpDown num_rating;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_AddNew;
        private System.Windows.Forms.GroupBox grp_AddNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Find;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.TextBox tb_Remove;
        private System.Windows.Forms.Label lbl_ErrorMessage;
        private System.Windows.Forms.Label lbl_SuccessMessage;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

