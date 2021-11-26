using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
{
    // Start is called before the first frame update
    public PICK_UP_EFFECT m_effect;
}

public enum PICK_UP_EFFECT 
{ 
    GROW,
    SLOW_DOWN,
    SPEED_UP,
    SHRINK
}
