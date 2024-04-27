using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour
{
    private Image _image;
    // Start is called before the first frame update
    void Start()
    {
        _image = GetComponent<Image>();
    }

    public void UpdateHPbar(float maxHP, float currentHP)
    {
        _image.fillAmount = currentHP / maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
