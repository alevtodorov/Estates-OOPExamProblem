namespace Estates.Interfaces
{
    public interface ICommand : ICreateable, ISearchable, IStatus
    {
        // Combines all methods in one bundle.
    }
}