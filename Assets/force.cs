using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour
{
    public GameObject volleyball;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TryHitBall();


    }
    private void TryHitBall()
    {
        float power = GetPower();
        if (power > 0)
        {
            Rigidbody rb = volleyball.GetComponent<Rigidbody>();
            rb.velocity = GetReflected() * power;
        }



    }

    private Vector3 GetReflected()
    {
        Vector3 volleyballVector = transform.position - volleyball.transform.position;
        Vector3 planeTangent = Vector3.Cross(volleyballVector, Camera.main.transform.forward);
        Vector3 planeNormal = Vector3.Cross(planeTangent, volleyballVector);
        Vector3 reflected = Vector3.Reflect(Camera.main.transform.forward, planeNormal);
        return reflected.normalized;
    }

    private float GetPower()
    {
        return 60;
    }
}
