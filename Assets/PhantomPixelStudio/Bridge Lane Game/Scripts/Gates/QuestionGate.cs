using UnityEngine;
using UnityEngine.UI;
using SDK;
namespace LaneGame.Gates
{
    public class QuestionGate : MonoBehaviour
    {

        public float gateValue;
        public GateSide gate;
        private GateTrigger trigger;
        public UI_Handler handler;
        //public Canvas UI;
        public SDK.SDK sdk;
        public Question question = new Question();
        //private TextMeshProUGUI gateText;

        private void Start() {
            trigger = GetComponentInChildren<GateTrigger>();
            sdk = new SDK.SDK();
            sdk.SplitTextToQuestions();
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
            Debug.Log($"{gate} gate activated!");
            //DestroyGates();                   //you can uncomment this line if you prefer the gates are destroyed after use. I chose not too.
            /*
            GameObject.Find("UI").SetActive(true);
            question = GameObject.Find("TrueFalse");
            question.SetActive(true);
            */
            handler.UI.enabled = true;
            //handler.TrueFalse.SetActive(true);
            Time.timeScale = 0f;
            
            PlayerUnitManager.UnitManager.HandleUnits(gateValue);
        }

        private void OnTriggerExit(Collider other) {
            handler.UI.enabled = false;
            
            Time.timeScale = 1f;
        }

        private void DestroyGates() {
            Destroy(gameObject.transform.parent.gameObject);
        }


        



        //intentionally left blank
        
    }
}