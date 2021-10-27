using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotationn : MonoBehaviour
{
    string target;
    private void Start()
    {

    }

    private void Update()
    {
        //if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        //    RaycastHit Hit;
        //    if (Physics.Raycast(ray, out Hit))
        //    {
        //        target = Hit.transform.name;
        //        if (target == "Spherex")
        //        {
                  Spin();
        //        }
        //    }
        //}
    }
    public void Spin()
    {
        transform.Rotate(Vector3.right, 20 * Time.deltaTime);
    }
}
