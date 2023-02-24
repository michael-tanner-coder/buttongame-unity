using UnityEngine;
using ScriptableObjectArchitecture;

public class RetrySpin : MonoBehaviour
{
    [SerializeField] private BoolVariable _retrySpin;
    [SerializeField] private GameEvent _spinEvent;

    public void StartSpin()
    {
        if (_retrySpin.Value)
        {
            _spinEvent?.Raise();
        }
    }
}
