using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheQuest
{
    public partial class Form1 : Form
    {
        
        private Game game;
        private Random random = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(92, 67, 540, 200));
            game.NewLevel(random);
            UpdateCharacters();
            
        }

        public void UpdateCharacters()
        {
            //Update the player’s position and stats.
            playerIcon.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;

            int enemiesShown = 0;
            batHitPoints.Visible = false;
            batLabel.Visible = false;
            ghostHitPoints.Visible = false;
            ghostLabel.Visible = false;
            ghoulHitPoints.Visible = false;
            ghoulLabel.Visible = false;


            //Update each enemy’s location and hit points

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    batIcon.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }

                if (enemy is Ghost)
                {
                    ghostIcon.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }

                if (enemy is Ghoul)
                {
                    ghoulIcon.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }

                batHitPoints.Visible = showBat;
                batLabel.Visible = showBat;
                batIcon.Visible = showBat;

                ghostHitPoints.Visible = showGhost;
                ghostLabel.Visible = showGhost;                
                ghostIcon.Visible = showGhost;

                ghoulHitPoints.Visible = showGhoul;
                ghoulLabel.Visible = showGhoul;
                ghoulIcon.Visible = showGhoul;


                //Update the weapon PictureBoxes

                swordIcon.Visible = false;
                bowIcon.Visible = false;
                redPotionIcon.Visible = false;
                bluePotionIcon.Visible = false;
                maceIcon.Visible = false;
                Control weaponControl = null;

                if (game.WeaponInRoom != null)
                {
                    switch (game.WeaponInRoom.Name)
                    {
                        case "Sword":
                            weaponControl = swordIcon; break;
                        case "Bow":
                            weaponControl = bowIcon; break;
                        case "Mace":
                            weaponControl = maceIcon; break;
                        case "Red Potion":
                            weaponControl = redPotionIcon; break;
                        case "Blue Potion":
                            weaponControl = bluePotionIcon; break;
                    }
                }
                
                if (weaponControl != null)
                {
                    weaponControl.Visible = true;
                }
                

                //Set the Visible property on each inventory icon PictureBox
                inventorySword.Visible = game.CheckPlayerInventory("Sword");
                inventoryBow.Visible = game.CheckPlayerInventory("Bow");
                inventoryMace.Visible = game.CheckPlayerInventory("Mace");
                inventoryRedPotion.Visible = game.CheckPlayerInventory("Red Potion");
                inventoryBluePotion.Visible = game.CheckPlayerInventory("Blue Potion");

                if (game.CheckPlayerInventory("Sword") && game.PlayerWeapons.Count() == 1)
                {
                    inventorySword.BorderStyle = BorderStyle.FixedSingle;
                }

                //The rest of the method does three things. First, it checks to see if the player’s already
                //picked up the weapon in the room, so it knows whether or not to display it. Then it
                //checks to see if the player died. And finally, it checks to see if the player’s defeated all of
                //the enemies. If he has, then the player advances to the next level.
                if (game.WeaponInRoom != null)
                {
                    weaponControl.Location = game.WeaponInRoom.Location;
                    if (game.WeaponInRoom.PickedUp)
                        weaponControl.Visible = false;
                    else
                        weaponControl.Visible = true;
                }               

                if (game.PlayerHitPoints <= 0)
                {
                    MessageBox.Show("You died");
                    Application.Exit();
                }
                if (enemiesShown < 1)
                {
                    MessageBox.Show("You have defeated the enemies on this level");
                    game.NewLevel(random);
                    if (game.Level <= 7) UpdateCharacters();
                }
            this.Text = "The Quest: level " + game.Level;

        }

        public Form1()
        {
            InitializeComponent();           
        }

        private void inventorySword_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Sword"))
            {
                game.Equip("Sword");
                inventorySword.BorderStyle = BorderStyle.FixedSingle;
                inventoryMace.BorderStyle = BorderStyle.None;
                inventoryBow.BorderStyle = BorderStyle.None;
                inventoryBluePotion.BorderStyle = BorderStyle.None;
                inventoryRedPotion.BorderStyle = BorderStyle.None;
                attackDown.Visible = true;
                attackLeft.Visible = true;
                attackRight.Visible = true;
                attackUp.Text = "↑";
            }
        }           
            
        private void inventoryBow_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Bow"))
            {
                game.Equip("Bow");
                inventorySword.BorderStyle = BorderStyle.None;
                inventoryMace.BorderStyle = BorderStyle.None;
                inventoryBow.BorderStyle = BorderStyle.FixedSingle;
                inventoryBluePotion.BorderStyle = BorderStyle.None;
                inventoryRedPotion.BorderStyle = BorderStyle.None;
                attackDown.Visible = true;
                attackLeft.Visible = true;
                attackRight.Visible = true;
                attackUp.Text = "↑";
            }
        }

        private void inventoryMace_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Mace"))
            {
                game.Equip("Mace");
                inventorySword.BorderStyle = BorderStyle.None;
                inventoryMace.BorderStyle = BorderStyle.FixedSingle;
                inventoryBow.BorderStyle = BorderStyle.None;
                inventoryBluePotion.BorderStyle = BorderStyle.None;
                inventoryRedPotion.BorderStyle = BorderStyle.None;
                attackDown.Visible = true;
                attackLeft.Visible = true;
                attackRight.Visible = true;
                attackUp.Text = "↑";
            }
        }

        private void inventoryBluePotion_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Blue Potion"))
            {
                game.Equip("Blue Potion");
                inventorySword.BorderStyle = BorderStyle.None;
                inventoryMace.BorderStyle = BorderStyle.None;
                inventoryBow.BorderStyle = BorderStyle.None; ;
                inventoryBluePotion.BorderStyle = BorderStyle.FixedSingle;
                inventoryRedPotion.BorderStyle = BorderStyle.None;
                attackDown.Visible = false;
                attackLeft.Visible = false;
                attackRight.Visible = false;
                attackUp.Text = "Drink";
                
            
            }
        }

        private void inventoryRedPotion_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Red Potion"))
            {
                game.Equip("Red Potion");
                inventorySword.BorderStyle = BorderStyle.None;
                inventoryMace.BorderStyle = BorderStyle.None;
                inventoryBow.BorderStyle = BorderStyle.None; ;
                inventoryBluePotion.BorderStyle = BorderStyle.None;
                inventoryRedPotion.BorderStyle = BorderStyle.FixedSingle;
                attackDown.Visible = false;
                attackLeft.Visible = false;
                attackRight.Visible = false;
                attackUp.Text = "Drink";
            }
        }

        private void moveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void moveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void moveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void attackUp_Click(object sender, EventArgs e)
        {            
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void attackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void attackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void attackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }
    }
}
