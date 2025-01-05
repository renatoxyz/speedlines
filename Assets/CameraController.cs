using System;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;
    private Camera cameraToMove;
    [SerializeField] private Vector3 mainPosition;
    private float endZ = -3.21f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cameraToMove = GetComponent<Camera>();
        mainPosition = cameraToMove.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float cameraZ = Mathf.Lerp(mainPosition.z, endZ, playerMovement.speed / 100);
        cameraToMove.transform.position = new Vector3(mainPosition.x, mainPosition.y, cameraZ);
    }
}
