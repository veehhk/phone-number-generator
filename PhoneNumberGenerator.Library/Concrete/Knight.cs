using PhoneNumberGenerator.Library.Abstract;

namespace PhoneNumberGenerator.Library.Concrete
{
    /// <summary>
    /// Represents a concrete Chess coin
    /// </summary>
    public class Knight : ChessCoin
    {
        public override List<(int, int)> GetMoves() => [
            (2, 1),
            (1, 2),
            (-1, 2),
            (-2, 1),
            (1, -2),
            (2, -1),
            (-2, -1),
            (-1, -2)
        ];  // L-shape moves
    }
}
