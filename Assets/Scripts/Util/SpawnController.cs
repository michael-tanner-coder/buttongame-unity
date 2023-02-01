using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _prefab;
    private List<GameObject> _spawnedObjects = new List<GameObject>();

    public void SpawnObjects() 
    {
        foreach(GameObject obj in _prefab)
        {
            GameObject spawnedObject = Instantiate(obj, transform.position, Quaternion.identity);
            _spawnedObjects.Add(spawnedObject);
        }
    }

    public void DestroyObjects() 
    {
        foreach(GameObject obj in _spawnedObjects)
        {
            Destroy(obj);
        }
    }
}
