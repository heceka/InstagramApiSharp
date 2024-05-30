namespace Blockout2024
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonLogin = new Button();
            labelUserNameTitle = new Label();
            labelUserName = new Label();
            labelFollowersTitle = new Label();
            labelFullName = new Label();
            listBoxFollowers = new ListBox();
            listBoxFollowing = new ListBox();
            labelFollowingTitle = new Label();
            labelFullNameTitle = new Label();
            listBoxDifference = new ListBox();
            labelDifferenceTitle = new Label();
            labelFollowersCount = new Label();
            labelFollowingCount = new Label();
            labelDifferenceCount = new Label();
            buttonRefresh = new Button();
            buttonBlockAccountsFollowedByAnAccount = new Button();
            labelBlockedUsersCountTitle = new Label();
            labelBlockedUsersCount = new Label();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonLogin.Location = new Point(888, 12);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(108, 58);
            buttonLogin.TabIndex = 0;
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelUserNameTitle
            // 
            labelUserNameTitle.AutoSize = true;
            labelUserNameTitle.Location = new Point(12, 12);
            labelUserNameTitle.Name = "labelUserNameTitle";
            labelUserNameTitle.Size = new Size(76, 15);
            labelUserNameTitle.TabIndex = 1;
            labelUserNameTitle.Text = "Kullanıcı Adı:";
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(94, 12);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(0, 15);
            labelUserName.TabIndex = 1;
            // 
            // labelFollowersTitle
            // 
            labelFollowersTitle.AutoSize = true;
            labelFollowersTitle.Location = new Point(12, 120);
            labelFollowersTitle.Name = "labelFollowersTitle";
            labelFollowersTitle.Size = new Size(59, 15);
            labelFollowersTitle.TabIndex = 2;
            labelFollowersTitle.Text = "Takipçiler:";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(94, 55);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(0, 15);
            labelFullName.TabIndex = 3;
            // 
            // listBoxFollowers
            // 
            listBoxFollowers.FormattingEnabled = true;
            listBoxFollowers.ItemHeight = 15;
            listBoxFollowers.Location = new Point(12, 138);
            listBoxFollowers.Name = "listBoxFollowers";
            listBoxFollowers.Size = new Size(300, 529);
            listBoxFollowers.TabIndex = 6;
            // 
            // listBoxFollowing
            // 
            listBoxFollowing.FormattingEnabled = true;
            listBoxFollowing.ItemHeight = 15;
            listBoxFollowing.Location = new Point(356, 138);
            listBoxFollowing.Name = "listBoxFollowing";
            listBoxFollowing.Size = new Size(300, 529);
            listBoxFollowing.TabIndex = 7;
            // 
            // labelFollowingTitle
            // 
            labelFollowingTitle.AutoSize = true;
            labelFollowingTitle.Location = new Point(356, 120);
            labelFollowingTitle.Name = "labelFollowingTitle";
            labelFollowingTitle.Size = new Size(85, 15);
            labelFollowingTitle.TabIndex = 2;
            labelFollowingTitle.Text = "Takip Edilenler:";
            // 
            // labelFullNameTitle
            // 
            labelFullNameTitle.AutoSize = true;
            labelFullNameTitle.Location = new Point(12, 55);
            labelFullNameTitle.Name = "labelFullNameTitle";
            labelFullNameTitle.Size = new Size(60, 15);
            labelFullNameTitle.TabIndex = 3;
            labelFullNameTitle.Text = "Ad Soyad:";
            // 
            // listBoxDifference
            // 
            listBoxDifference.FormattingEnabled = true;
            listBoxDifference.ItemHeight = 15;
            listBoxDifference.Location = new Point(696, 138);
            listBoxDifference.Name = "listBoxDifference";
            listBoxDifference.Size = new Size(300, 529);
            listBoxDifference.TabIndex = 7;
            // 
            // labelDifferenceTitle
            // 
            labelDifferenceTitle.AutoSize = true;
            labelDifferenceTitle.Location = new Point(696, 120);
            labelDifferenceTitle.Name = "labelDifferenceTitle";
            labelDifferenceTitle.Size = new Size(32, 15);
            labelDifferenceTitle.TabIndex = 2;
            labelDifferenceTitle.Text = "Fark:";
            // 
            // labelFollowersCount
            // 
            labelFollowersCount.AutoSize = true;
            labelFollowersCount.Location = new Point(77, 120);
            labelFollowersCount.Name = "labelFollowersCount";
            labelFollowersCount.Size = new Size(0, 15);
            labelFollowersCount.TabIndex = 2;
            // 
            // labelFollowingCount
            // 
            labelFollowingCount.AutoSize = true;
            labelFollowingCount.Location = new Point(447, 120);
            labelFollowingCount.Name = "labelFollowingCount";
            labelFollowingCount.Size = new Size(0, 15);
            labelFollowingCount.TabIndex = 2;
            // 
            // labelDifferenceCount
            // 
            labelDifferenceCount.AutoSize = true;
            labelDifferenceCount.Location = new Point(734, 120);
            labelDifferenceCount.Name = "labelDifferenceCount";
            labelDifferenceCount.Size = new Size(0, 15);
            labelDifferenceCount.TabIndex = 2;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonRefresh.Location = new Point(921, 88);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(75, 44);
            buttonRefresh.TabIndex = 8;
            buttonRefresh.Text = "Yenile";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonBlockAccountsFollowedByAnAccount
            // 
            buttonBlockAccountsFollowedByAnAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonBlockAccountsFollowedByAnAccount.Location = new Point(544, 74);
            buttonBlockAccountsFollowedByAnAccount.Name = "buttonBlockAccountsFollowedByAnAccount";
            buttonBlockAccountsFollowedByAnAccount.Size = new Size(112, 58);
            buttonBlockAccountsFollowedByAnAccount.TabIndex = 9;
            buttonBlockAccountsFollowedByAnAccount.Text = "Seçili Hesabın takip ettiği hesapları engelle";
            buttonBlockAccountsFollowedByAnAccount.UseVisualStyleBackColor = true;
            buttonBlockAccountsFollowedByAnAccount.Click += buttonBlockAccountsFollowedByAnAccount_Click;
            // 
            // labelBlockedUsersCountTitle
            // 
            labelBlockedUsersCountTitle.AutoSize = true;
            labelBlockedUsersCountTitle.Location = new Point(12, 88);
            labelBlockedUsersCountTitle.Name = "labelBlockedUsersCountTitle";
            labelBlockedUsersCountTitle.Size = new Size(136, 15);
            labelBlockedUsersCountTitle.TabIndex = 10;
            labelBlockedUsersCountTitle.Text = "Engellenen Hesap Sayisi:";
            // 
            // labelBlockedUsersCount
            // 
            labelBlockedUsersCount.AutoSize = true;
            labelBlockedUsersCount.Location = new Point(154, 88);
            labelBlockedUsersCount.Name = "labelBlockedUsersCount";
            labelBlockedUsersCount.Size = new Size(0, 15);
            labelBlockedUsersCount.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 681);
            Controls.Add(labelBlockedUsersCount);
            Controls.Add(labelBlockedUsersCountTitle);
            Controls.Add(buttonBlockAccountsFollowedByAnAccount);
            Controls.Add(buttonRefresh);
            Controls.Add(listBoxDifference);
            Controls.Add(listBoxFollowing);
            Controls.Add(listBoxFollowers);
            Controls.Add(labelFullNameTitle);
            Controls.Add(labelFullName);
            Controls.Add(labelDifferenceCount);
            Controls.Add(labelDifferenceTitle);
            Controls.Add(labelFollowingCount);
            Controls.Add(labelFollowingTitle);
            Controls.Add(labelFollowersCount);
            Controls.Add(labelFollowersTitle);
            Controls.Add(labelUserName);
            Controls.Add(labelUserNameTitle);
            Controls.Add(buttonLogin);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Label labelUserNameTitle;
        private Label labelUserName;
        private Label labelFollowersTitle;
        private Label labelFullName;
        private ListBox listBoxFollowers;
        private ListBox listBoxFollowing;
        private Label labelFollowingTitle;
        private Label labelFullNameTitle;
        private ListBox listBoxDifference;
        private Label labelDifferenceTitle;
        private Label labelFollowersCount;
        private Label labelFollowingCount;
        private Label labelDifferenceCount;
        private Button buttonRefresh;
        private Button buttonBlockAccountsFollowedByAnAccount;
        private Label labelBlockedUsersCountTitle;
        private Label labelBlockedUsersCount;
    }
}
