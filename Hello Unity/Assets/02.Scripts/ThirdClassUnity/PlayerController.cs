using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;  //이동에 사용할 리지드바디
    public float speed = 8.0f;          //이동 속력

    void Start()
    {
        //PlayRigidbody에 Rigidbody 할당
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //실제 이동 속도를 입력값과 이동 속력을 사용해 결정
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;
        //Vector3 속도를 (xSpeed,0,zSpeed) 로 생성
        Vector3 playerVelocity = new Vector3(xSpeed, 0, zSpeed);
        //리지드바디 속도에 playerRigidbody 할당
        playerRigidbody.velocity = playerVelocity;
    }



    public void Die()
    {
        //게임 오브젝트 비활성화
        gameObject.SetActive(false);
    }
}
