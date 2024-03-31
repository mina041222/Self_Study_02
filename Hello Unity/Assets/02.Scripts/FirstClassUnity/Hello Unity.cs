using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    void Start()
    {
        float distance = GetDistance(2, 2, 5, 6);
        Debug.Log("두점 사이의 거리:" + distance);
        

        //캐릭터의 프로필을 변수로 만들기
        string name = "민아";
        int age = 21;
        char bloodType = 'o';
        float height = 170.3f;
        bool isFemale = true;

        Debug.Log("내 이름은 " + name);
        Debug.Log("내 나이는 " + age);
        Debug.Log("내 혈액형은 " + bloodType);
        Debug.Log("내 키는 " + height);
        Debug.Log("나는 여자입니까? " + isFemale);

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
