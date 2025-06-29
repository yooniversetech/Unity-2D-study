using System.Collections;
using UnityEngine;

public class InteractionEvent : MonoBehaviour
{
    public enum InteractionType { SIGN, DOOR, NPC}
    public InteractionType type;

    public SoundController soundController;

    public GameObject Popup;

    public FadeRoutine fade;
    
    public GameObject map;
    public GameObject house;

    public Vector3 inDoorPos;
    public Vector3 outDoorPos;
    public bool isHouse;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Interaction(other.transform);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Popup.SetActive(false);
        }
    }

    void Interaction(Transform player)
    {
        switch (type)
        {
            case InteractionType.SIGN:
                Popup.SetActive(true);
                break;
            case InteractionType.DOOR:
                StartCoroutine(DoorRoutine(player));
                break;
            case InteractionType.NPC:
                Popup.SetActive(true);
                break;
        }
    }

    IEnumerator DoorRoutine(Transform player)
    {
        soundController.EventSoundPlay("Door Open");

        yield return StartCoroutine(fade.Fade(3f, Color.black, true));

        map.SetActive(isHouse);
        house.SetActive(!isHouse);

        var pos = isHouse ? outDoorPos : inDoorPos;
        player.transform.position = pos;

        isHouse = !isHouse;

        soundController.EventSoundPlay("Door Close");

        yield return new WaitForSeconds(1f);
        yield return StartCoroutine(fade.Fade(3f, Color.black, false));
    }
}
