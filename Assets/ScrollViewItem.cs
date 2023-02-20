using UnityEngine;
using UnityEngine.UI;

public class ScrollViewItem : MonoBehaviour
{
    [SerializeField] private ItemSO data;
    public ItemSO Data => data;
    [SerializeField] private Image childImage;

    void Start()
    {
        ChangeImage(data.sprite);
    }
    public void ChangeImage(Sprite image)
    {
        childImage.sprite = image;
    }

    public void SetData(ItemSO itemData)
    {
        data = itemData;
    }
}
