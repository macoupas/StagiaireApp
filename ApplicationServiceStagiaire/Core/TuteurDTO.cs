namespace Core
{
    public class TuteurDTO 
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public int? CodePostal { get; set; }
        public int? Telephone { get; set; }

        public TuteurDTO()
        {
            this.Nom = string.Empty;
            this.Prenom = string.Empty;
            this.Adresse = string.Empty;
            this.CodePostal = null;
            this.Telephone = null;
        }

        public TuteurDTO(string Nom, string Prenom, string Adresse, int? CodePostal, int? Telephone)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Adresse = Adresse;
            this.CodePostal = CodePostal;
            this.Telephone = Telephone;
        }

        public TuteurDTO(int Id, string Nom, string Prenom, string Adresse, int? CodePostal, int? Telephone)
        {
            this.Id = Id;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Adresse = Adresse;
            this.CodePostal = CodePostal;
            this.Telephone = Telephone;
        }

        public override bool Equals(object obj)
        {
            var item = obj as TuteurDTO;

            if (item == null)
            {
                return false;
            }

            return this.Id.Equals(item.Id);
        }
    }
}
