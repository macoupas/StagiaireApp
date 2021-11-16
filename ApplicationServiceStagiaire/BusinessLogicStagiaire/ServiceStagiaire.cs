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
    }
}
