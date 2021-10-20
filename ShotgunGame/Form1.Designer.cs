namespace ShotgunGame
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
      if(disposing && (components != null))
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
      this.buttonLoad = new System.Windows.Forms.Button();
      this.buttonShot = new System.Windows.Forms.Button();
      this.buttonBlock = new System.Windows.Forms.Button();
      this.buttonShotgun = new System.Windows.Forms.Button();
      this.labelComputerName = new System.Windows.Forms.Label();
      this.labelPlayerName = new System.Windows.Forms.Label();
      this.labelComputerAmmo = new System.Windows.Forms.Label();
      this.labelPlayerAmmo = new System.Windows.Forms.Label();
      this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
      this.pictureBoxComputer = new System.Windows.Forms.PictureBox();
      this.labelNewGame = new System.Windows.Forms.Label();
      this.buttonNewGameNo = new System.Windows.Forms.Button();
      this.buttonNewGameYes = new System.Windows.Forms.Button();
      this.labelComputerScore = new System.Windows.Forms.Label();
      this.labelPlayerScore = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComputer)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonLoad
      // 
      this.buttonLoad.Location = new System.Drawing.Point(289, 415);
      this.buttonLoad.Name = "buttonLoad";
      this.buttonLoad.Size = new System.Drawing.Size(75, 23);
      this.buttonLoad.TabIndex = 0;
      this.buttonLoad.Text = "Ladda";
      this.buttonLoad.UseVisualStyleBackColor = true;
      this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
      // 
      // buttonShot
      // 
      this.buttonShot.Location = new System.Drawing.Point(370, 415);
      this.buttonShot.Name = "buttonShot";
      this.buttonShot.Size = new System.Drawing.Size(75, 23);
      this.buttonShot.TabIndex = 0;
      this.buttonShot.Text = "Skjuta";
      this.buttonShot.UseVisualStyleBackColor = true;
      this.buttonShot.Click += new System.EventHandler(this.buttonShot_Click);
      // 
      // buttonBlock
      // 
      this.buttonBlock.Location = new System.Drawing.Point(451, 415);
      this.buttonBlock.Name = "buttonBlock";
      this.buttonBlock.Size = new System.Drawing.Size(75, 23);
      this.buttonBlock.TabIndex = 0;
      this.buttonBlock.Text = "Blocka";
      this.buttonBlock.UseVisualStyleBackColor = true;
      this.buttonBlock.Click += new System.EventHandler(this.buttonBlock_Click);
      // 
      // buttonShotgun
      // 
      this.buttonShotgun.Location = new System.Drawing.Point(370, 386);
      this.buttonShotgun.Name = "buttonShotgun";
      this.buttonShotgun.Size = new System.Drawing.Size(75, 23);
      this.buttonShotgun.TabIndex = 0;
      this.buttonShotgun.Text = "Shotgun";
      this.buttonShotgun.UseVisualStyleBackColor = true;
      this.buttonShotgun.Visible = false;
      this.buttonShotgun.Click += new System.EventHandler(this.buttonShotgun_Click);
      // 
      // labelComputerName
      // 
      this.labelComputerName.AutoSize = true;
      this.labelComputerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelComputerName.Location = new System.Drawing.Point(223, 28);
      this.labelComputerName.Name = "labelComputerName";
      this.labelComputerName.Size = new System.Drawing.Size(54, 20);
      this.labelComputerName.TabIndex = 2;
      this.labelComputerName.Text = "Dator";
      // 
      // labelPlayerName
      // 
      this.labelPlayerName.AutoSize = true;
      this.labelPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelPlayerName.Location = new System.Drawing.Point(543, 28);
      this.labelPlayerName.Name = "labelPlayerName";
      this.labelPlayerName.Size = new System.Drawing.Size(71, 20);
      this.labelPlayerName.TabIndex = 2;
      this.labelPlayerName.Text = "Spelare";
      // 
      // labelComputerAmmo
      // 
      this.labelComputerAmmo.AutoSize = true;
      this.labelComputerAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelComputerAmmo.Location = new System.Drawing.Point(223, 354);
      this.labelComputerAmmo.Name = "labelComputerAmmo";
      this.labelComputerAmmo.Size = new System.Drawing.Size(112, 20);
      this.labelComputerAmmo.TabIndex = 2;
      this.labelComputerAmmo.Text = "Dator ammo:";
      // 
      // labelPlayerAmmo
      // 
      this.labelPlayerAmmo.AutoSize = true;
      this.labelPlayerAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelPlayerAmmo.Location = new System.Drawing.Point(543, 354);
      this.labelPlayerAmmo.Name = "labelPlayerAmmo";
      this.labelPlayerAmmo.Size = new System.Drawing.Size(129, 20);
      this.labelPlayerAmmo.TabIndex = 2;
      this.labelPlayerAmmo.Text = "Spelare ammo:";
      // 
      // pictureBoxPlayer
      // 
      this.pictureBoxPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.pictureBoxPlayer.Image = global::ShotgunGame.Properties.Resources.Load;
      this.pictureBoxPlayer.Location = new System.Drawing.Point(451, 51);
      this.pictureBoxPlayer.Name = "pictureBoxPlayer";
      this.pictureBoxPlayer.Size = new System.Drawing.Size(247, 300);
      this.pictureBoxPlayer.TabIndex = 1;
      this.pictureBoxPlayer.TabStop = false;
      this.pictureBoxPlayer.Click += new System.EventHandler(this.pictureBox1_Click);
      // 
      // pictureBoxComputer
      // 
      this.pictureBoxComputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.pictureBoxComputer.Image = global::ShotgunGame.Properties.Resources.Gun;
      this.pictureBoxComputer.Location = new System.Drawing.Point(117, 51);
      this.pictureBoxComputer.Name = "pictureBoxComputer";
      this.pictureBoxComputer.Size = new System.Drawing.Size(247, 300);
      this.pictureBoxComputer.TabIndex = 1;
      this.pictureBoxComputer.TabStop = false;
      this.pictureBoxComputer.Click += new System.EventHandler(this.pictureBox1_Click);
      // 
      // labelNewGame
      // 
      this.labelNewGame.AutoSize = true;
      this.labelNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelNewGame.Location = new System.Drawing.Point(314, 166);
      this.labelNewGame.Name = "labelNewGame";
      this.labelNewGame.Size = new System.Drawing.Size(189, 20);
      this.labelNewGame.TabIndex = 2;
      this.labelNewGame.Text = "Vill du spela nytt spel?";
      // 
      // buttonNewGameNo
      // 
      this.buttonNewGameNo.Location = new System.Drawing.Point(409, 220);
      this.buttonNewGameNo.Name = "buttonNewGameNo";
      this.buttonNewGameNo.Size = new System.Drawing.Size(75, 23);
      this.buttonNewGameNo.TabIndex = 4;
      this.buttonNewGameNo.Text = "Nej";
      this.buttonNewGameNo.UseVisualStyleBackColor = true;
      this.buttonNewGameNo.Click += new System.EventHandler(this.buttonNewGameNo_Click);
      // 
      // buttonNewGameYes
      // 
      this.buttonNewGameYes.Location = new System.Drawing.Point(328, 220);
      this.buttonNewGameYes.Name = "buttonNewGameYes";
      this.buttonNewGameYes.Size = new System.Drawing.Size(75, 23);
      this.buttonNewGameYes.TabIndex = 5;
      this.buttonNewGameYes.Text = "Ja";
      this.buttonNewGameYes.UseVisualStyleBackColor = true;
      this.buttonNewGameYes.Click += new System.EventHandler(this.buttonNewGameYes_Click);
      // 
      // labelComputerScore
      // 
      this.labelComputerScore.AutoSize = true;
      this.labelComputerScore.Location = new System.Drawing.Point(114, 9);
      this.labelComputerScore.Name = "labelComputerScore";
      this.labelComputerScore.Size = new System.Drawing.Size(73, 13);
      this.labelComputerScore.TabIndex = 6;
      this.labelComputerScore.Text = "Dator vinster: ";
      // 
      // labelPlayerScore
      // 
      this.labelPlayerScore.AutoSize = true;
      this.labelPlayerScore.Location = new System.Drawing.Point(610, 9);
      this.labelPlayerScore.Name = "labelPlayerScore";
      this.labelPlayerScore.Size = new System.Drawing.Size(83, 13);
      this.labelPlayerScore.TabIndex = 7;
      this.labelPlayerScore.Text = "Spelare vinster: ";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.labelPlayerScore);
      this.Controls.Add(this.labelComputerScore);
      this.Controls.Add(this.buttonNewGameYes);
      this.Controls.Add(this.buttonNewGameNo);
      this.Controls.Add(this.labelNewGame);
      this.Controls.Add(this.labelPlayerAmmo);
      this.Controls.Add(this.labelPlayerName);
      this.Controls.Add(this.labelComputerAmmo);
      this.Controls.Add(this.labelComputerName);
      this.Controls.Add(this.pictureBoxPlayer);
      this.Controls.Add(this.pictureBoxComputer);
      this.Controls.Add(this.buttonBlock);
      this.Controls.Add(this.buttonShotgun);
      this.Controls.Add(this.buttonShot);
      this.Controls.Add(this.buttonLoad);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComputer)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonLoad;
    private System.Windows.Forms.Button buttonShot;
    private System.Windows.Forms.Button buttonBlock;
    private System.Windows.Forms.PictureBox pictureBoxComputer;
    private System.Windows.Forms.PictureBox pictureBoxPlayer;
    private System.Windows.Forms.Button buttonShotgun;
    private System.Windows.Forms.Label labelComputerName;
    private System.Windows.Forms.Label labelPlayerName;
    private System.Windows.Forms.Label labelComputerAmmo;
    private System.Windows.Forms.Label labelPlayerAmmo;
    private System.Windows.Forms.Label labelNewGame;
    private System.Windows.Forms.Button buttonNewGameNo;
    private System.Windows.Forms.Button buttonNewGameYes;
    private System.Windows.Forms.Label labelComputerScore;
    private System.Windows.Forms.Label labelPlayerScore;
  }
}

