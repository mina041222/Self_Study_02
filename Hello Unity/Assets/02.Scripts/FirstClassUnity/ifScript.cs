using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int love = 80 ;
        int age = 20;

        if (love > 90)
        {
            Debug.Log("Best Ending");
        }

        else if (love > 70)
        {
            Debug.Log("Good Ending");
        }
        
        else
        {
            Debug.Log("Bad Ending");
        }

        if (age >= 8 && age < 20)
        {
            Debug.Log("의무 교육을 받고 있습니다");
        }
        else if (age >= 20 || age <= 80)
        {
            Debug.Log("일을 할수 있는 나이입니다");
        }
    }
}
