using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [DataContract]
    public class Response
    {
        private bool isSuccess;
        private string message;
        public Response(bool isSuccess, string message)
        {
            this.isSuccess = isSuccess;
            this.message = message;
        }
        [DataMember]
        public bool IsSucces
        {
            get
            {
                return isSuccess;
            }

            private set
            {
                isSuccess = value;
            }
        }
        [DataMember]
        public string Message
        {
            get
            {
                return message;
            }

            private set
            {
                message = value;
            }
        }
    }
}
