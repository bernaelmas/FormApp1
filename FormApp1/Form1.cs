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
                Notlar�m.Items.Add(yeniNot);
                textBox.Clear();
            }

        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (Notlar�m.SelectedIndex != -1)  // Bir ��e se�ilmi� ise
            {
                Notlar�m.Items.RemoveAt(Notlar�m.SelectedIndex);  // Se�ilen notu silecek
            }
        }
    }
}