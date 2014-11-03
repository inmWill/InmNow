namespace InmNow.Enums
{
    public enum ApplicationTypes
    {
        JavaScript = 0,
        NativeConfidential = 1
    };

    public enum UserType
    {
        Standard = 1,
        Presenter = 2,
        Organizer = 3,
        Client = 4,
        Staff = 5,
        Reviewer = 6,
        Admin = 7,
        Banned = 8
    }

    public enum SurveyType
    {
        Ocv = 1,
        Dev = 2,
        Simple = 3,
        Complex = 4
    }

    public enum QuestionType
    {
        Text = 1,
        Boolean = 2,
        MultipleChoice = 3,
        MultiLine = 4 
    }

    public enum UnitOfMeasure
    {
        Date = 1,
        Currency = 2

    }


}
