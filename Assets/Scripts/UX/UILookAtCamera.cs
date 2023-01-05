using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILookAtCamera : MonoBehaviour
{
    private Transform ARCamera;

    private void Awake()
    {
        ARCamera = GameObject.Find("AR Session Origin").transform.GetChild(0);
    }

    private void Update()
    {
        this.transform.rotation = Quaternion.LookRotation(transform.position - ARCamera.transform.position);
    }
}
