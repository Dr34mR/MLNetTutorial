using System;
using MyMLAppML.Model;

namespace myMLApp
{
    internal class Program
    {
        private static void Main()
        {
            // Add input data
            var input = new ModelInput {SentimentText = "That is rude."};

            // Load model and predict output of sample data
            var result = ConsumeModel.Predict(input);
            Console.WriteLine($"Text: {input.SentimentText}\nIs Toxic: {result.Prediction}");
        }
    }
}
