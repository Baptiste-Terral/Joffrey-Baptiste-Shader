using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPNote : MonoBehaviour
{
    private Vector3 EmissiveIntensity;
    private Vector3 ScanlineDirection;
    private MeshRenderer meshrenderer;
    private Material material;
    // Start is called before the first frame update
    void Start()
    {
            EmissiveIntensity = new Vector4(1.0f, 1.0f, 1.0f, 1.0f);
            meshrenderer = GetComponent<MeshRenderer>();
            material = meshrenderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        selectColor();
    }

    void selectColor()
    {
        meshrenderer = GetComponent<MeshRenderer>();
        material = meshrenderer.material;
        if (Input.GetKey(KeyCode.R))
            EmissiveIntensity.x += Time.deltaTime;
        else
            EmissiveIntensity.x -= Time.deltaTime;
        if (Input.GetKey(KeyCode.G))
            EmissiveIntensity.y += Time.deltaTime;
        else
            EmissiveIntensity.y -= Time.deltaTime;
        if (Input.GetKey(KeyCode.B))
            EmissiveIntensity.z += Time.deltaTime;
        else
            EmissiveIntensity.z -= Time.deltaTime;

        EmissiveIntensity.x = Mathf.Clamp(EmissiveIntensity.x, 0, 1);
        EmissiveIntensity.y = Mathf.Clamp(EmissiveIntensity.y, 0, 1);
        EmissiveIntensity.z = Mathf.Clamp(EmissiveIntensity.z, 0, 1);
        material.SetVector("_EmissiveIntensity", EmissiveIntensity);
    }

    void selectDirection()
    {
        /*meshrenderer = GetComponent<MeshRenderer>();
        material = meshrenderer.material;
        if (Input.GetKey(KeyCode.UP))
            EmissiveIntensity.x += Time.deltaTime;
        else if (Input.GetKey(KeyCode.DOWN))
            EmissiveIntensity.y += Time.deltaTime;
        else
            EmissiveIntensity.y -= Time.deltaTime;

        EmissiveIntensity.x = Mathf.Clamp(EmissiveIntensity.x, 0, 1);
        EmissiveIntensity.y = Mathf.Clamp(EmissiveIntensity.y, 0, 1);
        EmissiveIntensity.z = Mathf.Clamp(EmissiveIntensity.z, 0, 1);
        material.SetVector("_EmissiveIntensity", EmissiveIntensity);*/
    }

    void selectVertical()
    {
        /*meshrenderer = GetComponent<MeshRenderer>();
        material = meshrenderer.material;
        if (Input.GetKey(KeyCode.UP))
            ScanlineDirection += Time.deltaTime;
        else if (Input.GetKey(KeyCode.DOWN))
            ScanlineDirection -= Time.deltaTime;
        else
            ScanlineDirection.y -= Time.deltaTime;

        ScanlineDirection.x = Mathf.Clamp(ScanlineDirection.x, 0, 1);
        ScanlineDirection.y = Mathf.Clamp(ScanlineDirection.y, 0, 1);
        ScanlineDirection.z = Mathf.Clamp(ScanlineDirection.z, 0, 1);
        material.SetVector("_ScanlineDirection", ScanlineDirection);*/
    }
}
