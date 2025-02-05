using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Controller : MonoBehaviour
{   
    public AudioMixer mixer;
    public AudioSource source;
    public GameObject Open;
    public GameObject Closed;
    private bool isClosed = true;

    private void OnMouseDown()
    {
        ToggleDoor();
    }

    private void ToggleDoor()
    {
        if (isClosed)
            OpenIt();
        else
            CloseIt();
    }

    private void SwitchDoorSprite(bool open)
    {
        Open.SetActive(open);
        Closed.SetActive(!open);

        isClosed = !isClosed;
    }

    private void OpenIt()
    {
        SwitchDoorSprite(true);

        mixer.SetFloat("LowpassCutoff", 5000);

    }

    private void CloseIt()
    {
        SwitchDoorSprite(false);

         mixer.SetFloat("LowpassCutoff", 300);

    }
}
