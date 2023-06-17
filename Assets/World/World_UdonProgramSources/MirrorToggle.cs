
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class MirrorToggle : UdonSharpBehaviour
{

    public GameObject mirrorMain;
    public bool mirrorMainState;

    void Start()
    {
        mirrorMain.SetActive(mirrorMainState);
    }

    public override void Interact()
    {
        Debug.Log("Toggling Mirror...");
        mirrorMainState = !mirrorMainState;
        mirrorMain.SetActive(mirrorMainState);
    }
    
}
