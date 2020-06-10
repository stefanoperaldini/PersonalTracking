namespace PersonalTracking
{
    partial class FrmPermission
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
            this.txtUserNo = new System.Windows.Forms.TextBox();
            this.lblUserNo = new System.Windows.Forms.Label();
            this.dpEnd = new System.Windows.Forms.DateTimePicker();
            this.dpStart = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.txtDayAmount = new System.Windows.Forms.TextBox();
            this.lblDayAmount = new System.Windows.Forms.Label();
            this.txtExplanation = new System.Windows.Forms.TextBox();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUserNo
            // 
            this.txtUserNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNo.Location = new System.Drawing.Point(130, 16);
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.ReadOnly = true;
            this.txtUserNo.Size = new System.Drawing.Size(149, 26);
            this.txtUserNo.TabIndex = 0;
            // 
            // lblUserNo
            // 
            this.lblUserNo.AutoSize = true;
            this.lblUserNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNo.Location = new System.Drawing.Point(12, 22);
            this.lblUserNo.Name = "lblUserNo";
            this.lblUserNo.Size = new System.Drawing.Size(112, 20);
            this.lblUserNo.TabIndex = 0;
            this.lblUserNo.Text = "User number";
            // 
            // dpEnd
            // 
            this.dpEnd.Location = new System.Drawing.Point(130, 108);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(142, 20);
            this.dpEnd.TabIndex = 1;
            this.dpEnd.ValueChanged += new System.EventHandler(this.dpEnd_ValueChanged);
            // 
            // dpStart
            // 
            this.dpStart.Location = new System.Drawing.Point(130, 64);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(142, 20);
            this.dpStart.TabIndex = 0;
            this.dpStart.ValueChanged += new System.EventHandler(this.dpStart_ValueChanged);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(12, 107);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(41, 20);
            this.lblEnd.TabIndex = 0;
            this.lblEnd.Text = "End";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(12, 65);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(49, 20);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Start";
            // 
            // txtDayAmount
            // 
            this.txtDayAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDayAmount.Location = new System.Drawing.Point(130, 141);
            this.txtDayAmount.Name = "txtDayAmount";
            this.txtDayAmount.ReadOnly = true;
            this.txtDayAmount.Size = new System.Drawing.Size(149, 26);
            this.txtDayAmount.TabIndex = 0;
            // 
            // lblDayAmount
            // 
            this.lblDayAmount.AutoSize = true;
            this.lblDayAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayAmount.Location = new System.Drawing.Point(12, 147);
            this.lblDayAmount.Name = "lblDayAmount";
            this.lblDayAmount.Size = new System.Drawing.Size(105, 20);
            this.lblDayAmount.TabIndex = 0;
            this.lblDayAmount.Text = "Day amount";
            // 
            // txtExplanation
            // 
            this.txtExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExplanation.Location = new System.Drawing.Point(130, 184);
            this.txtExplanation.Multiline = true;
            this.txtExplanation.Name = "txtExplanation";
            this.txtExplanation.Size = new System.Drawing.Size(421, 184);
            this.txtExplanation.TabIndex = 2;
            // 
            // lblExplanation
            // 
            this.lblExplanation.AutoSize = true;
            this.lblExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplanation.Location = new System.Drawing.Point(12, 190);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(103, 20);
            this.lblExplanation.TabIndex = 0;
            this.lblExplanation.Text = "Explanation";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(339, 394);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 33);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(206, 394);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 33);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtExplanation);
            this.Controls.Add(this.lblExplanation);
            this.Controls.Add(this.txtDayAmount);
            this.Controls.Add(this.lblDayAmount);
            this.Controls.Add(this.dpEnd);
            this.Controls.Add(this.dpStart);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.txtUserNo);
            this.Controls.Add(this.lblUserNo);
            this.Name = "FrmPermission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permission";
            this.Load += new System.EventHandler(this.FrmPermission_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserNo;
        private System.Windows.Forms.Label lblUserNo;
        private System.Windows.Forms.DateTimePicker dpEnd;
        private System.Windows.Forms.DateTimePicker dpStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox txtDayAmount;
        private System.Windows.Forms.Label lblDayAmount;
        private System.Windows.Forms.TextBox txtExplanation;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}