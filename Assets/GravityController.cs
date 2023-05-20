using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    [SerializeField] float acceleration = 9.8f;
    // Start is called before the first frame update
    void Start()
    {
        if(SystemInfo.supportsGyroscope)
            Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 gravity;
        if (Input.gyro.gravity != Vector3.zero)
            gravity = Input.gyro.gravity * acceleration;
        else
            gravity = Input.acceleration * acceleration;
            
        gravity.z = Mathf.Clamp(gravity.z, float.MinValue, 0);
        Physics.gravity = new Vector3(gravity.x, gravity.z, gravity,y);
    }
}