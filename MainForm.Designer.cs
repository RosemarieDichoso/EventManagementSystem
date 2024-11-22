namespace EventManagementSystem
{
    partial class MainForm
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
            panel1 = new Panel();
            exitApplication = new Label();
            btnAddEvent = new Button();
            eventManagement = new Label();
            eventPanel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add(exitApplication);
            panel1.Controls.Add(btnAddEvent);
            panel1.Controls.Add(eventManagement);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 114);
            panel1.TabIndex = 0;
            // 
            // exitApplication
            // 
            exitApplication.AutoSize = true;
            exitApplication.Cursor = Cursors.Hand;
            exitApplication.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitApplication.Location = new Point(836, 9);
            exitApplication.Name = "exitApplication";
            exitApplication.Size = new Size(20, 22);
            exitApplication.TabIndex = 2;
            exitApplication.Text = "X";
            exitApplication.Click += exitApplication_Click;
            // 
            // btnAddEvent
            // 
            btnAddEvent.BackColor = Color.ForestGreen;
            btnAddEvent.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEvent.ForeColor = Color.White;
            btnAddEvent.Location = new Point(707, 41);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(94, 35);
            btnAddEvent.TabIndex = 1;
            btnAddEvent.Text = "Add Event";
            btnAddEvent.UseVisualStyleBackColor = false;
            btnAddEvent.Click += btnAddEvent_Click;
            // 
            // eventManagement
            // 
            eventManagement.AutoSize = true;
            eventManagement.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eventManagement.ForeColor = Color.White;
            eventManagement.Location = new Point(29, 38);
            eventManagement.Name = "eventManagement";
            eventManagement.Size = new Size(320, 35);
            eventManagement.TabIndex = 0;
            eventManagement.Text = "Event Management App";
            eventManagement.Click += label1_Click;
            // 
            // eventPanel
            // 
            eventPanel.BackColor = Color.PaleGoldenrod;
            eventPanel.Location = new Point(2, 114);
            eventPanel.Name = "eventPanel";
            eventPanel.Size = new Size(867, 360);
            eventPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 476);
            Controls.Add(eventPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel eventPanel;
        private Label eventManagement;
        private Button btnAddEvent;
        private Label exitApplication;
    }
}
