namespace Earth.Models
{
    public class EarthModel
    {
        public int ID { get; set; }

        public string Question { get; set; } = string.Empty;
        public string OptionA { get; set; } = string.Empty;
        public string OptionB { get; set; } = string.Empty;
        public string OptionC { get; set; } = string.Empty;
        public string OptionD { get; set; } = string.Empty;
        public string CorrectAnswer { get; set; } = string.Empty;
        public string Explaination { get; set; } = string.Empty;
    }
}
