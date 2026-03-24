using UnityEngine;

public class Toggle : MonoBehaviour
{
    public GameObject[] objectsToToggle; // Hasta 4 objetos

    public void ToggleObjs()
    {
        foreach (GameObject obj in objectsToToggle)
        {
            if (obj != null)
            {
                obj.SetActive(!obj.activeSelf);
            }
        }
    }
}