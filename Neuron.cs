using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuralNetwork
{
    public class Neuron
    {
        public List<double> Weight { get; }
        public NeuronType NeuronType { get; set; }
        public double Output { get; private set; }

        public Neuron(int inputCount, NeuronType NeuronType = NeuronType.Normal)
        {
            this.NeuronType = NeuronType;
            Weight = Enumerable.Range(0, inputCount).Select(w => 1.0).ToList();
        }

        //feed forward
        //Слева направо - линейная сеть

        public double FeedForward(List<double> inputs)
        {
            var sum = 0.0;
            for(int i=0; i<inputs.Count; i++)
            {
                sum += inputs[i] * Weight[i];
            }

            Output = Sigmoid(sum);
            return Output;
        }

        /// <summary>
        /// Сигмоида
        /// </summary>
        /// <param name="x">Степень сигмоиды</param>
        /// <returns></returns>
        private double Sigmoid(double x) => 1.0 / (1 + Math.Exp(-x));

        public void SetWeights(params double[] weights)
        {
            //TODO: удалть после добавления возможности обучения сети
            for(int i=0; i< weights.Length; i++)
            {
                Weight[i] = weights[i];
            }
        }


        public override string ToString()
        {
            return Output.ToString();
        }

    }
}
