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

    // Update is called once per frame
    void Update()
    {
        
    }
}
