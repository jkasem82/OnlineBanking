namespace OnlineBanking.Core.Helpers.Params;
public class CashTransactionParams : PaginationParams
{
    public string OrderBy { get; set; }
    public int TimeScope { get; set; }
}
