using UnityEngine;
using ScriptableObjectArchitecture;

public class SmallBomb : MonoBehaviour
{
    [SerializeField]
    private FloatReference _speedReference;
    private float _speed;

    [SerializeField]
    private GameObjectCollection _doors;

    void Awake()
    {
        _speed = _speedReference.Value;
    }
    
    void Update() 
    {
        float newX = transform.position.x + _speed * Time.deltaTime;
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if (_doors.Contains(other.gameObject)) 
        {
            _speed *= -1;
        }
    }
}
