namespace HackerUServer.Models
{
    public class Lecturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int[] Languages { get; set; }

    }

    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}