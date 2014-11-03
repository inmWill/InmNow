namespace InmNow.Repository.Interfaces
{
    public interface ISurveyRepository : IReadRepository<Domain.SurveyBuilder.Models.Survey>, ICreateRepository<Domain.SurveyBuilder.Models.Survey>, IUpdateRepository<Domain.SurveyBuilder.Models.Survey>,
        IDeleteRepository<Domain.SurveyBuilder.Models.Survey>
    {

    }
}

