namespace The_Journey
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.player = new System.Windows.Forms.PictureBox();
            this.bat = new System.Windows.Forms.PictureBox();
            this.ghost = new System.Windows.Forms.PictureBox();
            this.ghoul = new System.Windows.Forms.PictureBox();
            this.bluePotion = new System.Windows.Forms.PictureBox();
            this.redPotion = new System.Windows.Forms.PictureBox();
            this.sword = new System.Windows.Forms.PictureBox();
            this.bow = new System.Windows.Forms.PictureBox();
            this.mace = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playerHitPoints = new System.Windows.Forms.Label();
            this.batHitPoints = new System.Windows.Forms.Label();
            this.ghostHitPoints = new System.Windows.Forms.Label();
            this.ghoultHitPoints = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.upMoveButton = new System.Windows.Forms.Button();
            this.leftMoveButton = new System.Windows.Forms.Button();
            this.downMoveButton = new System.Windows.Forms.Button();
            this.rightMoveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.upAttackButton = new System.Windows.Forms.Button();
            this.leftAttackButton = new System.Windows.Forms.Button();
            this.downAttackButton = new System.Windows.Forms.Button();
            this.rightAttackButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.playerHitPoints, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.batHitPoints, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ghostHitPoints, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ghoultHitPoints, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(480, 287);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(181, 61);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(90, 64);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(30, 30);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            this.player.Visible = false;
            // 
            // bat
            // 
            this.bat.BackColor = System.Drawing.Color.Transparent;
            this.bat.Image = ((System.Drawing.Image)(resources.GetObject("bat.Image")));
            this.bat.Location = new System.Drawing.Point(126, 64);
            this.bat.Name = "bat";
            this.bat.Size = new System.Drawing.Size(30, 30);
            this.bat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bat.TabIndex = 2;
            this.bat.TabStop = false;
            this.bat.Visible = false;
            // 
            // ghost
            // 
            this.ghost.BackColor = System.Drawing.Color.Transparent;
            this.ghost.Image = ((System.Drawing.Image)(resources.GetObject("ghost.Image")));
            this.ghost.Location = new System.Drawing.Point(162, 64);
            this.ghost.Name = "ghost";
            this.ghost.Size = new System.Drawing.Size(30, 30);
            this.ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghost.TabIndex = 3;
            this.ghost.TabStop = false;
            this.ghost.Visible = false;
            // 
            // ghoul
            // 
            this.ghoul.BackColor = System.Drawing.Color.Transparent;
            this.ghoul.Image = ((System.Drawing.Image)(resources.GetObject("ghoul.Image")));
            this.ghoul.Location = new System.Drawing.Point(198, 64);
            this.ghoul.Name = "ghoul";
            this.ghoul.Size = new System.Drawing.Size(30, 30);
            this.ghoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghoul.TabIndex = 4;
            this.ghoul.TabStop = false;
            this.ghoul.Visible = false;
            // 
            // bluePotion
            // 
            this.bluePotion.BackColor = System.Drawing.Color.Transparent;
            this.bluePotion.Image = ((System.Drawing.Image)(resources.GetObject("bluePotion.Image")));
            this.bluePotion.Location = new System.Drawing.Point(234, 64);
            this.bluePotion.Name = "bluePotion";
            this.bluePotion.Size = new System.Drawing.Size(30, 30);
            this.bluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bluePotion.TabIndex = 5;
            this.bluePotion.TabStop = false;
            this.bluePotion.Visible = false;
            // 
            // redPotion
            // 
            this.redPotion.BackColor = System.Drawing.Color.Transparent;
            this.redPotion.Image = ((System.Drawing.Image)(resources.GetObject("redPotion.Image")));
            this.redPotion.Location = new System.Drawing.Point(270, 64);
            this.redPotion.Name = "redPotion";
            this.redPotion.Size = new System.Drawing.Size(30, 30);
            this.redPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redPotion.TabIndex = 6;
            this.redPotion.TabStop = false;
            this.redPotion.Visible = false;
            // 
            // sword
            // 
            this.sword.BackColor = System.Drawing.Color.Transparent;
            this.sword.Image = ((System.Drawing.Image)(resources.GetObject("sword.Image")));
            this.sword.Location = new System.Drawing.Point(306, 64);
            this.sword.Name = "sword";
            this.sword.Size = new System.Drawing.Size(30, 30);
            this.sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sword.TabIndex = 7;
            this.sword.TabStop = false;
            this.sword.Visible = false;
            // 
            // bow
            // 
            this.bow.BackColor = System.Drawing.Color.Transparent;
            this.bow.Image = ((System.Drawing.Image)(resources.GetObject("bow.Image")));
            this.bow.Location = new System.Drawing.Point(342, 64);
            this.bow.Name = "bow";
            this.bow.Size = new System.Drawing.Size(30, 30);
            this.bow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bow.TabIndex = 8;
            this.bow.TabStop = false;
            this.bow.Visible = false;
            // 
            // mace
            // 
            this.mace.BackColor = System.Drawing.Color.Transparent;
            this.mace.Image = ((System.Drawing.Image)(resources.GetObject("mace.Image")));
            this.mace.Location = new System.Drawing.Point(378, 64);
            this.mace.Name = "mace";
            this.mace.Size = new System.Drawing.Size(30, 30);
            this.mace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mace.TabIndex = 9;
            this.mace.TabStop = false;
            this.mace.Visible = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(90, 372);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(50, 50);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 10;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(148, 372);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(50, 50);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 11;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(204, 372);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(50, 50);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 12;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(260, 372);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(50, 50);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 13;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(316, 372);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(50, 50);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 14;
            this.pictureBox14.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gracz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nietoperz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Upiór";
            // 
            // playerHitPoints
            // 
            this.playerHitPoints.AutoSize = true;
            this.playerHitPoints.Location = new System.Drawing.Point(70, 0);
            this.playerHitPoints.Name = "playerHitPoints";
            this.playerHitPoints.Size = new System.Drawing.Size(77, 13);
            this.playerHitPoints.TabIndex = 4;
            this.playerHitPoints.Text = "playerHitPoints";
            // 
            // batHitPoints
            // 
            this.batHitPoints.AutoSize = true;
            this.batHitPoints.Location = new System.Drawing.Point(70, 15);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(64, 13);
            this.batHitPoints.TabIndex = 5;
            this.batHitPoints.Text = "batHitPoints";
            // 
            // ghostHitPoints
            // 
            this.ghostHitPoints.AutoSize = true;
            this.ghostHitPoints.Location = new System.Drawing.Point(70, 30);
            this.ghostHitPoints.Name = "ghostHitPoints";
            this.ghostHitPoints.Size = new System.Drawing.Size(75, 13);
            this.ghostHitPoints.TabIndex = 6;
            this.ghostHitPoints.Text = "ghostHitPoints";
            // 
            // ghoultHitPoints
            // 
            this.ghoultHitPoints.AutoSize = true;
            this.ghoultHitPoints.Location = new System.Drawing.Point(70, 45);
            this.ghoultHitPoints.Name = "ghoultHitPoints";
            this.ghoultHitPoints.Size = new System.Drawing.Size(75, 13);
            this.ghoultHitPoints.TabIndex = 7;
            this.ghoultHitPoints.Text = "ghoulHitPoints";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.upMoveButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.leftMoveButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.downMoveButton, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.rightMoveButton, 2, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(395, 361);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(97, 83);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label5, 2);
            this.label5.Location = new System.Drawing.Point(3, 1);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ruch";
            // 
            // upMoveButton
            // 
            this.upMoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.upMoveButton.Location = new System.Drawing.Point(35, 19);
            this.upMoveButton.Name = "upMoveButton";
            this.upMoveButton.Size = new System.Drawing.Size(26, 27);
            this.upMoveButton.TabIndex = 1;
            this.upMoveButton.Text = "↑";
            this.upMoveButton.UseVisualStyleBackColor = true;
            // 
            // leftMoveButton
            // 
            this.leftMoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftMoveButton.Location = new System.Drawing.Point(3, 52);
            this.leftMoveButton.Name = "leftMoveButton";
            this.leftMoveButton.Size = new System.Drawing.Size(26, 28);
            this.leftMoveButton.TabIndex = 2;
            this.leftMoveButton.Text = "←";
            this.leftMoveButton.UseVisualStyleBackColor = true;
            // 
            // downMoveButton
            // 
            this.downMoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.downMoveButton.Location = new System.Drawing.Point(35, 52);
            this.downMoveButton.Name = "downMoveButton";
            this.downMoveButton.Size = new System.Drawing.Size(26, 28);
            this.downMoveButton.TabIndex = 3;
            this.downMoveButton.Text = "↓";
            this.downMoveButton.UseVisualStyleBackColor = true;
            // 
            // rightMoveButton
            // 
            this.rightMoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rightMoveButton.Location = new System.Drawing.Point(67, 52);
            this.rightMoveButton.Name = "rightMoveButton";
            this.rightMoveButton.Size = new System.Drawing.Size(27, 28);
            this.rightMoveButton.TabIndex = 4;
            this.rightMoveButton.Text = "→";
            this.rightMoveButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.upAttackButton, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.leftAttackButton, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.downAttackButton, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.rightAttackButton, 2, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(514, 361);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(97, 83);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label6, 2);
            this.label6.Location = new System.Drawing.Point(3, 1);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Atak";
            // 
            // upAttackButton
            // 
            this.upAttackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.upAttackButton.Location = new System.Drawing.Point(35, 19);
            this.upAttackButton.Name = "upAttackButton";
            this.upAttackButton.Size = new System.Drawing.Size(26, 27);
            this.upAttackButton.TabIndex = 1;
            this.upAttackButton.Text = "↑";
            this.upAttackButton.UseVisualStyleBackColor = true;
            // 
            // leftAttackButton
            // 
            this.leftAttackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftAttackButton.Location = new System.Drawing.Point(3, 52);
            this.leftAttackButton.Name = "leftAttackButton";
            this.leftAttackButton.Size = new System.Drawing.Size(26, 28);
            this.leftAttackButton.TabIndex = 2;
            this.leftAttackButton.Text = "←";
            this.leftAttackButton.UseVisualStyleBackColor = true;
            // 
            // downAttackButton
            // 
            this.downAttackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.downAttackButton.Location = new System.Drawing.Point(35, 52);
            this.downAttackButton.Name = "downAttackButton";
            this.downAttackButton.Size = new System.Drawing.Size(26, 28);
            this.downAttackButton.TabIndex = 3;
            this.downAttackButton.Text = "↓";
            this.downAttackButton.UseVisualStyleBackColor = true;
            // 
            // rightAttackButton
            // 
            this.rightAttackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rightAttackButton.Location = new System.Drawing.Point(67, 52);
            this.rightAttackButton.Name = "rightAttackButton";
            this.rightAttackButton.Size = new System.Drawing.Size(27, 28);
            this.rightAttackButton.TabIndex = 4;
            this.rightAttackButton.Text = "→";
            this.rightAttackButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(726, 466);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.player);
            this.Controls.Add(this.redPotion);
            this.Controls.Add(this.bluePotion);
            this.Controls.Add(this.ghoul);
            this.Controls.Add(this.ghost);
            this.Controls.Add(this.bat);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.sword);
            this.Controls.Add(this.bow);
            this.Controls.Add(this.mace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Wyprawa";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label playerHitPoints;
        private System.Windows.Forms.Label batHitPoints;
        private System.Windows.Forms.Label ghostHitPoints;
        private System.Windows.Forms.Label ghoultHitPoints;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox bat;
        private System.Windows.Forms.PictureBox ghost;
        private System.Windows.Forms.PictureBox ghoul;
        private System.Windows.Forms.PictureBox bluePotion;
        private System.Windows.Forms.PictureBox redPotion;
        private System.Windows.Forms.PictureBox sword;
        private System.Windows.Forms.PictureBox bow;
        private System.Windows.Forms.PictureBox mace;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button upMoveButton;
        private System.Windows.Forms.Button leftMoveButton;
        private System.Windows.Forms.Button downMoveButton;
        private System.Windows.Forms.Button rightMoveButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button upAttackButton;
        private System.Windows.Forms.Button leftAttackButton;
        private System.Windows.Forms.Button downAttackButton;
        private System.Windows.Forms.Button rightAttackButton;
    }
}

