using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] public List<GameObject> spawnPoints;
    [SerializeField] GameObject obstaculosPrefab;
    [SerializeField] int spawncount;
    List<GameObject> objetosActivos;
    List<GameObject> currentSpawnPoints;

    public void Start()
    {
        StartCoroutine(Timer());
    }

    private void SpawnMultipleItems(GameObject prefab, int count)
    {
        currentSpawnPoints = new List<GameObject>(spawnPoints.ToArray());
        for (int i = 0; i < count; i++)
        {
            GameObject Go = Instantiate(prefab, GetRandomPosition(), Quaternion.identity);
            objetosActivos.Add(Go);
        }
    }

    private Vector3 GetRandomPosition()
    {
        int randomIndex = Random.Range(0, currentSpawnPoints.Count);
        GameObject Go = currentSpawnPoints[randomIndex];
        currentSpawnPoints.RemoveAt(randomIndex);

        Vector3 spawnPosition = Go.transform.position;

        spawnPosition.y += 0f; //puedo cambiar el setup por otro valor o mover los gizmos

        return spawnPosition;
    }

    private void CleanMap()
    {
        for (int i = 0; i < objetosActivos.Count; i++)
        {
            Destroy(objetosActivos[i]);

        }
        objetosActivos.Clear();
    }

    IEnumerator Timer()
    {
        for (int i = 0; i < 5; i++)
        {
            CleanMap();
            SpawnMultipleItems(obstaculosPrefab, spawncount);
            yield return new WaitForSeconds(20f);
        }

    }
}

