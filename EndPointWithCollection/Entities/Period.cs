using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ManagedCare.InRule.Common.Entities
{
    [Serializable]
    [DataContract]
    public class Period
    {
        [DataMember]
        public DateTime Start { get; set; }

        [DataMember]
        public DateTime End { get; set; }
    }
}
