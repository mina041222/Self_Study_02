using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //케릭터 프로필을 변수로 만들기
        string characerName = "라라";
        char bloodType = 'A';
        int age = 17;
        float height = 173.8f;
        bool isFemale = true;

        //생성한 변수를 콘솔에 출력
        Debug.Log("케릭터 이름 : " + characerName);
        Debug.Log("혈액형:" + bloodType);
        Debug.Log("나이:" + age);
        Debug.Log("키:" + height);
        Debug.Log("여성인가: " + isFemale);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
