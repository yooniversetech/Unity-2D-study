using UnityEngine;

public class MathLight : MonoBehaviour // 빛이 깜빡깜빡하는 기능을 삼각함수를 이용해서 구현
{
    private Light light;
    private float theta;
    [SerializeField] private float power;
    [SerializeField] private float speed;

    private void Start()
    {
        light = GetComponent<Light>();
    }
    void Update()
    {
        theta += Time.deltaTime * speed;

        light.intensity = Mathf.Sin(theta) * power; // 깜빡깜빡하는 하는 기능

        //light.intensity = Mathf.PerlinNoise(theta, 0) * power; // 깜빡깜빡하는 하는 기능보다는 고장난 전등느낌(일렁일렁 하는 느낌)
    }
}
