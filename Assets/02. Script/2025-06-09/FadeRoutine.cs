using System.Collections;
using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.UI;

public class FadeRoutine : MonoBehaviour
{
    public Image fadePanel; // 페이드 이미지

    public void OnFade(float fadeTime, Color color, bool isFadeStart)
    {

        StartCoroutine(Fade(fadeTime, color, isFadeStart));
    }

    IEnumerator Fade(float fadeTime, Color color, bool isFadeStart)
    {
        float timer = 0f; // 사용될 타이머
        float percent = 0f;


        while (percent <= 1f)
        {
            timer += Time.deltaTime;
            percent = timer / fadeTime; // 페이드 시간이 퍼센트 단위로 동작
            
            float value = isFadeStart ? percent : 1 - percent;
            Debug.Log("value : " + value);

            fadePanel.color = new Color(color.r, color.g, color.b, value);
            yield return null;
        }
    }
}
