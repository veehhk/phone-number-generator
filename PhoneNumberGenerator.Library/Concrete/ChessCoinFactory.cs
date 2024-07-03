using Microsoft.Extensions.DependencyInjection;
using PhoneNumberGenerator.Library.Abstract;
using PhoneNumberGenerator.Library.Types;

namespace PhoneNumberGenerator.Library.Concrete
{
    /// <summary>
    /// Represents a concrete chess coin factory that can create an instance of a requested coin type from the DI container.
    /// Throws Argument Exception if the Coin Type is invalid
    /// </summary>
    /// <param name="serviceProvider"></param>
    public class ChessCoinFactory(IServiceProvider serviceProvider) : IChessCoinFactory
    {
        private IServiceProvider ServiceProvider { get; } = serviceProvider;

        public IChessCoin Create(ChessCoinType coinType) => coinType switch
        {
            ChessCoinType.Rook => ServiceProvider.GetRequiredService<Rook>(),
            ChessCoinType.Knight => ServiceProvider.GetRequiredService<Knight>(),
            ChessCoinType.Bishop => ServiceProvider.GetRequiredService<Bishop>(),
            ChessCoinType.Queen => ServiceProvider.GetRequiredService<Queen>(),
            ChessCoinType.King => ServiceProvider.GetRequiredService<King>(),
            ChessCoinType.Pawn => ServiceProvider.GetRequiredService<Pawn>(),
            _ => throw new ArgumentException("Invalid chess coin type", Enum.GetName(coinType))
        };
    }
}
