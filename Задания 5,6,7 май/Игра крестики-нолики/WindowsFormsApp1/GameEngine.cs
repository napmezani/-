using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class GameEngine
    {
        private GameMode Mode { get; set; } = GameMode.None;
        private WhooseTurn Turn { get; set; } = WhooseTurn.Player1Human;
        private string Winner { get; set; } = "";

        private int player1Score = 0;
        private int player2Score = 0;
        private int numberOfDraws = 0;

        const char EMPTY_CELL = '-';
        const char X_MARK = 'X';
        const char O_MARK = 'O';
        public const string PLAYER_HUMAN_TITLE = "Игрок";
        public const string PLAYER_CPU_TITLE = "Компьютер";

        private char[][] gameField = new char[][]
        {
        new char[] { EMPTY_CELL, EMPTY_CELL, EMPTY_CELL },
        new char[] { EMPTY_CELL, EMPTY_CELL, EMPTY_CELL },
        new char[] { EMPTY_CELL, EMPTY_CELL, EMPTY_CELL }
        };

        internal enum GameMode
        {
            None,
            PlayerVsPlayer,
            PlayerVsCPU
        }
        internal enum WhooseTurn
        {
            Player1Human,
            Player2Human,
            Player2CPU
        }
        public GameMode GetCurrentMode()
        {
            return Mode;
        }
        public bool IsGameStarted()
        {
            return Mode != GameMode.None;
        }
        public WhooseTurn GetCurrentTurn()
        {
            return Turn;
        }
        public string GetWinner()
        {
            return Winner;
        }
        public bool IsPlayer1HumanTurn()
        {
            return Turn == WhooseTurn.Player1Human;
        }
        public void SetPlayer1HumanTurn()
        {
            Turn = WhooseTurn.Player1Human;
        }
        public void ResetScore()
        {
            player1Score = 0;
            player2Score = 0;
            numberOfDraws = 0;
        }
        public void PrepareForNewGame()
        {
            Mode = GameMode.None;
            ResetScore();
        }
        public void StartGame(GameMode gameMode)
        {
            if (gameMode == GameMode.None)
            {
                return;
            }
            ResetScore();
            Mode = gameMode;
            Turn = WhooseTurn.Player1Human;
        }
        public string GetCurrentPlayer1Title()
        {
            switch (Mode)
            {
                case GameMode.PlayerVsCPU:
                    return PLAYER_HUMAN_TITLE;
                case GameMode.PlayerVsPlayer:
                    return PLAYER_HUMAN_TITLE + " 1";
            }
            return "";
        }
        public string GetCurrentPlayer2Title()
        {
            switch (Mode)
            {
                case GameMode.PlayerVsCPU:
                    return PLAYER_CPU_TITLE;
                case GameMode.PlayerVsPlayer:
                    return PLAYER_HUMAN_TITLE + " 2";
            }
            return "";
        }
        public string GetCurrentMarkLabelText()
        {
            if (IsPlayer1HumanTurn())
            {
                return X_MARK.ToString();
            }
            else
            {
                return O_MARK.ToString();
            }
        }
        public Color GetCurrentMarkLabelColor()
        {
            if (IsPlayer1HumanTurn())
            {
                return Color.Gold;
            }
            else
            {
                return Color.Fuchsia;
            }
        }
        public int GetPlayer1Score()
        {
            return player1Score;
        }
        public int GetPlayer2Score()
        {
            return player2Score;
        }
        public string GetWhooseTurnTitle()
        {
            switch (Mode)
            {
                case GameMode.PlayerVsCPU:
                    return Turn == WhooseTurn.Player1Human ? PLAYER_HUMAN_TITLE : PLAYER_CPU_TITLE;
                case GameMode.PlayerVsPlayer:
                    return Turn == WhooseTurn.Player1Human ? PLAYER_HUMAN_TITLE + " 1" : PLAYER_HUMAN_TITLE + " 2";
            }
            return "";
        }
        public string GetWhooseNextTurnTitle()
        {
            switch (Mode)
            {
                case GameMode.PlayerVsCPU:
                    return Turn == WhooseTurn.Player1Human ? PLAYER_CPU_TITLE : PLAYER_HUMAN_TITLE;
                case GameMode.PlayerVsPlayer:
                    return Turn == WhooseTurn.Player1Human ? PLAYER_HUMAN_TITLE + " 2" : PLAYER_HUMAN_TITLE + " 1";
            }
            return "";
        }
        public void ClearGameField()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    gameField[row][col] = EMPTY_CELL;
                }
            }
        }
        public void MakeTurnAndFillGameFieldCell(int row, int column)
        {
            if (IsPlayer1HumanTurn())
            {
                gameField[row][column] = X_MARK;
                if (Mode == GameMode.PlayerVsCPU)
                {
                    Turn = WhooseTurn.Player2CPU;
                }
                else if (Mode == GameMode.PlayerVsPlayer)
                {
                    Turn = WhooseTurn.Player2Human;
                }
            }
            else
            {
                gameField[row][column] = O_MARK;
                Turn = WhooseTurn.Player1Human;
            }
        }
        private Cell GetHorizontalCellForAttackOrDefence(char checkMark)
        {
            for (int row = 0; row < 3; row++)
            {
                int currentSumHorizontal = 0;
                int freeCol = -1;
                for (int col = 0; col < 3; col++)
                {
                    if (gameField[row][col] == EMPTY_CELL)
                    {
                        freeCol = col;
                    }
                    currentSumHorizontal += gameField[row][col] == checkMark ? 1 : 0;
                }
                if (currentSumHorizontal == 2 && freeCol >= 0)
                {
                    return Cell.From(row, freeCol);
                }
            }
            return Cell.ErrorCell();
        }
        private Cell GetVerticalCellForAttackOrDefence(char checkMark)
        {
            for (int col = 0; col < 3; col++)
            {
                int currentSumVert = 0;
                int freeRow = -1;
                for (int row = 0; row < 3; row++)
                {
                    if (gameField[row][col] == EMPTY_CELL)
                    {
                        freeRow = row;
                    }
                    currentSumVert += gameField[row][col] == checkMark ? 1 : 0;
                }
                if (currentSumVert == 2 && freeRow >= 0)
                {
                    return Cell.From(freeRow, col);
                }
            }
            return Cell.ErrorCell();
        }
        private Cell GetDiagonalCellForAttackOrDefence(char checkMark)
        {
            int diagonal1Sum = 0;
            int diagonal2Sum = 0;
            int freeCol1 = -1, freeRow1 = -1;
            int freeCol2 = -1, freeRow2 = -1;
            for (int row = 0; row < 3; row++)
            {
                diagonal1Sum += gameField[row][row] == checkMark ? 1 : 0;
                diagonal2Sum += gameField[row][2 - row] == checkMark ? 1 : 0;
                if (gameField[row][row] == EMPTY_CELL)
                {
                    freeCol1 = row;
                    freeRow1 = row;
                }
                if (gameField[row][2 - row] == EMPTY_CELL)
                {
                    freeCol2 = 2 - row;
                    freeRow2 = row;
                }
                if (diagonal1Sum == 2 && freeRow1 >= 0 && freeCol1 >= 0)
                {
                    return Cell.From(freeRow1, freeCol1);
                }
                else if (diagonal2Sum == 2 && freeRow2 >= 0 && freeCol2 >= 0)
                {
                    return Cell.From(freeRow2, freeCol2);
                }
            }
            return Cell.ErrorCell();
        }
        private Cell ComputerTryAttackHorizontalCell()
        {
            return GetHorizontalCellForAttackOrDefence(O_MARK);
        }
        private Cell ComputerTryAttackVerticalCell()
        {
            return GetVerticalCellForAttackOrDefence(O_MARK);
        }
        private Cell ComputerTryAttackDiagonalCell()
        {
            return GetDiagonalCellForAttackOrDefence(O_MARK);
        }
        private Cell ComputerTryDefendHorizontalCell()
        {
            return GetHorizontalCellForAttackOrDefence(X_MARK);
        }
        private Cell ComputerTryDefendVerticalCell()
        {
            return GetVerticalCellForAttackOrDefence(X_MARK);
        }
        private Cell ComputerTryDefendDiagonalCell()
        {
            return GetDiagonalCellForAttackOrDefence(X_MARK);
        }
        private Cell ComputerTryAttackCell()
        {
            Cell attackedHorizontalCell = ComputerTryAttackHorizontalCell();
            if (!attackedHorizontalCell.IsErrorCell())
            {
                return attackedHorizontalCell;
            }
            Cell attackedVerticalCell = ComputerTryAttackVerticalCell();
            if (!attackedVerticalCell.IsErrorCell())
            {
                return attackedVerticalCell;
            }
            Cell attackedDiagonalCell = ComputerTryAttackDiagonalCell();
            if (!attackedDiagonalCell.IsErrorCell())
            {
                return attackedDiagonalCell;
            }
        return Cell.ErrorCell();
        }
        private Cell ComputerTryDefendCell()
        {
            Cell defendedHorizontalCell = ComputerTryDefendHorizontalCell();
            if (!defendedHorizontalCell.IsErrorCell())
            {
                return defendedHorizontalCell;
            }
            Cell defendedVerticalCell = ComputerTryDefendVerticalCell();
            if (!defendedVerticalCell.IsErrorCell())
            {
                return defendedVerticalCell;
            }
            Cell defendedDiagonalCell = ComputerTryDefendDiagonalCell();
            if (!defendedDiagonalCell.IsErrorCell())
            {
                return defendedDiagonalCell;
            }
        return Cell.ErrorCell();
        }
        private Cell ComputerTrySelectRandomFreeCell()
        {
            Random random = new Random();
            int randomRow, randomCol;
            const int max_attempts = 1000;
            int current_attempt = 0;
            do
            {
                randomRow = random.Next(3);
                randomCol = random.Next(3);
                current_attempt++;
            } while (gameField[randomRow][randomCol] != EMPTY_CELL &&
            current_attempt <= max_attempts);
            if (current_attempt > max_attempts)
            {
            for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        if (gameField[row][col] == EMPTY_CELL)
                        {
                            return Cell.From(row, col);
                        }
                    }
                }
            }
            return Cell.From(randomRow, randomCol);
        }
        public bool IsAnyFreeCell()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (gameField[row][col] == EMPTY_CELL)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public Cell MakeComputerTurnAndGetCell()
        {
            Cell attackedCell = ComputerTryAttackCell();
            if (!attackedCell.IsErrorCell())
            {
                return attackedCell;
            }
            Cell defendedCell = ComputerTryDefendCell();
            if (!defendedCell.IsErrorCell())
            {
                return defendedCell;
            }
            if (IsAnyFreeCell())
            {
                Cell randomFreeCell = ComputerTrySelectRandomFreeCell();
                return randomFreeCell;
            }
            return Cell.ErrorCell();
        }
        public bool IsDraw()
        {
            bool isNoFreeCellsLeft = !IsAnyFreeCell();
            if (isNoFreeCellsLeft)
            {
                numberOfDraws++;
            }
            return isNoFreeCellsLeft;
        }
        private bool CheckWinOnHorizontalCellsAndUpdateWinner()
        {
            for (int row = 0; row < 3; row++)
            {
                int sumX = 0; int sumO = 0;
                for (int col = 0; col < 3; col++)
                {
                    sumX += gameField[row][col] == X_MARK ? 1 : 0;
                    sumO += gameField[row][col] == O_MARK ? 1 : 0;
                }
                if (sumX == 3)
                {
                    // X победили
                    Winner = Mode == GameMode.PlayerVsPlayer ?
                    PLAYER_HUMAN_TITLE + " 1" : PLAYER_HUMAN_TITLE;
                    player1Score++;
                    return true;
                }
                else if (sumO == 3)
                {
                    // O победили
                    Winner = Mode == GameMode.PlayerVsPlayer ?
                    PLAYER_HUMAN_TITLE + " 2" : PLAYER_CPU_TITLE;
                    player2Score++;
                    return true;
                }
            }
            return false;
        }
        private bool CheckWinOnVerticalCellsAndUpdateWinner()
        {
            for (int col = 0; col < 3; col++)
            {
                int sumX = 0; int sumO = 0;
                for (int row = 0; row < 3; row++)
                {
                    sumX += gameField[row][col] == X_MARK ? 1 : 0;
                    sumO += gameField[row][col] == O_MARK ? 1 : 0;
                }
                if (sumX == 3)
                {
                    // X победили
                    Winner = Mode == GameMode.PlayerVsPlayer ?
                    PLAYER_HUMAN_TITLE + " 1" : PLAYER_HUMAN_TITLE;
                    player1Score++;
                    return true;
                }
                else if (sumO == 3)
                {
                    // O победили
                    Winner = Mode == GameMode.PlayerVsPlayer ?
                    PLAYER_HUMAN_TITLE + " 2" : PLAYER_CPU_TITLE;
                    player2Score++;
                    return true;
                }
            }
            return false;
        }
        private bool CheckWinOnDiagonalCellsAndUpdateWinner()
        {
            int diag1sumX = 0, diag2sumX = 0;
            int diag1sumO = 0, diag2sumO = 0;
            for (int row = 0; row < 3; row++)
            {
                if (gameField[row][row] == O_MARK)
                {
                    diag1sumO++;
                }
                if (gameField[row][row] == X_MARK)
                {
                    diag1sumX++;
                }
                if (gameField[row][2 - row] == O_MARK)
                {
                    diag2sumO++;
                }
                if (gameField[row][2 - row] == X_MARK)
                {
                    diag2sumX++;
                }
            }
            if (diag1sumX == 3 || diag2sumX == 3)
            {
                Winner = Mode == GameMode.PlayerVsPlayer ?
                PLAYER_HUMAN_TITLE + " 1" : PLAYER_HUMAN_TITLE;
                player1Score++;
                return true;
            }
            else if (diag1sumO == 3 || diag2sumO == 3)
            {
                Winner = Mode == GameMode.PlayerVsPlayer ?
                PLAYER_HUMAN_TITLE + " 2" : PLAYER_CPU_TITLE;
                player2Score++;
                return true;
            }
            return false;
        }
        public bool IsWin()
        {
            if (CheckWinOnHorizontalCellsAndUpdateWinner())
            {
                return true;
            }
            if (CheckWinOnVerticalCellsAndUpdateWinner())
            {
                return true;
            }
            if (CheckWinOnDiagonalCellsAndUpdateWinner())
            {
                return true;
            }
            return false;
        }
    }
}
