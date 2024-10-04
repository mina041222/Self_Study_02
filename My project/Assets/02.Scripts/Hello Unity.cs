using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] students = new int[5];
        
        students [0] = 100;
        students [1] = 90;
        students [2] = 50;
        students [3] = 30;
        students [4] = 10;

        for (int i = 0; i < students.Length; i ++)
        {
            Debug.Log(students[i] + " ?? ??????" );
        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
