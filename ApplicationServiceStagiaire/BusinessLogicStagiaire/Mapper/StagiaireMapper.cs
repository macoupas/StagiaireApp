using ApplicationServiceStagiaire;
using Core;

namespace BusinessLogicStagiaire.Mapper
{
    public class StagiaireMapper
    {
        public Stagiaire StagiaireDTOToStagiairePOCO(StagiaireDTO stagiaire)
        {
            if (stagiaire == null)
                return null;

            using (var db = new Entities())
            {
                Stagiaire stagiairePOCO = new Stagiaire();
                stagiairePOCO.Id = stagiaire.Id;
                stagiairePOCO.Nom = stagiaire.Nom;
                stagiairePOCO.Prenom = stagiaire.Prenom;
                stagiairePOCO.Adresse = stagiaire.Adresse;
                stagiairePOCO.CodePostal = stagiaire.CodePostal;
                stagiairePOCO.Ville = stagiaire.Ville;
                stagiairePOCO.Age = stagiaire.Age;
                stagiairePOCO.Sexe = stagiaire.Sexe;

                return stagiairePOCO;
            }

        }

        public StagiaireDTO StagiairePOCOToStagiaireDTO(Stagiaire stagiaire)
        {
            if (stagiaire == null)
                return null;

            StagiaireDTO stagiaireDTO = new StagiaireDTO(stagiaire.Nom, stagiaire.Prenom, stagiaire.Adresse, 
                stagiaire.CodePostal, stagiaire.Ville, stagiaire.Age, stagiaire.Sexe);

            return stagiaireDTO;
        }
    }
}
