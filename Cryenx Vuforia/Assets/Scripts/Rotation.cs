using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//// suedo code
//alternating behaviour when sphere is touched
//first touch will spin it, second touch will stop spinning it
//if touch_number=1 then start spinning
//if touch_number=2 then stop spinning
//if touch_number%2 != 0 then start spinning else if touch_number%2 == 0 then stop spinning
// in conjuction with first action of touching object and playing sound

public class Rotation : MonoBehaviour
{
    string btnName;
    float x;


    // Update is called once per frame
    void Update()
    {

        Spin();

    }
    public void Spin()
    {
                
                    x += Time.deltaTime * 20;
                    transform.rotation = Quaternion.Euler(x, 0, 0);
                
    }
}

