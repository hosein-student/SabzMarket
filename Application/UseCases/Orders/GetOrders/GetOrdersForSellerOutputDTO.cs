namespace SabzMarket.Application.UseCases.Orders.GetOrders;

public record GetOrdersForSellerOutputDto(
        long OrderId,
        long OrderDetailId,
        long ProductId,
        string ImageProduct,
        string Status,
        int Number,
        long FarmerId,
        string Address,
        string FarmerProfileImage,
        string Phone,
        string FirstName,
        string LastName,
        string CodePosti);