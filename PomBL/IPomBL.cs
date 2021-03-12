using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PomModels;

namespace PomBL
{
    public interface IPomBL
    {
        User CreateUser(User newUser);
        NoteRecord CreateNoteRecord(NoteRecord newNoteRecord);
        User SearchUser(string userName);
        List<User> GetUsers();
        List<NoteRecord> GetNoteRecords(string userName);
        List<NoteRecord> GetAllNoteRecords();
    }
}