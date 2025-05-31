using UnityEngine;

public class PinBall : MonoBehaviour
{
    public PinBallManager pinBallManager;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Untagged") == false)
        {

            int score = 0;
            switch (other.gameObject.tag)
            {
                case "Triangle (10)":
                    score = 10;
                    break;
                case "Circle(30)":
                    score = 30;
                    break;
                case "Square (50)":
                    score = 50;
                    break;
                case "Capsule(70)":
                    score = 70;
                    break;
            }

            pinBallManager.totalScore += score;
            Debug.Log($"{score}점 획득");
        }



        //if (other.gameObject.CompareTag("Triangle (10)")) 
        //{
        //    pinBallManager.totalScore += 10;
        //    Debug.Log("10점 획득");
        //}
        //else if (other.gameObject.CompareTag("Circle(30)"))
        //{
        //    pinBallManager.totalScore += 30;
        //    Debug.Log("30점 획득");
        //}
        //else if (other.gameObject.CompareTag("Square (50)"))
        //{
        //    pinBallManager.totalScore += 50;
        //    Debug.Log("50점 획득");
        //}
        //else if (other.gameObject.CompareTag("Capsule(70)"))
        //{
        //    pinBallManager.totalScore += 70;
        //    Debug.Log("70점 획득");
        //}


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Gameover"))
        {
            Debug.Log($"게임 종료 : 최종 스코오 {pinBallManager.totalScore}");
        }
    }
}
