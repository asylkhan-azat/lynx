using LibGit2Sharp;
using Lynx.Domain.Ports;

namespace Lynx.Infrastructure.Adapters;

public sealed class LibGit2SharpGitInteractor : IGitInteractor
{
    public IRepositoryInteractor Clone(string url, string path)
    {
        var repository = new Repository(Repository.Clone(url, path));

        var interactor = new LibGit2SharpRepositoryInteractor(repository);

        return interactor;
    }

    public IRepositoryInteractor CreateFromExisting(string path)
    {
        var repository = new Repository(path);

        var interactor = new LibGit2SharpRepositoryInteractor(repository);

        return interactor;
    }

    public IRepositoryInteractor Init(string path)
    {
        var repository = new Repository(Repository.Init(path));

        var interactor = new LibGit2SharpRepositoryInteractor(repository);

        return interactor;
    }
}
