using UnityEngine;

public class StudyProperty : MonoBehaviour
{
    [SerializeField]private float moveSpeed = 10f;


    [field:SerializeField] // []안에 들어가는 것들을 어트리뷰트라고 함
    private float moveSpeed2 = 10f;
    public float MoveSpeed2
    {
        get; set;
    }
}
