using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;     //������ ź���� ���� ������
    public float spawnRateMin = 0.5f;          //������ ź���� �ּ� �ֱ�
    public float spawnRateMax = 3f;          //�ִ� �ֱ�

    private Transform target;
    private float spawnRate;
    private float timeAfterSpawn;
    
    // Start is called before the first frame update
    void Start()
    {
        //�ֱ� ���� ������ ���� �ð��� 0 ���� �ʱ�ȭ
        //ź�� ���� ������ spawnRateMin�� SpawnRateMax���̿��� ���� ����
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}