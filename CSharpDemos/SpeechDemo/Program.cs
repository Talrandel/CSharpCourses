using System;
using System.Speech.Recognition;
using System.Globalization;
using System.Diagnostics;
using System.Speech.Synthesis;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SpeechDemo
{
    class Program
    {
        static SpeechRecognitionEngine speechRecognitionEngine;
        static SpeechSynthesizer synthesizer;
        static List<string> commands;
        static string currentCommand;
        static PromptBuilder promptBuilder;
        static ReadOnlyCollection<InstalledVoice> voices;

        static void Main(string[] args)
        {
            var ci = new CultureInfo("en-us");
            var ciRussian = new CultureInfo("ru-RU");
            commands = new List<string>();
            currentCommand = string.Empty;
            promptBuilder = new PromptBuilder();

            synthesizer = new SpeechSynthesizer();
            voices = synthesizer.GetInstalledVoices();
            foreach (var voice in voices)
            {
                Console.WriteLine(voice.VoiceInfo.Name);
                Console.WriteLine(voice.VoiceInfo.Description);
                Console.WriteLine(voice.VoiceInfo.Age);
            }
            speechRecognitionEngine = new SpeechRecognitionEngine(ci);
            speechRecognitionEngine.SetInputToDefaultAudioDevice();
            speechRecognitionEngine.SpeechRecognized += Sre_SpeechRecognized;

            var choices = new Choices();
            choices.Add(new string[] { "say hello", "how are you", "print my name", "open notepad", "show my mail", "speak selected text", "shutdown"});
            //choices.Add(new string[] { "привет", "как дела", "взял и потащил", "раз", "два", "три", "четыре", "пять" });

            var gb = new GrammarBuilder();
            gb.Append(choices);
            gb.Culture = ci;

            var grammar = new Grammar(gb);
            speechRecognitionEngine.LoadGrammar(grammar);
            //var dictationGrammar = new DictationGrammar();
            //sre.LoadGrammar(dictationGrammar);

            speechRecognitionEngine.RecognizeAsync(RecognizeMode.Multiple);

            while (true)
            {
                Console.WriteLine("Input text to be spoken by machine:");
                currentCommand = Console.ReadLine();
                Console.WriteLine($"Text to be spoken by machine: {currentCommand}");
            }
            Console.ReadLine();
        }

        private static void Sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Confidence > 0.1)
            {
                //Console.WriteLine(e.Result.Text);
                switch (e.Result.Text)
                {
                    case "say hello":
                        SayHello();
                        break;
                    case "print my name":
                        PrintMyName();
                        break;
                    case "open notepad":
                        OpenNotepad();
                        break;
                    case "show my mail":
                        ShowMyMail();
                        break;
                    case "speak selected text":
                        SpeakSelectedText(currentCommand);
                        break;
                    case "shutdown":
                        Shutdown();
                        break;
                    default:
                        break;
                }
            }
        }

        private static void SpeakSelectedText(string param)
        {
            if (string.IsNullOrEmpty(param))
                return;
            synthesizer.SpeakAsync(param);
        }

        private static void Shutdown()
        {
            Environment.Exit(0);
        }

        private static void SayHello()
        {
            Console.WriteLine("Hello!");
            synthesizer.SelectVoice(voices[2].VoiceInfo.Name);
            synthesizer.Rate = 2;
            promptBuilder.StartSentence();
            promptBuilder.AppendText("Hello, Eugene!");
            promptBuilder.EndSentence();

            promptBuilder.AppendBreak(new TimeSpan(0, 0, 0, 0, 10));
            
            promptBuilder.StartSentence();
            promptBuilder.AppendText("How are you today?", PromptEmphasis.Strong);
            promptBuilder.EndSentence();

            synthesizer.SpeakAsync(promptBuilder);
        }

        private static void PrintMyName()
        {
            Console.WriteLine("Eugene");
        }

        private static void OpenNotepad()
        {
            OpenProgramByName("notepad++");
        }

        private static void OpenProgramByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Program name is empty.");
                return;
            }
            try
            {
                Process.Start(name);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\t{ex.Message}");
                Console.WriteLine($"\t{ex.Source}");
            }
        }

        private static void OpenProgramByNameWithParameter(string name, string param = null)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Program name is empty.");
                return;
            }
            try
            {
                if (param != null)
                    Process.Start(name, param);
                else
                    Process.Start(name);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\t{ex.Message}");
                Console.WriteLine($"\t{ex.Source}");
            }
        }

        private static void ShowMyMail()
        {
            OpenProgramByNameWithParameter("chrome", @"https://mail.google.com/mail/u/0/#inbox");
        }
    }
}