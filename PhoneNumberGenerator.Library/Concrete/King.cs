using PhoneNumberGenerator.Library.Abstract;

namespace PhoneNumberGenerator.Library.Concrete
{
    /// <summary>
    /// Represents a concrete Chess coin
    /// </summary>
    public class King : ChessCoin
    {
        public override List<(int, int)> GetMoves() => [
            (-1, -1), //up left
            (-1, 1), //up right
            (1, -1), //down left
            (1, 1), //down right
            (0,1), //move right
            (0, -1), //move left
            (1, 0), //move down
            (-1, 0) // move up
        ];

        /// <summary>
        /// Overridden to ensure that King coin moves only one step
        /// </summary>
        /// <returns></returns>
        public override bool IsSingleStep() => true;
    }
}
