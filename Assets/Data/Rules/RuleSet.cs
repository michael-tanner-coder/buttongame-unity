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

    [Header("Round Duration")]
    [SerializeField] private FloatReference _roundDuration;
    [SerializeField] private FloatReference _defaultRoundDuration;
    [SerializeField] private float _currentRoundDuration;
    public FloatReference RoundDuration => _roundDuration;

    void OnValidate() 
    {
        _tickRateModifier.Value = _currentTickRateModifier;
        _gravityModifier.Value = _currentGravityModifier;
        _roundDuration.Value = _currentRoundDuration;
    }

    public void ResetToDefaults()
    {
        
        _gravityModifier.Value = _defaultGravity.Value;
        _tickRateModifier.Value = _defaultTickRate.Value;
        _roundDuration.Value = _defaultRoundDuration.Value;
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

        if (item.durationModifier != 0f) 
        {
            _roundDuration.Value = item.durationModifier;
        }
    }
}
