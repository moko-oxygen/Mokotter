namespace PseudOfficial
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGetPIN = new System.Windows.Forms.Button();
            this.textPIN = new System.Windows.Forms.TextBox();
            this.buttonInputPIN = new System.Windows.Forms.Button();
            this.textMyTweets = new System.Windows.Forms.TextBox();
            this.buttonTweet = new System.Windows.Forms.Button();
            this.textTweet = new System.Windows.Forms.TextBox();
            this.textPublicTimeline = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGetTimeline = new System.Windows.Forms.Button();
            this.textConsumerSecret = new System.Windows.Forms.TextBox();
            this.textConsumerKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGetPIN
            // 
            this.buttonGetPIN.Location = new System.Drawing.Point(711, 99);
            this.buttonGetPIN.Name = "buttonGetPIN";
            this.buttonGetPIN.Size = new System.Drawing.Size(130, 23);
            this.buttonGetPIN.TabIndex = 4;
            this.buttonGetPIN.Text = "トークンを取りなおす";
            this.buttonGetPIN.UseVisualStyleBackColor = true;
            this.buttonGetPIN.Click += new System.EventHandler(this.buttonGetPIN_Click);
            // 
            // textPIN
            // 
            this.textPIN.Location = new System.Drawing.Point(565, 143);
            this.textPIN.Name = "textPIN";
            this.textPIN.Size = new System.Drawing.Size(130, 19);
            this.textPIN.TabIndex = 7;
            // 
            // buttonInputPIN
            // 
            this.buttonInputPIN.Location = new System.Drawing.Point(711, 139);
            this.buttonInputPIN.Name = "buttonInputPIN";
            this.buttonInputPIN.Size = new System.Drawing.Size(130, 23);
            this.buttonInputPIN.TabIndex = 9;
            this.buttonInputPIN.Text = "PINにゅうりょく";
            this.buttonInputPIN.UseVisualStyleBackColor = true;
            this.buttonInputPIN.Click += new System.EventHandler(this.buttonInputPIN_Click);
            // 
            // textMyTweets
            // 
            this.textMyTweets.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textMyTweets.Location = new System.Drawing.Point(23, 221);
            this.textMyTweets.Multiline = true;
            this.textMyTweets.Name = "textMyTweets";
            this.textMyTweets.ReadOnly = true;
            this.textMyTweets.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textMyTweets.Size = new System.Drawing.Size(397, 256);
            this.textMyTweets.TabIndex = 10;
            // 
            // buttonTweet
            // 
            this.buttonTweet.Location = new System.Drawing.Point(364, 123);
            this.buttonTweet.Name = "buttonTweet";
            this.buttonTweet.Size = new System.Drawing.Size(72, 23);
            this.buttonTweet.TabIndex = 13;
            this.buttonTweet.Text = "投稿";
            this.buttonTweet.UseVisualStyleBackColor = true;
            this.buttonTweet.Click += new System.EventHandler(this.buttonTweet_Click);
            // 
            // textTweet
            // 
            this.textTweet.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textTweet.Location = new System.Drawing.Point(23, 18);
            this.textTweet.Multiline = true;
            this.textTweet.Name = "textTweet";
            this.textTweet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textTweet.Size = new System.Drawing.Size(413, 90);
            this.textTweet.TabIndex = 12;
            // 
            // textPublicTimeline
            // 
            this.textPublicTimeline.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textPublicTimeline.Location = new System.Drawing.Point(444, 221);
            this.textPublicTimeline.Multiline = true;
            this.textPublicTimeline.Name = "textPublicTimeline";
            this.textPublicTimeline.ReadOnly = true;
            this.textPublicTimeline.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textPublicTimeline.Size = new System.Drawing.Size(397, 256);
            this.textPublicTimeline.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "自分の投稿";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "タイムライン";
            // 
            // buttonGetTimeline
            // 
            this.buttonGetTimeline.Location = new System.Drawing.Point(769, 498);
            this.buttonGetTimeline.Name = "buttonGetTimeline";
            this.buttonGetTimeline.Size = new System.Drawing.Size(72, 23);
            this.buttonGetTimeline.TabIndex = 11;
            this.buttonGetTimeline.Text = "ぐるぐる";
            this.buttonGetTimeline.UseVisualStyleBackColor = true;
            this.buttonGetTimeline.Click += new System.EventHandler(this.buttonGetTimeline_Click);
            // 
            // textConsumerSecret
            // 
            this.textConsumerSecret.Location = new System.Drawing.Point(500, 74);
            this.textConsumerSecret.Name = "textConsumerSecret";
            this.textConsumerSecret.Size = new System.Drawing.Size(341, 19);
            this.textConsumerSecret.TabIndex = 18;
            // 
            // textConsumerKey
            // 
            this.textConsumerKey.Location = new System.Drawing.Point(500, 33);
            this.textConsumerKey.Name = "textConsumerKey";
            this.textConsumerKey.Size = new System.Drawing.Size(341, 19);
            this.textConsumerKey.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "ConsumerKey";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "ConsumerSecret";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "PIN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 584);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textConsumerKey);
            this.Controls.Add(this.textConsumerSecret);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPublicTimeline);
            this.Controls.Add(this.buttonTweet);
            this.Controls.Add(this.textTweet);
            this.Controls.Add(this.buttonGetTimeline);
            this.Controls.Add(this.textMyTweets);
            this.Controls.Add(this.buttonInputPIN);
            this.Controls.Add(this.textPIN);
            this.Controls.Add(this.buttonGetPIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGetPIN;
        private System.Windows.Forms.TextBox textPIN;
        private System.Windows.Forms.Button buttonInputPIN;
        private System.Windows.Forms.TextBox textMyTweets;
        private System.Windows.Forms.Button buttonTweet;
        private System.Windows.Forms.TextBox textTweet;
        private System.Windows.Forms.TextBox textPublicTimeline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGetTimeline;
        private System.Windows.Forms.TextBox textConsumerSecret;
        private System.Windows.Forms.TextBox textConsumerKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

