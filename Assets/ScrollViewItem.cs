using UnityEngine;
using UnityEngine.UI;

public class ScrollViewItem : MonoBehaviour
{
    [SerializeField] private Image childImage;

    public void ChangeImage(Sprite image)
    {
        childImage.sprite = image;
    }
}
