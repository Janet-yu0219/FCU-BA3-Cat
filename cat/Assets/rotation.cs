using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public iTween.EaseType easeType;
    public iTween.LoopType loopType;


    void Start()
    {
        iTween.RotateTo(this.gameObject, iTween.Hash("z", 720, "time", 800f, "easeType", easeType, "loopType", loopType));
    }

}
