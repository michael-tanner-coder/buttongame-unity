using UnityEngine;
using ScriptableObjectArchitecture;

[CreateAssetMenu(fileName = "RuleSet", menuName = "Rules/RuleSet", order = 0)]
public class RuleSet : ScriptableObject {
    [Header("Gravity")]
    [SerializeField] private FloatReference _gravityModifierDefault;
    [SerializeField] private FloatReference _gravityModifier;
    public FloatReference GravityModifier => _gravityModifier;
    
    [Header("Timer")]
    [SerializeField] private FloatReference _tickRateModifierDefault;
    [SerializeField] private FloatReference _tickRateModifier;
    public FloatReference TickRateModifier => _tickRateModifier;

    public void ResetToDefaults()
    {
        
        _gravityModifier.Value = _gravityModifierDefault.Value;
        _tickRateModifier.Value = _tickRateModifierDefault.Value;
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
