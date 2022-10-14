namespace lecturesapi.Models.Domain
{
    public class Language
    {

        public Guid Id { get; set; }    
        public string Name { get; set; }

        public string ShortName { get; set; }

        public DateTime Date { get; set; }

        public bool isOpenSource { get; set; }  

        public  string LearningCurve { get; set; }

        // nav property

        public IEnumerable<Framework> Frameworks { get; set; }

        public IEnumerable<Area> Areas { get; set; }









    }
}
