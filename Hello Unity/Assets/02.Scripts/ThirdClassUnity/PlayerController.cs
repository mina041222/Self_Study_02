using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;  //�̵��� ����� ������ٵ�
    public float speed = 8.0f;          //�̵� �ӷ�

    void Start()
    {
        //PlayRigidbody�� Rigidbody �Ҵ�
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //���� �̵� �ӵ��� �Է°��� �̵� �ӷ��� ����� ����
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;
        //Vector3 �ӵ��� (xSpeed,0,zSpeed) �� ����
        Vector3 playerVelocity = new Vector3(xSpeed, 0, zSpeed);
        //������ٵ� �ӵ��� playerRigidbody �Ҵ�
        playerRigidbody.velocity = playerVelocity;
    }



    public void Die()
    {
        //���� ������Ʈ ��Ȱ��ȭ
        gameObject.SetActive(false);
    }
}