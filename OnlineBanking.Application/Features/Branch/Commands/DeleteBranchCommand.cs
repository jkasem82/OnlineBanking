using MediatR;
using OnlineBanking.Application.Models;

namespace OnlineBanking.Application.Features.Branch.Commands;

public class DeleteBranchCommand : IRequest<ApiResult<Unit>>
{
    public int BranchId { get; set; }
}
