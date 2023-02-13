using ScriptableObjectArchitecture;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private GameEvent _onButtonPress;
    [SerializeField] private GameObjectCollection _triggers;

    void ActivateDoor()
    {
        _onButtonPress?.Raise();
    }

    void OnCollisionEnter2D(Collision2D other) 
    {        
        if (_triggers.Contains(other.gameObject)) 
        {
            ActivateDoor();
        }
    }
}
