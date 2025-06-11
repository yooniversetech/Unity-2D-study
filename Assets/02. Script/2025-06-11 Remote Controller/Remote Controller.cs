using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class RemoteController : MonoBehaviour
{
    public GameObject videoScreen;
    private VideoPlayer videoPlayer;
    public Button[] buttonUI;
    public bool isMute = false;

    public VideoClip[] videoClips;

    public int currentClipIndex = 0;

    private void Awake()
    {
        videoPlayer = videoScreen.GetComponent<VideoPlayer>();
        videoPlayer.clip = videoClips[0];
    }

    private void Start()
    {
        buttonUI[0].onClick.AddListener(OnScreenPower);
        buttonUI[1].onClick.AddListener(OnMute);

        buttonUI[2].onClick.AddListener(OnNextChannel);
        buttonUI[3].onClick.AddListener(OnPrevChannel);
    }

    public void OnScreenPower()
    {
        videoScreen.SetActive(!videoScreen.activeSelf); // GameObject를 활용한 방법

        //길게 적은것
        //if (!isOn)
        //{
        //    videoScreen.SetActive(true);
        //    isOn = true;
        //}
        //else // isOn == false
        //{
        //    videoScreen.SetActive(false);
        //    isOn = false;
        //}

        // NOT을 활용해서 줄여서 적은 것
        //isOn = !isOn;
        //videoScreen.SetActive(isOn);
    }

    public void OnMute()
    {
        isMute = !isMute;
        videoPlayer.SetDirectAudioMute(0, isMute);

        //isMute = !isMute;
        //videoPlayer.SetDirectAudioMute(0, !videoPlayer.GetDirectAudioMute(0));
    }

    //public void OnChangeChannel(bool isNext)
    //{
    //    int value = isNext ? 1 : -1;
    //    currentClipIndex += value;

    //    if (currentClipIndex > videoClips.Length - 1)
    //        currentClipIndex = 0;

    //    if (currentClipIndex < 0)
    //        currentClipIndex = videoClips.Length - 1;


    //    videoPlayer.clip = videoClips[currentClipIndex];
    //    videoPlayer.Play();
    //}

    public void OnNextChannel() // 오른쪽 버튼
    {
        currentClipIndex++;
        if (currentClipIndex > videoClips.Length - 1)
        {
            currentClipIndex = 0;
        }

        videoPlayer.clip = videoClips[currentClipIndex];
        videoPlayer.Play();
    }

    public void OnPrevChannel() // 왼쪽 버튼
    {
        currentClipIndex--;
        if (currentClipIndex < 0)
        {
            currentClipIndex = videoClips.Length - 1;
        }

        videoPlayer.clip = videoClips[currentClipIndex];
        videoPlayer.Play();
    }
}
