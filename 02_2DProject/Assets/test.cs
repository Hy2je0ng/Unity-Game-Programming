using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player
{
    private int hp;
    private int power;

    public Player(int hp = 100, int power = 20)
    {
        this.hp = hp;
        this.power = power;
    }

    public void Attack()
    {
        Debug.Log(this.power + " �������� ������.\n");
    }

    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + " �������� �Ծ���.\n");
    }
}



public class Rectangle
{
    private float width;
    private float height;

    public Rectangle(float width = 1.0f, float height = 1.0f)
    {
        this.width = width;
        this.height = height;
    }

    public double evalArea()
    {
        return width * height;
    }

    public double evalPerimeter()
    {
        return (width + height) * 2.0;
    }

    public void printArea()
    {
        Debug.Log("���簢�� ���̴� : " + this.evalArea() + "\n");
    }

    public void printPeimeter()
    {
        Debug.Log("���簢�� �ѷ��� : " + this.evalPerimeter() + "\n");
    }
}



public class Student
{
    public const int SUBJECT_SIZE = 5;
    public string[] subjectName = { "����", "����", "����", "����", "����" };

    private static int serialNum = 1000;
    private int studentID;
    private string studentName;
    private float[] subjectScore = new float[SUBJECT_SIZE];

    public Student(string name, float mathScore, float scienceScore, float englishScore, float koreanScore, float musicScore)
    {
        this.studentID = ++serialNum;
        this.studentName = name;

        this.subjectScore[0] = mathScore;
        this.subjectScore[1] = scienceScore;
        this.subjectScore[2] = englishScore;
        this.subjectScore[3] = koreanScore;
        this.subjectScore[4] = musicScore;
    }

    public float evalAverage()
    {
        float avg = 0;
        for (int i = 0; i < SUBJECT_SIZE; i++)
        {
            avg += this.subjectScore[i];
        }
        avg /= SUBJECT_SIZE;
        return avg;
    }


    public void printSubjectScore() // �� ���� ���� ��� �޼ҵ�
    {
        for (int i = 0; i < SUBJECT_SIZE; i++)
        {
            Debug.Log(this.studentName + "�� " + subjectName[i] + "������ " + this.subjectScore[i] + "�� �Դϴ�.\n");
        }
    }

    public void printAverage() // ���� ��� ��� �޼ҵ�
    {
        Debug.Log(this.studentName + "�� ��� ������ " + this.evalAverage() + "�� �Դϴ�.\n");
    }
}

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // test 1
        Debug.Log("=== Test 1 ��� ===\n");
        Player myPlayer = new Player(150, 30);
        myPlayer.Attack();
        myPlayer.Damage(20);

        //test 2
        Debug.Log("=== Test 2 ��� ===\n");
        Rectangle myRect = new Rectangle(6, 7);
        myRect.printArea();
        myRect.printPeimeter();

        // test 3
        Debug.Log("=== Test 3 - 1 ��� ===\n");
        Student myStudent01 = new Student("����", 100.0f, 90.9f, 80.5f, 99.5f, 50.3f);
        myStudent01.printSubjectScore();
        myStudent01.printAverage();

        Debug.Log("=== Test 3 - 2 ��� ===\n");
        Student myStudent02 = new Student("����", 88.8f, 99.4f, 100.0f, 55.1f, 89.7f);
        myStudent02.printSubjectScore();
        myStudent02.printAverage();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

