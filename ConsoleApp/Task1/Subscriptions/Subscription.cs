namespace ConsoleApp.Task1.Subscriptions
{
    internal abstract class Subscription
    {
        public double Price { get; set; }
        public int MinPeriod { get; set; }
        public List<string>? Channels { get; set; }
        public List<string>? Features { get; set; }


        private string ListToStr(List<string>? value)
        {
            return value?.Count > 0 ? string.Join(", ", value) : "None";
        }

        public string Info()
        {
            return $"Price: {Price}\n" +
                   $"Min Period: {MinPeriod}\n" +
                   $"Channels: {ListToStr(Channels)}\n" +
                   $"Fatures: {ListToStr(Features)}";
        }
    }
}
