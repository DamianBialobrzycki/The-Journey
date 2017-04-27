using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Journey
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }

        private void UpdateCharacters()
        {
            player.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;

            int enemiesShown = 0;

            foreach(Enemy enemy in game.Enemies)
            {
                if(enemy is Bat)
                {
                    bat.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if(enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
            }

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Ghost)
                {
                    ghost.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
            }

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Ghoul)
                {
                    ghoul.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }

            if(showBat == false)
            {
                bat.Visible = false;
                batHitPoints.Text = "";
            }

            if(showGhost == false)
            {
                ghost.Visible = false;
                ghostHitPoints.Text = "";
            }

            if(showGhoul == false)
            {
                ghoul.Visible = false;
                ghoulHitPoints.Text = "";
            }

            sword.Visible = false;
            bow.Visible = false;
            redPotion.Visible = false;
            bluePotion.Visible = false;
            mace.Visible = false;

            Control weaponControl = null;

            switch(game.WeaponInRoom.Name)
            {
                case "Miecz":
                    weaponControl = sword;
                    break;
                case "Łuk":
                    weaponControl = bow;
                    break;
                case "Buława":
                    weaponControl = mace;
                    break;
                case "Niebieska mikstura":
                    weaponControl = bluePotion;
                    break;
                case "Czerwona mikstura":
                    weaponControl = redPotion;
                    break;
            }

            weaponControl.Visible = true;

            foreach(string playerWeapon in game.PlayerWeapons)
            {
                switch(playerWeapon)
                {
                    case "Miecz":
                        inventorySword.Visible = true;
                        break;
                    case "Łuk":
                        inventoryBow.Visible = true;
                        break;
                    case "Buława":
                        inventoryMace.Visible = true;
                        break;
                    case "Niebieska mikstura":
                        inventoryBluePotion.Visible = true;
                        break;
                    case "Czerwona mikstura":
                        inventoryRedPotion.Visible = true;
                        break;
                }
            }

            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
                weaponControl.Visible = true;

            if(game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("Zostałeś zabity!");
                Application.Exit();
            }

            if(enemiesShown < 1)
            {
                MessageBox.Show("Pokonałeś przeciwników na tym poziomie");
                game.NewLevel(random);
                UpdateCharacters();
            }
        }

        private void inventorySword_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory(sword.Name))
            {
                game.Equip(sword.Name);

                inventoryBow.BorderStyle = BorderStyle.None;
                inventorySword.BorderStyle = BorderStyle.FixedSingle;
                inventoryMace.BorderStyle = BorderStyle.None;
                inventoryRedPotion.BorderStyle = BorderStyle.None;
                inventoryBluePotion.BorderStyle = BorderStyle.None;

                CheckPotion(false);
                UpdateCharacters();
            }   
        }

        private void inventoryBluePotion_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory(bluePotion.Name))
            {
                game.Equip(bluePotion.Name);

                inventoryBow.BorderStyle = BorderStyle.None;
                inventorySword.BorderStyle = BorderStyle.None;
                inventoryMace.BorderStyle = BorderStyle.None;
                inventoryRedPotion.BorderStyle = BorderStyle.None;
                inventoryBluePotion.BorderStyle = BorderStyle.FixedSingle;

                CheckPotion(true);
                UpdateCharacters();
            }
        }

        private void inventoryMace_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory(mace.Name))
            {
                game.Equip(mace.Name);

                inventoryBow.BorderStyle = BorderStyle.None;
                inventorySword.BorderStyle = BorderStyle.None;
                inventoryMace.BorderStyle = BorderStyle.FixedSingle;
                inventoryRedPotion.BorderStyle = BorderStyle.None;
                inventoryBluePotion.BorderStyle = BorderStyle.None;

                CheckPotion(false);
                UpdateCharacters();
            }
        }

        private void inventoryRedPotion_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory(redPotion.Name))
            {
                game.Equip(redPotion.Name);

                inventoryBow.BorderStyle = BorderStyle.None;
                inventorySword.BorderStyle = BorderStyle.None;
                inventoryMace.BorderStyle = BorderStyle.None;
                inventoryRedPotion.BorderStyle = BorderStyle.FixedSingle;
                inventoryBluePotion.BorderStyle = BorderStyle.None;

                CheckPotion(true);
                UpdateCharacters();
            }
        }

        private void inventoryBow_Click(object sender, EventArgs e)
        {
            if(game.CheckPlayerInventory(bow.Name))
            {
                game.Equip(bow.Name);
                
                inventoryBow.BorderStyle = BorderStyle.FixedSingle;
                inventorySword.BorderStyle = BorderStyle.None;
                inventoryMace.BorderStyle = BorderStyle.None;
                inventoryRedPotion.BorderStyle = BorderStyle.None;
                inventoryBluePotion.BorderStyle = BorderStyle.None;

                CheckPotion(false);
                UpdateCharacters();
            }
        }

        private void upMoveButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void leftMoveButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void downMoveButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void rightMoveButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void upAttackButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            
            UpdateCharacters();
        }

        private void leftAttackButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);

            UpdateCharacters();
        }

        private void downAttackButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);

            UpdateCharacters();
        }

        private void rightAttackButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);

            UpdateCharacters();
        }

        private void CheckPotion(bool isCheck)
        {
            if(isCheck)
            {
                upAttackButton.Text = "♥";
                leftAttackButton.Visible = false;
                rightAttackButton.Visible = false;
                downAttackButton.Visible = false;
            }
            else
            {
                upAttackButton.Text = "↑";
                leftAttackButton.Visible = true;
                rightAttackButton.Visible = true;
                downAttackButton.Visible = true;
            }
        }
    }
}
