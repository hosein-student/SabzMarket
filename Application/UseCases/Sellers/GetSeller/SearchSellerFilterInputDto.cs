namespace SabzMarket.Application.UseCases.Sellers.GetSeller;

public class SearchSellerFilterInputDto
{
    public string Phone { get; set; }
    public string UserName { get; set; }
    public int Skip { get; set; }
    public int Take { get; set; }
}