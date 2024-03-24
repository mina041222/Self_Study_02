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
            Debug.Log(hp + " 정도 체력이 남았습니다");

            hp = hp -= 33;

            if (hp <= 0)
            {
                isDead = true;
                Debug.Log("플레이어가 죽엇습니다");
            }
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
