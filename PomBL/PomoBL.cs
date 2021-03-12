using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PomModels;
using PomDL;

namespace PomBL
{
    public class PomoBL : IPomBL
    {
        private IPomRepo _repo;
        public PomoBL(IPomRepo repo)
        {
            _repo = repo;
        }
        public NoteRecord CreateNoteRecord(NoteRecord newNoteRecord)
        {
            return _repo.CreateNoteRecord(newNoteRecord);
        }

        public User CreateUser(User newUser)
        {
            return _repo.CreateUser(newUser);
        }

        public List<NoteRecord> GetAllNoteRecords()
        {
            return _repo.GetAllNoteRecords();
        }

        public List<NoteRecord> GetNoteRecords(string userName)
        {
            return _repo.GetNoteRecords(userName);
        }

        public List<User> GetUsers()
        {
            return _repo.GetUsers();
        }

        public User SearchUser(string userName)
        {
            return _repo.SearchUser(userName);
        }
    }
}