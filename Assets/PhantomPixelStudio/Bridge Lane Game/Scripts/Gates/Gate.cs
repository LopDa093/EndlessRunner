using TMPro;
using UnityEngine;

namespace LaneGame.Gates
{
    public enum GateSide
    {
        Left,
        Right,
        Question
    }
    public abstract class Gate : MonoBehaviour
    {
        public float gateValue=0;
        public GateSide gate;
        private GateTrigger trigger;
        private TextMeshProUGUI gateText;

        private void Awake()
        {
            trigger = GetComponentInChildren<GateTrigger>();
            gateText = GetComponentInChildren<TextMeshProUGUI>();
            gateValue = Random.Range(-6,6);
            if (trigger != null)
                trigger.GateTriggered += ActivateGate;
            else
            {
                //Debug.LogWarning($"{gate} gate trigger not found!");
            }

            gateText.text = string.Format(gateValue >= 0 ? $"+{gateValue}" : $"{gateValue}");
        }

        private void ActivateGate()
        {
            Debug.Log($"{gate} gate activated!");

            //DestroyGates();                   //you can uncomment this line if you prefer the gates are destroyed after use. I chose not too.
            PlayerUnitManager.UnitManager.HandleUnits(gateValue);
        }

        private void DestroyGates()
        {
            Destroy(gameObject.transform.parent.gameObject);
        }
    }
}