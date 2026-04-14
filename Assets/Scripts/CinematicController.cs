using Sirenix.OdinInspector;
using Unity.Cinemachine;
using UnityEngine;

public class CinematicController : MonoBehaviour
{
    public CinemachineCamera camA;
    public CinemachineCamera camB;
    public CinemachineCamera camC;
    public CinemachineCamera camD;
    public CinemachineCamera CameraPlayer;

    public float tiempoPorCamara = 5f;

    private int paso = 0;
    private float timer = 0f;

    void Start()
    {
        ActivarCamara(0);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= tiempoPorCamara)
        {
            timer = 0f;
            paso++;

            ActivarCamara(paso);
        }
    }

    void ActivarCamara(int x)
    {
        camA.Priority = 0;
        camB.Priority = 0;
        camC.Priority = 0;
        camD.Priority = 0;
        CameraPlayer.Priority = 0;

        switch (x)
        {
            case 0:
                camA.Priority = 10;
                break;
            case 1:
                camB.Priority = 10;
                break;
            case 2:
                camC.Priority = 10;
                break;
            case 3:
                camD.Priority = 10;
                break;
            case 4:
                CameraPlayer.Priority = 10;
                break;
        }
    }
    /*[Button]
    public void SwitchCamera()
    {
        if (camB.Priority > camA.Priority)
        {
            camB.Priority = 10;
            camA.Priority = 20;
        }
        else 
        { 
            camB.Priority = 20;
            camA.Priority = 10;
        }
    }*/
}
