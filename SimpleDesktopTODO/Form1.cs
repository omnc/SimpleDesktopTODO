namespace SimpleDesktopTODO;
using System;
using System.IO;
using System.Windows.Forms;

public partial class Form1 : Form
{
    private StorageManager.ResetTime resetData;
    public Form1()
    {
        InitializeComponent();
                
        this.ShowInTaskbar = false;
        this.BackColor = System.Drawing.Color.LightYellow;
        
    }
    private void Form1_Load(object sender, EventArgs e)
    {
        resetData = StorageManager.LoadResetTime();
        var routine = StorageManager.LoadRoutine();
        timer1.Start();
        checkedListBox1.Items.Clear();
        foreach (var item in routine)
        {
            checkedListBox1.Items.Add(item.itemContent, item.isChecked);
        }

        var todo = StorageManager.LoadToDo();
        checkedListBox2.Items.Clear();
        foreach (var item in todo)
        {
            checkedListBox2.Items.Add(item.itemContent, item.isChecked);
        }
        
        DateTime currentDate = DateTime.Now;
        dateBox.Text = currentDate.ToString("yyyy/MM/dd");
    }
    private void RoutineUpdate()
    { 
        var routine = StorageManager.LoadRoutine();
        checkedListBox1.Items.Clear(); 
        foreach (var item in routine) 
        { 
            checkedListBox1.Items.Add(item.itemContent, item.isChecked);
        }
    }
    private void SaveRoutine()
    {
        var data = new List<StorageManager.Items>();
        foreach (var item in checkedListBox1.Items)
        {
            data.Add(new StorageManager.Items{itemContent = item.ToString(), isChecked =checkedListBox2.CheckedItems.Contains(item)});
        }
        StorageManager.SaveRoutine(data);
    }
    private void SaveToDos()
    {
        var data = new List<StorageManager.Items>();
        foreach (var item in checkedListBox2.Items)
        {
            data.Add(new StorageManager.Items{itemContent = item.ToString(), isChecked =checkedListBox2.CheckedItems.Contains(item)});
        }
        StorageManager.SaveToDo(data);
    }
    
    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
        string toDoItem = textBox1.Text;
        if (e.KeyCode == Keys.Enter && toDoItem!= String.Empty)
        {
            checkedListBox2.Items.Add(toDoItem);
            textBox1.Text = string.Empty;
            SaveToDos();
        }
        
    }
    
    private void optionButton_MouseClick(object sender, MouseEventArgs e)
    {
        OptionsForm optionsForm = new OptionsForm();
        optionsForm.OnApply += RoutineUpdate;
        optionsForm.ShowDialog();
    }

    private void checkedListBox2_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Back)
        {
            if (checkedListBox2.SelectedItem!= null)
            {
                checkedListBox2.Items.Remove(checkedListBox2.SelectedItem);
                SaveToDos();
            }
        }
    }
    

    private void timer1_Tick(object sender, EventArgs e)
    {
        TimeSpan resetTime = TimeSpan.Parse(resetData.timeContent);
        TimeSpan now = DateTime.Now.TimeOfDay;
        string today = DateTime.Today.ToString("yyyy/MM/dd");

        if (!resetData.isReset && now.Hours == resetTime.Hours && now.Minutes == resetTime.Minutes)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            
            resetData.isReset = true;
            resetData.lastResetDate = today;
            StorageManager.SaveTime(resetData);
        }

        if (resetData.lastResetDate != today)
        {
            resetData.isReset = false;
            StorageManager.SaveTime(resetData);
        }
    }
    private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
    {
        this.BeginInvoke((MethodInvoker)(() =>
        {
            SaveRoutine();
        }));
    }

    private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
    {
        this.BeginInvoke((MethodInvoker)(() =>
        {
            SaveToDos();
        }));
    }
}