using UnityEngine;
using ScriptableObjectArchitecture;

public class PlayerLose : MonoBehaviour
{
    [SerializeField]
    GameObjectGameEvent _onPlayerLose;

    public void Awake() 
    {
        _onPlayerLose.AddListener(StartLoseAnimation);
    }

    public void StartLoseAnimation(GameObject losingPlayer)
    {
        if (losingPlayer != gameObject) return;
        Debug.Log(losingPlayer.name);
    }
}
