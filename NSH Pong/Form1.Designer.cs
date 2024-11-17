
namespace NSH_Pong
{
    partial class Form1
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
            this.labelHS_MP = new System.Windows.Forms.Label();
            this.labelIntro = new System.Windows.Forms.Label();
            this.buttonStartMPSM = new System.Windows.Forms.Button();
            this.buttonStartMPEM = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMInfo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelUpScore = new System.Windows.Forms.Label();
            this.labelLowScore = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHS_MP
            // 
            this.labelHS_MP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHS_MP.AutoSize = true;
            this.labelHS_MP.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHS_MP.ForeColor = System.Drawing.Color.White;
            this.labelHS_MP.Location = new System.Drawing.Point(27, 29);
            this.labelHS_MP.Name = "labelHS_MP";
            this.labelHS_MP.Size = new System.Drawing.Size(356, 54);
            this.labelHS_MP.TabIndex = 2;
            this.labelHS_MP.Text = "Highscore of multiplayer: ";
            // 
            // labelIntro
            // 
            this.labelIntro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIntro.AutoSize = true;
            this.labelIntro.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntro.ForeColor = System.Drawing.Color.White;
            this.labelIntro.Location = new System.Drawing.Point(18, 253);
            this.labelIntro.Name = "labelIntro";
            this.labelIntro.Size = new System.Drawing.Size(417, 54);
            this.labelIntro.TabIndex = 3;
            this.labelIntro.Text = "* Press Esc to end score mode";
            // 
            // buttonStartMPSM
            // 
            this.buttonStartMPSM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStartMPSM.BackColor = System.Drawing.Color.White;
            this.buttonStartMPSM.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartMPSM.Location = new System.Drawing.Point(203, 151);
            this.buttonStartMPSM.Name = "buttonStartMPSM";
            this.buttonStartMPSM.Size = new System.Drawing.Size(95, 45);
            this.buttonStartMPSM.TabIndex = 0;
            this.buttonStartMPSM.TabStop = false;
            this.buttonStartMPSM.Text = "Score";
            this.buttonStartMPSM.UseVisualStyleBackColor = false;
            this.buttonStartMPSM.Click += new System.EventHandler(this.buttonStartMPSM_Click);
            // 
            // buttonStartMPEM
            // 
            this.buttonStartMPEM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStartMPEM.BackColor = System.Drawing.Color.White;
            this.buttonStartMPEM.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartMPEM.Location = new System.Drawing.Point(313, 151);
            this.buttonStartMPEM.Name = "buttonStartMPEM";
            this.buttonStartMPEM.Size = new System.Drawing.Size(95, 45);
            this.buttonStartMPEM.TabIndex = 4;
            this.buttonStartMPEM.TabStop = false;
            this.buttonStartMPEM.Text = "Extreme";
            this.buttonStartMPEM.UseVisualStyleBackColor = false;
            this.buttonStartMPEM.Click += new System.EventHandler(this.buttonStartMPEM_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Magneto", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(25, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(430, 129);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "PONG";
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(3, 307);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(444, 54);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = "* Extreme mode ends by scoring";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.labelHS_MP);
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Controls.Add(this.buttonStartMPEM);
            this.panel1.Controls.Add(this.labelIntro);
            this.panel1.Controls.Add(this.labelMInfo);
            this.panel1.Controls.Add(this.buttonStartMPSM);
            this.panel1.Location = new System.Drawing.Point(20, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 407);
            this.panel1.TabIndex = 5;
            // 
            // labelMInfo
            // 
            this.labelMInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMInfo.Font = new System.Drawing.Font("Dubai", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMInfo.ForeColor = System.Drawing.Color.White;
            this.labelMInfo.Location = new System.Drawing.Point(27, 147);
            this.labelMInfo.Name = "labelMInfo";
            this.labelMInfo.Size = new System.Drawing.Size(170, 54);
            this.labelMInfo.TabIndex = 1;
            this.labelMInfo.Text = "Multiplayer: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 80;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelUpScore
            // 
            this.labelUpScore.AutoSize = true;
            this.labelUpScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpScore.ForeColor = System.Drawing.Color.White;
            this.labelUpScore.Location = new System.Drawing.Point(461, 241);
            this.labelUpScore.Name = "labelUpScore";
            this.labelUpScore.Size = new System.Drawing.Size(29, 31);
            this.labelUpScore.TabIndex = 5;
            this.labelUpScore.Text = "0";
            this.labelUpScore.Visible = false;
            // 
            // labelLowScore
            // 
            this.labelLowScore.AutoSize = true;
            this.labelLowScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLowScore.ForeColor = System.Drawing.Color.White;
            this.labelLowScore.Location = new System.Drawing.Point(461, 272);
            this.labelLowScore.Name = "labelLowScore";
            this.labelLowScore.Size = new System.Drawing.Size(29, 31);
            this.labelLowScore.TabIndex = 5;
            this.labelLowScore.Text = "0";
            this.labelLowScore.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.labelLowScore);
            this.Controls.Add(this.labelUpScore);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::NSH_Pong.Properties.Resources.Ping;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelHS_MP;
        private System.Windows.Forms.Button buttonStartMPEM;
        private System.Windows.Forms.Label labelIntro;
        private System.Windows.Forms.Button buttonStartMPSM;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMInfo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelUpScore;
        private System.Windows.Forms.Label labelLowScore;
    }
}

