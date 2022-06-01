using UnityEngine;
using UnityEngine.UI;

namespace LaneGame.Gates
{
    public class QuestionGate : MonoBehaviour
    {

        public float gateValue;
        public GateSide gate;
        private GateTrigger trigger;
        UI_Handler handler;
        public Canvas UI;
        public GameObject question;
        //private TextMeshProUGUI gateText;

        private void Awake() {
            trigger = GetComponentInChildren<GateTrigger>();
           question =  GameObject.FindGameObjectWithTag("TrueFalse");
            Debug.Log(UI);
            //  gateText = GetComponentInChildren<TextMeshProUGUI>();
            //gateValue = Random.Range(-6, 6);
            if (trigger != null)
                trigger.GateTriggered += ActivateGate;
            else {
                //Debug.LogWarning($"{gate} gate trigger not found!");
            }

         //   gateText.text = string.Format(gateValue >= 0 ? $"+{gateValue}" : $"{gateValue}");
        }

        private void ActivateGate() {
            Debug.Log($"{gate} gate activated!");
            //DestroyGates();                   //you can uncomment this line if you prefer the gates are destroyed after use. I chose not too.
            UI.enabled = true;
            question.SetActive(true);
            Time.timeScale = 0f;
            
            PlayerUnitManager.UnitManager.HandleUnits(gateValue);
        }

        private void DestroyGates() {
            Destroy(gameObject.transform.parent.gameObject);
        }


        

        private void Start() {
            
        }


        //intentionally left blank
        
    }
}