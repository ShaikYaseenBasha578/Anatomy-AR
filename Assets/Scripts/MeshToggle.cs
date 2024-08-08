using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshToggler : MonoBehaviour
{
    public GameObject BodyObject;
    private bool isActive = true;

    public void Toggle()
    {
        if (isActive)
        {
            BodyObject.SetActive(false);
            isActive = false;
        }
        else
        {
            BodyObject.SetActive(true);
            isActive = true;
        }
    }
}