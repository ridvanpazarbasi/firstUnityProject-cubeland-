using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public DynamicJoystick variableJoystick;
    public Rigidbody rb;
    public Text horizontal;

    public void FixedUpdate()
    {
        Vector3 direction = (Vector3.forward * variableJoystick.Vertical) + Vector3.right * variableJoystick.Horizontal;
        horizontal.text = variableJoystick.Vertical.ToString() + "  " + variableJoystick.Horizontal.ToString();
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);

    }
}