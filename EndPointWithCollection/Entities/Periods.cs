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
    public class Periods
    {
        public Periods() 
        { 
            this.Initialize();
        }

        [DataMember]
        public List<Period> periodList;

        public void Initialize()
        { 
            this.periodList = new List<Period>();
        }
    }
}
