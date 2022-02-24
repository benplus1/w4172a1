using UnityEngine;
using UnityEngine.UI;

public class SwapCamera : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public Button swapButton;
    private bool swap;

    void Start()
    {
        // Set initial camera to be Main Camera.
        swap = false;

        // Add onClick listener for SwapCamera button.
        Button swapButtonComponent = swapButton.GetComponent<Button>();
        swapButtonComponent.onClick.AddListener(Swap);
    }

    void Swap()
    {
        // Switch the camera tags for Main and Platform so that they can be found.
        if (swap)
        {
            cam1.SetActive(true);
            cam1.tag = "MainCamera";
            cam2.SetActive(false);
            cam2.tag = "Untagged";
        }
        else
        {
            cam1.SetActive(false);
            cam2.tag = "MainCamera";
            cam2.SetActive(true);
            cam1.tag = "Untagged";
        }
        swap = !swap;
    }
}
