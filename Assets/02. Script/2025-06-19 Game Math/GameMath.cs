using UnityEngine;

public class GameMath : MonoBehaviour
{
    public float aAngle = 30f;
    public float bAngle = 90f;
    public float aSide = 1f;

    private void Start()
    {
        float aRad = aAngle * Mathf.Deg2Rad;
        float bRad = bAngle * Mathf.Deg2Rad;

        float bSide = (aSide * Mathf.Sin(bRad)) / Mathf.Sin(aRad);

        Debug.Log(bSide);
    }
}
