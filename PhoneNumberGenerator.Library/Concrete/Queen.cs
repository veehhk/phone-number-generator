using PhoneNumberGenerator.Library.Abstract;

namespace PhoneNumberGenerator.Library.Concrete
{
    /// <summary>
    /// Represents a concrete Chess coin
    /// </summary>
    public class Queen : ChessCoin
    {
        public override List<(int, int)> GetMoves() => [
            (0, 1), // Move right
            (0, -1), // Move left
            (1, 0), // Move downwards
            (-1, 0), // Move upwards
            (1, 1), // Move diagonally down-right
            (-1, 1), // Move diagonally up-right
            (1, -1), // Move diagonally down-left
            (-1, -1) // Move diagonally up-left
        ];
    }
}
