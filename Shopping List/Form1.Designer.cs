namespace Shopping_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Item = new CheckedListBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            saveFileDialog1 = new SaveFileDialog();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Item
            // 
            Item.BackColor = Color.MistyRose;
            Item.Font = new Font("Segoe Print", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Item.ForeColor = Color.Maroon;
            Item.FormattingEnabled = true;
            Item.Location = new Point(180, 100);
            Item.Margin = new Padding(4, 5, 4, 5);
            Item.Name = "Item";
            Item.ScrollAlwaysVisible = true;
            Item.Size = new Size(528, 284);
            Item.Sorted = true;
            Item.TabIndex = 0;
            Item.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Purple;
            button1.Location = new Point(775, 184);
            button1.Name = "button1";
            button1.Size = new Size(80, 64);
            button1.TabIndex = 1;
            button1.Text = "Add Item";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Thistle;
            textBox1.ForeColor = Color.Purple;
            textBox1.Location = new Point(729, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 36);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LavenderBlush;
            label1.Font = new Font("Segoe Print", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(325, 37);
            label1.Name = "label1";
            label1.Size = new Size(216, 43);
            label1.TabIndex = 3;
            label1.Text = "SHOPPING LIST";
            // 
            // button2
            // 
            button2.BackColor = Color.LightPink;
            button2.ForeColor = Color.Crimson;
            button2.Location = new Point(729, 384);
            button2.Name = "button2";
            button2.Size = new Size(64, 68);
            button2.TabIndex = 5;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(30, 184);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // button3
            // 
            button3.BackColor = Color.LightPink;
            button3.Location = new Point(836, 384);
            button3.Name = "button3";
            button3.Size = new Size(64, 68);
            button3.TabIndex = 8;
            button3.Text = "Done";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(912, 499);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(Item);
            Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Crimson;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Shopping List";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox Item;
        private Button button1;
        private TextBox textBox1;
        private Label label1;

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Your logic here
        }
        private Button button2;
        private PictureBox pictureBox1;
        private SaveFileDialog saveFileDialog1;
        private Button button3;
    }
}
