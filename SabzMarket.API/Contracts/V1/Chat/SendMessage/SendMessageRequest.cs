namespace SabzMarket.API.Contracts.V1.Chats.SendMessage;

public record SendMessageRequest(
    long Id,
    string Message,
    long SenderId,
    long ReceiverId,
    bool IsFile,
    DateTime SentAt);