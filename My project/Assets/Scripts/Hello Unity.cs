using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�ɸ��� �������� ������ �����
        string characerName = "���";
        char bloodType = 'A';
        int age = 17;
        float height = 173.8f;
        bool isFemale = true;

        //������ ������ �ֿܼ� ���
        Debug.Log("�ɸ��� �̸� : " + characerName);
        Debug.Log("������:" + bloodType);
        Debug.Log("����:" + age);
        Debug.Log("Ű:" + height);
        Debug.Log("�����ΰ�: " + isFemale);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
