namespace EventManagementSystem.Forms
{
    partial class UpdateEventForm
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
            groupBox1 = new GroupBox();
            exitUpdate = new Label();
            label1 = new Label();
            btnUpdateEvent = new Button();
            label2 = new Label();
            cboStatus = new ComboBox();
            label4 = new Label();
            txtEventName = new TextBox();
            label3 = new Label();
            rtxtDescription = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PaleGoldenrod;
            groupBox1.Controls.Add(exitUpdate);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnUpdateEvent);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboStatus);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEventName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(rtxtDescription);
            groupBox1.Location = new Point(36, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 400);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // exitUpdate
            // 
            exitUpdate.AutoSize = true;
            exitUpdate.Cursor = Cursors.Hand;
            exitUpdate.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitUpdate.Location = new Point(320, 9);
            exitUpdate.Name = "exitUpdate";
            exitUpdate.Size = new Size(22, 21);
            exitUpdate.TabIndex = 10;
            exitUpdate.Text = "X";
            exitUpdate.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 23);
            label1.Name = "label1";
            label1.Size = new Size(178, 32);
            label1.TabIndex = 0;
            label1.Text = "Update Event";
            // 
            // btnUpdateEvent
            // 
            btnUpdateEvent.BackColor = Color.ForestGreen;
            btnUpdateEvent.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateEvent.Location = new Point(214, 345);
            btnUpdateEvent.Name = "btnUpdateEvent";
            btnUpdateEvent.Size = new Size(94, 29);
            btnUpdateEvent.TabIndex = 7;
            btnUpdateEvent.Text = "Update";
            btnUpdateEvent.UseVisualStyleBackColor = false;
            btnUpdateEvent.Click += btnUpdateEvent_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 110);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 1;
            label2.Text = "Event Name";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "New", "On-going", "Done" });
            cboStatus.Location = new Point(157, 288);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(166, 28);
            cboStatus.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 288);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Status";
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(157, 110);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(166, 27);
            txtEventName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 162);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(157, 162);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(166, 105);
            rtxtDescription.TabIndex = 5;
            rtxtDescription.Text = "";
            // 
            // UpdateEventForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(412, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateEventForm";
            Text = "UpdateEventForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnUpdateEvent;
        private Label label2;
        private ComboBox cboStatus;
        private Label label4;
        private TextBox txtEventName;
        private Label label3;
        private RichTextBox rtxtDescription;
        private Label exitUpdate;
    }
}