using Petfolio.Communication.Request;
using Petfolio.Communication.Response;

namespace Petfolio.Application.UseCases.Pet.Register;
public class RegisterPetUseCase
{
    public ResponsePetRegisterJson Execute(RequestPetJson request)
    {
        return new ResponsePetRegisterJson
        {
            Id = 7,
            Name = request.Name,
        };
    }
}
