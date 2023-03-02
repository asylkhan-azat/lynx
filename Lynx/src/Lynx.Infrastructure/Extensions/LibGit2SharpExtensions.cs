using Lynx.Domain.Ports;
using Lynx.Infrastructure.Adapters;
using Microsoft.Extensions.DependencyInjection;

namespace Lynx.Infrastructure.Extensions;

public static class LibGit2SharpExtensions
{
    public static IServiceCollection AddLibGit2SharpAdapters(this IServiceCollection services)
    {
        return services.AddTransient<IGitInteractor, LibGit2SharpGitInteractor>();
    }
}
