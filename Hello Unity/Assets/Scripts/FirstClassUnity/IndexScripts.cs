using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndexScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] students = new int[4];

        students[0] = 100;
        students[1] = 80;
        students[2] = 70;
        students[3] = 30;

        for ( int i = 0; i < students.Length; i++)
        {
            Debug.Log("학생의 점수는 " + students[i]);
        }
    }
}
