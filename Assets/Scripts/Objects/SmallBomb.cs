using UnityEngine;

public class SmallBomb : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1f;

    void Update() 
    {
        float newX = transform.position.x + _speed * Time.deltaTime;
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
