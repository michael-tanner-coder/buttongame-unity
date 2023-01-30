using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    public class StateEvent : UnityEvent<GameState> { }

    [CreateAssetMenu(
        fileName = "StateVariable.asset",
        menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "state",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 3)]
    public class StateVariable : BaseVariable<GameState, StateEvent>
    {
    } 
}