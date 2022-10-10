using MediatR;
using Microsoft.Extensions.Configuration;

namespace ServiceA.Application.Queries.GetItem;

public class Handler : IRequestHandler<Request, Response>
{
    private readonly IConfiguration _configuration;

    public Handler(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public Task<Response> Handle(Request request, CancellationToken cancellationToken)
    {
        var prefix = _configuration["Prefix"];
        if (string.IsNullOrWhiteSpace(prefix))
        {
            throw new Exception("Missing configuration setting : Prefix");
        }
        var response = new Response("Service A" + prefix + request.Message);
        return Task.FromResult(response);
    }
}