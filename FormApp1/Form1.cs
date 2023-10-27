namespace FormApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            string yeniNot = textBox.Text;

            if (yeniNot != null)
            {
                Notlarým.Items.Add(yeniNot);
                textBox.Clear();
            }

        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (Notlarým.SelectedIndex != -1)  // Bir öðe seçilmiþ ise
            {
                Notlarým.Items.RemoveAt(Notlarým.SelectedIndex);  // Seçilen notu silecek
            }
        }
    }
}