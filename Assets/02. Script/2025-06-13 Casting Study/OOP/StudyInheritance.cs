using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;

public class StudyInheritance : MonoBehaviour
{
    //public List<Student> students = new List<Student>();
    //public List<Soldier> soldiers = new List<Soldier>();

    public List<Person> persons = new List<Person>();
    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Student student = new Student();
            persons.Add(student);

            Soldier soldier = new Soldier();
            persons.Add(student);

        }
    }

    public void AllMove()
    {
        foreach (var person in persons)
        {
            person.Walk();
        }
    }

    public class Character : MonoBehaviour
    {
        public virtual void Attack()
        {
            Debug.Log("공격1");
        }
    }
        
}