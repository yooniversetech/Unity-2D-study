using System.Collections;
using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.UI;

public class FadeRoutine : MonoBehaviour
{
    public Image fadePanel; // 페이드 이미지

    
    void Start()
    {
        StartCoroutine(FadeRoutineA(3, true));
    }

    IEnumerator FadeRoutineA(float fadeTime, bool isFadeIn)
    {
        float timer = 0f; // 사용될 타이머
        float percent = 0f;

        while (percent <= 1f)
        {
            timer += Time.deltaTime;
            percent = timer / fadeTime; // 페이드 시간이 퍼센트 단위로 동작
            float value = isFadeIn ? percent : 1 - percent;

            fadePanel.color = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, value);
            yield return null;
        }
    }
}
