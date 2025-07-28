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
        numericUpDown1 = new System.Windows.Forms.NumericUpDown();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        numericUpDown2 = new System.Windows.Forms.NumericUpDown();
        label3 = new System.Windows.Forms.Label();
        button2 = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
        SuspendLayout();
        // 
        // listBox1
        // 
        listBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
        listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 21;
        listBox1.Location = new System.Drawing.Point(24, 93);
        listBox1.Name = "listBox1";
        listBox1.Size = new System.Drawing.Size(331, 235);
        listBox1.TabIndex = 0;
        listBox1.KeyDown += listBox1_KeyDown;
        // 
        // textBox1
        // 
        textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
        textBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        textBox1.Location = new System.Drawing.Point(24, 342);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(268, 27);
        textBox1.TabIndex = 1;
        textBox1.KeyDown += textBox1_KeyDown;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(298, 343);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(57, 27);
        button1.TabIndex = 2;
        button1.Text = "APPLY";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // numericUpDown1
        // 
        numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        numericUpDown1.Location = new System.Drawing.Point(106, 36);
        numericUpDown1.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new System.Drawing.Size(49, 29);
        numericUpDown1.TabIndex = 3;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        label1.Location = new System.Drawing.Point(42, 36);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(58, 23);
        label1.TabIndex = 4;
        label1.Text = "Time ";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        label2.Location = new System.Drawing.Point(171, 35);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(58, 23);
        label2.TabIndex = 6;
        label2.Text = "Minute";
        // 
        // numericUpDown2
        // 
        numericUpDown2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        numericUpDown2.Location = new System.Drawing.Point(235, 35);
        numericUpDown2.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
        numericUpDown2.Name = "numericUpDown2";
        numericUpDown2.Size = new System.Drawing.Size(49, 29);
        numericUpDown2.TabIndex = 5;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        label3.Location = new System.Drawing.Point(42, 9);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(242, 21);
        label3.TabIndex = 7;
        label3.Text = "RESET TIME";
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(298, 35);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(57, 29);
        button2.TabIndex = 8;
        button2.Text = "APPLY";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // OptionsForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(379, 394);
        Controls.Add(button2);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(numericUpDown2);
        Controls.Add(label1);
        Controls.Add(numericUpDown1);
        Controls.Add(button1);
        Controls.Add(textBox1);
        Controls.Add(listBox1);
        Location = new System.Drawing.Point(15, 15);
        Text = "Options";
        Load += OptionsForm_Load;
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown numericUpDown2;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.NumericUpDown numericUpDown1;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.TextBox textBox1;

    #endregion
}