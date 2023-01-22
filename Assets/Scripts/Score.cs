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


    void Update() 
    {
        float percentage = Mathf.InverseLerp(0, maxPoints, points);
        scorebar.SetPercentage(percentage);
    }
}
