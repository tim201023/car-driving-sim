using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPS : MonoBehaviour
{
    private float fps;
    [SerializeField] private Text fpsText;

    // Update is called once per frame
    void Update()
    {
        fps = 1.0f / Time.deltaTime;
        fpsText.text = "FPS: " + (int)fps;
    }
}
