using System.Collections;
using UnityEngine;

public class SetTile2 : MonoBehaviour
{
    public GameObject tilePrefabs;
    public int row = 5, col = 5;

    IEnumerator Start()
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                var pos = new Vector3(j, 0, i);

                GameObject tile = Instantiate(tilePrefabs, pos, Quaternion.identity);
                Renderer renderer = tile.GetComponent<Renderer>();

                if ((i + j) % 2 == 0) // 짝수
                    renderer.material.color = Color.white;
                else // 홀수
                    renderer.material.color = Color.black;

                yield return new WaitForSeconds(0.1f);
            }
        }
    }
}