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
            _context.NoteRecords.Add(newNoteRecord);
            _context.SaveChanges();
            return newNoteRecord;
        }

        public User CreateUser(User newUser)
        {
            _context.Users.Add(newUser);
            _context.SaveChanges();
            return newUser;
        }

        public List<NoteRecord> GetAllNoteRecords()
        {
            return _context.NoteRecords.Select(note => note).ToList();
        }

        public List<NoteRecord> GetNoteRecords(string userName)
        {
            return _context.NoteRecords.Where(note => note.UserName == userName).ToList();
        }

        public List<User> GetUsers()
        {
            return _context.Users.Select(user => user).ToList();
        }

        public User SearchUser(string userName)
        {
            return _context.Users.Find(userName);
        }
    }
}
