using Mono.Cecil;
using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]private GameObject[] monsters;

    [SerializeField] private GameObject[] items;

    //n초마다 몬스터를 랜덤으로 생성하는 기능

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);

            var randomIndex = Random.Range(0, monsters.Length);
            var randomX = Random.Range(-8f, 9f);
            var randomY = Random.Range(-3f, 5f);

            var createPos = new Vector3(randomX, randomY, 0);

            Instantiate(monsters[randomIndex], createPos, Quaternion.identity);
        }
    }

    public void DropCoin(Vector3 dropPos)
    {
        var randomIndex = Random.Range(0, items.Length);

        GameObject item = Instantiate(items[randomIndex], dropPos, Quaternion.identity);

        Rigidbody2D itemRb = item.GetComponent<Rigidbody2D>();

        itemRb.AddForceY(3f, ForceMode2D.Impulse);
        itemRb.AddForceX(Random.Range(-2f, 2), ForceMode2D.Impulse);

        float ranPower = Random.Range(-1.5f, 1.5f);
        itemRb.AddTorque(ranPower, ForceMode2D.Impulse);
    }
}
