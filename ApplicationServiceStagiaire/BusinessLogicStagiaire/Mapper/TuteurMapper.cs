using ApplicationServiceStagiaire;
using Core;

namespace BusinessLogicStagiaire.Mapper
{
    public class TuteurMapper
    {
        public Tuteur TuteurDTOToTuteurPOCO(TuteurDTO tuteur)
        {
            if (tuteur == null)
                return null;

            Tuteur tuteurPOCO = new Tuteur();
            tuteurPOCO.Id = tuteur.Id;
            tuteurPOCO.Nom = tuteur.Nom;
            tuteurPOCO.Prenom = tuteur.Prenom;
            tuteurPOCO.Adresse = tuteur.Adresse;
            tuteurPOCO.CodePostal = tuteur.CodePostal;
            tuteurPOCO.Telephone = tuteur.Telephone;

            return tuteurPOCO;
        }

        public TuteurDTO TuteurPOCOToTuteurDTO(Tuteur tuteur)
        {
            if (tuteur == null)
                return null;

            TuteurDTO tuteurDTO = new TuteurDTO(tuteur.Id, tuteur.Nom, tuteur.Prenom, tuteur.Adresse,
                tuteur.CodePostal, tuteur.Telephone);

            return tuteurDTO;
        }
    }
}
