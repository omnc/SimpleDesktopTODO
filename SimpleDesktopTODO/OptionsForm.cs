using System.Windows.Forms.Design;

namespace SimpleDesktopTODO;

public partial class OptionsForm : Form
{
    public OptionsForm()
    {
        InitializeComponent();
        this.TopMost = true;
        this.ShowInTaskbar = false;
    }

    private void saveRoutine()
    {
        var data = new StorageManager.AppData();

        foreach (var item in listBox1.Items)
        {
            bool isChecked = false;
            data.List1.Add(new StorageManager.Items{itemContent = item.ToString(), isChecked = isChecked});
        }
        
        StorageManager.Save(data);
    }
    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            string s = textBox1.Text;
            listBox1.Items.Add(s);
            textBox1.Text = string.Empty;
            saveRoutine();
        }
    }

    public event Action OnApply;
    private void button1_Click(object sender, EventArgs e)
    {
        OnApply?.Invoke();
    }
}