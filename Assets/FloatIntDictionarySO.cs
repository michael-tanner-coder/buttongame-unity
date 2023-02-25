using UnityEngine;


[CreateAssetMenu(fileName = "FloatIntDictionarySO", menuName = "buttongame-unity/FloatIntDictionarySO", order = 0)]
public class FloatIntDictionarySO : ScriptableObject 
{
    [SerializeField] private FloatIntDictionary _value;
    public FloatIntDictionary Value => _value;
}
