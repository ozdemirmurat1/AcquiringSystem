﻿using MediatR;

namespace Application.Features.Merchants.Queries.GetById
{
    public sealed record GetByIdMerchantQuery(
        string id
        ):IRequest<GetByIdMerchantQueryResponse>;
}
