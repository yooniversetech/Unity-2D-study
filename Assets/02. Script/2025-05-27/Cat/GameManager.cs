using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI playTimeUI;
    public TextMeshProUGUI scoreUI;

    private float timer;
    public static int score;

    private void Update()
    {
        timer += Time.deltaTime;

        playTimeUI.text = string.Format("플레이 시간 : {0:F1}초", timer);
        scoreUI.text = $"{score}개";
    }
}

