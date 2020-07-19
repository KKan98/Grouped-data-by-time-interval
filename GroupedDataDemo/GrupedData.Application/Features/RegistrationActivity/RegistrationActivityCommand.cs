namespace GroupedData.Application.Features
{
    public class RegistrationActivityCommand
    {
        public RegistrationActivityCommand(string activity, string description, string date)
        {
            Activity = activity;
            Description = description;
            Date = date;
        }
        public string Activity { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
    }
}
