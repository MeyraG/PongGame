//using UnityEngine;
//using System.Linq;
//using System.Collections.Generic;
//using System;

//[DefaultExecutionOrder(-10)]
//public class ScreenSize : MonoBehaviour
//{
//    [SerializeField] private float speed;

//    [SerializeField] private Event myEvent;

//    private PlayerAI playerAI;

//    private (string, int) dataEntry;  // tuple

//    private Employee employee;

//    private const float range = 3f;

//    public float Speed => speed;

//    private void Awake()
//    {
//        playerAI = GameObject.FindGameObjectWithTag("tag").GetComponent<PlayerAI>();

//        playerAI = FindObjectOfType<PlayerAI>();
//    }

//    public void Positioner(GameObject[] array)
//    {
//        GameObject[] zordered = array.OrderBy(obj => obj.transform.position.z).ToArray();

//        Vector3[] positions = array.Select(obj => obj.transform.position).ToArray();

//        GameObject[] meyra = array.Where(obj => obj.transform.position.z > 0f).ToArray();

//        Vector3[] gizemtos = array.Where(obj => obj.transform.position.z > 0f).Select(obj => obj.transform.position).ToArray();
//    }

//    private void Hebele()
//    {
//        dataEntry = new("Gizem", 32);

//        int age = dataEntry.Item2;

//        employee = new Employee();

//        employee.name = "Mert";

//        employee.age = 31;

//        employee = new Employee("Mert", 31);


//        transform.position = default;
//    }

//    public void CheckShit(Animal[] animals)
//    {
//        List<Animal> anims = new List<Animal>();

//        for (int i = 0; i < animals.Length; i++)
//        {
//            if (animals[i] is Dog)
//            {
//                anims.Add(animals[i]);
//            }
//        }


//        Animal lastAnimal = animals[animals.Length - 1];

//        anims = animals.ToList();

//        lastAnimal = anims.Last();
//    }
//}

//public struct Employee
//{
//    public string name;

//    public int age;

//    public Employee(string n, int a)
//    {
//        name = n;

//        age = a;
//    }
//}

//public class Animal : MonoBehaviour
//{

//}

//public class Dog : Animal
//{
//    public string race;

//    public static float speed;

//    public int age;

//    public void SetRaceAndAge(string race, int age)
//    {
//        this.race = race;

//        this.age = age;
//    }
//}

//public class Cat : Animal
//{
//    MyClass myClass = new MyClass("Mert", 31);

//    public void YesSir()
//    {
//        Dog dog = FindObjectOfType<Dog>();

//        dog.age = 5;

//        Dog.speed = 8f;
//    }
//}

//public class MyClass
//{
//    public string name;

//    public int age;

//    public MyClass(string s, int i)
//    {
//        name = s;

//        age = i;
//    }
//}
