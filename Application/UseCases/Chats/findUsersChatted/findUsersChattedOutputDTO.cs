namespace SabzMarket.Application.UseCases.Chats.findUsersChatted;

public record FindUsersChattedOutputDto(
    long Id,
    string UserName,
    string FirstName,
    string LastName,
    string ProfileImage);