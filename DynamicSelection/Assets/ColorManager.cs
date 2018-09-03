using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour {

    public enum ManipulatedObjectColor
    {
        Red,
        Blue,
        Green
    }

    GameObject m_object;
    Renderer rend;


	// Use this for initialization
	void Start () {



    }
	
	// Update is called once per frame
	void Update () 
    {
        m_object = DetectionManager.Get().GetCurrentGameObject();
        rend = m_object.GetComponent<Renderer>();
    }

    public void ChangetoRedColor()
    {
        rend.material.color = Color.red;
    }

    public void ChangetoGreenColor()
    {
        rend.material.color = Color.green;
    }

    public void ChangetoBlueColor()
    {
        rend.material.color = Color.blue;
    }


}
