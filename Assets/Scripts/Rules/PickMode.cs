using ScriptableObjectArchitecture;
using UnityEngine;

public class PickMode : MonoBehaviour
{
    [SerializeField]
    private GameModeList _gameModes;

    [SerializeField]
    private GameModeVariable _currentMode;


    public void SetRandomGameMode()
    {
        int index = Random.Range(0, _gameModes.Value.Count);

        _currentMode.Value = _gameModes.Value[index];
    }
}
