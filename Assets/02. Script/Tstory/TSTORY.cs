using System.Collections;
using UnityEngine;

public class Animal
{
    public class Mammalia : Animal
    {
        // 포유류는 새끼를 낳아 젖을 먹이는 공통점이 있습니다.

        public class Cat : Mammalia
        {
            // 고양이 객체
        }

        public class Dog : Mammalia
        {
            // 강아지 객체
        }
    }
}