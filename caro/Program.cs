﻿using System;

public class Program
{
    static char[,] board = {
        { '1', '2', '3' },
        { '4', '5', '6' },
        { '7', '8', '9' }
    };

    static char currentPlayer = 'X';

    // ham in board
    
    public static void printBoard()
    {
        Console.Clear();
        Console.WriteLine("------------------");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{board[i, 0]} | {board[i, 1]} | {board[i, 2]}");
            if (i < 2)
                Console.WriteLine("--------------");
        }
        Console.WriteLine();
    }

    // ham kiem tra win

    public static bool checkWIN()
    {
        // ktra hang
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == currentPlayer &&
                board[i, 1] == currentPlayer &&
                board[i, 2] == currentPlayer)
            {
                return true;
            }
        }

        // ktra cot
        for (int i = 0; i < 3; i++)
        {
            if (board[0, i] == currentPlayer &&
                board[1, i] == currentPlayer &&
                board[2, i] == currentPlayer)
            {
                return true;
            }
        }

        // ktra duong cheo
        if (board[0, 0] == currentPlayer &&
            board[1, 1] == currentPlayer &&
            board[2, 2] == currentPlayer)
        {
            return true;
        }

        if (board[0, 2] == currentPlayer &&
            board[1, 1] == currentPlayer &&
            board[2, 0] == currentPlayer)
        {
            return true;
        }

        return false;
    }

    public static void Main(string[] args)
    {
        int moveCount = 0;
        bool gameWon = false;

        while (!gameWon && moveCount < 9)
        {
            printBoard();
            Console.WriteLine($"Turn {currentPlayer}, choose one cell (1-9)");
            string input = Console.ReadLine();

           
            if (!int.TryParse(input, out int choice) || choice < 1 || choice > 9)
            {
                Console.WriteLine("Your input must be from 1 to 9");
                continue;
            }

            int row = (choice - 1) / 3;
            int col = (choice - 1) % 3;

            if (board[row, col] == 'X' || board[row, col] == 'O')
            {
                Console.WriteLine("Zone has been chosen");
                continue;
            }

            board[row, col] = currentPlayer;
            moveCount++;

            if (checkWIN())
            {
                printBoard();
                Console.WriteLine($"The player {currentPlayer} wins!!!");
                gameWon = true;
                break;
            }

            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';

            if (!gameWon && moveCount < 9)
            {
                printBoard();
                Console.WriteLine("Game continues...");
            }
        }

        if (!gameWon)
        {
            Console.WriteLine("It's a draw!");
        }
    }
}