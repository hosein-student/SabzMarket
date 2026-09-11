namespace SabzMarket.Application.UseCases.Sms.SendSmsOtp;

public interface ISendSmsOtpUseCase
{
    Task<long> Execute(string phone, CancellationToken token);
}