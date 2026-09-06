namespace SabzMarket.Application.UseCases.Auth.SignUp;

public record SignUpInputDto(
    long Id,
    long OtpId,
    long Otp,
    string FirstName,
    string LastName,
    string Email,
    string Phone,
    string UserName,
    string Password,
    string ConfirmPassword
);