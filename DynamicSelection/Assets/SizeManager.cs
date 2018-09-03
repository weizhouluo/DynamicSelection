using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeManager : MonoBehaviour {

    GameObject m_object;
    GameObject originalObject;

    ManipulatedObjectSize currentSizeState;

  //  bool isOtherObject = false;

    public enum ManipulatedObjectSize
    {
        Small,
        Medium,
        Large
    }


    void Update()
    {
        //If the manipulated object is initializing...
        //save this object to originalObject
        if (m_object == null)
        {
            m_object = DetectionManager.Get().GetCurrentGameObject();
            originalObject = m_object;
        }

        //If the manipulated object has changed 
        //update this object to originalobject
        if (m_object != null && (m_object != originalObject))
        {
            originalObject = m_object;
        }


        //originalSize = m_object.transform.localScale;
    }



    public void ChangetoSmallSize()
    {

        if (currentSizeState != ManipulatedObjectSize.Small)
            m_object.transform.localScale = originalObject.transform.localScale * 0.5f;

        currentSizeState = ManipulatedObjectSize.Small;
    }

    public void ChangetoMediumSize()
    {

        if (currentSizeState != ManipulatedObjectSize.Medium)
            m_object.transform.localScale = originalObject.transform.localScale * 1.2f;

        currentSizeState = ManipulatedObjectSize.Medium;
    }

    public void ChangetoLargeSize()
    {

        if (currentSizeState != ManipulatedObjectSize.Large)
            m_object.transform.localScale = originalObject.transform.localScale * 1.5f;

        currentSizeState = ManipulatedObjectSize.Large;
    }
}
