using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
    public Movement movement;
    public GameObject camera;

    public string nickname;

    public TextMeshPro nicknameText;

    public void IslocalPlayer()
    {
        movement.enabled = true;
        camera.SetActive(true);
    }

    [PunRPC]
    public void setNickname(string _nickname)
    {
        nickname = _nickname;

        nicknameText.text = nickname;
    }

}
