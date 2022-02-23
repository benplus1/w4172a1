using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwapCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cam1;
    public GameObject cam2;
    public Button swapButton;
    private bool swap;

    void Start()
    {
        swap = false;
        Button swapButtonComponent = swapButton.GetComponent<Button>();
        swapButtonComponent.onClick.AddListener(Swap);
    }

    void Swap()
    {
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
