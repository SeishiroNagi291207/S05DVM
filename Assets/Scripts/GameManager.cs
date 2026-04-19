using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public FirstPersonController playerController;
    public TimerUI timerUI;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        if (playerController != null)
            playerController.enabled = false;

        if (timerUI != null)
            timerUI.activo = false;
    }

    public void StartGameplay()
    {
        if (playerController != null)
            playerController.enabled = true;

        if (timerUI != null)
            timerUI.activo = true;
    }
}