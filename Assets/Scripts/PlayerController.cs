using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerController : MonoBehaviour
{
    public bool isSeeker = false;

    [PunRPC]
    public void SetSeeker()
    {
        isSeeker = true;
    }
}
