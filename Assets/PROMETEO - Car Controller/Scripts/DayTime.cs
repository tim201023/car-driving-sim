using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayTime : MonoBehaviour
{
    [Range(0,1)]
    public float TimeOfDay;
    public float DayDuration = 30;

    public AnimationCurve SunCurve;

    public Light Sun;

    private float sunIntensity;
    // Start is called before the first frame update
    void Start()
    {
        sunIntensity = Sun.intensity;
    }

    // Update is called once per frame
    void Update()
    {
        TimeOfDay += Time.deltaTime / DayDuration;
        if(TimeOfDay >= 1)
        {
            TimeOfDay -= 1;
        }

        Sun.transform.localRotation = Quaternion.Euler(TimeOfDay * 360, 180, 0);
        Sun.intensity = sunIntensity * SunCurve.Evaluate(TimeOfDay);
    }
}
