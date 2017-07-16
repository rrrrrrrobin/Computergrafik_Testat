using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCAM : MonoBehaviour
{

    public Camera[] cams;

    public void camMAIN()
    {
        cams[0].enabled = true;
        cams[1].enabled = false;
        cams[2].enabled = false;
    }

    public void camONE()
    {
        cams[0].enabled = false;
        cams[1].enabled = true;
        cams[2].enabled = false;
    }

    public void camTWO()
    {
        cams[0].enabled = false;
        cams[1].enabled = false;
        cams[2].enabled = true;
    }


}
