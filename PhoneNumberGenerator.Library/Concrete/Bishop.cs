using PhoneNumberGenerator.Library.Abstract;

namespace PhoneNumberGenerator.Library.Concrete
{
    /// <summary>
    /// Represents a concrete Chess coin
    /// </summary>
    public class Bishop : ChessCoin
    {
        public override List<(int, int)> GetMoves() => [
            (-1, -1), //up left
            (-1, 1), //up right
            (1, -1), //down left
            (1, 1), //down right
        ];
    }
}
