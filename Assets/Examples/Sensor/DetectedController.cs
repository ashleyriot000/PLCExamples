using UnityEngine;
using DG.Tweening;

public class DetectedController : MonoBehaviour
{

    public void OnDetected()
    {
        transform.DOScale(Vector3.zero, 1f)
            .SetDelay(1f)
            .OnComplete(() => Destroy(gameObject));
    }

}
