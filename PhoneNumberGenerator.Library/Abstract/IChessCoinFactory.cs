using PhoneNumberGenerator.Library.Types;

namespace PhoneNumberGenerator.Library.Abstract
{
    /// <summary>
    /// Represents an abstract Chess coin factory
    /// </summary>
    public interface IChessCoinFactory
    {
        IChessCoin Create(ChessCoinType coinType);
    }
}
