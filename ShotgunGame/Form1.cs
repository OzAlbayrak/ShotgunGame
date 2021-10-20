/*
 * Inlämningsuppgift 2: Skapa ett spel -Shotgun 
 * Oguz Oz Albayrak
 * CMS21 - Programmering med C#
 * Nackademin
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShotgunGame
{
  public partial class Form1 : Form
  {
    private Player PlayerHuman = new Player();
    private Player PlayerComputer = new Player();
    string[] selection = {"Load","Block","Shoot","Shotgun"};
    bool firstRound = true;
    bool shotgunOn = false;
    private readonly Random random = new Random();
    public Form1()
    {
      InitializeComponent();
      HideGameAll();
      PlayerHuman.PlayerScore = 0;
      PlayerHuman.PlayerAmmo = 0;
      PlayerComputer.PlayerScore = 0;
      PlayerComputer.PlayerAmmo = 0;
      pictureBoxPlayer.Image = Properties.Resources.Load;
      pictureBoxComputer.Image = Properties.Resources.Load;
    }
    private void Form1_Load(object sender, EventArgs e)
    {
    }
    private void buttonNewGameYes_Click(object sender, EventArgs e)
    {
      HideGameStart();
      ShowGameAll();
      firstRound = true;
      MessageBox.Show("Spelet börjar med att alla spelare måste ladda först!!!");
    }
    private void buttonNewGameNo_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Vill du värkligen inte spela???");
    }
    private void pictureBox1_Click(object sender, EventArgs e)
    {
    }
    private void buttonLoad_Click(object sender, EventArgs e)
    {
      PlayerHuman.PlayerSelection = selection[0];    
      if (firstRound) 
      {
        firstRound = false;
        PlayerComputer.PlayerAmmo += 1;
        PlayerHuman.PlayerAmmo += 1;
        pictureBoxComputer.Image = Properties.Resources.Load;
        pictureBoxPlayer.Image = Properties.Resources.Load;
        ShowGameAll();
      }
      else
      {
        GameRound();
      }
    }
    private void buttonShot_Click(object sender, EventArgs e)
    {
      pictureBoxPlayer.Image = Properties.Resources.Gun;
      PlayerHuman.PlayerSelection = selection[2];     
      if (PlayerHuman.PlayerAmmo <= 0) 
      {
        buttonShot.Hide();
      }
      GameRound();
    }
    private void buttonBlock_Click(object sender, EventArgs e)
    {
      pictureBoxPlayer.Image = Properties.Resources.Shield;
      PlayerHuman.PlayerSelection = selection[1];
      GameRound();
    }
    private void buttonShotgun_Click(object sender, EventArgs e)
    {
      pictureBoxPlayer.Image = Properties.Resources.Shotgun;
      PlayerHuman.PlayerSelection = selection[3];
      if (PlayerHuman.PlayerAmmo < 3) 
      {
        shotgunOn = false;
      }
      GameRound();
    }
    private void HideGameAll() 
    {
      buttonLoad.Hide();
      buttonShot.Hide();
      buttonBlock.Hide();
      buttonShotgun.Hide();
      pictureBoxPlayer.Hide();
      pictureBoxComputer.Hide();
      labelPlayerScore.Hide();
      labelPlayerName.Hide();
      labelPlayerAmmo.Hide();
      labelComputerScore.Hide();
      labelComputerName.Hide();
      labelComputerAmmo.Hide();
    }
    private void ShowGameAll()
    {
      buttonLoad.Show();
      if (!firstRound && (PlayerHuman.PlayerAmmo > 0)) 
      { 
        buttonShot.Show(); 
      }
      else if (PlayerHuman.PlayerAmmo == 0) 
      {
        buttonShot.Hide();
      }
      else { buttonShot.Hide(); }
      if (!firstRound)
      {
        buttonBlock.Show();
      }
      else { buttonBlock.Hide(); }
      if (shotgunOn) 
      { 
        buttonShotgun.Show(); 
      }
      else { buttonShotgun.Hide(); }
      pictureBoxPlayer.Show();
      pictureBoxComputer.Show();
      labelPlayerScore.Text = "Spelare vinster: " + PlayerHuman.PlayerScore;
      labelPlayerScore.Show();
      labelPlayerName.Show();
      labelPlayerAmmo.Text = "Spelare ammo: " + PlayerHuman.PlayerAmmo;
      labelPlayerAmmo.Show();
      labelComputerScore.Text = "Dator vinster: " + PlayerComputer.PlayerScore;
      labelComputerScore.Show();
      labelComputerName.Show();
      labelComputerAmmo.Text = "Dator ammo: " + PlayerComputer.PlayerAmmo;
      labelComputerAmmo.Show();
    }
    private void HideGameStart()
    {
      buttonNewGameYes.Hide();
      buttonNewGameNo.Hide();
      labelNewGame.Hide();
    }
    private void ShowGameStart()
    {
      buttonNewGameYes.Show();
      buttonNewGameNo.Show();
      labelNewGame.Show();
      HideGameAll();
      PlayerHuman.PlayerAmmo = 0;
      PlayerComputer.PlayerAmmo = 0;
    }
    //"Load","Block","Shoot","Shotgun"
    public void GameRound() 
    {
      ComputerPlay();
      if (PlayerHuman.PlayerSelection == selection[0] && PlayerComputer.PlayerSelection == selection[0])//Load vs Load
      {
        pictureBoxPlayer.Image = Properties.Resources.Load;
        pictureBoxComputer.Image = Properties.Resources.Load;
        PlayerComputer.PlayerAmmo += 1;
        PlayerHuman.PlayerAmmo += 1;
        ShotganCheck();
        ShowGameAll();
      }
      else if (PlayerHuman.PlayerSelection == selection[0] && PlayerComputer.PlayerSelection == selection[1])//Load vs Block
      {
        pictureBoxPlayer.Image = Properties.Resources.Load;
        pictureBoxComputer.Image = Properties.Resources.Shield;
        PlayerHuman.PlayerAmmo += 1;
        ShotganCheck();
        ShowGameAll();
      }
      else if (PlayerHuman.PlayerSelection == selection[1] && PlayerComputer.PlayerSelection == selection[0])//Block vs Load
      {
        pictureBoxPlayer.Image = Properties.Resources.Shield;
        pictureBoxComputer.Image = Properties.Resources.Load;
        PlayerComputer.PlayerAmmo += 1;
        ShotganCheck();
        ShowGameAll();
      }
      else if (PlayerHuman.PlayerSelection == selection[1] && PlayerComputer.PlayerSelection == selection[1])//Block vs Block
      {
        pictureBoxPlayer.Image = Properties.Resources.Shield;
        pictureBoxComputer.Image = Properties.Resources.Shield;
        ShowGameAll();
      }
      else if (PlayerHuman.PlayerSelection == selection[2] && PlayerComputer.PlayerSelection == selection[1])//Shoot vs Block
      {
        pictureBoxPlayer.Image = Properties.Resources.Gun;
        pictureBoxComputer.Image = Properties.Resources.Shield;
        PlayerHuman.PlayerAmmo -= 1;
        ShotganCheck();
        ShowGameAll();
      }
      else if (PlayerHuman.PlayerSelection == selection[1] && PlayerComputer.PlayerSelection == selection[2])//Block vs Shoot
      {
        pictureBoxPlayer.Image = Properties.Resources.Shield;
        pictureBoxComputer.Image = Properties.Resources.Gun;
        PlayerComputer.PlayerAmmo -= 1;
        ShotganCheck();
        ShowGameAll();
      }
      else if (PlayerHuman.PlayerSelection == selection[2] && PlayerComputer.PlayerSelection == selection[2])//Shoot vs Shoot
      {
        pictureBoxPlayer.Image = Properties.Resources.Gun;
        pictureBoxComputer.Image = Properties.Resources.Gun;
        PlayerComputer.PlayerAmmo -= 1;
        PlayerHuman.PlayerAmmo -= 1;
        ShotganCheck();
        ShowGameAll();
      }
      else if (PlayerHuman.PlayerSelection == selection[2] && PlayerComputer.PlayerSelection == selection[0])//Shoot vs Load
      {
        pictureBoxPlayer.Image = Properties.Resources.Gun;
        pictureBoxComputer.Image = Properties.Resources.Load;
        PlayerHuman.PlayerScore += 1;
        shotgunOn = false;
        ShowGameAll();
        MessageBox.Show("Du van!!!");
        firstRound = true;
        pictureBoxPlayer.Image = Properties.Resources.Load;
        pictureBoxComputer.Image = Properties.Resources.Load;
        ShowGameStart();
      }
      else if (PlayerHuman.PlayerSelection == selection[0] && PlayerComputer.PlayerSelection == selection[2])//Load vs Shoot
      {
        pictureBoxPlayer.Image = Properties.Resources.Load;
        pictureBoxComputer.Image = Properties.Resources.Gun;
        PlayerComputer.PlayerScore += 1;
        shotgunOn = false;
        ShowGameAll();
        MessageBox.Show("Du förlorade...");
        firstRound = true;
        pictureBoxPlayer.Image = Properties.Resources.Load;
        pictureBoxComputer.Image = Properties.Resources.Load;
        ShowGameStart();
      }
      else if (PlayerHuman.PlayerSelection == selection[3] && PlayerComputer.PlayerSelection == selection[3])//Shotgun vs Shotgun
      {
        pictureBoxPlayer.Image = Properties.Resources.Shotgun;
        pictureBoxComputer.Image = Properties.Resources.Shotgun;
        PlayerComputer.PlayerAmmo -= 3;
        PlayerHuman.PlayerAmmo -= 3;
        ShotganCheck();
        ShowGameAll();
      }
      else if (PlayerHuman.PlayerSelection == selection[3] && PlayerComputer.PlayerSelection == selection[0])//Shotgun vs Load
      {
        pictureBoxPlayer.Image = Properties.Resources.Shotgun;
        pictureBoxComputer.Image = Properties.Resources.Load;
        PlayerHuman.PlayerAmmo -= 3;
        PlayerHuman.PlayerScore += 1;
        shotgunOn = false;
        ShowGameAll();
        MessageBox.Show("Du van!!!");
        firstRound = true;
        pictureBoxPlayer.Image = Properties.Resources.Load;
        pictureBoxComputer.Image = Properties.Resources.Load;
        ShowGameStart();
      }
      else if (PlayerHuman.PlayerSelection == selection[3] && PlayerComputer.PlayerSelection == selection[1])//Shotgun vs Block
      {
        pictureBoxPlayer.Image = Properties.Resources.Shotgun;
        pictureBoxComputer.Image = Properties.Resources.Shield;
        PlayerHuman.PlayerAmmo -= 3;
        PlayerHuman.PlayerScore += 1;
        shotgunOn = false;
        ShowGameAll();
        MessageBox.Show("Du van!!!");
        firstRound = true;
        pictureBoxPlayer.Image = Properties.Resources.Load;
        pictureBoxComputer.Image = Properties.Resources.Load;
        ShowGameStart();
      }
      else if (PlayerHuman.PlayerSelection == selection[3] && PlayerComputer.PlayerSelection == selection[2])//Shotgun vs Shoot
      {
        pictureBoxPlayer.Image = Properties.Resources.Shotgun;
        pictureBoxComputer.Image = Properties.Resources.Gun;
        PlayerHuman.PlayerAmmo -= 3;
        PlayerHuman.PlayerScore += 1;
        shotgunOn = false;
        ShowGameAll();
        MessageBox.Show("Du van!!!");
        firstRound = true;
        pictureBoxPlayer.Image = Properties.Resources.Load;
        pictureBoxComputer.Image = Properties.Resources.Load;
        ShowGameStart();
      }
      else if (PlayerHuman.PlayerSelection == selection[0] && PlayerComputer.PlayerSelection == selection[3])//Load vs Shotgun
      {
        pictureBoxPlayer.Image = Properties.Resources.Load;
        pictureBoxComputer.Image = Properties.Resources.Shotgun;
        PlayerComputer.PlayerAmmo -= 3;
        PlayerComputer.PlayerScore += 1;
        shotgunOn = false;
        ShowGameAll();
        MessageBox.Show("Du förlorade...");
        firstRound = true;
        pictureBoxPlayer.Image = Properties.Resources.Load;
        pictureBoxComputer.Image = Properties.Resources.Load;
        ShowGameStart();
      }
      else if (PlayerHuman.PlayerSelection == selection[1] && PlayerComputer.PlayerSelection == selection[3])//Block vs Shotgun
      {
        pictureBoxPlayer.Image = Properties.Resources.Shield;
        pictureBoxComputer.Image = Properties.Resources.Shotgun;
        PlayerComputer.PlayerAmmo -= 3;
        PlayerComputer.PlayerScore += 1;
        shotgunOn = false;
        ShowGameAll();
        MessageBox.Show("Du förlorade...");
        firstRound = true;
        pictureBoxPlayer.Image = Properties.Resources.Load;
        pictureBoxComputer.Image = Properties.Resources.Load;
        ShowGameStart();
      }
      else if (PlayerHuman.PlayerSelection == selection[2] && PlayerComputer.PlayerSelection == selection[3])//Shoot vs Shotgun
      {
        pictureBoxPlayer.Image = Properties.Resources.Gun;
        pictureBoxComputer.Image = Properties.Resources.Load;
        PlayerComputer.PlayerAmmo -= 3;
        PlayerComputer.PlayerScore += 1;
        shotgunOn = false;
        ShowGameAll();
        MessageBox.Show("Du förlorade...");
        firstRound = true;
        pictureBoxPlayer.Image = Properties.Resources.Load;
        pictureBoxComputer.Image = Properties.Resources.Load;
        ShowGameStart();
      }
      else 
      {      
      }
    }
    public void ComputerPlay()
    {
      if (PlayerComputer.PlayerAmmo >= 3)
      {
        PlayerComputer.PlayerSelection = selection[random.Next(4)];
      }
      else 
      {
        PlayerComputer.PlayerSelection = selection[random.Next(3)];
      }    
    }
    public void ShotganCheck() 
    {
      if (PlayerHuman.PlayerAmmo < 3)
      {
        shotgunOn = false;
        buttonShotgun.Hide();
      }
      else
      {
        shotgunOn = true;
        buttonShotgun.Show();
      }
    }
  }
}
