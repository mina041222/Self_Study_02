using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8.0f; //ź�� �̵��ӷ�
    private Rigidbody bulletRigidbody; //������ٵ� ����

    // Start is called before the first frame update
    void Start()
    {
        //���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� BullletRigidbody�� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();
        //������ٵ��� �ӵ� = �̵� �ӷ� * ���� ����
        bulletRigidbody.velocity = speed * transform.forward;

        //3�ʵڿ� �ڽ��� ���� ������Ʈ �ı�
        Destroy(gameObject,3f);
    }

    //Ʈ���� �浹 �� �ڵ����� ����Ǵ� �޼���
    void OnTriggerEnter (Collider other)
    {
        //�浹�� ���� ���ӿ�����Ʈ�� PLAYER �±׸� ���� ���
        if (other.tag == "Player")
        {
            //���� ���� ������Ʈ���� PlayerController ������Ʈ ��������
            PlayerController playerController = other.GetComponent<PlayerController>();

            //�������κ��� PlayerController ������Ʈ�� �������� �� ���� �ߴٸ�
            if (playerController !=  null)
            {
                //���� PlayerController ������Ʈ Die() �޼��� ����
                playerController.Die();
            }

        }
    }
}