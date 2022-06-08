using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace LaneGame {
    public class HandleCountdown : MonoBehaviour {
        public float countdownStartValue;
        [SerializeField] private TextMeshProUGUI countdownText;
        [SerializeField] private GameObject countdownUI;
        public UI_Handler ui;

        public event UnityAction StartGame = delegate { };
        private void Awake() {
            ui = gameObject.AddComponent<UI_Handler>();
        }

        private bool wasExecuted = false;

        public void foo() {
            if (!wasExecuted) {
                ui.Checkbox[0].SetActive(false);
                ui.Dropdown[0].SetActive(false);
                ui.TextBox[0].SetActive(false);
                ui.TrueFalse[0].SetActive(false);
                wasExecuted = true;
            }
        }
        private void Update() {
            countdownStartValue -= Time.deltaTime;
            countdownText.text = countdownStartValue.ToString("0");
            if (countdownStartValue < 0) {
                //We can now start moving!
                //countdownUI.SetActive(false);


                foo();
                StartGame();
            }
        }
    }
}