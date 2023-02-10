using UnityEngine;
using ScriptableObjectArchitecture;

public class UpdateRules : MonoBehaviour
{
    [SerializeField]
    private FloatVariable _gravity;

    public void ChangeRulesViaItem(ItemSO item) 
    {
        if (item.gravityModifier != 0f)
        {
            _gravity.Value = item.gravityModifier;
        }
    }

}
