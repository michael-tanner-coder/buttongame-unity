using UnityEngine;

public class Player : MonoBehaviour
{
    private string prev_type = "basic";
    
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
