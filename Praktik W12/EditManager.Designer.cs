namespace Praktik_W12
{
    partial class EditManager
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
            this.label_EditManager = new System.Windows.Forms.Label();
            this.comboBox_jenisTeam = new System.Windows.Forms.ComboBox();
            this.dGV_AddPlayer = new System.Windows.Forms.DataGridView();
            this.label_teamEditManager = new System.Windows.Forms.Label();
            this.textBox_idManager = new System.Windows.Forms.TextBox();
            this.label_IDManager = new System.Windows.Forms.Label();
            this.textBox_nameManager = new System.Windows.Forms.TextBox();
            this.label_namePlayer = new System.Windows.Forms.Label();
            this.dTP_Manbirthdate = new System.Windows.Forms.DateTimePicker();
            this.label_Birthdate = new System.Windows.Forms.Label();
            this.comboBox_ManNationality = new System.Windows.Forms.ComboBox();
            this.label_Nationality = new System.Windows.Forms.Label();
            this.label_Working = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_UPDATE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_AddPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // label_EditManager
            // 
            this.label_EditManager.AutoSize = true;
            this.label_EditManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EditManager.Location = new System.Drawing.Point(37, 40);
            this.label_EditManager.Name = "label_EditManager";
            this.label_EditManager.Size = new System.Drawing.Size(313, 42);
            this.label_EditManager.TabIndex = 11;
            this.label_EditManager.Text = "EDIT MANAGER";
            // 
            // comboBox_jenisTeam
            // 
            this.comboBox_jenisTeam.FormattingEnabled = true;
            this.comboBox_jenisTeam.Location = new System.Drawing.Point(189, 134);
            this.comboBox_jenisTeam.Name = "comboBox_jenisTeam";
            this.comboBox_jenisTeam.Size = new System.Drawing.Size(184, 24);
            this.comboBox_jenisTeam.TabIndex = 22;
            // 
            // dGV_AddPlayer
            // 
            this.dGV_AddPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_AddPlayer.Location = new System.Drawing.Point(472, 98);
            this.dGV_AddPlayer.Name = "dGV_AddPlayer";
            this.dGV_AddPlayer.RowHeadersWidth = 51;
            this.dGV_AddPlayer.RowTemplate.Height = 24;
            this.dGV_AddPlayer.Size = new System.Drawing.Size(660, 611);
            this.dGV_AddPlayer.TabIndex = 23;
            // 
            // label_teamEditManager
            // 
            this.label_teamEditManager.AutoSize = true;
            this.label_teamEditManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_teamEditManager.Location = new System.Drawing.Point(40, 138);
            this.label_teamEditManager.Name = "label_teamEditManager";
            this.label_teamEditManager.Size = new System.Drawing.Size(61, 20);
            this.label_teamEditManager.TabIndex = 24;
            this.label_teamEditManager.Text = "Team :";
            // 
            // textBox_idManager
            // 
            this.textBox_idManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_idManager.Location = new System.Drawing.Point(189, 357);
            this.textBox_idManager.Multiline = true;
            this.textBox_idManager.Name = "textBox_idManager";
            this.textBox_idManager.Size = new System.Drawing.Size(184, 27);
            this.textBox_idManager.TabIndex = 28;
            // 
            // label_IDManager
            // 
            this.label_IDManager.AutoSize = true;
            this.label_IDManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IDManager.Location = new System.Drawing.Point(45, 357);
            this.label_IDManager.Name = "label_IDManager";
            this.label_IDManager.Size = new System.Drawing.Size(106, 20);
            this.label_IDManager.TabIndex = 27;
            this.label_IDManager.Text = "ID Manager :";
            // 
            // textBox_nameManager
            // 
            this.textBox_nameManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nameManager.Location = new System.Drawing.Point(189, 307);
            this.textBox_nameManager.Multiline = true;
            this.textBox_nameManager.Name = "textBox_nameManager";
            this.textBox_nameManager.Size = new System.Drawing.Size(184, 27);
            this.textBox_nameManager.TabIndex = 26;
            // 
            // label_namePlayer
            // 
            this.label_namePlayer.AutoSize = true;
            this.label_namePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_namePlayer.Location = new System.Drawing.Point(45, 309);
            this.label_namePlayer.Name = "label_namePlayer";
            this.label_namePlayer.Size = new System.Drawing.Size(63, 20);
            this.label_namePlayer.TabIndex = 25;
            this.label_namePlayer.Text = "Name :";
            // 
            // dTP_Manbirthdate
            // 
            this.dTP_Manbirthdate.CustomFormat = "yyyy-MM-dd";
            this.dTP_Manbirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_Manbirthdate.Location = new System.Drawing.Point(189, 412);
            this.dTP_Manbirthdate.Name = "dTP_Manbirthdate";
            this.dTP_Manbirthdate.Size = new System.Drawing.Size(184, 22);
            this.dTP_Manbirthdate.TabIndex = 30;
            // 
            // label_Birthdate
            // 
            this.label_Birthdate.AutoSize = true;
            this.label_Birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Birthdate.Location = new System.Drawing.Point(46, 412);
            this.label_Birthdate.Name = "label_Birthdate";
            this.label_Birthdate.Size = new System.Drawing.Size(87, 20);
            this.label_Birthdate.TabIndex = 29;
            this.label_Birthdate.Text = "Birthdate :";
            // 
            // comboBox_ManNationality
            // 
            this.comboBox_ManNationality.FormattingEnabled = true;
            this.comboBox_ManNationality.Location = new System.Drawing.Point(189, 466);
            this.comboBox_ManNationality.Name = "comboBox_ManNationality";
            this.comboBox_ManNationality.Size = new System.Drawing.Size(184, 24);
            this.comboBox_ManNationality.TabIndex = 32;
            // 
            // label_Nationality
            // 
            this.label_Nationality.AutoSize = true;
            this.label_Nationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nationality.Location = new System.Drawing.Point(45, 466);
            this.label_Nationality.Name = "label_Nationality";
            this.label_Nationality.Size = new System.Drawing.Size(97, 20);
            this.label_Nationality.TabIndex = 31;
            this.label_Nationality.Text = "Nationality :";
            // 
            // label_Working
            // 
            this.label_Working.AutoSize = true;
            this.label_Working.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Working.Location = new System.Drawing.Point(46, 526);
            this.label_Working.Name = "label_Working";
            this.label_Working.Size = new System.Drawing.Size(80, 20);
            this.label_Working.TabIndex = 33;
            this.label_Working.Text = "Working :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "0"});
            this.comboBox1.Location = new System.Drawing.Point(189, 522);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(56, 24);
            this.comboBox1.TabIndex = 34;
            // 
            // button_UPDATE
            // 
            this.button_UPDATE.Location = new System.Drawing.Point(50, 600);
            this.button_UPDATE.Name = "button_UPDATE";
            this.button_UPDATE.Size = new System.Drawing.Size(228, 109);
            this.button_UPDATE.TabIndex = 35;
            this.button_UPDATE.Text = "UPDATE";
            this.button_UPDATE.UseVisualStyleBackColor = true;
            // 
            // EditManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 756);
            this.Controls.Add(this.button_UPDATE);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_Working);
            this.Controls.Add(this.comboBox_ManNationality);
            this.Controls.Add(this.label_Nationality);
            this.Controls.Add(this.dTP_Manbirthdate);
            this.Controls.Add(this.label_Birthdate);
            this.Controls.Add(this.textBox_idManager);
            this.Controls.Add(this.label_IDManager);
            this.Controls.Add(this.textBox_nameManager);
            this.Controls.Add(this.label_namePlayer);
            this.Controls.Add(this.label_teamEditManager);
            this.Controls.Add(this.dGV_AddPlayer);
            this.Controls.Add(this.comboBox_jenisTeam);
            this.Controls.Add(this.label_EditManager);
            this.Name = "EditManager";
            this.Text = "EditManager";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_AddPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_EditManager;
        private System.Windows.Forms.ComboBox comboBox_jenisTeam;
        private System.Windows.Forms.DataGridView dGV_AddPlayer;
        private System.Windows.Forms.Label label_teamEditManager;
        private System.Windows.Forms.TextBox textBox_idManager;
        private System.Windows.Forms.Label label_IDManager;
        private System.Windows.Forms.TextBox textBox_nameManager;
        private System.Windows.Forms.Label label_namePlayer;
        private System.Windows.Forms.DateTimePicker dTP_Manbirthdate;
        private System.Windows.Forms.Label label_Birthdate;
        private System.Windows.Forms.ComboBox comboBox_ManNationality;
        private System.Windows.Forms.Label label_Nationality;
        private System.Windows.Forms.Label label_Working;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_UPDATE;
    }
}