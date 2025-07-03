namespace IstekForm
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
            paradorText = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            saveButton = new Button();
            towelBox = new CheckBox();
            pillowBox = new CheckBox();
            blanketBox = new CheckBox();
            sheetBox = new CheckBox();
            shampooBox = new CheckBox();
            showerBox = new CheckBox();
            specialBox = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            completeButton = new Button();
            deleteButton = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // paradorText
            // 
            paradorText.BackColor = Color.LightBlue;
            paradorText.Cursor = Cursors.No;
            paradorText.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            paradorText.Location = new Point(172, 31);
            paradorText.Name = "paradorText";
            paradorText.Size = new Size(422, 35);
            paradorText.TabIndex = 0;
            paradorText.Text = "Parador Beach Hotel";
            paradorText.TextAlign = HorizontalAlignment.Center;
            paradorText.TextChanged += paradorText_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightBlue;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(12, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(363, 25);
            textBox1.TabIndex = 1;
            textBox1.Text = "These are the things that you can order to your room :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(699, 537);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 2;
            label1.Text = "Taha Kurhan";
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.LightBlue;
            saveButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            saveButton.Location = new Point(50, 310);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(646, 51);
            saveButton.TabIndex = 3;
            saveButton.Text = "SAVE";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // towelBox
            // 
            towelBox.AutoSize = true;
            towelBox.Location = new Point(12, 149);
            towelBox.Name = "towelBox";
            towelBox.Size = new Size(57, 19);
            towelBox.TabIndex = 4;
            towelBox.Text = "Towel";
            towelBox.UseVisualStyleBackColor = true;
            // 
            // pillowBox
            // 
            pillowBox.AutoSize = true;
            pillowBox.Location = new Point(116, 149);
            pillowBox.Name = "pillowBox";
            pillowBox.Size = new Size(58, 19);
            pillowBox.TabIndex = 5;
            pillowBox.Text = "Pillow";
            pillowBox.UseVisualStyleBackColor = true;
            // 
            // blanketBox
            // 
            blanketBox.AutoSize = true;
            blanketBox.Location = new Point(216, 149);
            blanketBox.Name = "blanketBox";
            blanketBox.Size = new Size(65, 19);
            blanketBox.TabIndex = 6;
            blanketBox.Text = "Blanket";
            blanketBox.UseVisualStyleBackColor = true;
            // 
            // sheetBox
            // 
            sheetBox.AutoSize = true;
            sheetBox.Location = new Point(324, 149);
            sheetBox.Name = "sheetBox";
            sheetBox.Size = new Size(55, 19);
            sheetBox.TabIndex = 7;
            sheetBox.Text = "Sheet";
            sheetBox.UseVisualStyleBackColor = true;
            // 
            // shampooBox
            // 
            shampooBox.AutoSize = true;
            shampooBox.Location = new Point(428, 149);
            shampooBox.Name = "shampooBox";
            shampooBox.Size = new Size(77, 19);
            shampooBox.TabIndex = 8;
            shampooBox.Text = "Shampoo";
            shampooBox.UseVisualStyleBackColor = true;
            // 
            // showerBox
            // 
            showerBox.AutoSize = true;
            showerBox.Location = new Point(526, 149);
            showerBox.Name = "showerBox";
            showerBox.Size = new Size(85, 19);
            showerBox.TabIndex = 9;
            showerBox.Text = "Shower Gel";
            showerBox.UseVisualStyleBackColor = true;
            // 
            // specialBox
            // 
            specialBox.BackColor = Color.LightBlue;
            specialBox.Location = new Point(12, 248);
            specialBox.Name = "specialBox";
            specialBox.Size = new Size(698, 23);
            specialBox.TabIndex = 10;
            specialBox.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 195);
            label2.Name = "label2";
            label2.Size = new Size(547, 28);
            label2.TabIndex = 11;
            label2.Text = "You can write here if you have special request from us";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 399);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(646, 150);
            dataGridView1.TabIndex = 12;
            // 
            // completeButton
            // 
            completeButton.BackColor = Color.LightBlue;
            completeButton.Location = new Point(116, 370);
            completeButton.Name = "completeButton";
            completeButton.Size = new Size(206, 26);
            completeButton.TabIndex = 13;
            completeButton.Text = "Tamamlandı";
            completeButton.UseVisualStyleBackColor = false;
            completeButton.Click += completeButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.LightBlue;
            deleteButton.Location = new Point(412, 370);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(233, 26);
            deleteButton.TabIndex = 14;
            deleteButton.Text = "Sil";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(completeButton);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(specialBox);
            panel1.Controls.Add(showerBox);
            panel1.Controls.Add(shampooBox);
            panel1.Controls.Add(sheetBox);
            panel1.Controls.Add(blanketBox);
            panel1.Controls.Add(pillowBox);
            panel1.Controls.Add(towelBox);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(paradorText);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 562);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox paradorText;
        private TextBox textBox1;
        private Label label1;
        private Button saveButton;
        private CheckBox towelBox;
        private CheckBox pillowBox;
        private CheckBox blanketBox;
        private CheckBox sheetBox;
        private CheckBox shampooBox;
        private CheckBox showerBox;
        private TextBox specialBox;
        private Label label2;
        private DataGridView dataGridView1;
        private Button completeButton;
        private Button deleteButton;
        private Panel panel1;
    }
}
