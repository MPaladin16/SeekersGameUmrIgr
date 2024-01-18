using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerGameLogic : MonoBehaviour
{
    // Start is called before the first frame update
    private bool _isHider;
    [SerializeField] GameLogic gameLogic;
    [SerializeField] PhotonView _photonView;
    [SerializeField] Transform _position;
    [SerializeField] PositionConstraint _posCon;
    void Start()
    {
        _isHider = true;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (_isHider || this.tag != "seeker")
        {
            if (collision.gameObject.tag == "seeker")
            {
                GotCaught();
            }
        }

    }

    private void GotCaught()
    {
        //Prebacit kameru u zrak i freezat joj poziciju, dopustit okretanje da se gleda mapa?
        //lokalno
        _position.position = new Vector3(-14.9803352f, 16.507f, 9.3464632f);
        _posCon.gameObject.SetActive(true);
        gameLogic.PlayerCaught();
        _photonView.RPC("RPC_Died", RpcTarget.Others);
    }


    [PunRPC]
    void RPC_Died()
    {
        //prebacit kameru svim ostalima
        _position.position = new Vector3(-14.9803352f, 16.507f, 9.3464632f);
        _posCon.gameObject.SetActive(true);
        gameLogic.PlayerCaught();
    }

}