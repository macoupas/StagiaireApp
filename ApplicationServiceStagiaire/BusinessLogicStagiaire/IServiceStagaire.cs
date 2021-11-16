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

        ResponseData<bool> DeleteStagiaire(StagiaireDTO stagiaireToDelete);

        ResponseData<bool> UpdateExistingStagiaire(StagiaireDTO stagiaireToUpdate);

        ResponseData<bool> AddStagiaire(StagiaireDTO stagiaireToAdd);
    }
}
