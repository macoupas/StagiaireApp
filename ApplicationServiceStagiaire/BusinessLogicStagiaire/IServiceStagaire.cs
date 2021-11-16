using Core;
using System.Collections.Generic;

namespace BusinessLogicStagiaire
{
    public interface IServiceStagaire
    {
        ResponseData<IEnumerable<StagiaireDTO>> ListAllStagiaire();

        ResponseData<bool> DeleteStagiaire(StagiaireDTO stagiaireToDelete);

        ResponseData<bool> UpdateExistingStagiaire(StagiaireDTO stagiaireToUpdate);

        ResponseData<bool> AddStagiaire(StagiaireDTO stagiaireToAdd);

        ResponseData<IEnumerable<TuteurDTO>> ListAllTuteur();
    }
}
