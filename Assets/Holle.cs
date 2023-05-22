using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Holle : MonoBehaviour
{
    public UnityEvent OnBallEnter = new UnityEvent();
    private void OnCollisionEnter(Collision other)
    {
        OnTriggerEnter(other.collider);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Debug.Log("Ball Enter");
            OnBallEnter.Invoke();
        }
    }
}
