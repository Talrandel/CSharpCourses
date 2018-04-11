using System;
using System.Speech.Recognition;
using System.Globalization;

namespace SpeechDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var ci = new CultureInfo("en-us");
            var ciRussian = new CultureInfo("ru-RU");

            var sre = new SpeechRecognitionEngine(ci);
            sre.SetInputToDefaultAudioDevice();
            sre.SpeechRecognized += Sre_SpeechRecognized;

            var choices = new Choices();
            choices.Add(new string[] { "hello", "how are you", "visual studio", "reactive programming" });
            //choices.Add(new string[] { "привет", "как дела", "взял и потащил", "раз", "два", "три", "четыре", "пять" });

            var gb = new GrammarBuilder();
            gb.Append(choices);
            gb.Culture = ci;

            var grammar = new Grammar(gb);
            sre.LoadGrammar(grammar);
            //var dictationGrammar = new DictationGrammar();
            //sre.LoadGrammar(dictationGrammar);

            sre.RecognizeAsync(RecognizeMode.Multiple);

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        private static void Sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Confidence > 0.1)
                Console.WriteLine(e.Result.Text);
        }
    }
}