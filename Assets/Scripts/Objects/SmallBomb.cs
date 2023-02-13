using UnityEngine;
using ScriptableObjectArchitecture;

public class SmallBomb : MonoBehaviour
{
    
    [Header("Movement")]
    [SerializeField] private FloatReference _baseSpeed;
    [SerializeField] private FloatReference _speedModifier;
    private float _speed;

    [Header("Collision")]
    [SerializeField] private GameObjectCollection _doors;

    void Awake()
    {
        _speed = _baseSpeed.Value;
    }
    
    void Update() 
    {
        float newX = transform.position.x + _speed * _speedModifier.Value * Time.deltaTime;
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
