using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] public List<GameObject> spawnPoints;
    [SerializeField] GameObject obstaculosPrefab;
    [SerializeField] int spawncount;
<<<<<<< HEAD

    public void Start()
    {
        SpawnMultipleItems(obstaculosPrefab, spawncount);
=======
    List<GameObject> objetosActivos;
    List<GameObject> currentSpawnPoints;

    public void Start()
    {
        StartCoroutine(Timer());
>>>>>>> iazz
    }

    private void SpawnMultipleItems(GameObject prefab, int count)
    {
<<<<<<< HEAD
        for (int i = 0; i < count; i++)
        {
            Instantiate(prefab, GetRandomPosition(), Quaternion.identity);
=======
        currentSpawnPoints = new List<GameObject>(spawnPoints.ToArray());
        for (int i = 0; i < count; i++)
        {
            GameObject Go = Instantiate(prefab, GetRandomPosition(), Quaternion.identity);
            objetosActivos.Add(Go);
>>>>>>> iazz
        }
    }

    private Vector3 GetRandomPosition()
    {
<<<<<<< HEAD
        int randomIndex = Random.Range(0, spawnPoints.Count);
        GameObject Go = spawnPoints[randomIndex];
        spawnPoints.RemoveAt(randomIndex);
=======
        int randomIndex = Random.Range(0, currentSpawnPoints.Count);
        GameObject Go = currentSpawnPoints[randomIndex];
        currentSpawnPoints.RemoveAt(randomIndex);
>>>>>>> iazz

        Vector3 spawnPosition = Go.transform.position;

        spawnPosition.y += 0f; //puedo cambiar el setup por otro valor o mover los gizmos

        return spawnPosition;
    }
<<<<<<< HEAD
}
=======

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

>>>>>>> iazz
