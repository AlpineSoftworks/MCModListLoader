namespace MCModListLoader
{
    partial class MCModpackListLoader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MCModpackListLoader));
            this.btn_MLBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ML = new System.Windows.Forms.TextBox();
            this.tab_MLMaster = new System.Windows.Forms.TabControl();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.chk_ItemQuote = new System.Windows.Forms.CheckBox();
            this.chk_ExAuth = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdb_DelCom = new System.Windows.Forms.RadioButton();
            this.rdb_DelNL = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_MLBrowse
            // 
            this.btn_MLBrowse.AutoSize = true;
            this.btn_MLBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_MLBrowse.Location = new System.Drawing.Point(305, 23);
            this.btn_MLBrowse.Name = "btn_MLBrowse";
            this.btn_MLBrowse.Size = new System.Drawing.Size(26, 23);
            this.btn_MLBrowse.TabIndex = 0;
            this.btn_MLBrowse.Text = "...";
            this.btn_MLBrowse.UseVisualStyleBackColor = true;
            this.btn_MLBrowse.Click += new System.EventHandler(this.btn_MLBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "modlist.html:";
            // 
            // txt_ML
            // 
            this.txt_ML.Location = new System.Drawing.Point(12, 25);
            this.txt_ML.Name = "txt_ML";
            this.txt_ML.Size = new System.Drawing.Size(287, 20);
            this.txt_ML.TabIndex = 2;
            // 
            // tab_MLMaster
            // 
            this.tab_MLMaster.Location = new System.Drawing.Point(12, 119);
            this.tab_MLMaster.Name = "tab_MLMaster";
            this.tab_MLMaster.SelectedIndex = 0;
            this.tab_MLMaster.Size = new System.Drawing.Size(410, 400);
            this.tab_MLMaster.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "modlist Name:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(12, 64);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(157, 20);
            this.txt_Name.TabIndex = 6;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(12, 90);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 7;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(347, 90);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add Another";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(6, 111);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(75, 23);
            this.btn_Export.TabIndex = 9;
            this.btn_Export.Text = "Export...";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // chk_ItemQuote
            // 
            this.chk_ItemQuote.AutoSize = true;
            this.chk_ItemQuote.Location = new System.Drawing.Point(6, 65);
            this.chk_ItemQuote.Name = "chk_ItemQuote";
            this.chk_ItemQuote.Size = new System.Drawing.Size(188, 17);
            this.chk_ItemQuote.TabIndex = 11;
            this.chk_ItemQuote.Text = "Surround items with double quotes";
            this.chk_ItemQuote.UseVisualStyleBackColor = true;
            // 
            // chk_ExAuth
            // 
            this.chk_ExAuth.AutoSize = true;
            this.chk_ExAuth.Location = new System.Drawing.Point(6, 88);
            this.chk_ExAuth.Name = "chk_ExAuth";
            this.chk_ExAuth.Size = new System.Drawing.Size(205, 17);
            this.chk_ExAuth.TabIndex = 12;
            this.chk_ExAuth.Text = "Export authors (mirrors above settings)";
            this.chk_ExAuth.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_DelNL);
            this.groupBox1.Controls.Add(this.rdb_DelCom);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.chk_ExAuth);
            this.groupBox1.Controls.Add(this.btn_Export);
            this.groupBox1.Controls.Add(this.chk_ItemQuote);
            this.groupBox1.Location = new System.Drawing.Point(12, 525);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 140);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(120, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.Text = "Delimit with commas";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdb_DelCom
            // 
            this.rdb_DelCom.AutoSize = true;
            this.rdb_DelCom.Checked = true;
            this.rdb_DelCom.Location = new System.Drawing.Point(6, 19);
            this.rdb_DelCom.Name = "rdb_DelCom";
            this.rdb_DelCom.Size = new System.Drawing.Size(159, 17);
            this.rdb_DelCom.TabIndex = 13;
            this.rdb_DelCom.TabStop = true;
            this.rdb_DelCom.Text = "Separate items with commas";
            this.rdb_DelCom.UseVisualStyleBackColor = true;
            // 
            // rdb_DelNL
            // 
            this.rdb_DelNL.AutoSize = true;
            this.rdb_DelNL.Location = new System.Drawing.Point(6, 42);
            this.rdb_DelNL.Name = "rdb_DelNL";
            this.rdb_DelNL.Size = new System.Drawing.Size(164, 17);
            this.rdb_DelNL.TabIndex = 13;
            this.rdb_DelNL.Text = "Separate items with new lines";
            this.rdb_DelNL.UseVisualStyleBackColor = true;
            // 
            // MCModpackListLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 672);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tab_MLMaster);
            this.Controls.Add(this.txt_ML);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_MLBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MCModpackListLoader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minecraft Modpack List Loader";
            this.Load += new System.EventHandler(this.MCModpackListLoader_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MLBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ML;
        private System.Windows.Forms.TabControl tab_MLMaster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.CheckBox chk_ItemQuote;
        private System.Windows.Forms.CheckBox chk_ExAuth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_DelNL;
        private System.Windows.Forms.RadioButton rdb_DelCom;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

