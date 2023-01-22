using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fill : MonoBehaviour
{
    [SerializeField]
    private float percentage;
    private Image image;

    void Start() 
    {
        image = GetComponent<Image>();
    }

    void Update() 
    {
        image.fillAmount = percentage;
    }

    public void SetPercentage(float percent) 
    {
        percentage = percent;
    }
}
