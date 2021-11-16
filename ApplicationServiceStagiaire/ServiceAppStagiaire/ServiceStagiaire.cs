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
    }
}
