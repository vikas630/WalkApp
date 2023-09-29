// File for fields
using System.Windows.Forms;
using System;
using System.Drawing;
using WalkApp;

public class WalkForm : Form
{
    private TextBox txtWalkerName;
    private TextBox txtLengthOfStep;
    private TextBox txtNumberOfSteps;
    private Label lblMilesWalked;
    private Button btnCreateWalk_Click;
    private Button button2;
    private Button button3;
    private readonly WalkProperties properties = new WalkProperties();

    // Constructor
    public WalkForm()
    {
        InitializeComponent();
    }



    private void InitializeComponent()
    {
        this.txtWalkerName = new System.Windows.Forms.TextBox();
        this.txtLengthOfStep = new System.Windows.Forms.TextBox();
        this.txtNumberOfSteps = new System.Windows.Forms.TextBox();
        this.lblMilesWalked = new System.Windows.Forms.Label();
        this.btnCreateWalk_Click = new System.Windows.Forms.Button();
        this.button2 = new System.Windows.Forms.Button();
        this.button3 = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // txtWalkerName
        // 
        this.txtWalkerName.Location = new System.Drawing.Point(635, 25);
        this.txtWalkerName.Name = "txtWalkerName";
        this.txtWalkerName.Size = new System.Drawing.Size(100, 22);
        this.txtWalkerName.TabIndex = 0;
        this.txtWalkerName.Text = "Enter your name";
        // 
        // txtLengthOfStep
        // 
        this.txtLengthOfStep.Location = new System.Drawing.Point(635, 73);
        this.txtLengthOfStep.Name = "txtLengthOfStep";
        this.txtLengthOfStep.Size = new System.Drawing.Size(100, 22);
        this.txtLengthOfStep.TabIndex = 1;
        this.txtLengthOfStep.Text = "Number Of Steps";
        // 
        // txtNumberOfSteps
        // 
        this.txtNumberOfSteps.Location = new System.Drawing.Point(635, 120);
        this.txtNumberOfSteps.Name = "txtNumberOfSteps";
        this.txtNumberOfSteps.Size = new System.Drawing.Size(100, 22);
        this.txtNumberOfSteps.TabIndex = 2;
        this.txtNumberOfSteps.Text = "Length Of Steps";
        // 
        // lblMilesWalked
        // 
        this.lblMilesWalked.AutoSize = true;
        this.lblMilesWalked.Location = new System.Drawing.Point(665, 380);
        this.lblMilesWalked.Name = "lblMilesWalked";
        this.lblMilesWalked.Size = new System.Drawing.Size(45, 16);
        this.lblMilesWalked.TabIndex = 3;
        this.lblMilesWalked.Text = "Output";
        // 
        // btnCreateWalk_Click
        // 
        this.btnCreateWalk_Click.Location = new System.Drawing.Point(339, 180);
        this.btnCreateWalk_Click.Name = "btnCreateWalk_Click";
        this.btnCreateWalk_Click.Size = new System.Drawing.Size(148, 23);
        this.btnCreateWalk_Click.TabIndex = 4;
        this.btnCreateWalk_Click.Text = "btnCreateWalk_Click";
        this.btnCreateWalk_Click.UseVisualStyleBackColor = true;
        this.btnCreateWalk_Click.Click += new System.EventHandler(this.button1_Click);
        // 
        // button2
        // 
        this.button2.Location = new System.Drawing.Point(917, 180);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(105, 23);
        this.button2.TabIndex = 5;
        this.button2.Text = "Clear/Reset";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += new System.EventHandler(this.button2_Click);
        // 
        // button3
        // 
        this.button3.Location = new System.Drawing.Point(650, 255);
        this.button3.Name = "button3";
        this.button3.Size = new System.Drawing.Size(75, 23);
        this.button3.TabIndex = 6;
        this.button3.Text = "Exit";
        this.button3.UseVisualStyleBackColor = true;
        this.button3.Click += new System.EventHandler(this.button3_Click);
        // 
        // WalkForm
        // 
        this.ClientSize = new System.Drawing.Size(1647, 658);
        this.Controls.Add(this.button3);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.btnCreateWalk_Click);
        this.Controls.Add(this.lblMilesWalked);
        this.Controls.Add(this.txtNumberOfSteps);
        this.Controls.Add(this.txtLengthOfStep);
        this.Controls.Add(this.txtWalkerName);
        this.Name = "WalkForm";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    private void button1_Click(object sender, EventArgs e)
    {
        Walk walk = new Walk(txtWalkerName.Text, int.Parse(txtNumberOfSteps.Text), int.Parse(txtLengthOfStep.Text));

        double milesWalked = walk.CalculateMilesWalked();

        properties.WalkerName = txtWalkerName.Text;

        lblMilesWalked.Text = $"{properties.WalkerName} walked {milesWalked:F2} miles.";

    }

    private void button2_Click(object sender, EventArgs e)
    {
        txtWalkerName.Text = "";
        txtNumberOfSteps.Text = "";
        txtLengthOfStep.Text = "";
        lblMilesWalked.Text = "";
    }

    private void button3_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
