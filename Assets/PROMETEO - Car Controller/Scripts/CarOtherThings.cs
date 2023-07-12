using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarOtherThings : MonoBehaviour
{
    [SerializeField] private Light light;
    [SerializeField] private Light light1;
    [SerializeField] private Light lightRedR;
    [SerializeField] private Light lightRedL;
    [SerializeField] private Light lightStopR;
    [SerializeField] private Light lightStopL;
    [SerializeField] private Light lightBackR;
    [SerializeField] private Light lightBackL;
    [SerializeField] private GameObject Llight;
    [SerializeField] private GameObject Rlight;
    private int Rl = 0;
    private int Ll = 0;
    private int Avarika = 0;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (light.enabled == false && light1.enabled == false)
            {
                light.enabled = true;
                light1.enabled = true;
                lightRedL.enabled = true;
                lightRedR.enabled = true;
            }
            else
            {
                light.enabled = false;
                light1.enabled = false;
                lightRedL.enabled = false;
                lightRedR.enabled = false;
            }
             
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && Avarika == 0)
        {
            
            if (Rl == 0)
            {
                if (Ll == 1)
                {
                    Rlight.SetActive(true);
                    Rl++;
                    Llight.SetActive(false);
                    Ll -= 1;
                }
                else
                {
                    Rlight.SetActive(true);
                    Rl++;
                    
                }
            }
            else
            {
                Rlight.SetActive(false);
                Rl -= 1;
                
            }

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && Avarika == 0)
        {
            
            if (Ll == 0)
            {
                if (Rl == 1)
                {
                    Llight.SetActive(true);
                    Ll++;
                    Rlight.SetActive(false);
                    Rl -= 1;
                }
                else
                {
                    Llight.SetActive(true);
                    Ll++;
                 
                }
            }
            else
            {
                Llight.SetActive(false);
                Ll -= 1;
                
            }

        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (Ll == 0 && Rl == 0)
            {
                Llight.SetActive(true);
                Rlight.SetActive(true);
                Ll++;
                Rl++;
                Avarika = 1;
            }
            else if (Ll == 1 && Rl == 0)
            {
                Llight.SetActive(false);
                Ll -= 1;
                Llight.SetActive(true);
                Rlight.SetActive(true);
                Ll++;
                Rl++;
                Avarika = 1;
            }
            else if (Ll == 0 && Rl == 1)
            {
                Rlight.SetActive(false);
                Rl -= 1;
                Llight.SetActive(true);
                Rlight.SetActive(true);
                Ll++;
                Rl++;
                Avarika = 1;
            }
            else
            {
                Llight.SetActive(false);
                Rlight.SetActive(false);
                Rl -= 1;
                Ll -= 1;
                Avarika = 0;
            }
        }


        
        if (Input.GetKey(KeyCode.W))
        {
            lightStopL.enabled = false;
            lightStopR.enabled = false;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            lightStopL.enabled = false;
            lightStopR.enabled = false;
            lightBackL.enabled = true;
            lightBackR.enabled = true;
        }
        else
        {
            lightStopL.enabled = true;
            lightStopR.enabled = true;
            lightBackL.enabled = false;
            lightBackR.enabled = false;
        }

    }
}
