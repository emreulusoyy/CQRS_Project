using MediatR;

namespace CQRS_İstanbulEğitimAkademi.CQRS.Commends.MemberCommand
{
    public class CreateMemberCommand:IRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
    }
}
