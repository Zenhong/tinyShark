using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SharkDevourController : MonoBehaviour
{
    public Text countText;
    int count;
    public string pickUpTag = "PickUp";
    int pickUpsTotal;
    public Text winText;
    public PlayerController m_playermovement;

    private void Start()
    {
        pickUpsTotal = GameObject.FindGameObjectsWithTag(pickUpTag).Length;
        count = 0;
        SetCountText();
        winText.text = string.Empty;
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag(pickUpTag))
        {
            other.gameObject.SetActive(false);
            count += 1;
            SetCountText();
            switch (other.GetComponent<PickUpController>().m_effect)
            {
                case (PICK_UP_EFFECT.GROW):
                    GrowEffect();
                    break;
                case (PICK_UP_EFFECT.SHRINK):
                    ShrinkEffect();
                    break;
                case (PICK_UP_EFFECT.SLOW_DOWN):
                    SlowEffect();
                    break;
                case (PICK_UP_EFFECT.SPEED_UP):
                    FastEffect();
                    break;

            } 
        }

    }
    void SetCountText()
    {
        countText.text = $"Count: {count}";
        if (count >= pickUpsTotal)
        {
            winText.text = "You win!";
        }
    }

    public void GrowEffect()
    {
        transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }
    public void SlowEffect()
    {
        m_playermovement.speed -= 50;
    }

    public void FastEffect()
    {
        m_playermovement.speed += 50;
    }

    public void ShrinkEffect()
    {
        transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
    }

}
