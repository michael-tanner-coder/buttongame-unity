using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSpawn : MonoBehaviour
{
    public string scheme;
    public GameObject playerPrefab;
    [SerializeField] private PlayerData _playerData;
    public bool flipped = false;

    // Start is called before the first frame update
    void Start()
    {
        PlayerInput input = PlayerInput.Instantiate(playerPrefab, controlScheme: scheme, pairWithDevice: Keyboard.current);
        GameObject player = input.gameObject;
        player.transform.position = transform.position;
        player.GetComponent<SpriteRenderer>().flipX = flipped;
        Player playerComponent = player.GetComponent<Player>();
        playerComponent.SetPlayerData(_playerData);
    }
}
