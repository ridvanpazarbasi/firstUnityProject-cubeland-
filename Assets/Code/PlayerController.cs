using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _rollSpeed = 5;
    private bool _isMoving;
    public DynamicJoystick dk;
    public GameManager gameManager;
    public Rigidbody rb;
    Vector3 m_EulerAngleVelocity;
    public bool stopmove=false;
    public MeshRenderer mr;





    private void Update()
    {
        if (stopmove == false)
        {
            if (_isMoving) return;

            if (dk.Horizontal == -1) Assemble(Vector3.left);
            else if (dk.Horizontal == 1) Assemble(Vector3.right);
            else if (dk.Vertical == 1) Assemble(Vector3.forward);
            else if (dk.Vertical == -1) Assemble(Vector3.back);

            void Assemble(Vector3 dir)
            {
                var anchor = transform.position + (Vector3.down + dir) * 0.5f;
                var axis = Vector3.Cross(Vector3.up, dir);
                StartCoroutine(Roll(anchor, axis));
                Vector3 m_Input = new Vector3(dk.Horizontal, dk.Vertical, 0);

                //            rb.MovePosition(transform.position + m_Input * Time.deltaTime * _rollSpeed);
                Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);

                rb.MoveRotation(transform.rotation * deltaRotation);



            }
        }

       
    }


    private IEnumerator Roll(Vector3 anchor, Vector3 axis)
    {
        _isMoving = true;
        for (var i = 0; i < 90 / _rollSpeed; i++)
        {
            transform.RotateAround(anchor, axis, _rollSpeed);
       
            yield return new WaitForSeconds(0.01f);
        }
        _isMoving = false;


    }

    public void stopwork()
    {
        stopmove = true;

    }
    public void colorChenge(Material mat)
    {
        mr.material = mat;


    }

}