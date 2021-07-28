using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] public List<GameObject> spawnPoints;
    [SerializeField] GameObject obstaculosPrefab;

    //public void Start()
    //{
    //    GenerateDrop();
    //}

    //private void SpawnMultipleItems(GameObject prefab, int count)
    //{
    //    for(int i = 0; i < count; i++)
    //    {
    //        Instantiate(prefab, GetRandomPosition(), Quaternion.identity);
    //    }
    //}

    //private void GenerateDrop(int count)
    //{
    //    SpawnMultipleItems(obstaculosPrefab, count);
    //}

    //private Vector3 GetRandomPosition()
    //{
    //    int randomIndex = Random.Range(0, spawnPoints.Count);
    //    GameObject objects = spawnPoints[randomIndex];
    //    spawnPoints.RemoveAt(randomIndex);

    //    Vector3 spawnPosition = new Vector3();


    //}
}
