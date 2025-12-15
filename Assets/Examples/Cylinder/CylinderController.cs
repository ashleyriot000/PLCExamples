using UnityEngine;

public class CylinderController : MonoBehaviour
{
    //실린더의 전진 방향(로컬)
    public Vector3 forward = Vector3.forward;
    //물리 강체
    public Rigidbody rod;
    //전후진시 가하는 힘.
    public float power = 100f;

    private bool _isOnForward = false;
    private bool _isOnBackward = false; 


    public void OnForward()
    {
        Debug.Log("전진");
        rod.AddRelativeForce(forward * power);
    }

    public void OnBackward()
    {
        Debug.Log("후진");
        rod.AddRelativeForce(-forward * power);
    }
}
