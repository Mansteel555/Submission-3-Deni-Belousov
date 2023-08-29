using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] ObjectPoolScript ObjectPool;
    [SerializeField] Transform Spawnpoint;
    [SerializeField] float spawnDelay;
    private float currentSpawnDelay;

    void Start()
    {
        currentSpawnDelay = spawnDelay;


    }
    private void OnValidate()
    {
        if (ObjectPool == null)
        {
            ObjectPool = GetComponent<ObjectPoolScript>();
        }
        if (Spawnpoint == null)
        {
            Spawnpoint = transform;
        }
    }


    private void Update()
    {
        currentSpawnDelay -= Time.deltaTime;
        if (currentSpawnDelay <= 0)
        {
           currentSpawnDelay = spawnDelay;
           GameObject enemy = ObjectPool.GetPooledObject();
            if (enemy == null)
            {
                return;
            }
            enemy.transform.position = Spawnpoint.position;
            enemy.SetActive(true);
        }

    }


}
