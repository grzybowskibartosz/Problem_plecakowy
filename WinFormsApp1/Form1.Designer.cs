namespace WinFormsApp1
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
            seedTextBox = new TextBox();
            num_of_items = new TextBox();
            capacity = new TextBox();
            button1 = new Button();
            Instance_box = new RichTextBox();
            result_box = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            instance = new Label();
            result = new Label();
            SuspendLayout();
            // 
            // seedTextBox
            // 
            seedTextBox.Location = new Point(12, 27);
            seedTextBox.Name = "seedTextBox";
            seedTextBox.Size = new Size(100, 23);
            seedTextBox.TabIndex = 0;
            seedTextBox.TextChanged += textBox1_TextChanged;
            // 
            // num_of_items
            // 
            num_of_items.Location = new Point(12, 115);
            num_of_items.Name = "num_of_items";
            num_of_items.Size = new Size(100, 23);
            num_of_items.TabIndex = 1;
            // 
            // capacity
            // 
            capacity.Location = new Point(12, 71);
            capacity.Name = "capacity";
            capacity.Size = new Size(100, 23);
            capacity.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(24, 144);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Instance_box
            // 
            Instance_box.Location = new Point(283, 27);
            Instance_box.Name = "Instance_box";
            Instance_box.Size = new Size(271, 281);
            Instance_box.TabIndex = 4;
            Instance_box.Text = "";
            // 
            // result_box
            // 
            result_box.Location = new Point(6, 173);
            result_box.Name = "result_box";
            result_box.Size = new Size(271, 135);
            result_box.TabIndex = 5;
            result_box.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 6;
            label1.Text = "Seed";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 7;
            label2.Text = "Capacity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 8;
            label3.Text = "Number of the items";
            // 
            // instance
            // 
            instance.AutoSize = true;
            instance.Location = new Point(503, 9);
            instance.Name = "instance";
            instance.Size = new Size(51, 15);
            instance.TabIndex = 9;
            instance.Text = "Instance";
            instance.Click += instance_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(239, 155);
            result.Name = "result";
            result.Size = new Size(39, 15);
            result.TabIndex = 10;
            result.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 320);
            Controls.Add(result);
            Controls.Add(instance);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(result_box);
            Controls.Add(Instance_box);
            Controls.Add(button1);
            Controls.Add(capacity);
            Controls.Add(num_of_items);
            Controls.Add(seedTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox seedTextBox;
        private TextBox num_of_items;
        private TextBox capacity;
        private Button button1;
        private RichTextBox Instance_box;
        private RichTextBox result_box;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label instance;
        private Label result;
    }
}
