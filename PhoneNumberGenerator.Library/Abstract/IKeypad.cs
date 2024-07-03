namespace PhoneNumberGenerator.Library.Abstract
{
    /// <summary>
    /// Represents an abstract type of Keypad
    /// </summary>
    public interface IKeypad
    {
        char[,] Layout { get; }

        char GetKey(int row, int column);

        bool IsValidPosition(int row, int column);

        int GetRowCount();

        int GetColumnCount();
    }
}
