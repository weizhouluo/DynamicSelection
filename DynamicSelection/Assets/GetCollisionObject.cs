using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;

public class GetCollisionObject : MonoBehaviour {

  
    void OnCollisionEnter(Collision col)
    {
        DetectionManager.Get().ChangeCurrentObject(col.gameObject);
    }

}
