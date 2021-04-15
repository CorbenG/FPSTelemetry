using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrosshairAmmoTracker : MonoBehaviour
{
    [Tooltip("UI element displaying ammo count")]
    public GameObject ammoCounter;

    PlayerWeaponsManager m_PlayerWeaponsManager;
    List<AmmoCounter> m_AmmoCounters = new List<AmmoCounter>();

    WeaponController activeWeapon;

    void Start()
    {
        m_PlayerWeaponsManager = FindObjectOfType<PlayerWeaponsManager>();
        DebugUtility.HandleErrorIfNullFindObject<PlayerWeaponsManager, WeaponHUDManager>(m_PlayerWeaponsManager, this);
    }

    void Update()
    {
        activeWeapon = m_PlayerWeaponsManager.GetActiveWeapon();

        ammoCounter.GetComponent<Image>().fillAmount = activeWeapon.currentAmmoRatio;
    }


}
