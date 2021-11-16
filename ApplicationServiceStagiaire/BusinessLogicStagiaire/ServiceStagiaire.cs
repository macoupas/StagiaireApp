using ApplicationServiceStagiaire;
using BusinessLogicStagiaire.Mapper;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicStagiaire
{
    public class ServiceStagiaire : IServiceStagaire
    {
        private StagiaireMapper stagiaireMapper = new StagiaireMapper();

        public ServiceStagiaire()
        {

        }

        public ResponseData<IEnumerable<StagiaireDTO>> ListAllStagiaire()
        {
            try
            {
                using (var db = new Entities())
                {
                    // on récupère la liste des stagiaires
                    List<StagiaireDTO> listOfStagiaireDTO = db.Stagiaire.ToList().Select(x => new StagiaireDTO(x.Id, x.Nom, x.Prenom,
                        x.Adresse, x.CodePostal, x.Ville, x.Age, x.Sexe)).ToList();
                    //on retourne la liste et le statut de la requete 
                    return new ResponseData<IEnumerable<StagiaireDTO>>(true, "Succes voici la liste des stagiaire", listOfStagiaireDTO);
                }
            }
            catch (Exception e)
            {
                //retourne la raison de l'erreur 
                return new ResponseData<IEnumerable<StagiaireDTO>>(false, e.Message, null);
            }

        }

        public ResponseData<bool> DeleteStagiaire(StagiaireDTO stagiaireToDelete)
        {
            try
            {
                ResponseData<bool> result = new ResponseData<bool>(true, null, true);

                using (var db = new Entities())
                {
                    var stagiaireToDeleteInDb = db.Stagiaire.FirstOrDefault(x => x.Id == stagiaireToDelete.Id);
                    if (stagiaireToDeleteInDb != null)
                    {
                        db.Stagiaire.Remove(stagiaireToDeleteInDb);
                        db.SaveChanges();
                    }
                    return result;
                }
            }
            catch (Exception e)
            {
                return new ResponseData<bool>(false, e.Message, false); ;
            }
        }

        public ResponseData<bool> UpdateExistingStagiaire(StagiaireDTO stagiaireToUpdate)
        {
            try
            {
                using (var db = new Entities())
                {
                    var stagiaireToUpdateInDb = db.Stagiaire.SingleOrDefault(x => x.Id == stagiaireToUpdate.Id);

                    if (stagiaireToUpdateInDb != null)
                    {
                        stagiaireToUpdateInDb.Nom = stagiaireToUpdate.Nom;
                        stagiaireToUpdateInDb.Prenom = stagiaireToUpdate.Prenom;
                        stagiaireToUpdateInDb.Adresse = stagiaireToUpdate.Adresse;
                        stagiaireToUpdateInDb.CodePostal = stagiaireToUpdate.CodePostal;
                        stagiaireToUpdateInDb.Ville = stagiaireToUpdate.Ville;
                        stagiaireToUpdateInDb.Age = stagiaireToUpdate.Age;
                        stagiaireToUpdateInDb.Sexe = stagiaireToUpdate.Sexe;
                        db.SaveChanges();

                        return new ResponseData<bool>(true, null, true);
                    }

                    return new ResponseData<bool>(false, "User not existing in database", false);
                }
            }
            catch (Exception e)
            {
                return new ResponseData<bool>(false, e.Message, false);
            }
        }

        public ResponseData<bool> AddStagiaire(StagiaireDTO stagiaireToAdd)
        {
            try
            {
                var stagiaireToCreate = stagiaireMapper.StagiaireDTOToStagiairePOCO(stagiaireToAdd);

                using (var db = new Entities())
                {
                    db.Stagiaire.Add(stagiaireToCreate);
                    db.SaveChanges();
                }

                return new ResponseData<bool>(true, null, true);
            }
            catch (Exception e)
            {
                return new ResponseData<bool>(false, e.Message, false);
            }
        }
    }
}
