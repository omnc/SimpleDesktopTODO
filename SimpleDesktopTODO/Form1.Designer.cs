namespace SimpleDesktopTODO;

partial class Form1
{
    
    
    private System.ComponentModel.IContainer components = null;
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
        checkedListBox1 = new System.Windows.Forms.CheckedListBox();
        optionButton = new System.Windows.Forms.Button();
        checkedListBox2 = new System.Windows.Forms.CheckedListBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // checkedListBox1
        // 
        checkedListBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
        checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
        checkedListBox1.CheckOnClick = true;
        checkedListBox1.FormattingEnabled = true;
        checkedListBox1.Location = new System.Drawing.Point(12, 93);
        checkedListBox1.Name = "checkedListBox1";
        checkedListBox1.Size = new System.Drawing.Size(343, 162);
        checkedListBox1.TabIndex = 5;
        // 
        // optionButton
        // 
        optionButton.Location = new System.Drawing.Point(278, 13);
        optionButton.Name = "optionButton";
        optionButton.Size = new System.Drawing.Size(65, 32);
        optionButton.TabIndex = 6;
        optionButton.Text = "Option";
        optionButton.UseVisualStyleBackColor = true;
        // 
        // checkedListBox2
        // 
        checkedListBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
        checkedListBox2.FormattingEnabled = true;
        checkedListBox2.Location = new System.Drawing.Point(12, 292);
        checkedListBox2.Name = "checkedListBox2";
        checkedListBox2.Size = new System.Drawing.Size(343, 274);
        checkedListBox2.TabIndex = 7;
        // 
        // label1
        // 
        label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
        label1.Location = new System.Drawing.Point(96, 67);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(162, 23);
        label1.TabIndex = 8;
        label1.Text = "Daily Routine";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
        label2.Location = new System.Drawing.Point(96, 266);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(162, 23);
        label2.TabIndex = 9;
        label2.Text = "TODO LIST";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(12, 572);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(343, 23);
        textBox1.TabIndex = 10;
        textBox1.KeyDown += textBox1_KeyDown;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(367, 625);
        Controls.Add(textBox1);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(checkedListBox2);
        Controls.Add(optionButton);
        Controls.Add(checkedListBox1);
        Location = new System.Drawing.Point(15, 15);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.CheckedListBox checkedListBox2;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button optionButton;

    private System.Windows.Forms.CheckedListBox checkedListBox1;

    #endregion
}