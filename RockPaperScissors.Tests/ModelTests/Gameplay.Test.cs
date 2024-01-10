using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{
    [TestClass]
    public class RockPaperScissorsTests
    {
        // First Test: Test to create instance of my GamePlay constructor
        [TestMethod]
        public void RockPaperScissors_CreatesInstanceOfConstructor_RockPaperScissors()
        {
            GamePlay myGame = new GamePlay("Paper", "Scissors");
            Assert.AreEqual(typeof(GamePlay), myGame.GetType());
        }

        // Test to get the game value of Player 
        [TestMethod]
        public void GetPlayer1_ReturnsValueOfPlayer1_String()
        {
            // Arrange
            GamePlay myGame = new GamePlay("Rock", "Scissors");
            string expectedPlayer1Value = "Rock";

            // Act
            string returnedPlayer1Value = myGame.Player1;

            // Assert
            Assert.AreEqual(expectedPlayer1Value, returnedPlayer1Value);

        }

        // 3rd Test: Test to set the game value for Player1
        [TestMethod]
        public void SetPlayer1_SetsValueForPlayer1_Void()
        {
            // Arrange
            GamePlay myGame = new GamePlay("Rock", "Scissors");
            string newPlayer1Val = "Scissors";

            // Act
            myGame.Player1 = newPlayer1Val;

            // Assert
            Assert.AreEqual(newPlayer1Val, myGame.Player1);
        }

        // 4th Test: Test to get the game value for Player1
        [TestMethod]
        public void GetPlayer2_ReturnsValueOfPlayer2_String()
        {
            // Arrange
            GamePlay myGame = new GamePlay("Rock", "Paper");
            string expectedPlayer2Value = "Paper";

            // Act
            string returnedPlayer2Value = myGame.Player2;

            // Assert
            Assert.AreEqual(expectedPlayer2Value, returnedPlayer2Value);
        }

        // 5th Test: Test to set the game value for Player1
        [TestMethod]
        public void SetPlayer2_SetsValueForPlayer2_Void()
        {
            // Arrange
            GamePlay myGame = new GamePlay("Rock", "Scissors");
            string newPlayer2Val = "Scissors";

            // Act
            myGame.Player2 = newPlayer2Val;

            // Assert
            Assert.AreEqual(newPlayer2Val, myGame.Player2);
        }

        // 6th Test: Test Method DetermineWinner();
        // [TestMethod]
        // public void DetermineWinner_ReturnsWinner_String()
        // {
        //     // Arrange
        //     string Player1Val = "Rock";
        //     string Player2Val = "Scissors";
        //     GamePlay myGame = new GamePlay();
        //     string expectedWinner = "Player 1";

        //     // Act
        //     string returnedWinner = myGame.DetermineWinner(Player1Val, Player2Val);

        //     // Assert
        //     Assert.AreEqual(expectedPlayer1Value, returnedWinner);
        // }

        // 9th Test: Test if a list of previous winners is created.
        // [TestMethod]
        // public voif GetAllPreviousWinners_Returns

    }
}