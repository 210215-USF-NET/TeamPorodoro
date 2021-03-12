using PomModels;

namespace PomMvc.Models
{
    public class Mapper : IMapper
    {
        public NoteCRVM cast2NoteCRVM(NoteRecord note2BCasted)
        {
            return new NoteCRVM
            {
                UserName = note2BCasted.UserName,
                Note = note2BCasted.Note
            };
        }

        public NoteRecord cast2NoteRecord(NoteCRVM note2BCasted)
        {
            return new NoteRecord
            {
                UserName = note2BCasted.UserName,
                Note = note2BCasted.Note
            };
        }
    }
}