using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    private int count = 0;
    private void Start()
    {
        while (count <= 10)
        {
            count++;
            if (count % 3 == 0)
            {
                Debug.Log("박수");
                continue;
            }
            Debug.Log($"현재 숫자 {count}");
        }
        
        
        
        
        
        
        
        //while (count < 10)
        //{
        //    count++;

        //    if (count == 5)
        //    {
        //        continue; //break; // break와 continue의 차이
        //    }
        //    Debug.Log($"현재 {count}입니다");
        //}

        //do
        //{
        //    count++;
        //Debug.Log(count);
        //}
        //while (count < 7);
    }
}
