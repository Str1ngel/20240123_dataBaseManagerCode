namespace _20240123_dataBaseManager
{
    partial class MainForm
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
            dataGridView1 = new DataGridView();
            btnUpload = new Button();
            label1 = new Label();
            label2 = new Label();
            button_better = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(751, 426);
            dataGridView1.TabIndex = 0;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(27, 456);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(149, 50);
            btnUpload.TabIndex = 1;
            btnUpload.Text = "Adatbetöltés";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 456);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 491);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // button_better
            // 
            button_better.Location = new Point(656, 456);
            button_better.Name = "button_better";
            button_better.Size = new Size(122, 50);
            button_better.TabIndex = 4;
            button_better.Text = "V2";
            button_better.UseVisualStyleBackColor = true;
            button_better.Click += button_better_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 518);
            Controls.Add(button_better);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpload);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnUpload;
        private Label label1;
        private Label label2;
        private Button button_better;
    }
}
