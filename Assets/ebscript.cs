using UnityEngine;
using System.Collections;
using Vuforia;

public class ebscript : MonoBehaviour, IVirtualButtonEventHandler
{

    private GameObject ebButtonObject;
    private GameObject pion;
    // Use this for initialization
    void Start()
    {
        ebButtonObject = GameObject.Find("explosionButton");
        ebButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        pion = GameObject.Find("pion");
    }

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("Button Presse !!!");
        pion.GetComponent<Animation>().Play();
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("Button Relache !!!");
        pion.GetComponent<Animation>().Stop();
    }
}
