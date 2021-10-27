using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip[] aClips;
    public AudioSource myAudioSource;
   // float x;
    string btnName;

    // Use this for initialization
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                btnName = Hit.transform.name;
                switch (btnName)
                {
                    case "Sphere":
                        myAudioSource.clip = aClips[0];
                        myAudioSource.Play();
                        //GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

                        break;
                    case "Spherex":
                        myAudioSource.clip = aClips[1];
                        myAudioSource.Play();
                        //Spin();
                        break;

                    default:
                        break;

                }
            }
        }

    }
    // public void Spin()
    //{
    //    x += Time.deltaTime * 20;
    //    transform.rotation = Quaternion.Euler(x, 0, 0);
    //}
    ////public void ColorChange()
    //{
    //    if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
    //    {
    //        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
    //        RaycastHit Hit;
    //        if (Physics.Raycast(ray, out Hit))
    //        {
    //            btnName = Hit.transform.name;
    //            if (btnName == "Sphere")
    //            {
    //                this.GetComponent<Renderer>().material.color = Color.HSVToRGB(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    //            }
    //        }
    //    }
    //}
}