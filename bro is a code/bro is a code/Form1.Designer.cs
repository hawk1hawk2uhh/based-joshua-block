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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, -1);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // healthBar
            // 
            healthBar.Location = new Point(12, 17);
            healthBar.Name = "healthBar";
            healthBar.Size = new Size(363, 15);
            healthBar.TabIndex = 0;
            healthBar.Value = 100;
            healthBar.Click += healthBar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(381, 17);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
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
            background.Location = new Point(12, 38);
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
            background.Size = new Size(692, 633);
            background.TabIndex = 0;
            background.Paint += background_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(710, 38);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 0;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 703);
            Controls.Add(label3);
            Controls.Add(background);
            Controls.Add(label2);
            Controls.Add(healthBar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar healthBar;
        private Label label2;
        private TableLayoutPanel background;
        private Label label3;
    }
}
