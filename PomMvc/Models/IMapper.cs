using PomModels;
namespace PomMvc.Models
{
    public interface IMapper
    {
        NoteCRVM cast2NoteCRVM(NoteRecord note2BCasted);
        NoteRecord cast2NoteRecord(NoteCRVM note2BCasted);
    }
}