using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SDK {
    class SDK : MonoBehaviour{

        //static readonly string rootFolder = @"C:\Users\Dany\Desktop";   
        //Default file. MAKE SURE TO CHANGE THIS LOCATION AND FILE PATH TO YOUR FILE   
        static readonly string textFile = @"C:\Users\Dany\Desktop\GIFT.txt";
        Question[] questions;

        public void Start() {
            
        }

        public string checkType(string text) {
            if (text.Contains("=") && text.Contains("~")) {
                return "Checkbox";
            } else if (text.Contains("{T}") || text.Contains("{TRUE}") || text.Contains("{F}") || text.Contains("{FALSE}")) {
                return "TrueFalse";
            } else if (text.Contains("=") && !text.Contains("~")) {
                return "Textbox";
            } else {
                return "";
            }
        }

        public void SplitTextToQuestions() {
            string[] text = textFile.Split('}');
            for (int i = 0; i < text.Length; i++) {
                if (checkType(text[i]) == "Checkbox") {
                    string[] temp ;
                    questions[i] = new MultiQuestion();
                }
                else if (checkType(text[i]) == "Textbox") {
                    questions[i] = new ShortQuestion();
                } else if (checkType(text[i]) == "TrueFalse") {
                    questions[i] = new TFQuestion();
                }
                else {
                    questions[i] = new Question();
                }
            }
        }

        public static string Read() {
            
            if (File.Exists(textFile)) {
                // Read entire text file content in one string    
                string text = File.ReadAllText(textFile);
                Console.WriteLine(text);
                return text;
            }
            /*
            if (File.Exists(textFile)) {
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(textFile);
                foreach (string line in lines)
                    Console.WriteLine(line);
            }*/
            /*
            if (File.Exists(textFile)) {
                // Read file using StreamReader. Reads file line by line  
                using (StreamReader file = new StreamReader(textFile)) {
                    int counter = 0;
                    string ln;

                    while ((ln = file.ReadLine()) != null) {
                        Console.WriteLine(ln);
                        Debug.Log(ln);
                        counter++;
                    }
                    file.Close();
                    Console.WriteLine("File has {counter} lines.");
                }
            }*/
            Console.ReadKey();
            return "";
            
        }

        public static string getQuestionType(string text) {
            int x = text.IndexOf("{")-1;
            text.Substring(x, text.Length - x);
            if (text.IndexOf("{true}") > -1 || text.IndexOf("{t}") > -1 || text.IndexOf("{f}") > -1 || text.IndexOf("{false}") > -1) {
                return "TrueFalse";
            }

            if (text.IndexOf("~") > -1 && text.IndexOf("=") > -1) {
                return "MultipleChoice";
            }
            if (text.IndexOf("~") == -1 && text.IndexOf("=") > -1) {
                return "ShortAnswer";
            }
            return "";
        }

        public static string[] TF(string text) {
            string[] spearator = { "::", "{"};

            string[] strlist = text.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in strlist) {
                Console.WriteLine(s);
                //Debug.Log(s);
            }

            return strlist;
        }

        public static string[] multi1(string text) {
            int x = text.IndexOf("=");
            int y = text.IndexOf("~", x);
            int z = text.IndexOf("}", x);

            string answer;

            if (y == -1) {
                answer = text.Substring(x, z-x);
            }
            else {
                answer = text.Substring(x, y - x);
            }


            string[] spearator = { "::", "=", "~" };

            string[] strlist = text.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in strlist) {
                Console.WriteLine(s);
                Debug.Log(s);
            }
            return strlist;
        }

        public static string[] multi2(string text) {
            int x = text.IndexOf("=");
            int y = text.IndexOf("~", x);
            int z = text.IndexOf("}", x);

            string answer;

            if (y == -1) {
                answer = text.Substring(x, z - x);
            }
            else {
                answer = text.Substring(x, y - x);
            }


            string[] spearator = { "::", "=", "~" };

            string[] strlist = text.Split(spearator, StringSplitOptions.RemoveEmptyEntries);



            foreach (string s in strlist) {
                Console.WriteLine(s);
                Debug.Log(s);
            }

            return strlist;
        }
        /*
        public static string title(string[] t) {
            return t[0];
        }

        public static string question(string[] t) {
            return t[1];
        }

        public static string answer(string[] t) {
            
            
            return "";
        }
        */
    }
}