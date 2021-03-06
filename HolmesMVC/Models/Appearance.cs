using System.Linq;

namespace HolmesMVC.Models
{
    public partial class Appearance
    {
        public int ID { get; set; }
        public int ActorID { get; set; }
        public int CharacterID { get; set; }
        public int EpisodeID { get; set; }
        public string Pic { get; set; }
        public virtual Actor Actor { get; set; }
        public virtual Character Character { get; set; }
        public virtual Episode Episode { get; set; }


        public Rename GetRename()
        {
            return (from r in Episode.Season.Adaptation.Renames
                    where
                        r.ActorID == ActorID
                        && r.CharacterID == CharacterID
                    select r).FirstOrDefault();
        }

        public string SortSurname()
        {
            var rename = GetRename();
            return (rename == null)
                ? Character.Surname
                : rename.Surname;
        }

        public string SortForename()
        {
            var rename = GetRename();
            return (rename == null)
                ? Character.Forename
                : rename.Forename;
        }
    }
}
