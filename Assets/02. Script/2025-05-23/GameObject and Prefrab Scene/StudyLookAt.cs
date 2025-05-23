using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTF;
    public Transform turretHead;

    public GameObject bulletPrefab; // 총알 프리팹
    public Transform firePos; // 발사 위치

    public float timer;
    public float cooldownTime;

    void Start() // 초기상태로 기본값 셋팅하는 기능
    {
        targetTF = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update() // 무언가를 바라보는 기능
    {
        turretHead.LookAt(targetTF);

        timer += Time.deltaTime;
        if (timer >= cooldownTime)
        {
            timer = 0f;
            GameObject bullet = Instantiate(bulletPrefab, firePos.position, firePos.rotation);
            Destroy(bullet, 0.5f);
        }
        //             GameObject                        Quternian
    }
}
