using UnityEngine;
using DG.Tweening;

public class DetectedController : MonoBehaviour
{
    public void OnDetected()
    {
        transform.DOScale(Vector3.one, 1f)
            .OnComplete(DestroySelf);
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}
