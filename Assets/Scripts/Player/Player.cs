using UnityEngine;

public class Player : MonoBehaviour
{
    private string prev_type = "basic";
    
    [SerializeField]
    private PlayerData data;

    void Start()
    {

     
    }

    void OnPlayerLose(GameObject player)
    {
        if (player == gameObject)
        {
   
        }
    }

    void Update() {

    }

    private void Awake() 
    {
        
    }
}
