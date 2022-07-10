using HackerUServer.Models;
using Newtonsoft.Json;

namespace HackerUServer.Dal
{
    public class Dal
    {
        private static Lecturer[] lecturers;
        private static Language[] languages;

        static Dal()
        {
            StreamReader r = new StreamReader("lecturers.json");
            string jsonString = r.ReadToEnd();
            lecturers = JsonConvert.DeserializeObject<Lecturer[]>(jsonString);

            StreamReader sr = new StreamReader("Languages.json");
            string js = sr.ReadToEnd();
            languages = JsonConvert.DeserializeObject<Language[]>(js);
        }

        public Lecturer[] GetLacturers()
        {
            return lecturers;
        }

        public Language[] GetLanguages()
        {
            return languages;
        }
    }
}
