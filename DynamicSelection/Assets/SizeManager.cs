using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeManager : MonoBehaviour {

    public enum ManipulatedObjectSize
    {
        Small,
        Medium,
        Large
    }

    GameObject m_object;
    Vector3 OriginalSize;
    ManipulatedObjectSize currentSizeState;

    void Update()
    {
        m_object = DetectionManager.Get().GetCurrentGameObject();
        OriginalSize = m_object.transform.localScale;
    }



    public void ChangetoSmallSize()
    {

        if (currentSizeState != ManipulatedObjectSize.Small)
            m_object.transform.localScale = OriginalSize * 0.5f;

        currentSizeState = ManipulatedObjectSize.Small;
    }

    public void ChangetoMediumSize()
    {

        if (currentSizeState != ManipulatedObjectSize.Medium)
            m_object.transform.localScale = OriginalSize * 1f;

        currentSizeState = ManipulatedObjectSize.Medium;
    }

    public void ChangetoLargeSize()
    {

        if (currentSizeState != ManipulatedObjectSize.Large)
            m_object.transform.localScale = OriginalSize * 1.5f;

        currentSizeState = ManipulatedObjectSize.Large;
    }
}
