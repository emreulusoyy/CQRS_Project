using CQRS_İstanbulEğitimAkademi.CQRS.Results.MemberResult;
using MediatR;
using System.Collections.Generic;

namespace CQRS_İstanbulEğitimAkademi.CQRS.Queries.MemberQueries
{
    public class GetAllMemberQuery:IRequest<List<GetAllMemberResult>>
    {
    }
}
