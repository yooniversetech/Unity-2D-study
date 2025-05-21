using UnityEngine;

public class ComponentStudy : MonoBehaviour
{
    GameObject obj; // GameObject는 class타입이므로 obj는 참조형 타입임.

    public string changeName; // 오브젝트의 바뀔 이름을 담을 변수 선언(public으로 선언하였으므로 인스펙터 창에서 changeName부분을 원하는데로 변경가능)


    void Start()
    {
        obj = GameObject.Find("Main Camera"); // 씬에서 Main Camera라는 이름의 오브젝트를 찾고 Main Camera를 obj로 참조하는 부분.

        obj.name = changeName; // changeNamename을 유니티 인스펙터 창에서 바꾼이름을 name(Alt로 확인했을 때)의 내부 선언이 겟터와 셋터로 선언되어 해당 씬의 식별자를 바꾸는 부분
    }
}
