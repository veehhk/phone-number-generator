using PhoneNumberGenerator.Library.Abstract;

namespace PhoneNumberGenerator.Library.Concrete
{
    /// <summary>
    /// Represents a concrete type of Keypad for the provided layout
    /// </summary>
    /// <param name="layout"></param>
    public class Keypad(char[,] layout) : IKeypad
    {
        private readonly char[,] layout = layout;

        public char[,] Layout => layout;

        /// <summary>
        /// Gets an exact key from the layout based on the provided row and column in the matrix
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public char GetKey(int row, int column)
        {
            if (row >= 0 && row < layout.GetLength(0) && column >= 0 && column < layout.GetLength(1))
            {
                return layout[row, column];
            }
            return '\0';
        }

        /// <summary>
        /// Returns true if the matrix index is valid and the index doesn't has * or #
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public bool IsValidPosition(int row, int column) =>
            row >= 0 && row < layout.GetLength(0) && column >= 0 && column < layout.GetLength(1)
                     && layout[row, column] != '*' && layout[row, column] != '#';

        public int GetRowCount() => Layout.GetLength(0);

        public int GetColumnCount() => Layout.GetLength(1);
    }
}
