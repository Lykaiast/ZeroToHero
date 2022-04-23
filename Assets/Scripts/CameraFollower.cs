using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public GameObject objectToFollow;
    private Vector3 offset = new Vector3(0, 6, -6) ;

    // Update is called once per frame
    void Update()
    {
        transform.position = objectToFollow.transform.position + offset;
    }
}
