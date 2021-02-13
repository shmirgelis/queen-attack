using System;

public class Queen
{
    public Queen(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public int Row { get; }
    public int Column { get; }
}

public static class QueenAttack
{
    public static bool CanAttack(Queen white, Queen black)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public static Queen Create(int row, int column)
    {
        if (row >= 0 && row <= 7)
        {
            if (column >= 0 && column <= 7)
            {
               _= column;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            _ = row;
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
        return new Queen(row, column);
    }

}