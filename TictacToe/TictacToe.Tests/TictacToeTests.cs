using System;
using Xunit;

namespace TictacToe.Tests
{
    public class TictacToeTests
    {
        [Theory]
        [InlineData(new char[] { 'X', 'X', 'X' }, new char[] { '4', '5', '6' }, new char[3] { '7', '8', '9' })]
        [InlineData(new char[] { '1', '2', '3' }, new char[] { 'X', 'X', 'X' }, new char[3] { '7', '8', '9' })]
        [InlineData(new char[] { '1', '2', '3' }, new char[] { '4', '5', '6' }, new char[3] { 'X', 'X', 'X' })]
        [InlineData(new char[] { 'X', '2', '3' }, new char[] { 'X', '5', '6' }, new char[3] { 'X', '8', '9' })]
        [InlineData(new char[] { '1', 'X', '3' }, new char[] { '4', 'X', '6' }, new char[3] { '7', 'X', '9' })]
        [InlineData(new char[] { '1', '2', 'X' }, new char[] { '4', '5', 'X' }, new char[3] { '7', '8', 'X' })]
        [InlineData(new char[] { 'X', '2', '3' }, new char[] { '4', 'X', '6' }, new char[3] { '7', '8', 'X' })]
        [InlineData(new char[] { '1', '2', 'X' }, new char[] { '4', 'X', '6' }, new char[3] { 'X', '8', '9' })]

        public void GameCompleteCheckerThreeValuesOnLineTheSameCharTrue(char[] boardConfiguration1, char[] boardConfiguration2, char[] boardConfiguration3)
        {
           char[,] boardConfiguration = new char[3, 3];


            for (int i = 0; i < 3; i++)
            {
                boardConfiguration[0, i] = boardConfiguration1[i];

                for (int j = 0; j < 3; j++)
                {
                    boardConfiguration[1, j] = boardConfiguration2[j];

                    for (int k = 0; k < 3; k++)
                    {
                        boardConfiguration[2, k] = boardConfiguration3[k];
                    }
                }
            }

            var board = new Board(boardConfiguration);

            bool boardResponse = board.GameCompleteChecker();

            Assert.True(boardResponse);
        }

        [Fact]

        public void GameCompleteCheckerAllFieldsEmptyFalse()
        {
            char[,] boardConfiguration = new char[,] {
                    { '1', '2', '3' },
                    { '4', '5', '6' },
                    { '7', '8', '9' }
                };

            var board = new Board(boardConfiguration);

            bool boardResponse = board.GameCompleteChecker();

            Assert.False(boardResponse);
        }
    }
}
