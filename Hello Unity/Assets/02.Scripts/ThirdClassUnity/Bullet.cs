using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8.0f; //탄알 이동속력
    private Rigidbody bulletRigidbody; //리지드바디 선언

    // Start is called before the first frame update
    void Start()
    {
        //게임 오브젝트에서 Rigidbody 컴포넌트를 찾아 BullletRigidbody에 할당
        bulletRigidbody = GetComponent<Rigidbody>();
        //리지드바디의 속도 = 이동 속력 * 앞쪽 방향
        bulletRigidbody.velocity = speed * transform.forward;

        //3초뒤에 자신의 게임 오브젝트 파괴
        Destroy(gameObject,3f);
    }

    //트리거 충돌 시 자동으로 실행되는 메서드
    void OnTriggerEnter (Collider other)
    {
        //충돌한 상대방 게임오브젝트가 PLAYER 태그를 가진 경우
        if (other.tag == "Player")
        {
            //상대방 게임 오브젝트에서 PlayerController 컴포넌트 가져오기
            PlayerController playerController = other.GetComponent<PlayerController>();

            //상대방으로부터 PlayerController 컴포넌트를 가져오는 데 성공 했다면
            if (playerController !=  null)
            {
                //상대방 PlayerController 컴포넌트 Die() 메서드 실행
                playerController.Die();
            }

        }
    }
}
