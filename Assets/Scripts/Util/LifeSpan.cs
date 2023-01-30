using UnityEngine;

public class LifeSpan : MonoBehaviour
{
    [SerializeField]
    private float _lifespan;
    public float Lifespan => _lifespan;

    void Update() 
    {
        _lifespan -= Time.deltaTime;

        if (_lifespan <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
