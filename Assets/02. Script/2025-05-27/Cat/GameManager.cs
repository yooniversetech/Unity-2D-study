using Cat;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace Cat
{
    public class GameManager : MonoBehaviour
    {
        public SoundManager soundManager;

        public TextMeshProUGUI playTimeUI;
        public TextMeshProUGUI scoreUI;

        private float timer;
        public static int score; // 사과 먹은 갯수
        public static bool isPlay;

        private void Start()
        {
            soundManager.SetBGMSound("Intro");
        }
        private void Update()
        {
            if (!isPlay)
                return;

            timer += Time.deltaTime;

            playTimeUI.text = string.Format("플레이 시간 : {0:F1}초", timer);
            scoreUI.text = $"{score}개";
        }
    }

}

