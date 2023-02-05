using UnityEngine;

public class ScaleOverTime : MonoBehaviour
{
    [SerializeField]
    private float _scaleRate = 1f;
    private Vector3 _currentScale;
    
    [SerializeField]
    private float _maxScale = 1f;

    [SerializeField]
    private bool _startScaling = false;
    
    [SerializeField]
    private bool _useMaxScale = false;

    void Awake()
    {
        _currentScale = transform.localScale;
    }
    void Update() 
    {
        // don't scale if we have this bool turned off
        if (!_startScaling) return;

        // get numbers for next scale update
        float x =  _currentScale.x + _scaleRate * Time.deltaTime;
        float y =  _currentScale.y + _scaleRate * Time.deltaTime;
        float z =  _currentScale.z + _scaleRate * Time.deltaTime;

        // limit to max scale value
        if (_useMaxScale)
        {
            x = Mathf.Clamp(x, 0f, _maxScale);
            y = Mathf.Clamp(y, 0f, _maxScale);
            z = Mathf.Clamp(z, 0f, _maxScale);
        }

        // perform scaling 
        _currentScale = new Vector3(x,y,z);
        transform.localScale = _currentScale;
    }
}
