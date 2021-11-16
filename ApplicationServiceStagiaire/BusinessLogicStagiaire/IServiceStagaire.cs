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
    }
}
