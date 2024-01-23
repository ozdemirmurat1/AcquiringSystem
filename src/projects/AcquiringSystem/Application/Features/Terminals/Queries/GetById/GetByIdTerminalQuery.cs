using Application.Features.Merchants.Queries.GetById;
using MediatR;

namespace Application.Features.Terminals.Queries.GetById
{
    public sealed record GetByIdTerminalQuery(
        string id):IRequest<GetByIdTerminalQueryResponse>;
}
