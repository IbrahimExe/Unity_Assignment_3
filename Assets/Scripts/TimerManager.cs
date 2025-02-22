using UnityEngine;
using TMPro;

public class TimerManager : MonoBehaviour
{
    public TextMeshProUGUI timerText; // UI Timer Reference
    private float timer;
    private bool isTimerRunning;
    private bool hasFinished; // Ensures timer does not restart

    void Start()
    {
        timer = 0f;
        isTimerRunning = false;
        hasFinished = false;
        UpdateTimerDisplay();
    }

    void Update()
    {
        // Start the timer when the player moves (only if it hasn't finished)
        if (!isTimerRunning && !hasFinished && (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0))
        {
            isTimerRunning = true;
        }

        // Update timer if running
        if (isTimerRunning)
        {
            timer += Time.deltaTime;
            UpdateTimerDisplay();
        }
    }

    public void StopTimer()
    {
        Debug.Log("Timer Stopped!"); // Debug log to verify
        isTimerRunning = false;
        hasFinished = true; // Prevents timer from restarting
        UpdateTimerDisplay();
    }

    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);
        timerText.text = $"{minutes:00}:{seconds:00}";
    }
}
