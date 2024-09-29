using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloUnity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;

        while (i < 10)
        {
            Debug.Log(i + "번째 루트입니다");
            i++
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
