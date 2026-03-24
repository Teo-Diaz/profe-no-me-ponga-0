using UnityEngine;
using UnityEngine.UI;

public class SliderImageManager : MonoBehaviour
{
    [System.Serializable]
    public class ImageSet
    {
        public GameObject[] objects; // 3 objetos (0,1,2)
    }

    public Slider slider;
    public ImageSet[] imageSets;

    void Start()
    {
        slider.onValueChanged.AddListener(UpdateImages);
        UpdateImages(slider.value);
    }

    void UpdateImages(float value)
    {
        int index = Mathf.Clamp(Mathf.RoundToInt(value), 0, 2);

        foreach (var set in imageSets)
        {
            for (int i = 0; i < set.objects.Length; i++)
            {
                if (set.objects[i] != null)
                {
                    set.objects[i].SetActive(i == index);
                }
            }
        }
    }
}