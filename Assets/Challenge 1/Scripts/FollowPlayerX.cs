using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Set the offset to be above and behind the plane
        offset = new Vector3(30, 0, 10); // Previously no initialization of offset
        transform.position = plane.transform.position + offset;
    }
}
