namespace _20240123_dataBaseManager
{
    partial class CleaingForm
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
            dataGridView1 = new DataGridView();
            textBox_Kereses = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox_userPlate = new TextBox();
            textBox_userType = new TextBox();
            textBox_userOwner = new TextBox();
            textBox_userPrice = new TextBox();
            button_save = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(559, 426);
            dataGridView1.TabIndex = 4;
            // 
            // textBox_Kereses
            // 
            textBox_Kereses.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Kereses.Location = new Point(12, 47);
            textBox_Kereses.Name = "textBox_Kereses";
            textBox_Kereses.Size = new Size(559, 23);
            textBox_Kereses.TabIndex = 5;
            textBox_Kereses.TextChanged += textBox_Kereses_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 6;
            label1.Text = "Keresés:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(601, 314);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 7;
            label2.Text = "Rendszám:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(601, 350);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 8;
            label3.Text = "Tipus:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(601, 389);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 9;
            label4.Text = "Tulajdonos:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(601, 428);
            label5.Name = "label5";
            label5.Size = new Size(23, 15);
            label5.TabIndex = 10;
            label5.Text = "Ár:";
            // 
            // textBox_userPlate
            // 
            textBox_userPlate.Location = new Point(693, 311);
            textBox_userPlate.Name = "textBox_userPlate";
            textBox_userPlate.Size = new Size(100, 23);
            textBox_userPlate.TabIndex = 11;
            // 
            // textBox_userType
            // 
            textBox_userType.Location = new Point(693, 347);
            textBox_userType.Name = "textBox_userType";
            textBox_userType.Size = new Size(100, 23);
            textBox_userType.TabIndex = 12;
            // 
            // textBox_userOwner
            // 
            textBox_userOwner.Location = new Point(693, 386);
            textBox_userOwner.Name = "textBox_userOwner";
            textBox_userOwner.Size = new Size(100, 23);
            textBox_userOwner.TabIndex = 13;
            // 
            // textBox_userPrice
            // 
            textBox_userPrice.Location = new Point(693, 425);
            textBox_userPrice.Name = "textBox_userPrice";
            textBox_userPrice.Size = new Size(100, 23);
            textBox_userPrice.TabIndex = 14;
            // 
            // button_save
            // 
            button_save.Location = new Point(601, 468);
            button_save.Name = "button_save";
            button_save.Size = new Size(192, 49);
            button_save.TabIndex = 15;
            button_save.Text = "Mentés";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // CleaingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 539);
            Controls.Add(button_save);
            Controls.Add(textBox_userPrice);
            Controls.Add(textBox_userOwner);
            Controls.Add(textBox_userType);
            Controls.Add(textBox_userPlate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Kereses);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "CleaingForm";
            Text = "CleaingForm";
            Load += CleaingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private TextBox textBox_Kereses;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox_userPlate;
        private TextBox textBox_userType;
        private TextBox textBox_userOwner;
        private TextBox textBox_userPrice;
        private Button button_save;
    }
}