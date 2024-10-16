namespace stockkkSystem
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            scode = new TextBox();
            sname = new TextBox();
            squantity = new TextBox();
            addBtn = new Button();
            deleteBtn = new Button();
            viewStockBtn = new Button();
            viewTransBtn = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 97);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 0;
            label1.Text = "Stock code:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 150);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 1;
            label2.Text = "Stock name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 207);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 21);
            label3.TabIndex = 2;
            label3.Text = "Stock quantity:";
            // 
            // scode
            // 
            scode.Location = new Point(177, 92);
            scode.Margin = new Padding(4, 4, 4, 4);
            scode.Name = "scode";
            scode.Size = new Size(144, 29);
            scode.TabIndex = 3;
            // 
            // sname
            // 
            sname.Location = new Point(177, 146);
            sname.Margin = new Padding(4, 4, 4, 4);
            sname.Name = "sname";
            sname.Size = new Size(184, 29);
            sname.TabIndex = 4;
            // 
            // squantity
            // 
            squantity.Location = new Point(177, 203);
            squantity.Margin = new Padding(4, 4, 4, 4);
            squantity.Name = "squantity";
            squantity.Size = new Size(104, 29);
            squantity.TabIndex = 5;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(85, 337);
            addBtn.Margin = new Padding(4, 4, 4, 4);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(96, 32);
            addBtn.TabIndex = 6;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(202, 337);
            deleteBtn.Margin = new Padding(4, 4, 4, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(96, 32);
            deleteBtn.TabIndex = 7;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // viewStockBtn
            // 
            viewStockBtn.Location = new Point(85, 402);
            viewStockBtn.Margin = new Padding(4, 4, 4, 4);
            viewStockBtn.Name = "viewStockBtn";
            viewStockBtn.Size = new Size(213, 32);
            viewStockBtn.TabIndex = 8;
            viewStockBtn.Text = "View stock levels";
            viewStockBtn.UseVisualStyleBackColor = true;
            viewStockBtn.Click += viewStockBtn_Click;
            // 
            // viewTransBtn
            // 
            viewTransBtn.Location = new Point(87, 469);
            viewTransBtn.Margin = new Padding(4, 4, 4, 4);
            viewTransBtn.Name = "viewTransBtn";
            viewTransBtn.Size = new Size(211, 32);
            viewTransBtn.TabIndex = 9;
            viewTransBtn.Text = "View transaction log";
            viewTransBtn.UseVisualStyleBackColor = true;
            viewTransBtn.Click += viewTransBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(414, 73);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 53;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(360, 210);
            dataGridView1.TabIndex = 10;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(414, 337);
            dataGridView2.Margin = new Padding(4, 4, 4, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 53;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(360, 210);
            dataGridView2.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 592);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(viewTransBtn);
            Controls.Add(viewStockBtn);
            Controls.Add(deleteBtn);
            Controls.Add(addBtn);
            Controls.Add(squantity);
            Controls.Add(sname);
            Controls.Add(scode);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox scode;
        private TextBox sname;
        private TextBox squantity;
        private Button addBtn;
        private Button deleteBtn;
        private Button viewStockBtn;
        private Button viewTransBtn;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}