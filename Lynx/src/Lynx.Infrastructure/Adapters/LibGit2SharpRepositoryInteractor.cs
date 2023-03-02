using LibGit2Sharp;
using Lynx.Domain.Ports;

namespace Lynx.Infrastructure.Adapters;

public sealed class LibGit2SharpRepositoryInteractor : IRepositoryInteractor
{
    private readonly Repository _repository;

    private bool _disposed;

    public LibGit2SharpRepositoryInteractor(Repository repository)
    {
        _repository = repository;
    }

    public string Path => _repository.Info.Path;

    public void Dispose()
    {
        Dispose(calledFromDispose: true);
        GC.SuppressFinalize(this);
    }

    private void Dispose(bool calledFromDispose)
    {
        if (_disposed) return;

        if (calledFromDispose)
        {
            _repository.Dispose();
        }

        _disposed = true;
    }

    ~LibGit2SharpRepositoryInteractor()
    {
        Dispose(calledFromDispose: false);
    }
}
