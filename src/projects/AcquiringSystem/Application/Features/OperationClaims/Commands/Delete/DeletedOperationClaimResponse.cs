using Core.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.OperationClaims.Commands.Delete
{
    public class DeletedOperationClaimResponse : IResponse
    {
        public int Id { get; set; }
    }
}
