using PhoneNumberGenerator.Library.Abstract;

namespace PhoneNumberGenerator.Library.Concrete
{
    /// <summary>
    /// Represents a concrete Chess coin
    /// </summary>
    public class Rook : ChessCoin
    {
        public override List<(int, int)> GetMoves() => [
            (-1, 0), // Move upwards
            (1, 0), // Move downwards
            (0, -1), // Move left
            (0, 1) // Move right
        ]; // up, down, left, right moves
    }
}