using UnityEngine;
using ScriptableObjectArchitecture;
public class Roulette : MonoBehaviour
{

    [SerializeField] private FloatVariable _speed;
    public void ToggleRoulette()
    {
        _speed.Value = _speed.Value == 0f ? 240f : 0f;
    }
}
