using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] public List<GameObject> spawnPoints;
    [SerializeField] GameObject obstaculosPrefab;
    [SerializeField] int spawncount;

    public void Start()
    {
        SpawnMultipleItems(obstaculosPrefab, spawncount);
    }

    private void SpawnMultipleItems(GameObject prefab, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Instantiate(prefab, GetRandomPosition(), Quaternion.identity);
        }
    }

    private Vector3 GetRandomPosition()
    {
        int randomIndex = Random.Range(0, spawnPoints.Count);
        GameObject Go = spawnPoints[randomIndex];
        spawnPoints.RemoveAt(randomIndex);

        Vector3 spawnPosition = Go.transform.position;

        spawnPosition.y += 0f; //puedo cambiar el setup por otro valor o mover los gizmos

        return spawnPosition;
    }
}
