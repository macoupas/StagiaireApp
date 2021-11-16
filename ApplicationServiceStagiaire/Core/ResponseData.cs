using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [DataContract]
    public class ResponseData<T> : Response
    {
        private T data;

        public ResponseData(bool isSuccess, string message, T data) : base(isSuccess, message)
        {
            this.data = data;
        }
        [DataMember]
        public T Data
        {
            get
            {
                return data;
            }

            private set
            {
                data = value;
            }
        }
    }
}
