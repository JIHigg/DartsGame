
namespace DartsGame
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.NewGame = new System.Windows.Forms.Button();
            this.SaveGame = new System.Windows.Forms.Button();
            this.LoadGame = new System.Windows.Forms.Button();
            this.SaveLoadDisplay = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.InputLabelFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Player1Label = new System.Windows.Forms.Label();
            this.Player2Label = new System.Windows.Forms.Label();
            this.TwoPlayerCheckBox = new System.Windows.Forms.CheckBox();
            this.playerNameFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.player1TextBox = new System.Windows.Forms.TextBox();
            this.Player2TextBox = new System.Windows.Forms.TextBox();
            this.ScoreLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.scoreFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.Player1ScoreLabel = new System.Windows.Forms.Label();
            this.Player2ScoreLabel = new System.Windows.Forms.Label();
            this.CurrentPlayerLabel = new System.Windows.Forms.Label();
            this.PlayerScoreFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.Player1Score = new System.Windows.Forms.Label();
            this.Player2Score = new System.Windows.Forms.Label();
            this.CurrentPlayerDisplay = new System.Windows.Forms.Label();
            this.OutputDisplayLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OutputDisplayFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.Display1 = new System.Windows.Forms.Label();
            this.NumberSelectionFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.ThrowBtn = new System.Windows.Forms.Button();
            this.numUpDownAim = new System.Windows.Forms.NumericUpDown();
            this.TurnFlavorText = new System.Windows.Forms.Label();
            this.ComContinueBtn = new System.Windows.Forms.Button();
            this.dartFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DartDisplayLabel = new System.Windows.Forms.Label();
            this.DartsLeftDisplay = new System.Windows.Forms.Label();
            this.ResultLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ResultflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultOutput = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.InputLabelFlowPanel.SuspendLayout();
            this.playerNameFlowPanel.SuspendLayout();
            this.ScoreLayoutPanel.SuspendLayout();
            this.scoreFlowLayoutPanel.SuspendLayout();
            this.PlayerScoreFlowLayout.SuspendLayout();
            this.OutputDisplayLayoutPanel.SuspendLayout();
            this.OutputDisplayFlow.SuspendLayout();
            this.NumberSelectionFlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAim)).BeginInit();
            this.dartFlowLayoutPanel.SuspendLayout();
            this.ResultLayoutPanel.SuspendLayout();
            this.ResultflowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ExitBtn, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.NewGame);
            this.flowLayoutPanel1.Controls.Add(this.SaveGame);
            this.flowLayoutPanel1.Controls.Add(this.LoadGame);
            this.flowLayoutPanel1.Controls.Add(this.SaveLoadDisplay);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(154, 399);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(15, 15);
            this.NewGame.Margin = new System.Windows.Forms.Padding(15, 15, 3, 3);
            this.NewGame.Name = "NewGame";
            this.NewGame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NewGame.Size = new System.Drawing.Size(108, 58);
            this.NewGame.TabIndex = 2;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // SaveGame
            // 
            this.SaveGame.Location = new System.Drawing.Point(15, 91);
            this.SaveGame.Margin = new System.Windows.Forms.Padding(15, 15, 3, 3);
            this.SaveGame.Name = "SaveGame";
            this.SaveGame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SaveGame.Size = new System.Drawing.Size(108, 58);
            this.SaveGame.TabIndex = 0;
            this.SaveGame.Text = "Save Game";
            this.SaveGame.UseVisualStyleBackColor = true;
            this.SaveGame.Click += new System.EventHandler(this.SaveGame_Click);
            // 
            // LoadGame
            // 
            this.LoadGame.Location = new System.Drawing.Point(15, 167);
            this.LoadGame.Margin = new System.Windows.Forms.Padding(15, 15, 3, 3);
            this.LoadGame.Name = "LoadGame";
            this.LoadGame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoadGame.Size = new System.Drawing.Size(108, 58);
            this.LoadGame.TabIndex = 1;
            this.LoadGame.Text = "Load Game";
            this.LoadGame.UseVisualStyleBackColor = true;
            this.LoadGame.Click += new System.EventHandler(this.LoadGame_Click);
            // 
            // SaveLoadDisplay
            // 
            this.SaveLoadDisplay.AutoSize = true;
            this.SaveLoadDisplay.Location = new System.Drawing.Point(15, 243);
            this.SaveLoadDisplay.Margin = new System.Windows.Forms.Padding(15, 15, 3, 0);
            this.SaveLoadDisplay.Name = "SaveLoadDisplay";
            this.SaveLoadDisplay.Size = new System.Drawing.Size(10, 13);
            this.SaveLoadDisplay.TabIndex = 3;
            this.SaveLoadDisplay.Text = " ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ScoreLayoutPanel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.OutputDisplayLayoutPanel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ResultLayoutPanel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(163, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(634, 399);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.18971F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.81029F));
            this.tableLayoutPanel3.Controls.Add(this.InputLabelFlowPanel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.playerNameFlowPanel, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 202);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(311, 194);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // InputLabelFlowPanel
            // 
            this.InputLabelFlowPanel.Controls.Add(this.Player1Label);
            this.InputLabelFlowPanel.Controls.Add(this.Player2Label);
            this.InputLabelFlowPanel.Controls.Add(this.TwoPlayerCheckBox);
            this.InputLabelFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputLabelFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.InputLabelFlowPanel.Location = new System.Drawing.Point(3, 3);
            this.InputLabelFlowPanel.Name = "InputLabelFlowPanel";
            this.InputLabelFlowPanel.Size = new System.Drawing.Size(91, 188);
            this.InputLabelFlowPanel.TabIndex = 0;
            // 
            // Player1Label
            // 
            this.Player1Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Player1Label.AutoSize = true;
            this.Player1Label.Location = new System.Drawing.Point(34, 10);
            this.Player1Label.Margin = new System.Windows.Forms.Padding(25, 10, 3, 0);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(45, 13);
            this.Player1Label.TabIndex = 0;
            this.Player1Label.Text = "Player 1";
            // 
            // Player2Label
            // 
            this.Player2Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Player2Label.AutoSize = true;
            this.Player2Label.Location = new System.Drawing.Point(34, 43);
            this.Player2Label.Margin = new System.Windows.Forms.Padding(25, 20, 3, 0);
            this.Player2Label.Name = "Player2Label";
            this.Player2Label.Size = new System.Drawing.Size(45, 13);
            this.Player2Label.TabIndex = 1;
            this.Player2Label.Text = "Player 2";
            // 
            // TwoPlayerCheckBox
            // 
            this.TwoPlayerCheckBox.AutoSize = true;
            this.TwoPlayerCheckBox.Location = new System.Drawing.Point(5, 79);
            this.TwoPlayerCheckBox.Margin = new System.Windows.Forms.Padding(5, 23, 3, 3);
            this.TwoPlayerCheckBox.Name = "TwoPlayerCheckBox";
            this.TwoPlayerCheckBox.Size = new System.Drawing.Size(84, 17);
            this.TwoPlayerCheckBox.TabIndex = 2;
            this.TwoPlayerCheckBox.Text = "Two Players";
            this.TwoPlayerCheckBox.UseVisualStyleBackColor = true;
            // 
            // playerNameFlowPanel
            // 
            this.playerNameFlowPanel.Controls.Add(this.player1TextBox);
            this.playerNameFlowPanel.Controls.Add(this.Player2TextBox);
            this.playerNameFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerNameFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.playerNameFlowPanel.Location = new System.Drawing.Point(100, 3);
            this.playerNameFlowPanel.Name = "playerNameFlowPanel";
            this.playerNameFlowPanel.Size = new System.Drawing.Size(208, 188);
            this.playerNameFlowPanel.TabIndex = 1;
            // 
            // player1TextBox
            // 
            this.player1TextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.player1TextBox.Location = new System.Drawing.Point(3, 10);
            this.player1TextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.player1TextBox.Name = "player1TextBox";
            this.player1TextBox.Size = new System.Drawing.Size(117, 20);
            this.player1TextBox.TabIndex = 0;
            this.player1TextBox.Text = "Player 1 Name";
            // 
            // Player2TextBox
            // 
            this.Player2TextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Player2TextBox.Location = new System.Drawing.Point(3, 40);
            this.Player2TextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.Player2TextBox.Name = "Player2TextBox";
            this.Player2TextBox.Size = new System.Drawing.Size(117, 20);
            this.Player2TextBox.TabIndex = 1;
            this.Player2TextBox.Text = "Player 2 Name";
            // 
            // ScoreLayoutPanel
            // 
            this.ScoreLayoutPanel.ColumnCount = 2;
            this.ScoreLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.76206F));
            this.ScoreLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.23795F));
            this.ScoreLayoutPanel.Controls.Add(this.scoreFlowLayoutPanel, 0, 0);
            this.ScoreLayoutPanel.Controls.Add(this.PlayerScoreFlowLayout, 1, 0);
            this.ScoreLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScoreLayoutPanel.Location = new System.Drawing.Point(320, 202);
            this.ScoreLayoutPanel.Name = "ScoreLayoutPanel";
            this.ScoreLayoutPanel.RowCount = 1;
            this.ScoreLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.80412F));
            this.ScoreLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.19588F));
            this.ScoreLayoutPanel.Size = new System.Drawing.Size(311, 194);
            this.ScoreLayoutPanel.TabIndex = 4;
            this.ScoreLayoutPanel.Visible = false;
            // 
            // scoreFlowLayoutPanel
            // 
            this.scoreFlowLayoutPanel.Controls.Add(this.ScoreLabel);
            this.scoreFlowLayoutPanel.Controls.Add(this.Player1ScoreLabel);
            this.scoreFlowLayoutPanel.Controls.Add(this.Player2ScoreLabel);
            this.scoreFlowLayoutPanel.Controls.Add(this.CurrentPlayerLabel);
            this.scoreFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.scoreFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.scoreFlowLayoutPanel.Name = "scoreFlowLayoutPanel";
            this.scoreFlowLayoutPanel.Size = new System.Drawing.Size(98, 188);
            this.scoreFlowLayoutPanel.TabIndex = 0;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(15, 10);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(48, 15);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "Score:";
            // 
            // Player1ScoreLabel
            // 
            this.Player1ScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Player1ScoreLabel.AutoSize = true;
            this.Player1ScoreLabel.Location = new System.Drawing.Point(18, 35);
            this.Player1ScoreLabel.Margin = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.Player1ScoreLabel.Name = "Player1ScoreLabel";
            this.Player1ScoreLabel.Size = new System.Drawing.Size(45, 13);
            this.Player1ScoreLabel.TabIndex = 1;
            this.Player1ScoreLabel.Text = "Player 1";
            // 
            // Player2ScoreLabel
            // 
            this.Player2ScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Player2ScoreLabel.AutoSize = true;
            this.Player2ScoreLabel.Location = new System.Drawing.Point(18, 58);
            this.Player2ScoreLabel.Margin = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.Player2ScoreLabel.Name = "Player2ScoreLabel";
            this.Player2ScoreLabel.Size = new System.Drawing.Size(45, 13);
            this.Player2ScoreLabel.TabIndex = 2;
            this.Player2ScoreLabel.Text = "Player 2";
            // 
            // CurrentPlayerLabel
            // 
            this.CurrentPlayerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentPlayerLabel.AutoSize = true;
            this.CurrentPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPlayerLabel.Location = new System.Drawing.Point(23, 81);
            this.CurrentPlayerLabel.Margin = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.CurrentPlayerLabel.Name = "CurrentPlayerLabel";
            this.CurrentPlayerLabel.Size = new System.Drawing.Size(40, 15);
            this.CurrentPlayerLabel.TabIndex = 3;
            this.CurrentPlayerLabel.Text = "Turn:";
            // 
            // PlayerScoreFlowLayout
            // 
            this.PlayerScoreFlowLayout.Controls.Add(this.Player1Score);
            this.PlayerScoreFlowLayout.Controls.Add(this.Player2Score);
            this.PlayerScoreFlowLayout.Controls.Add(this.CurrentPlayerDisplay);
            this.PlayerScoreFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PlayerScoreFlowLayout.Location = new System.Drawing.Point(107, 3);
            this.PlayerScoreFlowLayout.Name = "PlayerScoreFlowLayout";
            this.PlayerScoreFlowLayout.Size = new System.Drawing.Size(150, 100);
            this.PlayerScoreFlowLayout.TabIndex = 1;
            // 
            // Player1Score
            // 
            this.Player1Score.AutoSize = true;
            this.Player1Score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player1Score.Location = new System.Drawing.Point(0, 35);
            this.Player1Score.Margin = new System.Windows.Forms.Padding(0, 35, 3, 0);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.Size = new System.Drawing.Size(45, 13);
            this.Player1Score.TabIndex = 0;
            this.Player1Score.Text = "301";
            // 
            // Player2Score
            // 
            this.Player2Score.AutoSize = true;
            this.Player2Score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player2Score.Location = new System.Drawing.Point(0, 58);
            this.Player2Score.Margin = new System.Windows.Forms.Padding(0, 10, 3, 0);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.Size = new System.Drawing.Size(45, 13);
            this.Player2Score.TabIndex = 1;
            this.Player2Score.Text = "301";
            // 
            // CurrentPlayerDisplay
            // 
            this.CurrentPlayerDisplay.AutoSize = true;
            this.CurrentPlayerDisplay.Location = new System.Drawing.Point(0, 81);
            this.CurrentPlayerDisplay.Margin = new System.Windows.Forms.Padding(0, 10, 3, 0);
            this.CurrentPlayerDisplay.Name = "CurrentPlayerDisplay";
            this.CurrentPlayerDisplay.Size = new System.Drawing.Size(45, 13);
            this.CurrentPlayerDisplay.TabIndex = 2;
            this.CurrentPlayerDisplay.Text = "Player 1";
            // 
            // OutputDisplayLayoutPanel
            // 
            this.OutputDisplayLayoutPanel.ColumnCount = 2;
            this.OutputDisplayLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OutputDisplayLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OutputDisplayLayoutPanel.Controls.Add(this.OutputDisplayFlow, 0, 0);
            this.OutputDisplayLayoutPanel.Controls.Add(this.NumberSelectionFlow, 0, 1);
            this.OutputDisplayLayoutPanel.Controls.Add(this.dartFlowLayoutPanel, 1, 0);
            this.OutputDisplayLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputDisplayLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.OutputDisplayLayoutPanel.Name = "OutputDisplayLayoutPanel";
            this.OutputDisplayLayoutPanel.RowCount = 2;
            this.OutputDisplayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OutputDisplayLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OutputDisplayLayoutPanel.Size = new System.Drawing.Size(311, 193);
            this.OutputDisplayLayoutPanel.TabIndex = 5;
            // 
            // OutputDisplayFlow
            // 
            this.OutputDisplayFlow.Controls.Add(this.Display1);
            this.OutputDisplayFlow.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.OutputDisplayFlow.Location = new System.Drawing.Point(3, 3);
            this.OutputDisplayFlow.Name = "OutputDisplayFlow";
            this.OutputDisplayFlow.Size = new System.Drawing.Size(149, 90);
            this.OutputDisplayFlow.TabIndex = 0;
            // 
            // Display1
            // 
            this.Display1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Display1.AutoSize = true;
            this.Display1.Location = new System.Drawing.Point(9, 20);
            this.Display1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.Display1.Name = "Display1";
            this.Display1.Size = new System.Drawing.Size(137, 52);
            this.Display1.TabIndex = 0;
            this.Display1.Text = "Welcome To Darts! \r\nEnter names for one or two players, then press \'New Game\'\r\n";
            // 
            // NumberSelectionFlow
            // 
            this.OutputDisplayLayoutPanel.SetColumnSpan(this.NumberSelectionFlow, 2);
            this.NumberSelectionFlow.Controls.Add(this.ThrowBtn);
            this.NumberSelectionFlow.Controls.Add(this.numUpDownAim);
            this.NumberSelectionFlow.Controls.Add(this.TurnFlavorText);
            this.NumberSelectionFlow.Controls.Add(this.ComContinueBtn);
            this.NumberSelectionFlow.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.NumberSelectionFlow.Location = new System.Drawing.Point(3, 99);
            this.NumberSelectionFlow.Name = "NumberSelectionFlow";
            this.NumberSelectionFlow.Size = new System.Drawing.Size(305, 91);
            this.NumberSelectionFlow.TabIndex = 1;
            this.NumberSelectionFlow.Visible = false;
            // 
            // ThrowBtn
            // 
            this.ThrowBtn.Location = new System.Drawing.Point(227, 3);
            this.ThrowBtn.Name = "ThrowBtn";
            this.ThrowBtn.Size = new System.Drawing.Size(75, 23);
            this.ThrowBtn.TabIndex = 2;
            this.ThrowBtn.Text = "Throw";
            this.ThrowBtn.UseVisualStyleBackColor = true;
            this.ThrowBtn.Click += new System.EventHandler(this.ThrowBtn_Click);
            // 
            // numUpDownAim
            // 
            this.numUpDownAim.Location = new System.Drawing.Point(172, 3);
            this.numUpDownAim.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpDownAim.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownAim.Name = "numUpDownAim";
            this.numUpDownAim.Size = new System.Drawing.Size(49, 20);
            this.numUpDownAim.TabIndex = 0;
            this.numUpDownAim.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TurnFlavorText
            // 
            this.TurnFlavorText.Location = new System.Drawing.Point(29, 5);
            this.TurnFlavorText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.TurnFlavorText.Name = "TurnFlavorText";
            this.TurnFlavorText.Size = new System.Drawing.Size(137, 50);
            this.TurnFlavorText.TabIndex = 1;
            this.TurnFlavorText.Text = "Select a number on the dartboard (1-20) to aim for:\r\n";
            // 
            // ComContinueBtn
            // 
            this.ComContinueBtn.Location = new System.Drawing.Point(227, 61);
            this.ComContinueBtn.Name = "ComContinueBtn";
            this.ComContinueBtn.Size = new System.Drawing.Size(75, 23);
            this.ComContinueBtn.TabIndex = 3;
            this.ComContinueBtn.Text = "Continue";
            this.ComContinueBtn.UseVisualStyleBackColor = true;
            this.ComContinueBtn.Visible = false;
            this.ComContinueBtn.Click += new System.EventHandler(this.ComContinueBtn_Click);
            // 
            // dartFlowLayoutPanel
            // 
            this.dartFlowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dartFlowLayoutPanel.Controls.Add(this.DartDisplayLabel);
            this.dartFlowLayoutPanel.Controls.Add(this.DartsLeftDisplay);
            this.dartFlowLayoutPanel.Location = new System.Drawing.Point(158, 23);
            this.dartFlowLayoutPanel.Name = "dartFlowLayoutPanel";
            this.dartFlowLayoutPanel.Size = new System.Drawing.Size(150, 50);
            this.dartFlowLayoutPanel.TabIndex = 2;
            // 
            // DartDisplayLabel
            // 
            this.DartDisplayLabel.AutoSize = true;
            this.DartDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DartDisplayLabel.Location = new System.Drawing.Point(13, 20);
            this.DartDisplayLabel.Margin = new System.Windows.Forms.Padding(13, 20, 3, 0);
            this.DartDisplayLabel.Name = "DartDisplayLabel";
            this.DartDisplayLabel.Size = new System.Drawing.Size(77, 15);
            this.DartDisplayLabel.TabIndex = 0;
            this.DartDisplayLabel.Text = "Darts Left: ";
            // 
            // DartsLeftDisplay
            // 
            this.DartsLeftDisplay.AutoSize = true;
            this.DartsLeftDisplay.Location = new System.Drawing.Point(106, 20);
            this.DartsLeftDisplay.Margin = new System.Windows.Forms.Padding(13, 20, 3, 0);
            this.DartsLeftDisplay.Name = "DartsLeftDisplay";
            this.DartsLeftDisplay.Size = new System.Drawing.Size(13, 13);
            this.DartsLeftDisplay.TabIndex = 1;
            this.DartsLeftDisplay.Text = "0";
            // 
            // ResultLayoutPanel
            // 
            this.ResultLayoutPanel.ColumnCount = 1;
            this.ResultLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ResultLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ResultLayoutPanel.Controls.Add(this.ResultflowLayoutPanel, 0, 1);
            this.ResultLayoutPanel.Controls.Add(this.pictureBox1, 0, 0);
            this.ResultLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultLayoutPanel.Location = new System.Drawing.Point(320, 3);
            this.ResultLayoutPanel.Name = "ResultLayoutPanel";
            this.ResultLayoutPanel.RowCount = 2;
            this.ResultLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ResultLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ResultLayoutPanel.Size = new System.Drawing.Size(311, 193);
            this.ResultLayoutPanel.TabIndex = 6;
            // 
            // ResultflowLayoutPanel
            // 
            this.ResultflowLayoutPanel.Controls.Add(this.ResultLabel);
            this.ResultflowLayoutPanel.Controls.Add(this.ResultOutput);
            this.ResultflowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultflowLayoutPanel.Location = new System.Drawing.Point(3, 99);
            this.ResultflowLayoutPanel.Name = "ResultflowLayoutPanel";
            this.ResultflowLayoutPanel.Size = new System.Drawing.Size(305, 91);
            this.ResultflowLayoutPanel.TabIndex = 0;
            this.ResultflowLayoutPanel.Visible = false;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Stencil Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(3, 20);
            this.ResultLabel.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(71, 17);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = "Result: ";
            // 
            // ResultOutput
            // 
            this.ResultOutput.AutoSize = true;
            this.ResultOutput.Location = new System.Drawing.Point(80, 20);
            this.ResultOutput.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.ResultOutput.Name = "ResultOutput";
            this.ResultOutput.Size = new System.Drawing.Size(10, 13);
            this.ResultOutput.TabIndex = 1;
            this.ResultOutput.Text = " ";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(15, 408);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Load Game";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DartsGame.Properties.Resources.dartboard;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Darts Game";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.InputLabelFlowPanel.ResumeLayout(false);
            this.InputLabelFlowPanel.PerformLayout();
            this.playerNameFlowPanel.ResumeLayout(false);
            this.playerNameFlowPanel.PerformLayout();
            this.ScoreLayoutPanel.ResumeLayout(false);
            this.scoreFlowLayoutPanel.ResumeLayout(false);
            this.scoreFlowLayoutPanel.PerformLayout();
            this.PlayerScoreFlowLayout.ResumeLayout(false);
            this.PlayerScoreFlowLayout.PerformLayout();
            this.OutputDisplayLayoutPanel.ResumeLayout(false);
            this.OutputDisplayFlow.ResumeLayout(false);
            this.OutputDisplayFlow.PerformLayout();
            this.NumberSelectionFlow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAim)).EndInit();
            this.dartFlowLayoutPanel.ResumeLayout(false);
            this.dartFlowLayoutPanel.PerformLayout();
            this.ResultLayoutPanel.ResumeLayout(false);
            this.ResultLayoutPanel.PerformLayout();
            this.ResultflowLayoutPanel.ResumeLayout(false);
            this.ResultflowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button SaveGame;
        private System.Windows.Forms.Button LoadGame;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel InputLabelFlowPanel;
        private System.Windows.Forms.Label Player1Label;
        private System.Windows.Forms.Label Player2Label;
        private System.Windows.Forms.CheckBox TwoPlayerCheckBox;
        private System.Windows.Forms.FlowLayoutPanel playerNameFlowPanel;
        private System.Windows.Forms.TextBox player1TextBox;
        private System.Windows.Forms.TextBox Player2TextBox;
        private System.Windows.Forms.TableLayoutPanel ScoreLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel scoreFlowLayoutPanel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label Player1ScoreLabel;
        private System.Windows.Forms.Label Player2ScoreLabel;
        private System.Windows.Forms.FlowLayoutPanel PlayerScoreFlowLayout;
        private System.Windows.Forms.Label Player1Score;
        private System.Windows.Forms.Label Player2Score;
        private System.Windows.Forms.Label CurrentPlayerLabel;
        private System.Windows.Forms.Label CurrentPlayerDisplay;
        private System.Windows.Forms.TableLayoutPanel OutputDisplayLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel OutputDisplayFlow;
        private System.Windows.Forms.Label Display1;
        private System.Windows.Forms.FlowLayoutPanel NumberSelectionFlow;
        private System.Windows.Forms.NumericUpDown numUpDownAim;
        private System.Windows.Forms.Label TurnFlavorText;
        private System.Windows.Forms.Button ThrowBtn;
        private System.Windows.Forms.FlowLayoutPanel dartFlowLayoutPanel;
        private System.Windows.Forms.Label DartDisplayLabel;
        private System.Windows.Forms.Label DartsLeftDisplay;
        private System.Windows.Forms.TableLayoutPanel ResultLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel ResultflowLayoutPanel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label ResultOutput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ComContinueBtn;
        private System.Windows.Forms.Label SaveLoadDisplay;
        private System.Windows.Forms.Button ExitBtn;
    }
}

