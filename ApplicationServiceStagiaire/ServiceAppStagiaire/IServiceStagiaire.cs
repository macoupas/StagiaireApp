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
    }
}
