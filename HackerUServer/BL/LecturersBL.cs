using HackerUServer.Dal;
using HackerUServer.Models;

namespace HackerUServer.BL
{
    public class LecturersBL
    {
        public Lecturer[] GetLecturers()
        {
            Dal.Dal dal = new Dal.Dal();
            return dal.GetLacturers();
        }

        public Language[] GetLanguages()
        {
            Dal.Dal dal = new Dal.Dal();
            return dal.GetLanguages();
        }
    }
}
