namespace lecturesapi.Models.Domain
{
    public class Framework
    {

        public Guid Id { get; set; }    
        public string Name { get; set; }

        public bool isOpenSource { get; set; }

        public Guid Language { get; set; }

        public Guid AreaOfDevelopment { get; set; }

        // nav property

        public Language language { get; set; }

        public Area area { get; set; }




    }
}
