using UnityEngine;

namespace Cat
{
    public class SoundManager : MonoBehaviour
    {
        public AudioSource audioSource;
        public AudioClip playBgmClip;
        public AudioClip jumpClip;

        public AudioClip introBgmClip; //(06-10)
        public AudioClip colliderClip; //(06-10)

        public void SetBGMSound(string bgmName)
        {
            if (bgmName == "Intro")
            {
                audioSource.clip = introBgmClip;

            }
            else if (bgmName == "Paly")
            {
                audioSource.clip = playBgmClip;
            }

            audioSource.loop = true;
            audioSource.volume = 0.1f;

            audioSource.Play();
        }
        public void OnJumpSound()
        {
            audioSource.PlayOneShot(jumpClip);
        }

        public void OnColliderSound()
        {
            audioSource.PlayOneShot(colliderClip);
        }
    }
}
