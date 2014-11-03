namespace InmNow.Repository.Interfaces
{
    public interface IClientRepository : IReadRepository<Domain.SurveyBuilder.Models.Client>, ICreateRepository<Domain.SurveyBuilder.Models.Client>, IUpdateRepository<Domain.SurveyBuilder.Models.Client>,
        IDeleteRepository<Domain.SurveyBuilder.Models.Client>
    {

    }
}

