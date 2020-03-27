using UnityEngine;

public class Test : MonoBehaviour
{
    private PIDController pidController;

    private Rigidbody rb;

    private void Awake()
    {
        pidController = new PIDController(1, 0.5, 1);
        pidController.SetPoint = 0;

        rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        rb.AddForce(Vector3.up * (float)pidController.Calculate(rb.position.y));
    }
}
