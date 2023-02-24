using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct ItemDrop {
    public float probabilityWeight;
    public float probabilityFrom;
    public float probabilityTo;
}

[Serializable]
public class ItemDropTableDictionary : SerializableDictionary<ItemSO, ItemDrop> {}

[CreateAssetMenu(fileName = "ItemDropTable", menuName = "Scriptable Objects/Item Drop Table", order = 0)]
public class ItemDropTable : ScriptableObject 
{   
    [SerializeField] private float _probabilityTotalWeight;
    public ItemDropTableDictionary Lookup;

    void OnEnable()
    {
        float currentProbabilityWeightMaximum = 0f;
        List<ItemSO> itemKeys = new List<ItemSO>(Lookup.Keys);
        foreach(ItemSO item in itemKeys)
        {
            ItemDrop itemDropEntry = new ItemDrop();
            if (Lookup[item].probabilityWeight < 0f)
            {
                Debug.Log("Can't have a negative probability weight");
                itemDropEntry.probabilityWeight = 0f;
            }
            else 
            {
                itemDropEntry.probabilityWeight = Lookup[item].probabilityWeight;
                itemDropEntry.probabilityFrom = currentProbabilityWeightMaximum;
                currentProbabilityWeightMaximum += itemDropEntry.probabilityWeight;	
                itemDropEntry.probabilityTo = currentProbabilityWeightMaximum;
                Lookup[item] = itemDropEntry;
            }
        }
        _probabilityTotalWeight = currentProbabilityWeightMaximum;
    }
}


