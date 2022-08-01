namespace Services.Content.Domain
{
    public class HomeModel
    {
        public int PersonsTotal { get; set; }
        public int AliveTotal { get; set; }
        public int DeadTotal { get; set; }
        public int GendersTotal { get; set; }
        public IReadOnlyCollection<KeyValuePair<string, int>> PersonsTotalByGenders { get; set; }
    }
}