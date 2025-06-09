using UnityEngine;

public class StudyForeach : MonoBehaviour
{
    public string[] persons = new string[5] { "철수", "영희", "동수", "마이클", "존" };

    public string findName;

    private void Start()
    {
        FindPerson(findName);
    }

    private void FindPerson(string name)
    {
        bool inFind = false;
        foreach (var person in persons)
        {
            if (person == name)
            {
                inFind = true;
                Debug.Log($"인원 중에 {name}이 존재합니다.");
                break;
            }
        }
        if(!inFind)
            Debug.Log($"{name}을 찾지 못했습니다.");
    }
}
