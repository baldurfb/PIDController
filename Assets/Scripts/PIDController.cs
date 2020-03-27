using UnityEngine;

public class PIDController
{
    private double kP;
    private double kI;
    private double kD;

    private double pTerm;
    private double iTerm;
    private double dTerm;

    private float lastTime;

    private double setPoint;

    public double SetPoint
    {
        get => setPoint;
        set => setPoint = value;
    }

    private double lastError;

    private double windupGuard;


    public PIDController(double kP, double kI, double kD, double windupGuard = 20)
    {
        this.kP = kP;
        this.kI = kI;
        this.kD = kD;

        this.windupGuard = windupGuard;

        lastTime = Time.time;
    }

    public double Calculate(double feedbackValue)
    {
        double error = setPoint - feedbackValue;

        float currentTime = Time.time;
        float deltaTime = currentTime - lastTime;
        double deltaError = error - lastError;


        pTerm = kP * error;
        iTerm += error * deltaTime;

        if (iTerm < -windupGuard) { iTerm = -windupGuard; }
        else if (iTerm > windupGuard) { iTerm = windupGuard; }

        dTerm = 0.0;
        if (deltaTime > 0)
        {
            dTerm = deltaError / deltaTime;
        }

        // Remember last time and last error for next calculation
        lastTime = currentTime;
        lastError = error;

        return pTerm + (kI * iTerm) + (kD * dTerm);
    }
    
    
}
