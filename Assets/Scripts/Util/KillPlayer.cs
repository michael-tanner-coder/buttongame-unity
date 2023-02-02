using UnityEngine;
using ScriptableObjectArchitecture;

public class KillPlayer : MonoBehaviour
{
    [SerializeField]
    private GameObjectCollection _players;
    
    [SerializeField]
    private GameObjectGameEvent _onPlayerLose;

    void OnCollisionEnter2D(Collision2D other) 
    {
        if (_players.Contains(other.gameObject))
        {
            _onPlayerLose.Raise(other.gameObject);
        }
    }
}
