namespace AndroidQQ_8_4_1_4680_ECDH
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxClient = new System.Windows.Forms.GroupBox();
            this.btnClientGenKeys = new System.Windows.Forms.Button();
            this.txtClientPrikey = new System.Windows.Forms.TextBox();
            this.lblClientPrikey = new System.Windows.Forms.Label();
            this.txtClientPubkey = new System.Windows.Forms.TextBox();
            this.lblClientPubkey = new System.Windows.Forms.Label();
            this.gbxServer = new System.Windows.Forms.GroupBox();
            this.btnServerGenKeys = new System.Windows.Forms.Button();
            this.txtServerPrikey = new System.Windows.Forms.TextBox();
            this.lblServerPrikey = new System.Windows.Forms.Label();
            this.txtServerPubkey = new System.Windows.Forms.TextBox();
            this.lblServerPubkey = new System.Windows.Forms.Label();
            this.btnExchangePubkey = new System.Windows.Forms.Button();
            this.btnClientGenShakey = new System.Windows.Forms.Button();
            this.btnServerGenShakey = new System.Windows.Forms.Button();
            this.txtClientShakey = new System.Windows.Forms.TextBox();
            this.lblClientShakey = new System.Windows.Forms.Label();
            this.txtServerShakey = new System.Windows.Forms.TextBox();
            this.lblServerShakey = new System.Windows.Forms.Label();
            this.gbxClient.SuspendLayout();
            this.gbxServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxClient
            // 
            this.gbxClient.Controls.Add(this.txtClientShakey);
            this.gbxClient.Controls.Add(this.lblClientShakey);
            this.gbxClient.Controls.Add(this.btnClientGenShakey);
            this.gbxClient.Controls.Add(this.btnClientGenKeys);
            this.gbxClient.Controls.Add(this.txtClientPrikey);
            this.gbxClient.Controls.Add(this.lblClientPrikey);
            this.gbxClient.Controls.Add(this.txtClientPubkey);
            this.gbxClient.Controls.Add(this.lblClientPubkey);
            this.gbxClient.Location = new System.Drawing.Point(12, 12);
            this.gbxClient.Name = "gbxClient";
            this.gbxClient.Size = new System.Drawing.Size(492, 359);
            this.gbxClient.TabIndex = 0;
            this.gbxClient.TabStop = false;
            this.gbxClient.Text = "客户端";
            // 
            // btnClientGenKeys
            // 
            this.btnClientGenKeys.Location = new System.Drawing.Point(162, 115);
            this.btnClientGenKeys.Name = "btnClientGenKeys";
            this.btnClientGenKeys.Size = new System.Drawing.Size(131, 37);
            this.btnClientGenKeys.TabIndex = 4;
            this.btnClientGenKeys.Text = "1.生成公钥与私钥";
            this.btnClientGenKeys.UseVisualStyleBackColor = true;
            this.btnClientGenKeys.Click += new System.EventHandler(this.BtnClientGenKeys_Click);
            // 
            // txtClientPrikey
            // 
            this.txtClientPrikey.Location = new System.Drawing.Point(53, 75);
            this.txtClientPrikey.Name = "txtClientPrikey";
            this.txtClientPrikey.Size = new System.Drawing.Size(433, 21);
            this.txtClientPrikey.TabIndex = 3;
            // 
            // lblClientPrikey
            // 
            this.lblClientPrikey.AutoSize = true;
            this.lblClientPrikey.Location = new System.Drawing.Point(6, 78);
            this.lblClientPrikey.Name = "lblClientPrikey";
            this.lblClientPrikey.Size = new System.Drawing.Size(41, 12);
            this.lblClientPrikey.TabIndex = 2;
            this.lblClientPrikey.Text = "私钥：";
            // 
            // txtClientPubkey
            // 
            this.txtClientPubkey.Location = new System.Drawing.Point(53, 30);
            this.txtClientPubkey.Name = "txtClientPubkey";
            this.txtClientPubkey.Size = new System.Drawing.Size(433, 21);
            this.txtClientPubkey.TabIndex = 1;
            // 
            // lblClientPubkey
            // 
            this.lblClientPubkey.AutoSize = true;
            this.lblClientPubkey.Location = new System.Drawing.Point(6, 33);
            this.lblClientPubkey.Name = "lblClientPubkey";
            this.lblClientPubkey.Size = new System.Drawing.Size(41, 12);
            this.lblClientPubkey.TabIndex = 0;
            this.lblClientPubkey.Text = "公钥：";
            // 
            // gbxServer
            // 
            this.gbxServer.Controls.Add(this.txtServerShakey);
            this.gbxServer.Controls.Add(this.lblServerShakey);
            this.gbxServer.Controls.Add(this.btnServerGenShakey);
            this.gbxServer.Controls.Add(this.btnServerGenKeys);
            this.gbxServer.Controls.Add(this.txtServerPrikey);
            this.gbxServer.Controls.Add(this.lblServerPrikey);
            this.gbxServer.Controls.Add(this.txtServerPubkey);
            this.gbxServer.Controls.Add(this.lblServerPubkey);
            this.gbxServer.Location = new System.Drawing.Point(510, 12);
            this.gbxServer.Name = "gbxServer";
            this.gbxServer.Size = new System.Drawing.Size(492, 359);
            this.gbxServer.TabIndex = 1;
            this.gbxServer.TabStop = false;
            this.gbxServer.Text = "服务端";
            // 
            // btnServerGenKeys
            // 
            this.btnServerGenKeys.Location = new System.Drawing.Point(194, 114);
            this.btnServerGenKeys.Name = "btnServerGenKeys";
            this.btnServerGenKeys.Size = new System.Drawing.Size(131, 37);
            this.btnServerGenKeys.TabIndex = 8;
            this.btnServerGenKeys.Text = "2.生成公钥与私钥";
            this.btnServerGenKeys.UseVisualStyleBackColor = true;
            this.btnServerGenKeys.Click += new System.EventHandler(this.BtnServerGenKeys_Click);
            // 
            // txtServerPrikey
            // 
            this.txtServerPrikey.Location = new System.Drawing.Point(53, 74);
            this.txtServerPrikey.Name = "txtServerPrikey";
            this.txtServerPrikey.Size = new System.Drawing.Size(433, 21);
            this.txtServerPrikey.TabIndex = 7;
            // 
            // lblServerPrikey
            // 
            this.lblServerPrikey.AutoSize = true;
            this.lblServerPrikey.Location = new System.Drawing.Point(6, 77);
            this.lblServerPrikey.Name = "lblServerPrikey";
            this.lblServerPrikey.Size = new System.Drawing.Size(41, 12);
            this.lblServerPrikey.TabIndex = 6;
            this.lblServerPrikey.Text = "私钥：";
            // 
            // txtServerPubkey
            // 
            this.txtServerPubkey.Location = new System.Drawing.Point(53, 29);
            this.txtServerPubkey.Name = "txtServerPubkey";
            this.txtServerPubkey.Size = new System.Drawing.Size(433, 21);
            this.txtServerPubkey.TabIndex = 5;
            // 
            // lblServerPubkey
            // 
            this.lblServerPubkey.AutoSize = true;
            this.lblServerPubkey.Location = new System.Drawing.Point(6, 32);
            this.lblServerPubkey.Name = "lblServerPubkey";
            this.lblServerPubkey.Size = new System.Drawing.Size(41, 12);
            this.lblServerPubkey.TabIndex = 4;
            this.lblServerPubkey.Text = "公钥：";
            // 
            // btnExchangePubkey
            // 
            this.btnExchangePubkey.Location = new System.Drawing.Point(443, 183);
            this.btnExchangePubkey.Name = "btnExchangePubkey";
            this.btnExchangePubkey.Size = new System.Drawing.Size(131, 37);
            this.btnExchangePubkey.TabIndex = 5;
            this.btnExchangePubkey.Text = "3.交换公钥";
            this.btnExchangePubkey.UseVisualStyleBackColor = true;
            this.btnExchangePubkey.Click += new System.EventHandler(this.BtnExchangePubkey_Click);
            // 
            // btnClientGenShakey
            // 
            this.btnClientGenShakey.Location = new System.Drawing.Point(162, 306);
            this.btnClientGenShakey.Name = "btnClientGenShakey";
            this.btnClientGenShakey.Size = new System.Drawing.Size(131, 37);
            this.btnClientGenShakey.TabIndex = 6;
            this.btnClientGenShakey.Text = "4.生成协商秘钥";
            this.btnClientGenShakey.UseVisualStyleBackColor = true;
            this.btnClientGenShakey.Click += new System.EventHandler(this.BtnClientGenShakey_Click);
            // 
            // btnServerGenShakey
            // 
            this.btnServerGenShakey.Location = new System.Drawing.Point(194, 306);
            this.btnServerGenShakey.Name = "btnServerGenShakey";
            this.btnServerGenShakey.Size = new System.Drawing.Size(131, 37);
            this.btnServerGenShakey.TabIndex = 9;
            this.btnServerGenShakey.Text = "5.生成协商秘钥";
            this.btnServerGenShakey.UseVisualStyleBackColor = true;
            this.btnServerGenShakey.Click += new System.EventHandler(this.BtnServerGenShakey_Click);
            // 
            // txtClientShakey
            // 
            this.txtClientShakey.Location = new System.Drawing.Point(53, 251);
            this.txtClientShakey.Name = "txtClientShakey";
            this.txtClientShakey.Size = new System.Drawing.Size(433, 21);
            this.txtClientShakey.TabIndex = 8;
            // 
            // lblClientShakey
            // 
            this.lblClientShakey.AutoSize = true;
            this.lblClientShakey.Location = new System.Drawing.Point(6, 254);
            this.lblClientShakey.Name = "lblClientShakey";
            this.lblClientShakey.Size = new System.Drawing.Size(53, 12);
            this.lblClientShakey.TabIndex = 7;
            this.lblClientShakey.Text = "shakey：";
            // 
            // txtServerShakey
            // 
            this.txtServerShakey.Location = new System.Drawing.Point(53, 251);
            this.txtServerShakey.Name = "txtServerShakey";
            this.txtServerShakey.Size = new System.Drawing.Size(433, 21);
            this.txtServerShakey.TabIndex = 11;
            // 
            // lblServerShakey
            // 
            this.lblServerShakey.AutoSize = true;
            this.lblServerShakey.Location = new System.Drawing.Point(6, 254);
            this.lblServerShakey.Name = "lblServerShakey";
            this.lblServerShakey.Size = new System.Drawing.Size(53, 12);
            this.lblServerShakey.TabIndex = 10;
            this.lblServerShakey.Text = "shakey：";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 379);
            this.Controls.Add(this.btnExchangePubkey);
            this.Controls.Add(this.gbxServer);
            this.Controls.Add(this.gbxClient);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "安卓QQ 8.4.1.4680 椭圆曲线算法(ECDH)";
            this.gbxClient.ResumeLayout(false);
            this.gbxClient.PerformLayout();
            this.gbxServer.ResumeLayout(false);
            this.gbxServer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxClient;
        private System.Windows.Forms.GroupBox gbxServer;
        private System.Windows.Forms.TextBox txtClientPrikey;
        private System.Windows.Forms.Label lblClientPrikey;
        private System.Windows.Forms.TextBox txtClientPubkey;
        private System.Windows.Forms.Label lblClientPubkey;
        private System.Windows.Forms.TextBox txtServerPrikey;
        private System.Windows.Forms.Label lblServerPrikey;
        private System.Windows.Forms.TextBox txtServerPubkey;
        private System.Windows.Forms.Label lblServerPubkey;
        private System.Windows.Forms.Button btnClientGenKeys;
        private System.Windows.Forms.Button btnServerGenKeys;
        private System.Windows.Forms.Button btnExchangePubkey;
        private System.Windows.Forms.Button btnClientGenShakey;
        private System.Windows.Forms.Button btnServerGenShakey;
        private System.Windows.Forms.TextBox txtClientShakey;
        private System.Windows.Forms.Label lblClientShakey;
        private System.Windows.Forms.TextBox txtServerShakey;
        private System.Windows.Forms.Label lblServerShakey;
    }
}

