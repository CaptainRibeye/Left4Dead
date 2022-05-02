using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camshake : MonoBehaviour
{

    public Transform cameraTransform = default;
    private Vector3 _originalPosOfCam = default;
    public float shakeFrequency = default;

    private void CameraShake()
    {
        cameraTransform.position = _originalPosOfCam + Random.insideUnitSphere * shakeFrequency;
    }

    private void StopShake()
    {
        cameraTransform.position = _originalPosOfCam;
    }

    void Start()
    {
        _originalPosOfCam = cameraTransform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            CameraShake();
        }
        else if (Input.GetKeyUp("f"))
        {
            StopShake();
        }
    }
    








}
    /*Vector3 camInitialPos;
    public float shakeMag = 0.05f, shakeTime = 0.5f;
    public Camera mainCamera;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
            StartCameraShaking();
    }

    public void ShakeIt()
    {
        camInitialPos = mainCamera.transform.position;
        InvokeRepeating("StartCameraShaking", 0f, 0.005f);
        Invoke("StopCameraShaking", shakeTime);

    }

    void StartCameraShaking()
    {
        float cameraShakingOffsetX = Random.value * shakeMag * 2 - shakeMag;
        float cameraShakingOffsetY = Random.value * shakeMag * 2 - shakeMag;
        Vector3 cameraIntermadiatePosition = mainCamera.transform.position;
        cameraIntermadiatePosition.x += cameraShakingOffsetX;
        cameraIntermadiatePosition.y += cameraShakingOffsetY;
        mainCamera.transform.position = cameraIntermadiatePosition;

    }

    void StopCameraShaking()
    {
        CancelInvoke("StartCameraShaking");
        mainCamera.transform.position = camInitialPos;
    }
}*/
