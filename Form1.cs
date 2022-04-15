using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DartsGame
{
    public partial class Form1 : Form
    {

        

        private Game game = new Game();


        public Form1()
        {
            InitializeComponent();
            
        }

        //New Game
        private void NewGame_Click(object sender, EventArgs e)
        {
            
            
            game.Player1 = new Player(player1TextBox.Text);
            if (TwoPlayerCheckBox.Checked)
                game.Player2 = new Player(Player2TextBox.Text);
            else
            {
                game.Player2 = new Player("COM");
                game.Player2.IsCom = true;
            }

            //Name Display
            Player1ScoreLabel.Text = game.Player1.Name;
            Player2ScoreLabel.Text = game.Player2.Name;

            ScoreLayoutPanel.Visible = true;
            Display1.Text = $"You have started a new Game!\nPlayer 1 is {game.Player1.Name}\n" +
                $"Player 2 is {game.Player2.Name}";

           
            NumberSelectionFlow.Visible = true;
            ResultflowLayoutPanel.Visible = true;
            CurrentPlayerDisplay.Text = game.Player1.TurnsCount == game.Player2.TurnsCount ? game.Player1.Name : game.Player2.Name;

            DartsLeftDisplay.Text = $"{3-game.DartCounter}";
        }

        private void SaveGame_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Document|*.txt";
            saveFileDialog1.Title = "Save Game";
            

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var text = "";
                using(var textWriter = new StringWriter())
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(game.GetType());

                    xmlSerializer.Serialize(textWriter, game);
                    
                    text = textWriter.ToString();

                }

                using (var streamWriter = new StreamWriter(saveFileDialog1.FileName,true))
                {
                    try 
                    {
                        streamWriter.WriteLine(text);
                        SaveLoadDisplay.Text = "Game Saved!";
                    }catch (Exception ex)
                    {
                        SaveLoadDisplay.Text = ex.Message;
                    }

                    streamWriter.Close();
                }
            }
        }

        private void LoadGame_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                var results = "";

                using(var streamReader = new StreamReader(fileName))
                {
                    try
                    {
                        results = streamReader.ReadToEnd();
                    }
                    catch(Exception ex)
                    {
                        SaveLoadDisplay.Text = ex.Message;
                    }

                    streamReader.Close();
                }

                using(var stringReader  = new StringReader(results))
                {
                    XmlSerializer xml = new XmlSerializer(game.GetType());

                    try
                    {

                        Game loadedGame = (Game)xml.Deserialize(stringReader);
                        game = loadedGame;

                        SaveLoadDisplay.Text = "Game Loaded Succesfully";

                        //Resetting displays
                        player1TextBox.Text = game.Player1.Name;
                        Player2TextBox.Text = game.Player2.Name;
                        Display1.Text = $"Continuing Game of {game.Player1.Name} and {game.Player2.Name}!";
                        
                        Player1Score.Text = (301 - game.Player1.GetScore()).ToString();
                        Player2Score.Text = (301 - game.Player2.GetScore()).ToString();
                        
                        CurrentPlayerDisplay.Text = game.Player1.TurnsCount == game.Player2.TurnsCount ?
                            game.Player1.Name : game.Player2.Name;
                        DartsLeftDisplay.Text = (3 - game.DartCounter).ToString();

                        NumberSelectionFlow.Visible = true;
                        ScoreLayoutPanel.Visible = true;
                        ResultflowLayoutPanel.Visible = true;

                        ComContinueBtn_Click(sender, e);
                        
                    }
                    catch (Exception ex)
                    {
                        SaveLoadDisplay.Text = ex.Message;
                    }

                }
            }
        }

        private void ThrowBtn_Click(object sender, EventArgs e)
        {
            //Determine Player
            Player currentPlayer = game.Player1.TurnsCount == game.Player2.TurnsCount ? game.Player1 : game.Player2;
            CurrentPlayerDisplay.Text = currentPlayer.Name;

            //Target
            int aimNumber;
            if (!currentPlayer.IsCom)
                aimNumber = (int)numUpDownAim.Value;
            else aimNumber = new Random().Next(1, 20);

            //Result
            int result = game.Dartboard.Target(aimNumber);
            ResultOutput.Text = result == 0 ? $"{currentPlayer.Name} has missed the board!" :
                $"{currentPlayer.Name} hit {result}";

            //If Winner
            if(currentPlayer.GetScore() + result + game.TurnScore == 301)
            {
                NumberSelectionFlow.Visible = false;
                ResultOutput.Text = $"{currentPlayer.Name} WINS!!";
            }

            //Update Scores
            Player1Score.Text = currentPlayer == game.Player1 ? $"{301 - (game.Player1.GetScore() + game.TurnScore + result)}" :
                        Player1Score.Text;
            Player2Score.Text = currentPlayer == game.Player2 ? $"{301 - (game.Player2.GetScore() + game.TurnScore + result)}" :
                        Player2Score.Text;

            //Overshoot 301
            if (301 != currentPlayer.GetScore() + game.TurnScore +result && currentPlayer.GetScore()+ result + game.TurnScore < 301)
            {
                game.TurnDarts[game.DartCounter] = result;
                game.TurnScore += result;
            }
            else
                game.TurnDarts[game.DartCounter] = 0;

            //Dart Display
            game.DartCounter++;
            DartsLeftDisplay.Text = (3 - game.DartCounter).ToString();

            //End of Turn
            if(game.DartCounter == 3)
            {
                currentPlayer.AddTurn(game.TurnDarts);
                
                game.DartCounter = 0;
                DartsLeftDisplay.Text = "3";

                Array.Clear(game.TurnDarts, 0, game.TurnDarts.Length);
                game.TurnScore = 0;
                ToggleVis();
                CurrentPlayerDisplay.Text = currentPlayer == game.Player1 ? game.Player2.Name : game.Player1.Name;
            }
        }

        private void ComContinueBtn_Click(object sender, EventArgs e)
        {
            Player currentPlayer = game.Player1.TurnsCount == game.Player2.TurnsCount ? game.Player1 : game.Player2;
            if (currentPlayer.IsCom)
            {
                ThrowBtn_Click(sender, e);
            }
            else
            {
                ToggleVis();
            }
        }

        private void ToggleVis()
        {
            ComContinueBtn.Visible = !ComContinueBtn.Visible;
            numUpDownAim.Visible = !numUpDownAim.Visible;
            TurnFlavorText.Visible = !TurnFlavorText.Visible;
            ThrowBtn.Visible = !ThrowBtn.Visible;

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
