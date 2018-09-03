using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSizetoS : MonoBehaviour {
   
    GameObject m_object = DetectionManager.Get().GetCurrentGameObject();

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        //ChangetoHalfSizem();
	}

    public void ChangetoHalfSize()
    {
        m_object.transform.localScale = new Vector3(m_object.transform.localScale.x * 0.5f, m_object.transform.localScale.x * 0.5f, m_object.transform.localScale.x * 0.5f);
    }
}
