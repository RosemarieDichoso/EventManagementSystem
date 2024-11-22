namespace EventManagementSystem.Forms
{
    partial class AddEventForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEventName = new TextBox();
            rtxtDescription = new RichTextBox();
            cboStatus = new ComboBox();
            btnSaveEvent = new Button();
            groupBox1 = new GroupBox();
            exitAdd = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 23);
            label1.Name = "label1";
            label1.Size = new Size(201, 32);
            label1.TabIndex = 0;
            label1.Text = "Add New Event";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 110);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 1;
            label2.Text = "Event Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 162);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 288);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Status";
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(157, 107);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(170, 27);
            txtEventName.TabIndex = 4;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(157, 162);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(170, 105);
            rtxtDescription.TabIndex = 5;
            rtxtDescription.Text = "";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "New", "On-going", "Done" });
            cboStatus.Location = new Point(157, 288);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(170, 28);
            cboStatus.TabIndex = 6;
            // 
            // btnSaveEvent
            // 
            btnSaveEvent.BackColor = Color.ForestGreen;
            btnSaveEvent.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveEvent.Location = new Point(214, 345);
            btnSaveEvent.Name = "btnSaveEvent";
            btnSaveEvent.Size = new Size(94, 33);
            btnSaveEvent.TabIndex = 7;
            btnSaveEvent.Text = "Save";
            btnSaveEvent.UseVisualStyleBackColor = false;
            btnSaveEvent.Click += btnSaveEvent_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PaleGoldenrod;
            groupBox1.Controls.Add(exitAdd);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSaveEvent);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboStatus);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEventName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(rtxtDescription);
            groupBox1.Location = new Point(25, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 400);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // exitAdd
            // 
            exitAdd.AutoSize = true;
            exitAdd.Cursor = Cursors.Hand;
            exitAdd.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitAdd.Location = new Point(320, 9);
            exitAdd.Name = "exitAdd";
            exitAdd.Size = new Size(22, 21);
            exitAdd.TabIndex = 11;
            exitAdd.Text = "X";
            exitAdd.Click += exitAdd_Click;
            // 
            // AddEventForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(401, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddEventForm";
            Text = "AddEventForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSaveEvent;
        private ComboBox cboStatus;
        private RichTextBox rtxtDescription;
        private TextBox txtEventName;
        private GroupBox groupBox1;
        private Label exitAdd;
    }
}