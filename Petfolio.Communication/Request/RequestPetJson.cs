using Petfolio.Communication.Enums;


namespace Petfolio.Communication.Request;
public class RequestPetJson
{

    public string Name { get; set; } = string.Empty;
    public DateTime Nascimento { get; set; }
    public PetType Type { get; set; }
}
