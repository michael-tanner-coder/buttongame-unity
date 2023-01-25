using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
    public int points;

    [SerializeField]
    public int maxPoints;

    // UI
    [SerializeField]
    private Fill scorebar;

    // Events
    [SerializeField]
    private GameEvents gameEvents;

    // Data
    [SerializeField]
    private PlayerData playerData;

    void Awake() 
    {
        gameEvents.roundEndEvent.AddListener(CheckForWinner);
    }

    void CheckForWinner() 
    {
        if (playerData.doorState == DoorState.Enums.CLOSED)
        {
            points += 1;
            points = (int) Mathf.Clamp(points, 0, maxPoints);
            playerData.score = points;
        }
    }

    void Update() 
    {
        float percentage = Mathf.InverseLerp(0, maxPoints, points);
        scorebar.SetPercentage(percentage);

        if (points >= maxPoints)
        {
            gameEvents.gameOverEvent?.Invoke();
        }
    }
}
