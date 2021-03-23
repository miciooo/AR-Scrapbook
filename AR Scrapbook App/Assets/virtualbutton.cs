using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class virtualbutton : MonoBehaviour
{
    public GameObject model, audio;
    VirtualButtonBehaviour[] awa;
    // Start is called before the first frame update
    void Start()
    {
        awa = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < awa.Length; ++i)
        {
            awa[i].RegisterOnButtonPressed(OnButtonPressed);
            awa[i].RegisterOnButtonReleased(OnButtonReleased);
        }
        model.SetActive(false);
        audio.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour go
        )
    {
        model.SetActive(true);
        audio.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour go
        )
    {
        model.SetActive(false);
        audio.SetActive(false);
    }

}