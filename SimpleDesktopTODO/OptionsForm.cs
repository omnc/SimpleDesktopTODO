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

    private void SaveRoutine()
    {
        var data = new List<StorageManager.Items>();
        foreach (var item in listBox1.Items)
        {
            data.Add(new StorageManager.Items{itemContent = item.ToString(), isChecked = false});
        }
        StorageManager.SaveRoutine(data);
    }
    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            string s = textBox1.Text;
            listBox1.Items.Add(s);
            textBox1.Text = string.Empty;
            SaveRoutine();
        }
    }

    public event Action OnApply = null!;
    private void button1_Click(object sender, EventArgs e)
    {
        OnApply?.Invoke();
    }

    private void listBox1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Back)
        {
            if (listBox1.SelectedItem!= null)
            { 
                listBox1.Items.Remove(listBox1.SelectedItem);
                SaveRoutine();
            }
          
        }
    }

    private void OptionsForm_Load(object sender, EventArgs e)
    {
        var data = StorageManager.LoadRoutine();
        TimeSpan time = TimeSpan.Parse(StorageManager.LoadResetTime().timeContent);
        listBox1.Items.Clear();
        foreach (var item in data)
        {
            listBox1.Items.Add(item.itemContent);
        }
        numericUpDown1.Value = time.Hours;
        numericUpDown2.Value = time.Minutes;
        
    }

    private void button2_Click(object sender, EventArgs e)
    {
        string hour = numericUpDown1.Value.ToString();
        string min = numericUpDown2.Value.ToString();
        var data = new StorageManager.ResetTime
        {
            timeContent = hour+ ':'+ min,
            isReset = false,
            lastResetDate = ""
        };
        
        StorageManager.SaveTime(data);
        
    }

   
}