using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PotalController : MonoBehaviour
{
    public FadeRoutine fade;

    public GameObject portalEffect;
    public GameObject loadingImage;

    public Image ProgressBar;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(PortalRoutine());
        }
        portalEffect.SetActive(true);
    }
    
    IEnumerator PortalRoutine()
    {
        portalEffect.SetActive(true);
        yield return StartCoroutine(fade.Fade(3f, Color.white, true));

        loadingImage.SetActive(true);
        yield return StartCoroutine(fade.Fade(3f, Color.white, false));

        while (ProgressBar.fillAmount < 1f)
        {
            ProgressBar.fillAmount += Time.deltaTime * 0.3f;

            yield return null;
        }
        SceneManager.LoadScene(1);
    }
}
