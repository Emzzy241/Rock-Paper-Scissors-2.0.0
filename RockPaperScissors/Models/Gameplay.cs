using System;

namespace RockPaperScissors.Models
{
    public class GamePlay
    {
        public string Player1 { get; set; }
        // public string Name { get; }
        
        
        
        
            public GamePlay(string myPlayer1)
            {   
                Player1 = myPlayer1;
            }
    }    
}