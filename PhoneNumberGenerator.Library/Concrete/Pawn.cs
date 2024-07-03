using PhoneNumberGenerator.Library.Abstract;

namespace PhoneNumberGenerator.Library.Concrete
{
    /// <summary>
    /// Represents a concrete Chess coin
    /// </summary>
    public class Pawn : ChessCoin
    {
        public override List<(int, int)> GetMoves() => [(1, 0)]; // one step move downward

        /// <summary>
        /// Overridden to ensure that Pawn coin moves only one step
        /// </summary>
        /// <returns></returns>
        public override bool IsSingleStep() => true;
    }
}
