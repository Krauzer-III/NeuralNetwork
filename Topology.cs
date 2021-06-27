using System.Collections.Generic;

namespace NeuralNetwork
{
    public class Topology
    {
        public int InputCount { get; }
        public int OutputCount { get; }
        public List<int> HiddenLayers { get; }

        public Topology(int InputCount, int OutputCount, params int[] layers)
        {
            this.InputCount = InputCount;
            this.OutputCount = OutputCount;
            HiddenLayers = new List<int>();
            HiddenLayers.AddRange(layers);
        }
    }
}
