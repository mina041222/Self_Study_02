using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool isDead = false;
        int hp = 100;

        while (!isDead)
        {
            Debug.Log(hp + " ���� ü���� ���ҽ��ϴ�");

            hp = hp -= 33;

            if (hp <= 0)
            {
                isDead = true;
                Debug.Log("�÷��̾ �׾����ϴ�");
            }
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}