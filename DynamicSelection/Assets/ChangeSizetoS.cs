using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSizetoS : MonoBehaviour {

    GameObject m_object;

    void Update()
    {
        m_object = DetectionManager.Get().GetCurrentGameObject();
    }



    public void ChangetoHalfSize()
    {
        m_object.transform.localScale *= 0.5f;
    }
}
