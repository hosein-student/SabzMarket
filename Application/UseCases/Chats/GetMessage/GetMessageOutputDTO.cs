namespace SabzMarket.Application.UseCases.Chats.GetMessage;

public record GetMessageOutputDto(
    long Id,
    string Message,
    long SenderId,
    long ReceiverId,
    bool IsDeleted,
    bool IsRead,
    DateTime SentAt,
    bool IsFile);