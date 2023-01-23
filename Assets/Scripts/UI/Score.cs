using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
    public float points;

    [SerializeField]
    public float maxPoints;

    // UI
    [SerializeField]
    private Fill scorebar;

    // Events
    [SerializeField]
    private GameEvents gameEvents;

    // Data
    [SerializeField]
    private PlayerData playerData;

    void Update() 
    {
        float percentage = Mathf.InverseLerp(0, maxPoints, points);
        scorebar.SetPercentage(percentage);

        if (maxPoints == points) {
            // invoke game over event
        }
    }
}
