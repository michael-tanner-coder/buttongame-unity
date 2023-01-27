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
    private ScriptableObjectArchitecture.FloatReference current;

    [SerializeField]
    private ScriptableObjectArchitecture.FloatReference maximum;

    void Start() 
    {
        image = GetComponent<Image>();
    }

    void Update() 
    {
        // float perc = Mathf.InverseLerp(0, maximum.Value, current.Value);
        
        if (!lerp)
        {
            image.fillAmount = percentage;
        }
        else 
        {
            image.fillAmount = Mathf.Lerp(image.fillAmount, percentage, Time.deltaTime);
        }
    }

    public void SetPercentage(float percent) 
    {
        percentage = percent;
    }
}
