using UnityEngine;

public class QuadCopter : MonoBehaviour
{
    public Rigidbody core;
    public Rigidbody fl;
    public Rigidbody fr;
    public Rigidbody bl;
    public Rigidbody br;

    [Range(0, 50)]
    public float power = 0f;


    public bool autoHeight = false;
    [Range(0, 20)]
    public float height = 0;

    [Range(-10, 10)]
    public float xRoll;

    [Range(-10, 10)]
    public float zRoll;
    

    private PIDController heightController;
    private PIDController xRollController;
    private PIDController zRollController;

    private void Awake()
    {
        heightController = new PIDController(8, 15, 30, 40); // 4-1-2
    }

    private void FixedUpdate()
    {
        if (autoHeight)
        {
            heightController.SetPoint = height;
            power = (float)heightController.Calculate(core.position.y);
            power = Mathf.Clamp(power, 0, 50);
        }


        fl.AddForce(Vector3.up * power);
        fr.AddForce(Vector3.up * power);
        bl.AddForce(Vector3.up * power);
        br.AddForce(Vector3.up * power);
    }
}
