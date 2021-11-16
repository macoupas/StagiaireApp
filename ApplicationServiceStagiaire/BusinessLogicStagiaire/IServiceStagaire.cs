using ApplicationServiceStagiaire;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicStagiaire
{
    public interface IServiceStagaire
    {
        ResponseData<IEnumerable<StagiaireDTO>> ListAllStagiaire();

        ResponseData<StagiaireDTO> GetStagiaireById(int id);

        ResponseData<bool> DeleteStagiaire(StagiaireDTO stagiaireToDelete);

        ResponseData<bool> UpdateExistingStagiaire(StagiaireDTO stagiaireToUpdate);

        ResponseData<bool> AddStagiaire(StagiaireDTO stagiaireToAdd);

        ResponseData<IEnumerable<TuteurDTO>> ListAllTuteur();

        ResponseData<TuteurDTO> GetTuteurById(int id);

        ResponseData<bool> DeleteTuteur(TuteurDTO tuteurToDelete);

        ResponseData<bool> UpdateExistingTuteur(TuteurDTO tuteurToUpdate);

        ResponseData<bool> AddTuteur(TuteurDTO tuteurToAdd);

        ResponseData<bool> AddStagiaireToTuteur(TuteurDTO tuteurToUpdate, StagiaireDTO stagiaireToAdd);

        ResponseData<bool> DeleteStagiaireOfTuteur(TuteurDTO tuteurToUpdate, StagiaireDTO stagiaireToDelete);

        ResponseData<IEnumerable<StagiaireDTO>> ListStagiaireOfTuteur(TuteurDTO tuteurToGetStagiaire);
    }
}
