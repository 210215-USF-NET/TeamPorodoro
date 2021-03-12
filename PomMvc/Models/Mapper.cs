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
        public UserCRVM cast2UserCRVM(User user2BCasted)
        {
            return new UserCRVM
            {
                Id = user2BCasted.Id,
                UserUserName = user2BCasted.UserUserName,
                UserFirstName = user2BCasted.UserFirstName,
                UserLastName = user2BCasted.UserLastName
            };
        }
        public User cast2User(UserCRVM user2BCasted)
        {
            return new User
            {
                Id = user2BCasted.Id,
                UserUserName = user2BCasted.UserUserName,
                UserFirstName = user2BCasted.UserFirstName,
                UserLastName = user2BCasted.UserLastName
            };
        }
    }
}