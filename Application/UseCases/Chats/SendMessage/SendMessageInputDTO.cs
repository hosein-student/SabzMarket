namespace SabzMarket.Application.UseCases.Chats.SendMessage;

public record SendMessageInputDto(
    long Id,
    string Message,
    long SenderId,
    long ReceiverId,
    bool IsFile,
    DateTime SentAt);