using System;

namespace RockPaperScissors.Models
{
    public class GamePlay
    {
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        
        
        
        
            public GamePlay(string myPlayer1, string myPlayer2)
            {   
                Player1 = myPlayer1;
                Player2 = myPlayer2;
            }

            public string DetermineWinner(string newPlayer1, string newPlayer2)
            {
                
                return "Player 1";
            }
    }    
}