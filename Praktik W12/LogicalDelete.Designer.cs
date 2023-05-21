namespace Praktik_W12
{
    partial class LogicalDelete
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
            this.comboBox_SelTeam = new System.Windows.Forms.ComboBox();
            this.label_logDel = new System.Windows.Forms.Label();
            this.label_selTeam = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_DELETE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_SelTeam
            // 
            this.comboBox_SelTeam.FormattingEnabled = true;
            this.comboBox_SelTeam.Location = new System.Drawing.Point(179, 135);
            this.comboBox_SelTeam.Name = "comboBox_SelTeam";
            this.comboBox_SelTeam.Size = new System.Drawing.Size(211, 24);
            this.comboBox_SelTeam.TabIndex = 0;
            // 
            // label_logDel
            // 
            this.label_logDel.AutoSize = true;
            this.label_logDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logDel.Location = new System.Drawing.Point(41, 41);
            this.label_logDel.Name = "label_logDel";
            this.label_logDel.Size = new System.Drawing.Size(349, 42);
            this.label_logDel.TabIndex = 12;
            this.label_logDel.Text = "LOGICAL DELETE";
            // 
            // label_selTeam
            // 
            this.label_selTeam.AutoSize = true;
            this.label_selTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_selTeam.Location = new System.Drawing.Point(44, 135);
            this.label_selTeam.Name = "label_selTeam";
            this.label_selTeam.Size = new System.Drawing.Size(113, 20);
            this.label_selTeam.TabIndex = 25;
            this.label_selTeam.Text = "Select Team :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(444, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(687, 582);
            this.dataGridView1.TabIndex = 26;
            // 
            // button_DELETE
            // 
            this.button_DELETE.Location = new System.Drawing.Point(48, 588);
            this.button_DELETE.Name = "button_DELETE";
            this.button_DELETE.Size = new System.Drawing.Size(228, 109);
            this.button_DELETE.TabIndex = 36;
            this.button_DELETE.Text = "DELETE";
            this.button_DELETE.UseVisualStyleBackColor = true;
            // 
            // LogicalDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 744);
            this.Controls.Add(this.button_DELETE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_selTeam);
            this.Controls.Add(this.label_logDel);
            this.Controls.Add(this.comboBox_SelTeam);
            this.Name = "LogicalDelete";
            this.Text = "LogicalDelete";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_SelTeam;
        private System.Windows.Forms.Label label_logDel;
        private System.Windows.Forms.Label label_selTeam;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_DELETE;
    }
}