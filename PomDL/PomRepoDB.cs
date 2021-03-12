using PomModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomDL
{
    public class PomRepoDB : IPomRepo
    {
        private readonly PomDBContext _context;
        public PomRepoDB(PomDBContext context)
        {
            _context = context;
        }

        public NoteRecord CreateNoteRecord(NoteRecord newNoteRecord)
        {
            throw new NotImplementedException();
        }

        public User CreateUser(User newUser)
        {
            throw new NotImplementedException();
        }

        public List<NoteRecord> GetAllNoteRecords()
        {
            throw new NotImplementedException();
        }

        public List<NoteRecord> GetNoteRecords(string userName)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public User SearchUser(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
