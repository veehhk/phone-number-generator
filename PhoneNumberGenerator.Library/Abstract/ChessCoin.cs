namespace PhoneNumberGenerator.Library.Abstract
{
    /// <summary>
    /// Represents an abstract type of Chess coin
    /// </summary>
    public abstract class ChessCoin : IChessCoin
    {
        /// <summary>
        /// Moves associated to each chess coin
        /// </summary>
        /// <returns></returns>
        public abstract List<(int, int)> GetMoves();

        /// <summary>
        /// returns true if the coin makes a single step move otherwise false. 
        /// It can be overridden in the custom chess coin definitions as required.
        /// If overridden the derived type value works. Otherwise the virtual definition of this parent class works.
        /// </summary>
        /// <returns></returns>
        public virtual bool IsSingleStep() => false;
    }
}