using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthUI : MonoBehaviour
{
     public Slider oneSlider;
     public GameObject player;
    void Start()
    {
        oneSlider.maxValue = 50;
        oneSlider.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        do
        {
            if (oneSlider == null)
            {
                Debug.Log("滑动条为空");
                break;
            }

            oneSlider.value = player.GetComponent<PlayerMoveL2>().health;
 
        } while (false);
    }
}
