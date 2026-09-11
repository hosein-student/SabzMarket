namespace SabzMarket.Application.UseCases.Users.GetUser;

public interface IGetUserByUserNameUseCase
{
    Task<GetUserByUserNameOutputDto> ExecuteAsync(string username, CancellationToken token);
}