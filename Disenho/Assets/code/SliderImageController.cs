using UnityEngine;
using UnityEngine.UI;

public class SliderImageController : MonoBehaviour
{
    [System.Serializable]
    public class ImageGroup
    {
        public Image targetImage;   // La imagen del objeto
        public Sprite[] sprites;    // 3 sprites (posición 0, 1, 2)
    }

    public Slider slider;
    public ImageGroup[] imageGroups;

    void Start()
    {
        slider.onValueChanged.AddListener(UpdateImages);
        UpdateImages(slider.value); // actualizar al inicio
    }

    void UpdateImages(float value)
    {
        int index = Mathf.RoundToInt(value); // 0, 1 o 2

        foreach (var group in imageGroups)
        {
            if (group.targetImage != null && group.sprites.Length > index)
            {
                group.targetImage.sprite = group.sprites[index];
            }
        }
    }
}