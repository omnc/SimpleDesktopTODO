namespace SimpleDesktopTODO;
using System;
using System.IO;
using System.Windows.Forms;

public partial class Form1 : Form
{
    string repeatedTaskPath = "repeatedTask.txt";
    string todayTaskPath = "todayTask.txt";

    public Form1()
    {
        InitializeComponent();
        //this.FormBorderStyle = FormBorderStyle.None;
        this.TopMost = true;
        this.BackColor = System.Drawing.Color.LightYellow;
    }
    
    
    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
        string toDoItem = textBox1.Text;
        if (e.KeyCode == Keys.Enter)
        {
            checkedListBox2.Items.Add(toDoItem);
        }
    }
}