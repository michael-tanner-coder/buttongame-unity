using UnityEngine;
using ScriptableObjectArchitecture;

public class MoveToPosition : MonoBehaviour
{
    [SerializeField]
    private GameObjectCollection _locations;

    public void MoveToRandomLocation() 
    {
        int index = Random.Range(0, _locations.Count);
        GameObject newLocation = _locations[index];
        transform.position = newLocation.transform.position;
    }

}
