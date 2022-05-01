using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followcursor : MonoBehaviour
{
    Camera cam;
    Collider planecollider;
    Collider sphereCollider;
    GameObject[] sphereObjs;
    SphereCollider[] spherecolliders;
    RaycastHit hit;
    Ray ray;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        planecollider = GameObject.Find("Plane").GetComponent<Collider>();
        sphereCollider = GameObject.FindGameObjectWithTag("Trampoline").GetComponent<Collider>();
        sphereObjs = GameObject.FindGameObjectsWithTag("Trampoline");
        for(int i = 0; i < sphereObjs.Length; i++)
        {
            spherecolliders[i] = sphereObjs[i].GetComponent<SphereCollider>();
        }
        
        


    }

    // Update is called once per frame
    void Update()
    {
        ray = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(hit.point.x, 20, hit.point.z), Time.deltaTime * 100);
            /*
            if (hit.collider == planecollider)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(hit.point.x, 20, hit.point.z), Time.deltaTime * 100);
            if (hit.collider == sphereCollider)
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(hit.point.x, 20, hit.point.z), Time.deltaTime * 100);

            foreach (SphereCollider collider in spherecolliders)
            {
                if (hit.collider == collider)
                    transform.position = Vector3.MoveTowards(transform.position, new Vector3(hit.point.x, 20, hit.point.z), Time.deltaTime * 100);
            }
            */
        }
    }
}
