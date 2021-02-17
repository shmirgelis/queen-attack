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
        return white.Row == black.Row ||
               white.Column == black.Column ||
               white.Row + white.Column == black.Row + black.Column ||
               white.Row - white.Column == black.Row - black.Column;        
    }

    public static Queen Create(int row, int column)
    {
        const int RowColumnMinLimit = 0;
        const int RowColumnMaxLimit = 7;
        
        if ((row >= RowColumnMinLimit && row <= RowColumnMaxLimit) && (column >= RowColumnMinLimit && column <= RowColumnMaxLimit))
        {
            return new Queen(row, column);
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }

    }

}