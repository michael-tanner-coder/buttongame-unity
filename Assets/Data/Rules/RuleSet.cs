using UnityEngine;
using ScriptableObjectArchitecture;

[CreateAssetMenu(fileName = "RuleSet", menuName = "Rules/RuleSet", order = 0)]
public class RuleSet : ScriptableObject {
    [Header("Gravity")]
    [SerializeField] private FloatReference _gravityModifier;
    [SerializeField] private FloatReference _defaultGravity;
    [SerializeField] private float _currentGravityModifier;
    public FloatReference GravityModifier => _gravityModifier;
    
    [Header("Timer")]
    [SerializeField] private FloatReference _tickRateModifier;
    [SerializeField] private FloatReference _defaultTickRate;
    [SerializeField] private float _currentTickRateModifier;
    public FloatReference TickRateModifier => _tickRateModifier;

    void OnValidate() 
    {
        _tickRateModifier.Value = _currentTickRateModifier;
        _gravityModifier.Value = _currentGravityModifier;
    }

    public void ResetToDefaults()
    {
        
        _gravityModifier.Value = _defaultGravity.Value;
        _tickRateModifier.Value = _defaultTickRate.Value;
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
