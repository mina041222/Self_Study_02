using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;     //생성할 탄알의 원본 프리팹
    public float spawnRateMin = 0.5f;          //생성할 탄알의 최소 주기
    public float spawnRateMax = 3f;          //최대 주기

    private Transform target;
    private float spawnRate;
    private float timeAfterSpawn;
    
    // Start is called before the first frame update
    void Start()
    {
        //최근 생성 이후의 누적 시간을 0 으로 초기화
        //탄알 생성 간격을 spawnRateMin와 SpawnRateMax사이에서 랜덤 지정
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
