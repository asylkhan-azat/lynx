namespace Lynx.Domain.Ports;

public interface IRepositoryInteractor : IDisposable
{
    string Path { get; }
}
