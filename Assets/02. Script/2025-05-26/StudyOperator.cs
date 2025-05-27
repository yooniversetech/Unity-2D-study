using UnityEngine;

public class StudyOperator : MonoBehaviour
{
    public int currentLevel = 10;
    public int maxLevel = 99;

    void Start()
    {
        // 1. bool isMax = currentLevel >= maxLevel;
        //    Debug.Log($"현재 레벨을 만랩이 {isMax}입니다");
        string msg = currentLevel >= maxLevel ? "현재 만랩입니다." : "현재 만랩이 아닙니다.";
        Debug.Log(msg);
    }
}
