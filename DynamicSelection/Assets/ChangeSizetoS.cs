using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSizetoS : MonoBehaviour {

<<<<<<< HEAD
<<<<<<< HEAD
    GameObject m_object = DetectionManager.Get().GetCurrentGameObject();

    void Update()
    {
        ChangetoHalfSize();
    }

    public void ChangetoHalfSize()
    {
        Debug.Log("Changing Size......" + m_object.name);
        m_object.transform.localScale *= 0.5f;
=======
    GameObject m_object;

    void Update()
    {
=======
    GameObject m_object;

    void Update()
    {
>>>>>>> 142f65116698fe87868eecd5043765caf9460a4f
        m_object = DetectionManager.Get().GetCurrentGameObject();
    }



    public void ChangetoHalfSize()
    {
        m_object.transform.localScale *= 0.5f;
        //new Vector3(m_object.transform.localScale.x * 0.5f, m_object.transform.localScale.y * 0.5f, m_object.transform.localScale.z * 0.5f);
<<<<<<< HEAD
>>>>>>> 142f65116698fe87868eecd5043765caf9460a4f
=======
>>>>>>> 142f65116698fe87868eecd5043765caf9460a4f
    }
}
