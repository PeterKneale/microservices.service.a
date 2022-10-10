using Grpc.Core;
using MediatR;
using ServiceA.Application.Queries.GetItem;

namespace ServiceA.Api;

public class GrpcService : ServiceA.ServiceABase
{
    private readonly IMediator _mediator;

    public GrpcService(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    public override async Task<GetItemResponse> GetItem(GetItemRequest request, ServerCallContext context)
    {
        var response = await _mediator.Send(new Request(request.Message));
        return new GetItemResponse
        {
            Message = response.Message
        };
    }
}