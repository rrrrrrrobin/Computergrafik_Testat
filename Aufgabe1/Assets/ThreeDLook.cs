using UnityEngine;
using System.Collections;

[AddComponentMenu("Camera-Control/Mouse Look")]

public class ThreeDLook : MonoBehaviour
{
    public enum RotationAxes { mouseXY = 0, mouseX = 1, mouseY = 2 }
    public RotationAxes rotAxes = RotationAxes.mouseXY;
    public float xMin = -360F;
    public float xMax = 360F;
    public float yMin = -60F;
    public float yMax = 60F;
    float xRot = 0F;
    float yRot = 0F;
    public float xSensivity = 15F;
    public float ySensivity = 15F;

    Quaternion originalRotation;

    void Update()
    {
        if (rotAxes == RotationAxes.mouseXY)
        {
            // Read the mouse input axis
            xRot += Input.GetAxis("Mouse X") * xSensivity;
            yRot += Input.GetAxis("Mouse Y") * ySensivity;
            xRot = ClampAngle(xRot, xMin, xMax);
            yRot = ClampAngle(yRot, yMin, yMax);

            Quaternion xQuaternion = Quaternion.AngleAxis(xRot, Vector3.up);
            Quaternion yQuaternion = Quaternion.AngleAxis(yRot, Vector3.left);

            transform.localRotation = originalRotation * xQuaternion * yQuaternion;
        }
        else if (rotAxes == RotationAxes.mouseX)
        {
            xRot += Input.GetAxis("Mouse X") * xSensivity;
            xRot = ClampAngle(xRot, xMin, xMax);

            Quaternion xQuaternion = Quaternion.AngleAxis(xRot, Vector3.up);
            transform.localRotation = originalRotation * xQuaternion;
        }
        else
        {
            yRot += Input.GetAxis("Mouse Y") * ySensivity;
            yRot = ClampAngle(yRot, yMin, yMax);

            Quaternion yQuaternion = Quaternion.AngleAxis(yRot, Vector3.left);
            transform.localRotation = originalRotation * yQuaternion;
        }
    }

    void Start()
    {
        if (GetComponent<Rigidbody>())GetComponent<Rigidbody>().freezeRotation = true;
        originalRotation = transform.localRotation;
    }

    public static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360F)
            angle += 360F;
        if (angle > 360F)
            angle -= 360F;
        return Mathf.Clamp(angle, min, max);
    }
}
