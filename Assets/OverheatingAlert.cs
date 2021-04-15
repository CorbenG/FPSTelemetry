using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverheatingAlert : MonoBehaviour
{
    PlayerWeaponsManager m_PlayerWeaponsManager;
    WeaponController activeWeapon;

    public float showLevel;
    // Start is called before the first frame update
    void Start()
    {
        m_PlayerWeaponsManager = FindObjectOfType<PlayerWeaponsManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        activeWeapon = m_PlayerWeaponsManager.GetActiveWeapon();
        if (activeWeapon != null)
        {
            if (activeWeapon.currentAmmoRatio < showLevel)
            {
                GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, (1-(activeWeapon.currentAmmoRatio*(1/showLevel))));
            }
            else
            {
                GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, 0);
            }
        }
        
    }
}
