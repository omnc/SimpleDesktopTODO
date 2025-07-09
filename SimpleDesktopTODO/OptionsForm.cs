namespace SimpleDesktopTODO;

public partial class OptionsForm : Form
{
    public OptionsForm()
    {
        InitializeComponent();
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            string s = textBox1.Text;
            listBox1.Items.Add(s);
        }
    }
}