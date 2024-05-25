using CromulentBisgetti.ContainerPacking.Entities;
using System.Collections.Generic;

namespace CromulentBisgetti.ContainerPacking.Utils
{
    internal class AlgorithmPackingResultNameComparison : IComparer<AlgorithmPackingResult>
    {
        public int Compare(AlgorithmPackingResult x, AlgorithmPackingResult y)
        {
            return x.AlgorithmName.CompareTo(y.AlgorithmName);
        }

        internal static AlgorithmPackingResultNameComparison Comparer { get; } = new AlgorithmPackingResultNameComparison();
    }
}