using Petfolio.Communication.Response;

namespace Petfolio.Application.UseCases.Pet.GetById;
public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Name = "Byli",
            Type = Communication.Enums.PetType.dog
            
        };
    }
}
