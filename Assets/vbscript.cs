using UnityEngine;
using System.Collections;
using Vuforia;

public class vbscript : MonoBehaviour, IVirtualButtonEventHandler {

    private GameObject vbButtonObject;
    private GameObject soldier;
	// Use this for initialization
	void Start () {
        vbButtonObject = GameObject.Find("actionButton");
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        soldier = GameObject.Find("soldier");
	}
	
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("Button Presse !!!");
        soldier.GetComponent<Animation>().Play();
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("Button Relache !!!");
        soldier.GetComponent<Animation>().Stop();
    }
}
