namespace PhoneNumberGenerator.Library.Abstract
{
    /// <summary>
    /// Represents an abstrct type of Keypad Navigator
    /// </summary>
    public interface IKeyPadNavigator
    {
        HashSet<string> GenerateNumbers(bool circular);

        int GetResultsCount();
    }
}
