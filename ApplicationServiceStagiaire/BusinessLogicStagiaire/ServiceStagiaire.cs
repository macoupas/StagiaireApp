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
        private TuteurMapper tuteurMapper = new TuteurMapper();

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
                        x.Adresse, x.CodePostal, x.Ville, x.Age, x.Sexe, tuteurMapper.TuteurPOCOToTuteurDTO(x.Tuteur))).ToList();
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

        public ResponseData<StagiaireDTO> GetStagiaireById(int id)
        {
            try
            {
                using (var db = new Entities())
                {
                    var stagiaireInDb = db.Stagiaire.FirstOrDefault(x => x.Id == id);

                    var stagiaireToReturn = stagiaireInDb != null ? stagiaireMapper.StagiairePOCOToStagiaireDTO(stagiaireInDb) : new StagiaireDTO();

                    return new ResponseData<StagiaireDTO>(true, null, stagiaireToReturn);
                }
            }
            catch (Exception e)
            {
                return new ResponseData<StagiaireDTO>(false, e.Message, null);
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
                        stagiaireToUpdateInDb.TuteurId = stagiaireToUpdate.Tuteur != null ? (int?)stagiaireToUpdate.Tuteur.Id : null;
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

        public ResponseData<IEnumerable<TuteurDTO>> ListAllTuteur()
        {
            try
            {
                using (var db = new Entities())
                {
                    // on récupère la liste des stagiaires
                    List<TuteurDTO> listOfTuteurDTO = db.Tuteur.ToList().Select(x => new TuteurDTO(x.Id, x.Nom, x.Prenom,
                    x.Adresse, x.CodePostal, x.Telephone)).ToList();
                    //on retourne la liste et le statut de la requete 
                    return new ResponseData<IEnumerable<TuteurDTO>>(true, "Succes voici la liste des tuteurs", listOfTuteurDTO);
                }
            }
            catch (Exception e)
            {
                //retourne la raison de l'erreur 
                return new ResponseData<IEnumerable<TuteurDTO>>(false, e.Message, null);
            }
        }

        public ResponseData<TuteurDTO> GetTuteurById(int id)
        {
            try
            {
                using (var db = new Entities())
                {
                    var tuteurInDb = db.Tuteur.FirstOrDefault(x => x.Id == id);

                    var tuteurToReturn = tuteurInDb != null ? tuteurMapper.TuteurPOCOToTuteurDTO(tuteurInDb) : new TuteurDTO();

                    return new ResponseData<TuteurDTO>(true, null, tuteurToReturn);
                }
            }
            catch (Exception e)
            {
                return new ResponseData<TuteurDTO>(false, e.Message, null);
            }
        }

        public ResponseData<bool> DeleteTuteur(TuteurDTO tuteurToDelete)
        {
            try
            {
                ResponseData<bool> result = new ResponseData<bool>(true, null, true);

                using (var db = new Entities())
                {
                    var tuteurToDeleteInDb = db.Tuteur.FirstOrDefault(x => x.Id == tuteurToDelete.Id);
                    if (tuteurToDeleteInDb != null)
                    {
                        db.Tuteur.Remove(tuteurToDeleteInDb);
                        db.SaveChanges();
                    }
                }
                return result;
            }
            catch (Exception e)
            {
                return new ResponseData<bool>(false, e.Message, false); ;
            }
        }

        public ResponseData<bool> UpdateExistingTuteur(TuteurDTO tuteurToUpdate)
        {
            try
            {
                using (var db = new Entities())
                {
                    var tuteurToUpdateInDb = db.Tuteur.SingleOrDefault(x => x.Id == tuteurToUpdate.Id);

                    if (tuteurToUpdateInDb != null)
                    {
                        tuteurToUpdateInDb.Nom = tuteurToUpdate.Nom;
                        tuteurToUpdateInDb.Prenom = tuteurToUpdate.Prenom;
                        tuteurToUpdateInDb.Adresse = tuteurToUpdate.Adresse;
                        tuteurToUpdateInDb.CodePostal = tuteurToUpdate.CodePostal;
                        tuteurToUpdateInDb.Telephone = tuteurToUpdate.Telephone;
                        db.SaveChanges();

                        return new ResponseData<bool>(true, null, true);
                    }
                }

                return new ResponseData<bool>(false, "Tuteur not existing in database", false);
            }
            catch (Exception e)
            {
                return new ResponseData<bool>(false, e.Message, false);
            }
        }

        public ResponseData<bool> AddTuteur(TuteurDTO tuteurToAdd)
        {
            try
            {
                var tuteurToCreate = tuteurMapper.TuteurDTOToTuteurPOCO(tuteurToAdd);

                using (var db = new Entities())
                {
                    db.Tuteur.Add(tuteurToCreate);
                    db.SaveChanges();
                }

                return new ResponseData<bool>(true, null, true);
            }
            catch (Exception e)
            {
                return new ResponseData<bool>(false, e.Message, false);
            }
        }

        public ResponseData<bool> AddStagiaireToTuteur(TuteurDTO tuteurToUpdate, StagiaireDTO stagiaireToAdd)
        {
            try
            {
                using (var db = new Entities())
                {
                    db.Stagiaire.FirstOrDefault(x => x.Id == stagiaireToAdd.Id).TuteurId = tuteurToUpdate.Id;
                    db.SaveChanges();
                }

                return new ResponseData<bool>(true, null, true);
            }
            catch (Exception e)
            {
                return new ResponseData<bool>(false, e.Message, false);
            }
        }

        public ResponseData<bool> DeleteStagiaireOfTuteur(TuteurDTO tuteurToUpdate, StagiaireDTO stagiaireToDelete)
        {
            try
            {
                using (var db = new Entities())
                {
                    db.Stagiaire.FirstOrDefault(x => x.Id == stagiaireToDelete.Id).TuteurId = null;
                    db.SaveChanges();
                }

                return new ResponseData<bool>(true, null, true);
            }
            catch (Exception e)
            {
                return new ResponseData<bool>(false, e.Message, false);
            }
        }

        public ResponseData<IEnumerable<StagiaireDTO>> ListStagiaireOfTuteur(TuteurDTO tuteurToGetStagiaire)
        {
            try
            {
                using (var db = new Entities())
                {
                    // on récupère la liste des stagiaires
                    List<StagiaireDTO> listOfStagiaireDTO = db.Stagiaire.Where(x => x.TuteurId == tuteurToGetStagiaire.Id)
                    .ToList()
                    .Select(x => new StagiaireDTO(x.Id, x.Nom, x.Prenom,
                    x.Adresse, x.CodePostal, x.Ville, x.Age, x.Sexe, tuteurMapper.TuteurPOCOToTuteurDTO(x.Tuteur))).ToList();
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
    }
}
