using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Cat
{
    public class UIManager : MonoBehaviour
    {
        public SoundManager soundManager;// (06-10)

        public GameObject PlayObj;
        public GameObject introUI;
        public GameObject playUI;

        public TMP_InputField inputField; // 게임 시작전 이름을 넣는 부분의 텍스트 UI임
        public TextMeshProUGUI nameTextUI; // TextMeshProUGUI는 게임시작시 고양이 머리위에 있는 텍스트 UI임

        public Button startButton;

        private void Awake()
        {
            PlayObj.SetActive(false);
            introUI.SetActive(true);
            playUI.SetActive(false);
        }

        private void Start()
        {
            startButton.onClick.AddListener(OnStartButton);
        }
        public void OnStartButton()
        {
            bool isNoText = inputField.text == "" ? false : true;
            
            if (isNoText)
            {
                Debug.Log("이름을 입력하세요");
            }
            else
            {
                PlayObj.SetActive(true);
                playUI.SetActive(true);
                introUI.SetActive(false);
                GameManager.isPlay = true;

                soundManager.SetBGMSound("Play"); // (06-10)

                nameTextUI.text = inputField.text;
            }
        }
    }
}
