namespace Lynx.Domain.Ports;

public interface IGitInteractor
{
    IRepositoryInteractor Init(string path);
    IRepositoryInteractor Clone(string url, string path);
    IRepositoryInteractor CreateFromExisting(string path);
}
