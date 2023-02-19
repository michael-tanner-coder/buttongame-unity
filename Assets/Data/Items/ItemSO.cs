using UnityEngine;
[CreateAssetMenu(fileName = "ItemSO", menuName = "Scriptable Objects/Item Data", order = 0)]
public class ItemSO : ScriptableObject {

    public string id;

    // Display
    public string itemName;
    public Sprite sprite;

    // Stats
    public float rarity;
    public int quantity;

    // Modifiers
    public float timeModifier;
    public float gravityModifier;
    public float massModifier;
    public float spriteModifier;
    public float durationModifier;
    public float tickRateModifier;
    public float timeScaleModifier;
    public float bombSpeedModifier;
    public float buttonHeightModifier;
    public bool swapCharacters;
    public bool giveDoubleJump;
    public float effectDuration;
}

