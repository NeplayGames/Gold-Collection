using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAnimation : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        ///Rotate the coin according to the speed provided i.e. 100 per second
        transform.Rotate(new Vector3( 0, 0 ,100 * Time.deltaTime));   
    }
}
