namespace FBApp.Forms
{
    public partial class FacebookAppForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacebookAppForm));
            this.tabControlProfile = new System.Windows.Forms.TabControl();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.panelBirthdays = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lableTomorrowBirthdays = new System.Windows.Forms.Label();
            this.lableTodayBirthdays = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelUserDetails = new System.Windows.Forms.Panel();
            this.labelFriendStatus = new System.Windows.Forms.Label();
            this.labelFullFriendDetails = new System.Windows.Forms.Label();
            this.pictureBoxSelectedFriend = new System.Windows.Forms.PictureBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.friendListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPrivacy = new System.Windows.Forms.ComboBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelPostStatus = new System.Windows.Forms.Label();
            this.tabPageMultiGroupPost = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonPostToGoups = new System.Windows.Forms.Button();
            this.labelPostToGroups = new System.Windows.Forms.Label();
            this.textBoxGroupsPost = new System.Windows.Forms.TextBox();
            this.labelSelectGroups = new System.Windows.Forms.Label();
            this.groupsBox = new System.Windows.Forms.ListBox();
            this.loggedInUserGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelMultipleGroupMessage = new System.Windows.Forms.Label();
            this.tabPageMusicPlaylist = new System.Windows.Forms.TabPage();
            this.listBoxMusic = new System.Windows.Forms.ListBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelNoPlaylists = new System.Windows.Forms.Label();
            this.axShockwaveFlashPlayer = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.labelMusic = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMyStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.facebookAppLogicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlProfile.SuspendLayout();
            this.tabPageProfile.SuspendLayout();
            this.panelBirthdays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelUserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).BeginInit();
            this.tabPageMultiGroupPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loggedInUserGroupsBindingSource)).BeginInit();
            this.tabPageMusicPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlashPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookAppLogicBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlProfile
            // 
            resources.ApplyResources(this.tabControlProfile, "tabControlProfile");
            this.tabControlProfile.Controls.Add(this.tabPageProfile);
            this.tabControlProfile.Controls.Add(this.tabPageMultiGroupPost);
            this.tabControlProfile.Controls.Add(this.tabPageMusicPlaylist);
            this.tabControlProfile.Name = "tabControlProfile";
            this.tabControlProfile.SelectedIndex = 0;
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.BackColor = System.Drawing.Color.Black;
            this.tabPageProfile.BackgroundImage = global::FBApp.Properties.Resources.FBackground;
            resources.ApplyResources(this.tabPageProfile, "tabPageProfile");
            this.tabPageProfile.Controls.Add(this.panelBirthdays);
            this.tabPageProfile.Controls.Add(this.label2);
            this.tabPageProfile.Controls.Add(this.panelUserDetails);
            this.tabPageProfile.Controls.Add(this.listBoxFriends);
            this.tabPageProfile.Controls.Add(this.label1);
            this.tabPageProfile.Controls.Add(this.comboBoxPrivacy);
            this.tabPageProfile.Controls.Add(this.buttonPost);
            this.tabPageProfile.Controls.Add(this.textBoxStatus);
            this.tabPageProfile.Controls.Add(this.labelPostStatus);
            this.tabPageProfile.ForeColor = System.Drawing.Color.Transparent;
            this.tabPageProfile.Name = "tabPageProfile";
            // 
            // panelBirthdays
            // 
            this.panelBirthdays.BackColor = System.Drawing.Color.Transparent;
            this.panelBirthdays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBirthdays.Controls.Add(this.pictureBox1);
            this.panelBirthdays.Controls.Add(this.lableTomorrowBirthdays);
            this.panelBirthdays.Controls.Add(this.lableTodayBirthdays);
            resources.ApplyResources(this.panelBirthdays, "panelBirthdays");
            this.panelBirthdays.Name = "panelBirthdays";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lableTomorrowBirthdays
            // 
            resources.ApplyResources(this.lableTomorrowBirthdays, "lableTomorrowBirthdays");
            this.lableTomorrowBirthdays.Name = "lableTomorrowBirthdays";
            // 
            // lableTodayBirthdays
            // 
            resources.ApplyResources(this.lableTodayBirthdays, "lableTodayBirthdays");
            this.lableTodayBirthdays.Name = "lableTodayBirthdays";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // panelUserDetails
            // 
            resources.ApplyResources(this.panelUserDetails, "panelUserDetails");
            this.panelUserDetails.BackColor = System.Drawing.Color.Transparent;
            this.panelUserDetails.Controls.Add(this.labelFriendStatus);
            this.panelUserDetails.Controls.Add(this.labelFullFriendDetails);
            this.panelUserDetails.Controls.Add(this.pictureBoxSelectedFriend);
            this.panelUserDetails.ForeColor = System.Drawing.Color.Black;
            this.panelUserDetails.Name = "panelUserDetails";
            // 
            // labelFriendStatus
            // 
            resources.ApplyResources(this.labelFriendStatus, "labelFriendStatus");
            this.labelFriendStatus.ForeColor = System.Drawing.Color.Chocolate;
            this.labelFriendStatus.Name = "labelFriendStatus";
            // 
            // labelFullFriendDetails
            // 
            resources.ApplyResources(this.labelFullFriendDetails, "labelFullFriendDetails");
            this.labelFullFriendDetails.ForeColor = System.Drawing.Color.Black;
            this.labelFullFriendDetails.Name = "labelFullFriendDetails";
            // 
            // pictureBoxSelectedFriend
            // 
            this.pictureBoxSelectedFriend.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBoxSelectedFriend, "pictureBoxSelectedFriend");
            this.pictureBoxSelectedFriend.Name = "pictureBoxSelectedFriend";
            this.pictureBoxSelectedFriend.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.DataSource = this.friendListBindingSource;
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxFriends, "listBoxFriends");
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Sorted = true;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // comboBoxPrivacy
            // 
            this.comboBoxPrivacy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrivacy.FormattingEnabled = true;
            this.comboBoxPrivacy.Items.AddRange(new object[] {
            resources.GetString("comboBoxPrivacy.Items"),
            resources.GetString("comboBoxPrivacy.Items1"),
            resources.GetString("comboBoxPrivacy.Items2")});
            resources.ApplyResources(this.comboBoxPrivacy, "comboBoxPrivacy");
            this.comboBoxPrivacy.Name = "comboBoxPrivacy";
            // 
            // buttonPost
            // 
            resources.ApplyResources(this.buttonPost, "buttonPost");
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxStatus
            // 
            resources.ApplyResources(this.textBoxStatus, "textBoxStatus");
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.TextChanged += new System.EventHandler(this.textBoxStatus_TextChanged);
            // 
            // labelPostStatus
            // 
            resources.ApplyResources(this.labelPostStatus, "labelPostStatus");
            this.labelPostStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelPostStatus.Name = "labelPostStatus";
            // 
            // tabPageMultiGroupPost
            // 
            this.tabPageMultiGroupPost.BackgroundImage = global::FBApp.Properties.Resources.FBackground;
            resources.ApplyResources(this.tabPageMultiGroupPost, "tabPageMultiGroupPost");
            this.tabPageMultiGroupPost.Controls.Add(this.pictureBox2);
            this.tabPageMultiGroupPost.Controls.Add(this.buttonPostToGoups);
            this.tabPageMultiGroupPost.Controls.Add(this.labelPostToGroups);
            this.tabPageMultiGroupPost.Controls.Add(this.textBoxGroupsPost);
            this.tabPageMultiGroupPost.Controls.Add(this.labelSelectGroups);
            this.tabPageMultiGroupPost.Controls.Add(this.groupsBox);
            this.tabPageMultiGroupPost.Controls.Add(this.labelMultipleGroupMessage);
            this.tabPageMultiGroupPost.Name = "tabPageMultiGroupPost";
            this.tabPageMultiGroupPost.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FBApp.Properties.Resources.envelopes;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // buttonPostToGoups
            // 
            resources.ApplyResources(this.buttonPostToGoups, "buttonPostToGoups");
            this.buttonPostToGoups.Name = "buttonPostToGoups";
            this.buttonPostToGoups.UseVisualStyleBackColor = true;
            this.buttonPostToGoups.Click += new System.EventHandler(this.buttonPostToGroups_Click);
            // 
            // labelPostToGroups
            // 
            resources.ApplyResources(this.labelPostToGroups, "labelPostToGroups");
            this.labelPostToGroups.ForeColor = System.Drawing.Color.White;
            this.labelPostToGroups.Name = "labelPostToGroups";
            // 
            // textBoxGroupsPost
            // 
            resources.ApplyResources(this.textBoxGroupsPost, "textBoxGroupsPost");
            this.textBoxGroupsPost.Name = "textBoxGroupsPost";
            this.textBoxGroupsPost.TextChanged += new System.EventHandler(this.textBoxGroupsPost_TextChanged);
            // 
            // labelSelectGroups
            // 
            resources.ApplyResources(this.labelSelectGroups, "labelSelectGroups");
            this.labelSelectGroups.ForeColor = System.Drawing.Color.White;
            this.labelSelectGroups.Name = "labelSelectGroups";
            // 
            // groupsBox
            // 
            this.groupsBox.DataSource = this.loggedInUserGroupsBindingSource;
            this.groupsBox.DisplayMember = "Name";
            resources.ApplyResources(this.groupsBox, "groupsBox");
            this.groupsBox.FormattingEnabled = true;
            this.groupsBox.Name = "groupsBox";
            this.groupsBox.Sorted = true;
            this.groupsBox.SelectedIndexChanged += new System.EventHandler(this.groupsBox_SelectedIndexChanged);
            // 
            // loggedInUserGroupsBindingSource
            // 
            this.loggedInUserGroupsBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
            // 
            // labelMultipleGroupMessage
            // 
            resources.ApplyResources(this.labelMultipleGroupMessage, "labelMultipleGroupMessage");
            this.labelMultipleGroupMessage.ForeColor = System.Drawing.Color.White;
            this.labelMultipleGroupMessage.Name = "labelMultipleGroupMessage";
            // 
            // tabPageMusicPlaylist
            // 
            this.tabPageMusicPlaylist.BackgroundImage = global::FBApp.Properties.Resources.FBackground;
            this.tabPageMusicPlaylist.Controls.Add(this.listBoxMusic);
            this.tabPageMusicPlaylist.Controls.Add(this.labelNoPlaylists);
            this.tabPageMusicPlaylist.Controls.Add(this.axShockwaveFlashPlayer);
            this.tabPageMusicPlaylist.Controls.Add(this.labelMusic);
            this.tabPageMusicPlaylist.Controls.Add(this.pictureBox3);
            resources.ApplyResources(this.tabPageMusicPlaylist, "tabPageMusicPlaylist");
            this.tabPageMusicPlaylist.Name = "tabPageMusicPlaylist";
            this.tabPageMusicPlaylist.UseVisualStyleBackColor = true;
            // 
            // listBoxMusic
            // 
            this.listBoxMusic.DataSource = this.pageBindingSource;
            this.listBoxMusic.DisplayMember = "Name";
            this.listBoxMusic.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxMusic, "listBoxMusic");
            this.listBoxMusic.Name = "listBoxMusic";
            this.listBoxMusic.Sorted = true;
            this.listBoxMusic.SelectedIndexChanged += new System.EventHandler(this.listBoxMusic_SelectedIndexChanged);
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // labelNoPlaylists
            // 
            resources.ApplyResources(this.labelNoPlaylists, "labelNoPlaylists");
            this.labelNoPlaylists.ForeColor = System.Drawing.Color.Transparent;
            this.labelNoPlaylists.Image = global::FBApp.Properties.Resources.tape;
            this.labelNoPlaylists.Name = "labelNoPlaylists";
            this.labelNoPlaylists.UseCompatibleTextRendering = true;
            // 
            // axShockwaveFlashPlayer
            // 
            resources.ApplyResources(this.axShockwaveFlashPlayer, "axShockwaveFlashPlayer");
            this.axShockwaveFlashPlayer.Name = "axShockwaveFlashPlayer";
            this.axShockwaveFlashPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlashPlayer.OcxState")));
            // 
            // labelMusic
            // 
            resources.ApplyResources(this.labelMusic, "labelMusic");
            this.labelMusic.ForeColor = System.Drawing.Color.Transparent;
            this.labelMusic.Name = "labelMusic";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FBApp.Properties.Resources.eaceonnT4;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBoxProfilePicture, "pictureBoxProfilePicture");
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // labelName
            // 
            resources.ApplyResources(this.labelName, "labelName");
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Name = "labelName";
            // 
            // labelMyStatus
            // 
            resources.ApplyResources(this.labelMyStatus, "labelMyStatus");
            this.labelMyStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelMyStatus.ForeColor = System.Drawing.Color.Black;
            this.labelMyStatus.Name = "labelMyStatus";
            // 
            // facebookAppLogicBindingSource
            // 
            this.facebookAppLogicBindingSource.DataSource = typeof(FBApp.FacebookAppLogic);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            resources.ApplyResources(this.toolStripStatusLabel, "toolStripStatusLabel");
            // 
            // FacebookAppForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::FBApp.Properties.Resources.FBackground;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Controls.Add(this.labelMyStatus);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.tabControlProfile);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FacebookAppForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.tabControlProfile.ResumeLayout(false);
            this.tabPageProfile.ResumeLayout(false);
            this.tabPageProfile.PerformLayout();
            this.panelBirthdays.ResumeLayout(false);
            this.panelBirthdays.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelUserDetails.ResumeLayout(false);
            this.panelUserDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).EndInit();
            this.tabPageMultiGroupPost.ResumeLayout(false);
            this.tabPageMultiGroupPost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loggedInUserGroupsBindingSource)).EndInit();
            this.tabPageMusicPlaylist.ResumeLayout(false);
            this.tabPageMusicPlaylist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlashPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookAppLogicBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlProfile;
        private System.Windows.Forms.TabPage tabPageProfile;
        private System.Windows.Forms.TabPage tabPageMultiGroupPost;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelPostStatus;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.ComboBox comboBoxPrivacy;
        private System.Windows.Forms.PictureBox pictureBoxSelectedFriend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Panel panelUserDetails;
        private System.Windows.Forms.Label labelFullFriendDetails;
        private System.Windows.Forms.Label labelFriendStatus;
        private System.Windows.Forms.Label labelMyStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBirthdays;
        private System.Windows.Forms.Label lableTomorrowBirthdays;
        private System.Windows.Forms.Label lableTodayBirthdays;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxGroupsPost;
        private System.Windows.Forms.Label labelSelectGroups;
        private System.Windows.Forms.ListBox groupsBox;
        private System.Windows.Forms.Label labelMultipleGroupMessage;
        private System.Windows.Forms.Button buttonPostToGoups;
        private System.Windows.Forms.Label labelPostToGroups;
        private System.Windows.Forms.TabPage tabPageMusicPlaylist;
        private System.Windows.Forms.Label labelMusic;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlashPlayer;
        private System.Windows.Forms.Label labelNoPlaylists;
        private System.Windows.Forms.BindingSource loggedInUserGroupsBindingSource;
        private System.Windows.Forms.BindingSource friendListBindingSource;
        private System.Windows.Forms.BindingSource facebookAppLogicBindingSource;
        private System.Windows.Forms.ListBox listBoxMusic;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}