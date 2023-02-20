using UnityEngine;
using ScriptableObjectArchitecture;
public class Roulette : MonoBehaviour
{

    [SerializeField] private FloatVariable _speed;
    [SerializeField] private IntVariable _money;
    [SerializeField] private IntVariable _cost;
    public void ToggleRoulette()
    {
        if (_speed.Value == 0 && _money.Value >= _cost.Value)
        {
            _money.Value -= _cost.Value;
            _speed.Value = 240f;
            // emit event that roulete finished?
        }
        else 
        {
            _speed.Value = 0f;
        }
    }
}
