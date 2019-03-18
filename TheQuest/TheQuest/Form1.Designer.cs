namespace TheQuest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moveDown = new System.Windows.Forms.Button();
            this.moveRight = new System.Windows.Forms.Button();
            this.moveLeft = new System.Windows.Forms.Button();
            this.moveUp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.attackDown = new System.Windows.Forms.Button();
            this.attackLeft = new System.Windows.Forms.Button();
            this.attackRight = new System.Windows.Forms.Button();
            this.attackUp = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ghoulHitPoints = new System.Windows.Forms.Label();
            this.ghostHitPoints = new System.Windows.Forms.Label();
            this.ghostLabel = new System.Windows.Forms.Label();
            this.batHitPoints = new System.Windows.Forms.Label();
            this.batLabel = new System.Windows.Forms.Label();
            this.playerHitPoints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ghoulLabel = new System.Windows.Forms.Label();
            this.playerIcon = new System.Windows.Forms.PictureBox();
            this.swordIcon = new System.Windows.Forms.PictureBox();
            this.batIcon = new System.Windows.Forms.PictureBox();
            this.ghoulIcon = new System.Windows.Forms.PictureBox();
            this.ghostIcon = new System.Windows.Forms.PictureBox();
            this.bowIcon = new System.Windows.Forms.PictureBox();
            this.bluePotionIcon = new System.Windows.Forms.PictureBox();
            this.redPotionIcon = new System.Windows.Forms.PictureBox();
            this.maceIcon = new System.Windows.Forms.PictureBox();
            this.inventorySword = new System.Windows.Forms.PictureBox();
            this.inventoryBow = new System.Windows.Forms.PictureBox();
            this.inventoryMace = new System.Windows.Forms.PictureBox();
            this.inventoryBluePotion = new System.Windows.Forms.PictureBox();
            this.inventoryRedPotion = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoulIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryRedPotion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.moveDown);
            this.groupBox1.Controls.Add(this.moveRight);
            this.groupBox1.Controls.Add(this.moveLeft);
            this.groupBox1.Controls.Add(this.moveUp);
            this.groupBox1.Location = new System.Drawing.Point(414, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move";
            // 
            // moveDown
            // 
            this.moveDown.Location = new System.Drawing.Point(39, 62);
            this.moveDown.Name = "moveDown";
            this.moveDown.Size = new System.Drawing.Size(30, 23);
            this.moveDown.TabIndex = 3;
            this.moveDown.Text = "↓";
            this.moveDown.UseVisualStyleBackColor = true;
            this.moveDown.Click += new System.EventHandler(this.moveDown_Click);
            // 
            // moveRight
            // 
            this.moveRight.Location = new System.Drawing.Point(70, 48);
            this.moveRight.Name = "moveRight";
            this.moveRight.Size = new System.Drawing.Size(30, 23);
            this.moveRight.TabIndex = 2;
            this.moveRight.Text = "→";
            this.moveRight.UseVisualStyleBackColor = true;
            this.moveRight.Click += new System.EventHandler(this.moveRight_Click);
            // 
            // moveLeft
            // 
            this.moveLeft.Location = new System.Drawing.Point(9, 47);
            this.moveLeft.Name = "moveLeft";
            this.moveLeft.Size = new System.Drawing.Size(30, 23);
            this.moveLeft.TabIndex = 1;
            this.moveLeft.Text = "←";
            this.moveLeft.UseVisualStyleBackColor = true;
            this.moveLeft.Click += new System.EventHandler(this.moveLeft_Click);
            // 
            // moveUp
            // 
            this.moveUp.Location = new System.Drawing.Point(40, 32);
            this.moveUp.Name = "moveUp";
            this.moveUp.Size = new System.Drawing.Size(30, 23);
            this.moveUp.TabIndex = 0;
            this.moveUp.Text = "↑";
            this.moveUp.UseVisualStyleBackColor = true;
            this.moveUp.Click += new System.EventHandler(this.moveUp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.attackDown);
            this.groupBox2.Controls.Add(this.attackLeft);
            this.groupBox2.Controls.Add(this.attackRight);
            this.groupBox2.Controls.Add(this.attackUp);
            this.groupBox2.Location = new System.Drawing.Point(534, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(111, 102);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attack";
            // 
            // attackDown
            // 
            this.attackDown.Location = new System.Drawing.Point(36, 62);
            this.attackDown.Name = "attackDown";
            this.attackDown.Size = new System.Drawing.Size(30, 23);
            this.attackDown.TabIndex = 7;
            this.attackDown.Text = "↓";
            this.attackDown.UseVisualStyleBackColor = true;
            this.attackDown.Click += new System.EventHandler(this.attackDown_Click);
            // 
            // attackLeft
            // 
            this.attackLeft.Location = new System.Drawing.Point(6, 47);
            this.attackLeft.Name = "attackLeft";
            this.attackLeft.Size = new System.Drawing.Size(30, 23);
            this.attackLeft.TabIndex = 6;
            this.attackLeft.Text = "←";
            this.attackLeft.UseVisualStyleBackColor = true;
            this.attackLeft.Click += new System.EventHandler(this.attackLeft_Click);
            // 
            // attackRight
            // 
            this.attackRight.Location = new System.Drawing.Point(67, 47);
            this.attackRight.Name = "attackRight";
            this.attackRight.Size = new System.Drawing.Size(30, 23);
            this.attackRight.TabIndex = 5;
            this.attackRight.Text = "→";
            this.attackRight.UseVisualStyleBackColor = true;
            this.attackRight.Click += new System.EventHandler(this.attackRight_Click);
            // 
            // attackUp
            // 
            this.attackUp.Location = new System.Drawing.Point(36, 32);
            this.attackUp.Name = "attackUp";
            this.attackUp.Size = new System.Drawing.Size(30, 23);
            this.attackUp.TabIndex = 4;
            this.attackUp.Text = "↑";
            this.attackUp.UseVisualStyleBackColor = true;
            this.attackUp.Click += new System.EventHandler(this.attackUp_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.22222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.77778F));
            this.tableLayoutPanel1.Controls.Add(this.ghoulHitPoints, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ghostHitPoints, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ghostLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.batHitPoints, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.batLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.playerHitPoints, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ghoulLabel, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(534, 266);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(180, 71);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ghoulHitPoints
            // 
            this.ghoulHitPoints.AutoSize = true;
            this.ghoulHitPoints.Location = new System.Drawing.Point(51, 51);
            this.ghoulHitPoints.Name = "ghoulHitPoints";
            this.ghoulHitPoints.Size = new System.Drawing.Size(0, 13);
            this.ghoulHitPoints.TabIndex = 7;
            // 
            // ghostHitPoints
            // 
            this.ghostHitPoints.AutoSize = true;
            this.ghostHitPoints.Location = new System.Drawing.Point(51, 34);
            this.ghostHitPoints.Name = "ghostHitPoints";
            this.ghostHitPoints.Size = new System.Drawing.Size(0, 13);
            this.ghostHitPoints.TabIndex = 5;
            // 
            // ghostLabel
            // 
            this.ghostLabel.AutoSize = true;
            this.ghostLabel.Location = new System.Drawing.Point(3, 34);
            this.ghostLabel.Name = "ghostLabel";
            this.ghostLabel.Size = new System.Drawing.Size(35, 13);
            this.ghostLabel.TabIndex = 4;
            this.ghostLabel.Text = "Ghost";
            // 
            // batHitPoints
            // 
            this.batHitPoints.AutoSize = true;
            this.batHitPoints.Location = new System.Drawing.Point(51, 17);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(0, 13);
            this.batHitPoints.TabIndex = 3;
            // 
            // batLabel
            // 
            this.batLabel.AutoSize = true;
            this.batLabel.Location = new System.Drawing.Point(3, 17);
            this.batLabel.Name = "batLabel";
            this.batLabel.Size = new System.Drawing.Size(23, 13);
            this.batLabel.TabIndex = 2;
            this.batLabel.Text = "Bat";
            // 
            // playerHitPoints
            // 
            this.playerHitPoints.AutoSize = true;
            this.playerHitPoints.Location = new System.Drawing.Point(51, 0);
            this.playerHitPoints.Name = "playerHitPoints";
            this.playerHitPoints.Size = new System.Drawing.Size(0, 13);
            this.playerHitPoints.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player";
            // 
            // ghoulLabel
            // 
            this.ghoulLabel.AutoSize = true;
            this.ghoulLabel.Location = new System.Drawing.Point(3, 51);
            this.ghoulLabel.Name = "ghoulLabel";
            this.ghoulLabel.Size = new System.Drawing.Size(35, 13);
            this.ghoulLabel.TabIndex = 6;
            this.ghoulLabel.Text = "Ghoul";
            // 
            // playerIcon
            // 
            this.playerIcon.BackColor = System.Drawing.Color.Transparent;
            this.playerIcon.Image = ((System.Drawing.Image)(resources.GetObject("playerIcon.Image")));
            this.playerIcon.Location = new System.Drawing.Point(96, 70);
            this.playerIcon.Name = "playerIcon";
            this.playerIcon.Size = new System.Drawing.Size(30, 30);
            this.playerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerIcon.TabIndex = 3;
            this.playerIcon.TabStop = false;
            // 
            // swordIcon
            // 
            this.swordIcon.BackColor = System.Drawing.Color.Transparent;
            this.swordIcon.Image = ((System.Drawing.Image)(resources.GetObject("swordIcon.Image")));
            this.swordIcon.Location = new System.Drawing.Point(147, 70);
            this.swordIcon.Name = "swordIcon";
            this.swordIcon.Size = new System.Drawing.Size(30, 30);
            this.swordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.swordIcon.TabIndex = 4;
            this.swordIcon.TabStop = false;
            this.swordIcon.Visible = false;
            // 
            // batIcon
            // 
            this.batIcon.BackColor = System.Drawing.Color.Transparent;
            this.batIcon.Image = ((System.Drawing.Image)(resources.GetObject("batIcon.Image")));
            this.batIcon.Location = new System.Drawing.Point(202, 70);
            this.batIcon.Name = "batIcon";
            this.batIcon.Size = new System.Drawing.Size(30, 30);
            this.batIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.batIcon.TabIndex = 5;
            this.batIcon.TabStop = false;
            this.batIcon.Visible = false;
            // 
            // ghoulIcon
            // 
            this.ghoulIcon.BackColor = System.Drawing.Color.Transparent;
            this.ghoulIcon.Image = ((System.Drawing.Image)(resources.GetObject("ghoulIcon.Image")));
            this.ghoulIcon.Location = new System.Drawing.Point(255, 70);
            this.ghoulIcon.Name = "ghoulIcon";
            this.ghoulIcon.Size = new System.Drawing.Size(30, 30);
            this.ghoulIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghoulIcon.TabIndex = 6;
            this.ghoulIcon.TabStop = false;
            this.ghoulIcon.Visible = false;
            // 
            // ghostIcon
            // 
            this.ghostIcon.BackColor = System.Drawing.Color.Transparent;
            this.ghostIcon.Image = ((System.Drawing.Image)(resources.GetObject("ghostIcon.Image")));
            this.ghostIcon.Location = new System.Drawing.Point(308, 70);
            this.ghostIcon.Name = "ghostIcon";
            this.ghostIcon.Size = new System.Drawing.Size(30, 30);
            this.ghostIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghostIcon.TabIndex = 7;
            this.ghostIcon.TabStop = false;
            this.ghostIcon.Visible = false;
            // 
            // bowIcon
            // 
            this.bowIcon.BackColor = System.Drawing.Color.Transparent;
            this.bowIcon.Image = ((System.Drawing.Image)(resources.GetObject("bowIcon.Image")));
            this.bowIcon.Location = new System.Drawing.Point(361, 70);
            this.bowIcon.Name = "bowIcon";
            this.bowIcon.Size = new System.Drawing.Size(30, 30);
            this.bowIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bowIcon.TabIndex = 8;
            this.bowIcon.TabStop = false;
            this.bowIcon.Visible = false;
            // 
            // bluePotionIcon
            // 
            this.bluePotionIcon.BackColor = System.Drawing.Color.Transparent;
            this.bluePotionIcon.Image = ((System.Drawing.Image)(resources.GetObject("bluePotionIcon.Image")));
            this.bluePotionIcon.Location = new System.Drawing.Point(414, 70);
            this.bluePotionIcon.Name = "bluePotionIcon";
            this.bluePotionIcon.Size = new System.Drawing.Size(30, 30);
            this.bluePotionIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bluePotionIcon.TabIndex = 9;
            this.bluePotionIcon.TabStop = false;
            this.bluePotionIcon.Visible = false;
            // 
            // redPotionIcon
            // 
            this.redPotionIcon.BackColor = System.Drawing.Color.Transparent;
            this.redPotionIcon.Image = ((System.Drawing.Image)(resources.GetObject("redPotionIcon.Image")));
            this.redPotionIcon.Location = new System.Drawing.Point(467, 70);
            this.redPotionIcon.Name = "redPotionIcon";
            this.redPotionIcon.Size = new System.Drawing.Size(30, 30);
            this.redPotionIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redPotionIcon.TabIndex = 10;
            this.redPotionIcon.TabStop = false;
            this.redPotionIcon.Visible = false;
            // 
            // maceIcon
            // 
            this.maceIcon.BackColor = System.Drawing.Color.Transparent;
            this.maceIcon.Image = ((System.Drawing.Image)(resources.GetObject("maceIcon.Image")));
            this.maceIcon.Location = new System.Drawing.Point(520, 70);
            this.maceIcon.Name = "maceIcon";
            this.maceIcon.Size = new System.Drawing.Size(30, 30);
            this.maceIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maceIcon.TabIndex = 11;
            this.maceIcon.TabStop = false;
            this.maceIcon.Visible = false;
            // 
            // inventorySword
            // 
            this.inventorySword.BackColor = System.Drawing.Color.Transparent;
            this.inventorySword.Image = ((System.Drawing.Image)(resources.GetObject("inventorySword.Image")));
            this.inventorySword.Location = new System.Drawing.Point(85, 383);
            this.inventorySword.Name = "inventorySword";
            this.inventorySword.Size = new System.Drawing.Size(50, 50);
            this.inventorySword.TabIndex = 12;
            this.inventorySword.TabStop = false;
            this.inventorySword.Click += new System.EventHandler(this.inventorySword_Click);
            // 
            // inventoryBow
            // 
            this.inventoryBow.BackColor = System.Drawing.Color.Transparent;
            this.inventoryBow.Image = ((System.Drawing.Image)(resources.GetObject("inventoryBow.Image")));
            this.inventoryBow.Location = new System.Drawing.Point(142, 383);
            this.inventoryBow.Name = "inventoryBow";
            this.inventoryBow.Size = new System.Drawing.Size(50, 50);
            this.inventoryBow.TabIndex = 13;
            this.inventoryBow.TabStop = false;
            this.inventoryBow.Click += new System.EventHandler(this.inventoryBow_Click);
            // 
            // inventoryMace
            // 
            this.inventoryMace.BackColor = System.Drawing.Color.Transparent;
            this.inventoryMace.Image = ((System.Drawing.Image)(resources.GetObject("inventoryMace.Image")));
            this.inventoryMace.Location = new System.Drawing.Point(199, 383);
            this.inventoryMace.Name = "inventoryMace";
            this.inventoryMace.Size = new System.Drawing.Size(50, 50);
            this.inventoryMace.TabIndex = 14;
            this.inventoryMace.TabStop = false;
            this.inventoryMace.Click += new System.EventHandler(this.inventoryMace_Click);
            // 
            // inventoryBluePotion
            // 
            this.inventoryBluePotion.BackColor = System.Drawing.Color.Transparent;
            this.inventoryBluePotion.Image = ((System.Drawing.Image)(resources.GetObject("inventoryBluePotion.Image")));
            this.inventoryBluePotion.Location = new System.Drawing.Point(256, 383);
            this.inventoryBluePotion.Name = "inventoryBluePotion";
            this.inventoryBluePotion.Size = new System.Drawing.Size(50, 50);
            this.inventoryBluePotion.TabIndex = 15;
            this.inventoryBluePotion.TabStop = false;
            this.inventoryBluePotion.Click += new System.EventHandler(this.inventoryBluePotion_Click);
            // 
            // inventoryRedPotion
            // 
            this.inventoryRedPotion.BackColor = System.Drawing.Color.Transparent;
            this.inventoryRedPotion.Image = ((System.Drawing.Image)(resources.GetObject("inventoryRedPotion.Image")));
            this.inventoryRedPotion.Location = new System.Drawing.Point(313, 383);
            this.inventoryRedPotion.Name = "inventoryRedPotion";
            this.inventoryRedPotion.Size = new System.Drawing.Size(50, 50);
            this.inventoryRedPotion.TabIndex = 16;
            this.inventoryRedPotion.TabStop = false;
            this.inventoryRedPotion.Click += new System.EventHandler(this.inventoryRedPotion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 477);
            this.Controls.Add(this.swordIcon);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.playerIcon);
            this.Controls.Add(this.inventoryRedPotion);
            this.Controls.Add(this.inventoryBluePotion);
            this.Controls.Add(this.inventoryMace);
            this.Controls.Add(this.inventoryBow);
            this.Controls.Add(this.inventorySword);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.redPotionIcon);
            this.Controls.Add(this.bluePotionIcon);
            this.Controls.Add(this.ghostIcon);
            this.Controls.Add(this.ghoulIcon);
            this.Controls.Add(this.batIcon);
            this.Controls.Add(this.maceIcon);
            this.Controls.Add(this.bowIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "The Quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoulIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryRedPotion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox playerIcon;
        private System.Windows.Forms.PictureBox swordIcon;
        private System.Windows.Forms.PictureBox batIcon;
        private System.Windows.Forms.PictureBox ghoulIcon;
        private System.Windows.Forms.PictureBox ghostIcon;
        private System.Windows.Forms.PictureBox bowIcon;
        private System.Windows.Forms.PictureBox bluePotionIcon;
        private System.Windows.Forms.PictureBox redPotionIcon;
        private System.Windows.Forms.PictureBox maceIcon;
        private System.Windows.Forms.PictureBox inventorySword;
        private System.Windows.Forms.PictureBox inventoryBow;
        private System.Windows.Forms.PictureBox inventoryMace;
        private System.Windows.Forms.PictureBox inventoryBluePotion;
        private System.Windows.Forms.PictureBox inventoryRedPotion;
        private System.Windows.Forms.Label ghoulHitPoints;
        private System.Windows.Forms.Label ghoulLabel;
        private System.Windows.Forms.Label ghostHitPoints;
        private System.Windows.Forms.Label ghostLabel;
        private System.Windows.Forms.Label batHitPoints;
        private System.Windows.Forms.Label batLabel;
        private System.Windows.Forms.Label playerHitPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button moveDown;
        private System.Windows.Forms.Button moveRight;
        private System.Windows.Forms.Button moveLeft;
        private System.Windows.Forms.Button moveUp;
        private System.Windows.Forms.Button attackDown;
        private System.Windows.Forms.Button attackLeft;
        private System.Windows.Forms.Button attackRight;
        private System.Windows.Forms.Button attackUp;
    }
}

