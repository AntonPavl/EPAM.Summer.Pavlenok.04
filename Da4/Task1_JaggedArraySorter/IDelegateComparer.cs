using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_JaggedArraySorter
{
    public interface IDelegateComparer
    {
        int Compare(double[] a,double[] b,Func<double[], double[], int> f);
    }
}
