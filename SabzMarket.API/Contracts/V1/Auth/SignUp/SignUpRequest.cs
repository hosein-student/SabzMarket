namespace SabzMarket.API.Contracts.V1.Auth.SignUp;

public record SignUpRequest(
    long Id,
    long OtpId,
    long Otp,
    string FirstName,
    string LastName,
    string Email,
    string Phone,
    string UserName,
    string Password,
    string ConfirmPassword);