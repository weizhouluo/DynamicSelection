using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMenuManager : MonoBehaviour {

    // Use this for initialization
    void Awake()
    {
        this.gameObject.SetActive(false);
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PresentingthisObjectMenu()
    {
        this.gameObject.SetActive(true);
    }

    public void HidethisObjectMenu()
    {
        this.gameObject.SetActive(false);
    }
}
