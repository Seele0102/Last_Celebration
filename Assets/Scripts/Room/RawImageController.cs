using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RawImageController : MonoBehaviour
{
    public GameObject rawImage;
    bool isOn=false;

    private void Update()
    {
        OpenAndClose();
    }

    public void OpenAndClose()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isOn = !isOn;
            rawImage.SetActive(isOn);
        }

    }
}
