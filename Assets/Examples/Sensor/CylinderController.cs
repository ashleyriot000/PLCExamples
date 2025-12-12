using UnityEngine;

public class CylinderController : MonoBehaviour
{
    public Rigidbody rod;
    public float power = 100f;

    public void OnForward()
    {
        Debug.Log("전진");
        rod.AddRelativeForce(Vector3.down * power);
    }

    public void OnBackward()
    {
        Debug.Log("후진");
        rod.AddRelativeForce(Vector3.up * power);
    }
    
}
