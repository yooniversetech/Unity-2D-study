using UnityEngine;

public class DoorSlideEvent : MonoBehaviour
{
    private Animator anim;

    public string openKey;
    public string closeKey;

    private void Start()
    {
       anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetTrigger(openKey);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetTrigger(closeKey);
        }
    }
}
