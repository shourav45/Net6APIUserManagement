using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public static class ObjectComparison
    {
        public static List<string> GetChangedProperties(Object A, Object B)
        {
            if (A.GetType() != B.GetType())
            {
                throw new System.InvalidOperationException("Objects of different Type");
            }

            List<string> changedProperties = new List<string>();
            foreach (PropertyInfo info in A.GetType().GetProperties())
            {
                object propValueA = info.GetValue(A, null);
                object propValueB = info.GetValue(B, null);
                if (propValueA.ToString() != propValueB.ToString())
                {
                    changedProperties.Add(info.Name);
                }
            }
            return changedProperties;

            //List<string> changedProperties = ElaborateChangedProperties(A.GetType().GetProperties(), B.GetType().GetProperties(), A, B);
            //return changedProperties;
        }

        public static List<string> ElaborateChangedProperties(PropertyInfo[] pA, PropertyInfo[] pB, Object A, Object B)
        {
            List<string> changedProperties = new List<string>();
            foreach (PropertyInfo info in pA)
            {
                object propValueA = info.GetValue(A, null);
                object propValueB = info.GetValue(B, null);
                if (propValueA != propValueB)
                {
                    changedProperties.Add(info.Name);
                }
            }
            return changedProperties;
        }
    }
}
