using Core;
using System;
using System.Collections.Generic;

namespace ServiceAppStagiaire
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceStagiaire : IServiceStagiaire
    {
        private BusinessLogicStagiaire.ServiceStagiaire serviceMetier = new BusinessLogicStagiaire.ServiceStagiaire();
        public ServiceStagiaire()
        {

        }

        public ResponseData<IEnumerable<StagiaireDTO>> ListAllStagiaire()
        {
            try
            {
                return serviceMetier.ListAllStagiaire();
            }
            catch (Exception e)
            {

                return new ResponseData<IEnumerable<StagiaireDTO>>(false, e.Message, null);

            }
        }

        public ResponseData<bool> DeleteStagiaire(StagiaireDTO stagiaireToDelete)
        {
            try
            {
                return serviceMetier.DeleteStagiaire(stagiaireToDelete);
            }
            catch (Exception e)
            {
                return new ResponseData<bool>(false, e.Message, false);
            }
        }

        public ResponseData<StagiaireDTO> GetStagiaireById(int stagiaireId)
        {
            try
            {
                return serviceMetier.GetStagiaireById(stagiaireId);
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
                return serviceMetier.UpdateExistingStagiaire(stagiaireToUpdate);
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
                return serviceMetier.AddStagiaire(stagiaireToAdd);
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
                return serviceMetier.ListAllTuteur();
            }
            catch (Exception e)
            {

                return new ResponseData<IEnumerable<TuteurDTO>>(false, e.Message, null);

            }
        }

        public ResponseData<bool> DeleteTuteur(TuteurDTO tuteurToDelete)
        {
            try
            {
                return serviceMetier.DeleteTuteur(tuteurToDelete);
            }
            catch (Exception e)
            {
                return new ResponseData<bool>(false, e.Message, false);
            }
        }

        public ResponseData<TuteurDTO> GetTuteurById(int tuteurId)
        {
            try
            {
                return serviceMetier.GetTuteurById(tuteurId);
            }
            catch (Exception e)
            {
                return new ResponseData<TuteurDTO>(false, e.Message, null);
            }
        }

        public ResponseData<bool> UpdateExistingTuteur(TuteurDTO tuteurToUpdate)
        {
            try
            {
                return serviceMetier.UpdateExistingTuteur(tuteurToUpdate);
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
                return serviceMetier.AddTuteur(tuteurToAdd);
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
                return serviceMetier.AddStagiaireToTuteur(tuteurToUpdate, stagiaireToAdd);
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
                return serviceMetier.DeleteStagiaireOfTuteur(tuteurToUpdate, stagiaireToDelete);
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
                return serviceMetier.ListStagiaireOfTuteur(tuteurToGetStagiaire);
            }
            catch (Exception e)
            {
                return new ResponseData<IEnumerable<StagiaireDTO>>(false, e.Message, null);
            }
        }
    }
}
