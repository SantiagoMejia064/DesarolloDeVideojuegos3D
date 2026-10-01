using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class ObjectPosition : MonoBehaviour
{
    void Update (){
        Shader.SetGlobalVector("_ObjectPosition", new Vector4(transform.position.x, transform.position.y, transform.position.z));
    }
}
