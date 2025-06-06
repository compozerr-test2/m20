using Core.Feature;
using Microsoft.Extensions.DependencyInjection;
using M20.Services;

namespace M20;

public class M20Feature : IFeature
{

    void IFeature.ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IM20Service, M20Service>();
    }
}