using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class GameReset : MonoBehaviour
{
    [SerializeField]
    private GameObjectCollection _playerPrefabs = default(GameObjectCollection);

    [SerializeField]
    private List<PlayerData> players;

    void Awake()
    {
        ResetPlayerData();
    }

    void ResetPlayerData()
    {
        players.ForEach((PlayerData player) =>
        {
            player.ResetData();
        });
    }
}






