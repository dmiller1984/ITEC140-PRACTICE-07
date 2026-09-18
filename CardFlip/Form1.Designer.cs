namespace CardFlip;
partial class Form1
{
    private System.ComponentModel.IContainer? components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        picCardF = new PictureBox();
        picCardB = new PictureBox();
        btnCardB = new Button();
        btnCardF = new Button();
        btnFlip = new Button();
        ((System.ComponentModel.ISupportInitialize)picCardF).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picCardB).BeginInit();
        SuspendLayout();
        // 
        // picCardF
        // 
        picCardF.Image = (Image)resources.GetObject("picCardF.Image");
        picCardF.Location = new Point(216, 28);
        picCardF.Name = "picCardF";
        picCardF.Size = new Size(150, 210);
        picCardF.SizeMode = PictureBoxSizeMode.StretchImage;
        picCardF.TabIndex = 1;
        picCardF.TabStop = false;
        picCardF.Visible = false;
        // 
        // picCardB
        // 
        picCardB.Image = (Image)resources.GetObject("picCardB.Image");
        picCardB.Location = new Point(25, 28);
        picCardB.Name = "picCardB";
        picCardB.Size = new Size(150, 210);
        picCardB.SizeMode = PictureBoxSizeMode.CenterImage;
        picCardB.TabIndex = 2;
        picCardB.TabStop = false;
        picCardB.Click += picCardB_Click;
        // 
        // btnCardB
        // 
        btnCardB.Location = new Point(55, 306);
        btnCardB.Name = "btnCardB";
        btnCardB.Size = new Size(75, 43);
        btnCardB.TabIndex = 3;
        btnCardB.Text = "SHOW BACK";
        btnCardB.UseVisualStyleBackColor = true;
        // 
        // btnCardF
        // 
        btnCardF.Location = new Point(245, 306);
        btnCardF.Name = "btnCardF";
        btnCardF.Size = new Size(75, 43);
        btnCardF.TabIndex = 4;
        btnCardF.Text = "SHOW FACE";
        btnCardF.UseVisualStyleBackColor = true;
        // 
        // btnFlip
        // 
        btnFlip.Location = new Point(144, 361);
        btnFlip.Name = "btnFlip";
        btnFlip.Size = new Size(83, 27);
        btnFlip.TabIndex = 5;
        btnFlip.Text = "FLIP";
        btnFlip.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(393, 410);
        Controls.Add(btnFlip);
        Controls.Add(btnCardF);
        Controls.Add(btnCardB);
        Controls.Add(picCardB);
        Controls.Add(picCardF);
        Name = "Form1";
        Text = "Card Flip";
        ((System.ComponentModel.ISupportInitialize)picCardF).EndInit();
        ((System.ComponentModel.ISupportInitialize)picCardB).EndInit();
        ResumeLayout(false);
    }

    private PictureBox picCardF;
    private PictureBox picCardB;
    private Button btnCardB;
    private Button btnCardF;
    private Button btnFlip;
}
