using UnityEngine;
using UnityEngine.UI;

public class Fill : MonoBehaviour
{
    [SerializeField]
    private float percentage;
    private Image image;

    [SerializeField]
    private bool lerp;
    [SerializeField]
    private bool useInt;

    [SerializeField]
    private ScriptableObjectArchitecture.FloatReference currentFloat;

    [SerializeField]
    private ScriptableObjectArchitecture.FloatReference maximumFloat;
    
    [SerializeField]
    private ScriptableObjectArchitecture.IntReference currentInt;

    [SerializeField]
    private ScriptableObjectArchitecture.IntReference maximumInt;

    void Start() 
    {
        image = GetComponent<Image>();
    }

    void Update() 
    {
        float perc = useInt ? Mathf.InverseLerp(0, maximumInt.Value, currentInt.Value) : Mathf.InverseLerp(0, maximumFloat.Value, currentFloat.Value);

        image.fillAmount = lerp ? Mathf.Lerp(image.fillAmount, perc, Time.deltaTime) : perc;
    }

    public void SetPercentage(float percent) 
    {
        percentage = percent;
    }
}
