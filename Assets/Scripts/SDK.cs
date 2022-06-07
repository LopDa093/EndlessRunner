using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Random = UnityEngine.Random;

namespace SDK {
    public class SDK : MonoBehaviour{

        //static readonly string rootFolder = @"C:\Users\Dany\Desktop";   
        //Default file. MAKE SURE TO CHANGE THIS LOCATION AND FILE PATH TO YOUR FILE   
        static readonly string textFile = @"C:\Users\Dany\Desktop\GIFT.txt";
        public Question[] questions;
        public GameObject gameObj;
        
        public void Awake() {
            questions = new Question[5];
            for (int i = 0; i < questions.Length; i++) {
                questions[i] = gameObject.AddComponent<Question>();
            }
            gameObj = new GameObject();
            SplitTextToQuestions();
        }

        public Question randomQuestion() {
            int x = Random.Range( 0 , 4 );
            return questions[0];
        }

        public string checkType(string text) {
            
            if (text.Contains("=") && text.Contains("~")) {
                return "Checkbox";
            } else if (text.Contains("{T}") || text.Contains("{TRUE}") || text.Contains("{F}") || text.Contains("{FALSE}")) {
                return "TrueFalse";
            } else if (text.Contains("=") && !text.Contains("~")) {
                return "TextBox";
            } else {
                return "";
            }
        }
        /*
        public Question returnQuestion() {
            
        }
        */
        public void SplitTextToQuestions() {
            string[] text = Read().Split('}', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < text.Length; i++) {
                text[i].Trim();
                Debug.Log(text[i]);
            }
            for (int i = 0; i < text.Length; i++) {
                if (checkType(text[i]) == "Checkbox") {
                    string[] temp;
                    temp = multi1(text[i]);
                    for (int j = 0; j < temp.Length; j++) {
                        Debug.Log(temp[j]);
                    }
                    //gameObject.AddComponent<MultiQuestion>();
                    //questions[i] = Instantiate<MultiQuestion>();
                    MultiQuestion myC = MultiQuestion.CreateComponent(gameObj, temp[0], temp[1], temp[2], "Checkbox", temp);
                    questions[i] = myC;
                }
                else if (checkType(text[i]) == "TextBox") {
                    string[] temp;
                    temp = Textbox(text[i]);
                    string[] cook = new string[temp.Length - 2];
                    for (int j = 0; j < temp.Length - 2; j++) {
                        cook[j] = temp[j + 2];
                    }
                    //questions[i] = new ShortQuestion(temp[0], temp[1], cook);
                    
                    ShortQuestion myC = ShortQuestion.CreateComponent(gameObj, temp[0], temp[1], cook, "TextBox");
                    questions[i] = myC;
                }
                else if (checkType(text[i]) == "TrueFalse") {
                    string[] temp;
                    temp = TF(text[i]);
                    
                    TFQuestion myC = TFQuestion.CreateComponent(gameObj, temp[0], temp[1], temp[2], "TrueFalse");
                    questions[i] = myC;
                    //questions[i] = new TFQuestion(temp[0], temp[1], temp[2]);
                }
                else {
                    questions[i] = gameObject.AddComponent<Question>();
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
            }
            
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
            }
            */
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

        public static string[] Textbox(string text) {
            string[] spearator = { "::", "="};

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
            /*
            foreach (string s in strlist) {
                Console.WriteLine(s);
                Debug.Log(s);
            }
            */
            //strlist[strlist.Length] = answer;
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