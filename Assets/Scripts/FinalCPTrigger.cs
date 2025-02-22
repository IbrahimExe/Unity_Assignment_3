using UnityEngine;

public class FinalCPTrigger : MonoBehaviour
{
    [SerializeField] private TimerManager timerManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player reached CP4! Stopping timer.");
            timerManager.StopTimer();
        }
    }
}