using UnityEngine;
using ScriptableObjectArchitecture;

public class GameRules : MonoBehaviour
{
    [SerializeField]
    private FloatVariable _gravityModifier;
    
    [SerializeField]
    private FloatVariable _tickRateModifier;

    void Awake() 
    {
        ResetToDefaults();
    }


    public void ResetToDefaults()
    {
        _gravityModifier.Value = 1f;
        _tickRateModifier.Value = 1f;
    }

    public void ChangeRulesViaItem(ItemSO item) 
    {
        if (item.gravityModifier != 0f)
        {
            _gravityModifier.Value = item.gravityModifier;
        }

        if (item.tickRateModifier != 0f) 
        {
            _tickRateModifier.Value = item.tickRateModifier;
        }
    }
}
