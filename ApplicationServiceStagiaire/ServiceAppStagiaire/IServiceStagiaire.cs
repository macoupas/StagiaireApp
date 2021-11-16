using Core;
using System.Collections.Generic;
using System.ServiceModel;

namespace ServiceAppStagiaire
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceStagiaire
    {
        [OperationContract]
        ResponseData<IEnumerable<StagiaireDTO>> ListAllStagiaire();

        [OperationContract]
        ResponseData<bool> DeleteStagiaire(StagiaireDTO stagiaireToDelete);

        [OperationContract]
        ResponseData<StagiaireDTO> GetStagiaireById(int stagiaireId);

        [OperationContract]
        ResponseData<bool> UpdateExistingStagiaire(StagiaireDTO stagiaireToUpdate);

        [OperationContract]
        ResponseData<bool> AddStagiaire(StagiaireDTO stagiaireToAdd);

        [OperationContract]
        ResponseData<IEnumerable<TuteurDTO>> ListAllTuteur();

        [OperationContract]
        ResponseData<bool> DeleteTuteur(TuteurDTO tuteurToDelete);

        [OperationContract]
        ResponseData<TuteurDTO> GetTuteurById(int tuteurId);

        [OperationContract]
        ResponseData<bool> UpdateExistingTuteur(TuteurDTO tuteurToUpdate);

        [OperationContract]
        ResponseData<bool> AddTuteur(TuteurDTO tuteurToAdd);

        [OperationContract]
        ResponseData<bool> AddStagiaireToTuteur(TuteurDTO tuteurToUpdate, StagiaireDTO stagiaireToAdd);

        [OperationContract]
        ResponseData<bool> DeleteStagiaireOfTuteur(TuteurDTO tuteurToUpdate, StagiaireDTO stagiaireToDelete);

        [OperationContract]
        ResponseData<IEnumerable<StagiaireDTO>> ListStagiaireOfTuteur(TuteurDTO tuteurToGetStagiaire);
    }
}
