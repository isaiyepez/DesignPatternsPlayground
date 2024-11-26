namespace Services.Contracts
{
    public interface IPrototype
    {
        IPrototype Clone();
        string GetConnectionString();
    }
}
