using RestSharp;
using RestSharpTemplate.Bases;

namespace RestSharpTemplate.Requests.Agenda
{
    public class FindPetsRequest : RequestBase
    {

        public FindPetsRequest(string idPet)
        {
            requestService = "/pet/{petId}";
            method = Method.GET;

            parameters.Add("idPet", idPet);
        }
    }
}
