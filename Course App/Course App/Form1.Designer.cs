namespace Course_App
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnAddAll = new Button();
            btnRemoveAll = new Button();
            btnFinal = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(286, 199);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(513, 12);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(275, 199);
            listBox2.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(319, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(169, 34);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 12F);
            btnRemove.Location = new Point(319, 52);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(169, 34);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAddAll
            // 
            btnAddAll.Font = new Font("Segoe UI", 12F);
            btnAddAll.Location = new Point(319, 92);
            btnAddAll.Name = "btnAddAll";
            btnAddAll.Size = new Size(169, 34);
            btnAddAll.TabIndex = 4;
            btnAddAll.Text = "Add All";
            btnAddAll.UseVisualStyleBackColor = true;
            btnAddAll.Click += btnAddAll_Click;
            // 
            // btnRemoveAll
            // 
            btnRemoveAll.Font = new Font("Segoe UI", 12F);
            btnRemoveAll.Location = new Point(319, 132);
            btnRemoveAll.Name = "btnRemoveAll";
            btnRemoveAll.Size = new Size(169, 34);
            btnRemoveAll.TabIndex = 5;
            btnRemoveAll.Text = "Remove All";
            btnRemoveAll.UseVisualStyleBackColor = true;
            btnRemoveAll.Click += btnRemoveAll_Click;
            // 
            // btnFinal
            // 
            btnFinal.Font = new Font("Segoe UI", 12F);
            btnFinal.Location = new Point(319, 172);
            btnFinal.Name = "btnFinal";
            btnFinal.Size = new Size(169, 34);
            btnFinal.TabIndex = 6;
            btnFinal.Text = "Finalize";
            btnFinal.UseVisualStyleBackColor = true;
            btnFinal.Click += btnFinal_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 231);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 207);
            dataGridView1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnFinal);
            Controls.Add(btnRemoveAll);
            Controls.Add(btnAddAll);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnAddAll;
        private Button btnRemoveAll;
        private Button btnFinal;
        private DataGridView dataGridView1;
    }
}
