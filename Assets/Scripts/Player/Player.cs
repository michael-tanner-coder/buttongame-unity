using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private PlayerData data;

    public void CheckIfWinner() 
    {
        if (data.score.Value >= data.maxScore.Value)
        {
            Debug.Log("Winner!");
        }
        else
        {
            Debug.Log("Not Winner!");
        }
    }
}
