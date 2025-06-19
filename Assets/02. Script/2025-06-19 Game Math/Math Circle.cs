using UnityEngine;

public class MathCircle : MonoBehaviour
{
    private float theta;
    [SerializeField] private float speed, radius;
    private void Update()
    {
        theta += Time.deltaTime * speed;

        float x = Mathf.Cos(theta);
        float y = Mathf.Sin(theta);

        Vector2 pos = new Vector2(x, y) * radius;
        transform.position = pos;
    }
}
