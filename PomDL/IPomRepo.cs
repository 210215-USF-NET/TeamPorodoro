using PomModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomDL
{
    public interface IPomRepo
    {
        User CreateUser(User newUser);
        NoteRecord CreateNoteRecord(NoteRecord newNoteRecord);
        User SearchUser(string userName);
        List<User> GetUsers();
        List<NoteRecord> GetNoteRecords(string userName);
        List<NoteRecord> GetAllNoteRecords();
    }
}
