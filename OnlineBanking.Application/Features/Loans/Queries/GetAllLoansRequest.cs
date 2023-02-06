using MediatR;
using OnlineBanking.Application.Models;
using OnlineBanking.Application.Models.Loans.Responses;

namespace OnlineBanking.Application.Features.Loans.Queries;

public class GetAllLoansRequest : IRequest<ApiResult<LoanListResponse>>
{

}