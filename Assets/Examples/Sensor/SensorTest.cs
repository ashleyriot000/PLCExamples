using UnityEngine;

public class SensorTest : MonoBehaviour
{
   public void OnDetectedSensor(bool hasDetected)
   {
        Debug.Log($"{(hasDetected ? "감지했다" : "감지못했다")}");
   }
}
