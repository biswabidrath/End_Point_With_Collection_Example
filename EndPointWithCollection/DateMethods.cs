using ManagedCare.InRule.Common.Entities;
using System;
using System.Linq;
using System.Text;

namespace ManagedCare.InRule.Common.Methods
{
    [Serializable]
    public class DateMethods
    {
        public static Periods GetOverLappingPeriods(Periods firstPersiodSet, Periods secondPersiodSet)
        {
            Periods periods = new Periods();
            periods.periodList = (from f in firstPersiodSet.periodList
                                    from s in secondPersiodSet.periodList
                                    where f.Start < s.End
                                    && s.Start < f.End
                                    select new Period()
                                    {
                                        Start = f.Start < s.Start ? s.Start : f.Start,
                                        End = f.End < s.End ? f.End : s.End
                                    }).ToList();

            return periods;
        }
    }
}
