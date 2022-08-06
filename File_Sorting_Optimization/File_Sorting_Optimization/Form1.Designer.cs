namespace File_Sorting_Optimization
{
    partial class Form1
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
            this.Button_Select_Directory = new System.Windows.Forms.Button();
            this.CKList_Sort = new System.Windows.Forms.CheckedListBox();
            this.textBox_Filter_Filename = new System.Windows.Forms.TextBox();
            this.textBox_Filter_extension = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox_sort = new System.Windows.Forms.ListBox();
            this.checkBox_asc = new System.Windows.Forms.CheckBox();
            this.listBox_Sort_result = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox_Category = new System.Windows.Forms.ListBox();
            this.button_add_category = new System.Windows.Forms.Button();
            this.button_add_file = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.TextBox();
            this.comboBox_file = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox_Category_File = new System.Windows.Forms.ListBox();
            this.button_Select_Category = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Select_Directory
            // 
            this.Button_Select_Directory.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button_Select_Directory.Location = new System.Drawing.Point(40, 64);
            this.Button_Select_Directory.Name = "Button_Select_Directory";
            this.Button_Select_Directory.Size = new System.Drawing.Size(200, 75);
            this.Button_Select_Directory.TabIndex = 1;
            this.Button_Select_Directory.Text = "최상위 폴더 검색";
            this.Button_Select_Directory.UseVisualStyleBackColor = true;
            this.Button_Select_Directory.Click += new System.EventHandler(this.Button_Select_Directory_Click);
            // 
            // CKList_Sort
            // 
            this.CKList_Sort.FormattingEnabled = true;
            this.CKList_Sort.Location = new System.Drawing.Point(40, 296);
            this.CKList_Sort.Name = "CKList_Sort";
            this.CKList_Sort.Size = new System.Drawing.Size(120, 94);
            this.CKList_Sort.TabIndex = 2;
            this.CKList_Sort.SelectedIndexChanged += new System.EventHandler(this.CKList_Sort_SelectedIndexChanged);
            // 
            // textBox_Filter_Filename
            // 
            this.textBox_Filter_Filename.Location = new System.Drawing.Point(129, 182);
            this.textBox_Filter_Filename.Name = "textBox_Filter_Filename";
            this.textBox_Filter_Filename.Size = new System.Drawing.Size(100, 23);
            this.textBox_Filter_Filename.TabIndex = 3;
            // 
            // textBox_Filter_extension
            // 
            this.textBox_Filter_extension.Location = new System.Drawing.Point(129, 221);
            this.textBox_Filter_extension.Name = "textBox_Filter_extension";
            this.textBox_Filter_extension.Size = new System.Drawing.Size(100, 23);
            this.textBox_Filter_extension.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "파일명 필터";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "확장자 필터";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "정렬 결과";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "정렬기준";
            // 
            // listBox_sort
            // 
            this.listBox_sort.FormattingEnabled = true;
            this.listBox_sort.ItemHeight = 15;
            this.listBox_sort.Location = new System.Drawing.Point(227, 297);
            this.listBox_sort.Name = "listBox_sort";
            this.listBox_sort.Size = new System.Drawing.Size(120, 94);
            this.listBox_sort.TabIndex = 11;
            // 
            // checkBox_asc
            // 
            this.checkBox_asc.AutoSize = true;
            this.checkBox_asc.Location = new System.Drawing.Point(55, 270);
            this.checkBox_asc.Name = "checkBox_asc";
            this.checkBox_asc.Size = new System.Drawing.Size(74, 19);
            this.checkBox_asc.TabIndex = 12;
            this.checkBox_asc.Text = "오름차순";
            this.checkBox_asc.UseVisualStyleBackColor = true;
            // 
            // listBox_Sort_result
            // 
            this.listBox_Sort_result.FormattingEnabled = true;
            this.listBox_Sort_result.ItemHeight = 15;
            this.listBox_Sort_result.Location = new System.Drawing.Point(450, 64);
            this.listBox_Sort_result.Name = "listBox_Sort_result";
            this.listBox_Sort_result.Size = new System.Drawing.Size(473, 334);
            this.listBox_Sort_result.TabIndex = 13;
            this.listBox_Sort_result.SelectedIndexChanged += new System.EventHandler(this.listBox_Sort_result_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(975, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "카테고리별 분류";
            // 
            // listBox_Category
            // 
            this.listBox_Category.FormattingEnabled = true;
            this.listBox_Category.ItemHeight = 15;
            this.listBox_Category.Location = new System.Drawing.Point(975, 64);
            this.listBox_Category.Name = "listBox_Category";
            this.listBox_Category.Size = new System.Drawing.Size(256, 334);
            this.listBox_Category.TabIndex = 15;
            this.listBox_Category.SelectedIndexChanged += new System.EventHandler(this.listBox_Category_SelectedIndexChanged);
            // 
            // button_add_category
            // 
            this.button_add_category.Location = new System.Drawing.Point(450, 455);
            this.button_add_category.Name = "button_add_category";
            this.button_add_category.Size = new System.Drawing.Size(139, 38);
            this.button_add_category.TabIndex = 16;
            this.button_add_category.Text = "카테고리 추가";
            this.button_add_category.UseVisualStyleBackColor = true;
            this.button_add_category.Click += new System.EventHandler(this.button_add_category_Click);
            // 
            // button_add_file
            // 
            this.button_add_file.Location = new System.Drawing.Point(450, 516);
            this.button_add_file.Name = "button_add_file";
            this.button_add_file.Size = new System.Drawing.Size(139, 42);
            this.button_add_file.TabIndex = 17;
            this.button_add_file.Text = "카테고리 설정";
            this.button_add_file.UseVisualStyleBackColor = true;
            this.button_add_file.Click += new System.EventHandler(this.button_add_file_Click);
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(624, 464);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(200, 23);
            this.category.TabIndex = 18;
            // 
            // comboBox_file
            // 
            this.comboBox_file.FormattingEnabled = true;
            this.comboBox_file.Location = new System.Drawing.Point(624, 527);
            this.comboBox_file.Name = "comboBox_file";
            this.comboBox_file.Size = new System.Drawing.Size(200, 23);
            this.comboBox_file.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(690, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "설정할 파일";
            // 
            // comboBox_category
            // 
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(890, 527);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(200, 23);
            this.comboBox_category.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(964, 509);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "카테고리";
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(40, 503);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Exit.Size = new System.Drawing.Size(143, 55);
            this.button_Exit.TabIndex = 23;
            this.button_Exit.Text = "프로그램 종료";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1263, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "카테고리 내 파일";
            // 
            // listBox_Category_File
            // 
            this.listBox_Category_File.FormattingEnabled = true;
            this.listBox_Category_File.ItemHeight = 15;
            this.listBox_Category_File.Location = new System.Drawing.Point(1263, 64);
            this.listBox_Category_File.Name = "listBox_Category_File";
            this.listBox_Category_File.Size = new System.Drawing.Size(273, 334);
            this.listBox_Category_File.TabIndex = 25;
            // 
            // button_Select_Category
            // 
            this.button_Select_Category.Location = new System.Drawing.Point(1123, 516);
            this.button_Select_Category.Name = "button_Select_Category";
            this.button_Select_Category.Size = new System.Drawing.Size(139, 41);
            this.button_Select_Category.TabIndex = 26;
            this.button_Select_Category.Text = "카테고리 파일 보기";
            this.button_Select_Category.UseVisualStyleBackColor = true;
            this.button_Select_Category.Click += new System.EventHandler(this.button_Select_Category_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 632);
            this.Controls.Add(this.button_Select_Category);
            this.Controls.Add(this.listBox_Category_File);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_file);
            this.Controls.Add(this.category);
            this.Controls.Add(this.button_add_file);
            this.Controls.Add(this.button_add_category);
            this.Controls.Add(this.listBox_Category);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox_Sort_result);
            this.Controls.Add(this.checkBox_asc);
            this.Controls.Add(this.listBox_sort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Filter_extension);
            this.Controls.Add(this.textBox_Filter_Filename);
            this.Controls.Add(this.CKList_Sort);
            this.Controls.Add(this.Button_Select_Directory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button_Select_Directory;
        private System.Windows.Forms.CheckedListBox CKList_Sort;
        private System.Windows.Forms.TextBox textBox_Filter_Filename;
        private System.Windows.Forms.TextBox textBox_Filter_extension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox_sort;
        private System.Windows.Forms.CheckBox checkBox_asc;
        private System.Windows.Forms.ListBox listBox_Sort_result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_Category;
        private System.Windows.Forms.Button button_add_category;
        private System.Windows.Forms.Button button_add_file;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.ComboBox comboBox_file;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox_Category_File;
        private System.Windows.Forms.Button button_Select_Category;
    }
}
