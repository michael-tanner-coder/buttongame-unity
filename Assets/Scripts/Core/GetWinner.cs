using UnityEngine;
using UnityEngine.SceneManagement;
using ScriptableObjectArchitecture;

public class GetWinner : MonoBehaviour
{

    [SerializeField] private IntVariable _money;
    [SerializeField] private IntVariable _goal;
    
    void Update()
    {
        if (_money.Value >= _goal.Value)
        {
            Debug.Log("You Win!");
            SceneManager.LoadScene("WinScene");
        }
    }
}
