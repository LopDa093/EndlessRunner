using UnityEngine;
using UnityEngine.UI;
using SDK;
using System.Collections;

namespace LaneGame.Gates
{
    public class QuestionGate : MonoBehaviour
    {

        public float gateValue;
        public GateSide gate;
        private GateTrigger trigger;
        public UI_Handler handler;
        //public Canvas UI;
        //public SDK.SDK sdk = new SDK.SDK();
        public SDK.SDK sdk;
        public Question question;
        private string correct = "";
        private bool collided = false;
        private bool executed = false;
        //private TextMeshProUGUI gateText;

        private void Start() {
            handler = gameObject.AddComponent<UI_Handler>();
            question = gameObject.AddComponent<Question>();
            sdk = gameObject.GetComponent<SDK.SDK>();
            trigger = GetComponentInChildren<GateTrigger>();
            //Debug.Log(handler);
            //question = new Question();
            //sdk = new SDK.SDK();
            //sdk.SplitTextToQuestions();
            question = sdk.randomQuestion();
            //Debug.Log(question);
            //Debug.Log(question);
            //string name = question.gameObject.name;
            //Debug.Log(name);
            //Debug.Log(UI);
            //gateText = GetComponentInChildren<TextMeshProUGUI>();
            //gateValue = Random.Range(-6, 6);
            if (trigger != null)
                trigger.GateTriggered += ActivateGate;
            else {
                //Debug.LogWarning($"{gate} gate trigger not found!");
            }
        }
        /*
        private void Awake() {
            trigger = GetComponentInChildren<GateTrigger>();
            //sdk.SplitTextToQuestions();
            sdk = new SDK.SDK();
            question = sdk.randomQuestion();
            string name = question.gameObject.name;
            Debug.Log(name);
            //Debug.Log(UI);
            //gateText = GetComponentInChildren<TextMeshProUGUI>();
            //gateValue = Random.Range(-6, 6);
            if (trigger != null)
                trigger.GateTriggered += ActivateGate;
            else {
                //Debug.LogWarning($"{gate} gate trigger not found!");
            }

         //   gateText.text = string.Format(gateValue >= 0 ? $"+{gateValue}" : $"{gateValue}");
        }
        */
        private void ActivateGate() {
            //Debug.Log($"{gate} gate activated!");
            //DestroyGates();                   //you can uncomment this line if you prefer the gates are destroyed after use. I chose not too.
            /*
            GameObject.Find("UI").SetActive(true);
            question = GameObject.Find("TrueFalse");
            question.SetActive(true);
            */
            //Debug.Log(question.name);
            collided = true;
            //correct = question.ChangeUI(handler.Checkbox[0], question.name, question.title, question.text, question.options);

            //handler.UI.enabled = true;
            //handler.TrueFalse.SetActive(true);

            

        }

        private void OnTriggerExit(Collider other) {
            StopCoroutine(Fade());
        }

        private void DestroyGates() {
            Destroy(gameObject.transform.parent.gameObject);
        }


        private void Update() {
            if (collided == true && executed == false) {
                StartCoroutine(Fade());
            }
            if (collided == true && executed == false) {
                if (correct == "correct") {
                    Debug.Log("it is correct");
                    Time.timeScale = 1f;
                    PlayerUnitManager.UnitManager.HandleUnits(13);
                    StopCoroutine(Fade());
                    executed = true;
                } else if (correct == "false") {
                    Debug.Log("it is incorrect");
                    Time.timeScale = 1f;
                    PlayerUnitManager.UnitManager.HandleUnits(-10);
                    StopCoroutine(Fade());
                    executed = true;
                } else {

                }
            }
            
        }

        IEnumerator Fade() {
            correct = question.ChangeUI(question.name, question.title, question.text, question.options);
            yield return new WaitForSeconds(5);
        }

        //intentionally left blank

    }
}