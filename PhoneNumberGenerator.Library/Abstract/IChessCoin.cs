namespace PhoneNumberGenerator.Library.Abstract
{
    /// <summary>
    /// Represents an abstract type of Chess coin
    /// </summary>
    public interface IChessCoin
    {
        bool IsSingleStep();
        List<(int, int)> GetMoves();
    }
}