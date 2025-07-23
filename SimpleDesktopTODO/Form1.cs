namespace SimpleDesktopTODO;
using System;
using System.IO;
using System.Windows.Forms;

public partial class Form1 : Form
{
    
    public Form1()
    {
        InitializeComponent();
                
        this.ShowInTaskbar = false;
        //this.TopMost = true;
        this.BackColor = System.Drawing.Color.LightYellow;
        
    }

    public void routineUpdate()
    {
        var data = StorageManager.Load();
        checkedListBox1.Items.Clear();
        
        foreach (var item in data.List1)
        {
            checkedListBox1.Items.Add(item.itemContent, item.isChecked);
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        var data = StorageManager.Load();
        
        checkedListBox1.Items.Clear();
        foreach (var item in data.List1)
        {
            checkedListBox1.Items.Add(item.itemContent, item.isChecked);
        }
        
        checkedListBox2.Items.Clear();
        foreach (var item in data.List2)
        {
            checkedListBox2.Items.Add(item.itemContent, item.isChecked);
        }
    }
    private void saveTODOs()
    {
        var data = new StorageManager.AppData();

        foreach (var item in checkedListBox2.Items)
        {
            bool isChecked = checkedListBox2.CheckedItems.Contains(item);
            data.List2.Add(new StorageManager.Items{itemContent = item.ToString(), isChecked = isChecked});
        }
        
        StorageManager.Save(data);
    }
    
    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
        string toDoItem = textBox1.Text;
        if (e.KeyCode == Keys.Enter)
        {
            checkedListBox2.Items.Add(toDoItem);
            textBox1.Text = string.Empty;
            saveTODOs();
        }
        
    }
    
    private void optionButton_MouseClick(object sender, MouseEventArgs e)
    {
        OptionsForm optionsForm = new OptionsForm();
        optionsForm.OnApply += routineUpdate;
        optionsForm.ShowDialog();
    }
    
}