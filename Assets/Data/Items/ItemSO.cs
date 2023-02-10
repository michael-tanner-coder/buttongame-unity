using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

[CreateAssetMenu(fileName = "ItemSO", menuName = "Scriptable Objects/Item", order = 0)]
public class ItemSO : ScriptableObject {
    // Display
    public string itemName;
    public Sprite sprite;

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

    // Time before effect stops
    public float effectDuration;
}

