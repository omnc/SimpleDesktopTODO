using System.ComponentModel;

namespace SimpleDesktopTODO;

partial class OptionsForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        listBox1 = new System.Windows.Forms.ListBox();
        textBox1 = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // listBox1
        // 
        listBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 15;
        listBox1.Location = new System.Drawing.Point(24, 93);
        listBox1.Name = "listBox1";
        listBox1.Size = new System.Drawing.Size(331, 229);
        listBox1.TabIndex = 0;
        listBox1.Visible = false;
        // 
        // textBox1
        // 
        textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
        textBox1.Location = new System.Drawing.Point(24, 328);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(268, 23);
        textBox1.TabIndex = 1;
        textBox1.Visible = false;
        textBox1.KeyDown += textBox1_KeyDown;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(298, 328);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(57, 23);
        button1.TabIndex = 2;
        button1.Text = "Apply";
        button1.UseVisualStyleBackColor = true;
        button1.Visible = false;
        button1.Click += button1_Click;
        // 
        // OptionsForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(379, 394);
        Controls.Add(button1);
        Controls.Add(textBox1);
        Controls.Add(listBox1);
        Location = new System.Drawing.Point(15, 15);
        Text = "Options";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.TextBox textBox1;

    #endregion
}