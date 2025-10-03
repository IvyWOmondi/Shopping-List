namespace Shopping_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itemName = textBox1.Text.Trim();

            // Ensure the name is not blank
            if (string.IsNullOrEmpty(itemName))
            {
                MessageBox.Show("Item name cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure the name does not already exist
            foreach (var item in Item.Items)
            {
                var itemString = item?.ToString();
                if (!string.IsNullOrEmpty(itemString) && itemString.Equals(itemName, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Item already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Item.Items.Add(itemName);
            textBox1.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string itemName = textBox1.Text.Trim();

            // Ensure the name is not blank
            if (string.IsNullOrEmpty(itemName))
            {
                MessageBox.Show("Enter the item name to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Try to remove the item (case-insensitive)
            object? itemToRemove = null; // Use nullable object
            foreach (var item in Item.Items)
            {
                var itemString = item?.ToString();
                if (!string.IsNullOrEmpty(itemString) && itemString.Equals(itemName, StringComparison.OrdinalIgnoreCase))
                {
                    itemToRemove = item;
                    break;
                }
            }

            if (itemToRemove != null)
            {
                Item.Items.Remove(itemToRemove);
                MessageBox.Show("Item removed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Show the Save File dialog
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;

                // Save each item to the file, one per line
                System.IO.File.WriteAllLines(filePath, Item.Items.Cast<string>());
                MessageBox.Show("Shopping list saved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
