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
        bool attack;
        if (white.Row == black.Row || white.Column == black.Column)
        {
            attack = true;
        }
        else if ((white.Row + white.Column) == (black.Row + black.Column))
        {
            attack = true;
        }
        else if ((white.Row - black.Row) == (white.Column - black.Column))
        {
            attack = true;
        }
        else
        {
            attack = false;
        }
        return attack;
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