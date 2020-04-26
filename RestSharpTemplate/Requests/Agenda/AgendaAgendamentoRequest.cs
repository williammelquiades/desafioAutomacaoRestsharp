using RestSharp;
using RestSharpTemplate.Bases;

namespace RestSharpTemplate.Requests.Agenda
{
    public class AgendaAgendamentoRequest : RequestBase
    {

        public AgendaAgendamentoRequest(string idAgendamento)
        {
            requestService = "/api/Agenda/Agendamento/{idAgendamento}";
            method = Method.GET;

            parameters.Add("idAgendamento", idAgendamento);
        }
    }
}
