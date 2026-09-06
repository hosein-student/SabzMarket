namespace SabzMarket.API.Contracts.V1.Chats.findUsersChatted;

public record FindUsersChattedResponse(
    long Id,
    string UserName,
    string FirstName,
    string LastName,
    string ProfileImage);