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
        // gameEvents.roundEndEvent.AddListener(CheckForWinner);
    }

    void CheckForWinner() 
    {
        if (playerData.doorState == DoorState.CLOSED)
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

        points = playerData.score;
        points = (int) Mathf.Clamp(points, 0, maxPoints);
    }
}
