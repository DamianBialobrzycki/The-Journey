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

            player.Visible = true;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    bat.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }

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

            if (!showBat)
            {
                bat.Visible = false;
                batHitPoints.Text = "";
            }
            else bat.Visible = true;

            if (!showGhost)
            {
                ghost.Visible = false;
                ghostHitPoints.Text = "";
            }
            else ghost.Visible = true;

           if (!showGhoul)
           {
                ghoul.Visible = false;
                ghoulHitPoints.Text = "";
           }
           else ghoul.Visible = true;

            inventorySword.Visible = false;
            inventoryBow.Visible = false;
            inventoryRedPotion.Visible = false;
            inventoryBluePotion.Visible = false;
            inventoryMace.Visible = false;

            sword.Visible = false;
            bow.Visible = false;
            redPotion.Visible = false;
            bluePotion.Visible = false;
            mace.Visible = false;

            Control weaponControl = null;

            switch (game.WeaponInRoom.Name)
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
                    weaponControl = bluePotion;
                    break;
            }

            weaponControl.Visible = true;

            if (game.CheckPlayerInventory("Miecz")) inventorySword.Visible = true;
            if (game.CheckPlayerInventory("Łuk")) inventoryBow.Visible = true;
            if (game.CheckPlayerInventory("Buława")) inventoryMace.Visible = true;
            if (game.CheckPlayerInventory("Niebieska mikstura")) inventoryBluePotion.Visible = true;
            if (game.CheckPlayerInventory("Czerwona mikstura")) inventoryRedPotion.Visible = true;

            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
                weaponControl.Visible = true;

            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("Zostałeś zabity");
                Application.Exit();
            }
            if (enemiesShown < 1)
            {
                MessageBox.Show("Pokonałeś przeciwników na tym poziomie");
                game.NewLevel(random);
                UpdateCharacters();
            }
        }
        




        private void upMoveButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void downMoveButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void leftMoveButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
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

        private void downAttackButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void leftAttackButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void rightAttackButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void inventorySword_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Miecz"))
            {
                game.Equip("Miecz");
                ClearEquiped();
                inventorySword.BorderStyle = BorderStyle.FixedSingle;

                CheckPotion(false);
                UpdateCharacters();
            }
        }

        private void inventoryBow_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Łuk"))
            {
                game.Equip("Łuk");
                ClearEquiped();
                inventoryBow.BorderStyle = BorderStyle.FixedSingle;

                CheckPotion(false);
                UpdateCharacters();
            }
        }

        private void inventoryBluePotion_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Niebieska mikstura"))
            {
                game.Equip("Niebieska mikstura");
                ClearEquiped();
                inventoryBluePotion.BorderStyle = BorderStyle.FixedSingle;

                CheckPotion(true);
                UpdateCharacters();
            }
        }

        private void inventoryRedPotion_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Czerwona mikstura"))
            {
                game.Equip("Czerwona mikstura");
                ClearEquiped();
                inventoryRedPotion.BorderStyle = BorderStyle.FixedSingle;

                CheckPotion(true);
                UpdateCharacters();
            }
        }

        private void inventoryMace_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Buława"))
            {
                game.Equip("Buława");
                ClearEquiped();
                inventoryMace.BorderStyle = BorderStyle.FixedSingle;

                CheckPotion(false);
                UpdateCharacters();
            }
        }

        private void ClearEquiped()
        {
            inventorySword.BorderStyle = BorderStyle.None;
            inventoryBow.BorderStyle = BorderStyle.None;
            inventoryRedPotion.BorderStyle = BorderStyle.None;
            inventoryBluePotion.BorderStyle = BorderStyle.None;
            inventoryMace.BorderStyle = BorderStyle.None;
        }

        private void CheckPotion(bool isCheck)
        {
            if (isCheck)
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