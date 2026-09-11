using SabzMarket.Application.Common;
using SabzMarket.Application.Constants.Common.Messages;
using SabzMarket.Application.Constants.Seller;
using SabzMarket.Application.Constants.User;
using SabzMarket.Application.Exceptions;
using SabzMarket.Application.Interfaces.Persistence;
using SabzMarket.Application.Interfaces.Repository;
using SabzMarket.Application.Interfaces.Services;

namespace SabzMarket.Application.UseCases.Sellers.UpdateSeller;

public class SellerUpdateUseCase(
    IUserRepository userRepository,
    ISellerRepository sellerRepository,
    IFileStorageService fileStorageService,
    IUnitOfWork unitOfWork) : ISellerUpdateUseCase
{
    public async Task ExecuteAsync(SellerUpdateInputDto inputDto, Stream stream,
        CancellationToken token)
    {
        if (inputDto.NewUsername != inputDto.CurrentUsername)
        {
            var user = await userRepository.GetByUserNameAsync(inputDto.NewUsername!, token);
            if (user is not null)
                throw new ConflictException(CommonMessages.DuplicateWarning(UserMessages.UserName));
        }

        var image = inputDto.ProfileImage;

        if (!inputDto.ProfileImage.StartsWith(Messages.Url))
        {
            image = await fileStorageService
                .SaveAsync(stream, inputDto.ProfileImage, token);
        }

        try
        {
            await unitOfWork.BeginAsync();

            var user = await userRepository.GetByIdAsync(inputDto.UserId, token);
            if (user is null)
            {
                throw new NotFoundException(CommonMessages.NotFoundWarning(UserMessages.User));
            }

            user.Update(inputDto.FirstName, inputDto.LastName, inputDto.NewUsername);
            userRepository.Update(user);

            var seller = await sellerRepository.GetByIdAsync(inputDto.Id, token);
            if (seller is null)
            {
                throw new NotFoundException(CommonMessages.NotFoundWarning(SellerMessages.Seller));
            }

            seller.Update(inputDto.Id, inputDto.Address, image, inputDto.WorkHistory);
            sellerRepository.Update(seller);
            await unitOfWork.SaveChangesAsync(token);
            await unitOfWork.CommitAsync();
        }
        catch
        {
            await unitOfWork.RollbackAsync();
            throw;
        }
    }
}