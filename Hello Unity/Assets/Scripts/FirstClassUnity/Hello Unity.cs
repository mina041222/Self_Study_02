using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    void Start()
    {
        float distance = GetDistance(2, 2, 5, 6);
        Debug.Log("���� ������ �Ÿ�:" + distance);
        

        //ĳ������ �������� ������ �����
        string name = "�ξ�";
        int age = 21;
        char bloodType = 'o';
        float height = 170.3f;
        bool isFemale = true;

        Debug.Log("�� �̸��� " + name);
        Debug.Log("�� ���̴� " + age);
        Debug.Log("�� �������� " + bloodType);
        Debug.Log("�� Ű�� " + height);
        Debug.Log("���� �����Դϱ�? " + isFemale);

        Debug.Log("Hello Unity!");
    }
    
    float GetDistance (float x1, float y1, float x2, float y2)
    {
        float width = x2 - x1;
        float height = y2 - y1;

        float distance = width * width + height * height;
        distance = Mathf.Sqrt(distance);

        return distance;
    }
  
}