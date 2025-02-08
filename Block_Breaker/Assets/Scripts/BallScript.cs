using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update
    protected Rigidbody rb;

    [SerializeField] protected Vector3 startForce = Vector3.one;

    [SerializeField] protected float worldVelocity = 25f;


    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        ApplyStartForce();
    }

    private void FixedUpdate()
    {
        LimitBallVelocity();
    }

    protected void ApplyStartForce()
    {
        rb.AddForce(startForce, ForceMode.Impulse);
    }

    protected void LimitBallVelocity()
    {
        Vector3 hV3 = rb.velocity;

        Vector3 nV3 = Vector3.zero;

        nV3.x = Mathf.Clamp(hV3.x, -worldVelocity, worldVelocity);
        nV3.y = Mathf.Clamp(hV3.y, -worldVelocity, worldVelocity);
        nV3.z = 0;

        rb.velocity = nV3;
    }

}
