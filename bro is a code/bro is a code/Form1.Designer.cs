namespace bro_is_a_code
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            healthBar = new ProgressBar();
            label2 = new Label();
            background = new TableLayoutPanel();
            label3 = new Label();
            airFryerBox = new PictureBox();
            winBox = new PictureBox();
            loseBox = new PictureBox();
            logButton = new Button();
            logBox = new TextBox();
            restart = new Button();
            ((System.ComponentModel.ISupportInitialize)airFryerBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)winBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loseBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, -1);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // healthBar
            // 
            healthBar.Location = new Point(14, 23);
            healthBar.Margin = new Padding(3, 4, 3, 4);
            healthBar.Name = "healthBar";
            healthBar.Size = new Size(415, 20);
            healthBar.TabIndex = 0;
            healthBar.Value = 100;
            healthBar.Click += healthBar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(435, 23);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 6;
            label2.Text = "Turn: 0";
            label2.Click += label2_Click;
            // 
            // background
            // 
            background.BackgroundImage = (Image)resources.GetObject("background.BackgroundImage");
            background.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            background.ColumnCount = 8;
            background.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            background.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            background.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            background.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            background.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            background.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            background.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            background.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            background.Location = new Point(14, 51);
            background.Margin = new Padding(3, 4, 3, 4);
            background.Name = "background";
            background.RowCount = 8;
            background.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            background.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            background.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            background.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            background.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            background.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            background.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            background.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            background.Size = new Size(791, 844);
            background.TabIndex = 0;
            background.Paint += background_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(811, 46);
            label3.Name = "label3";
            label3.Size = new Size(52, 22);
            label3.TabIndex = 0;
            label3.Text = "label3";
            // 
            // airFryerBox
            // 
            airFryerBox.Image = (Image)resources.GetObject("airFryerBox.Image");
            airFryerBox.Location = new Point(811, 108);
            airFryerBox.Name = "airFryerBox";
            airFryerBox.Size = new Size(717, 723);
            airFryerBox.TabIndex = 7;
            airFryerBox.TabStop = false;
            // 
            // winBox
            // 
            winBox.Image = (Image)resources.GetObject("winBox.Image");
            winBox.Location = new Point(958, 121);
            winBox.Name = "winBox";
            winBox.Size = new Size(434, 558);
            winBox.TabIndex = 0;
            winBox.TabStop = false;
            // 
            // loseBox
            // 
            loseBox.Image = (Image)resources.GetObject("loseBox.Image");
            loseBox.Location = new Point(956, 121);
            loseBox.Name = "loseBox";
            loseBox.Size = new Size(436, 558);
            loseBox.TabIndex = 8;
            loseBox.TabStop = false;
            // 
            // logButton
            // 
            logButton.Location = new Point(989, 42);
            logButton.Name = "logButton";
            logButton.Size = new Size(94, 29);
            logButton.TabIndex = 9;
            logButton.Text = "Show Log";
            logButton.UseVisualStyleBackColor = true;
            logButton.Click += logButton_Click;
            // 
            // logBox
            // 
            logBox.Location = new Point(975, 121);
            logBox.Multiline = true;
            logBox.Name = "logBox";
            logBox.ReadOnly = true;
            logBox.ScrollBars = ScrollBars.Vertical;
            logBox.Size = new Size(214, 644);
            logBox.TabIndex = 10;
            logBox.Visible = false;
            // 
            // restart
            // 
            restart.Location = new Point(888, 42);
            restart.Name = "restart";
            restart.Size = new Size(81, 29);
            restart.TabIndex = 11;
            restart.Text = "Restart";
            restart.UseVisualStyleBackColor = true;
            restart.Click += restart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1537, 973);
            Controls.Add(restart);
            Controls.Add(logBox);
            Controls.Add(logButton);
            Controls.Add(airFryerBox);
            Controls.Add(label3);
            Controls.Add(background);
            Controls.Add(label2);
            Controls.Add(healthBar);
            Controls.Add(label1);
            Controls.Add(loseBox);
            Controls.Add(winBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)airFryerBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)winBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)loseBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar healthBar;
        private Label label2;
        private TableLayoutPanel background;
        private Label label3;
        private PictureBox airFryerBox;
        private PictureBox winBox;
        private PictureBox loseBox;
        private Button logButton;
        private TextBox logBox;
        private Button restart;
    }
}
