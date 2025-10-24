using UnityEngine;

/// <summary>
/// This script manages enabling and disabling weapons that are children of this GameObject.
/// Attach this script to your "Weapons Manager" GameObject.
/// </summary>
public class WeaponManager : MonoBehaviour
{
    [Header("Weapon Setup")]
    [Tooltip("Assign your 3 weapon GameObjects here in the order you want to switch them (1, 2, 3).")]
    public GameObject[] weapons;

    // To keep track of the currently active weapon
    private int currentWeaponIndex = -1; // -1 means no weapon is active

    void Start()
    {
        // Select the first weapon (index 0) by default when the game starts.
        SelectWeapon(0);
    }

    void Update()
    {
        // Check for number key presses
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SelectWeapon(0); // Select weapon 1
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SelectWeapon(1); // Select weapon 2
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SelectWeapon(2); // Select weapon 3
        }
    }

    /// <summary>
    /// Enables the weapon at the specified index and disables all others.
    /// </summary>
    /// <param name="index">The index of the weapon to activate (0, 1, or 2).</param>
    void SelectWeapon(int index)
    {
        // Check for invalid index or if the weapon is already selected
        if (index < 0 || index >= weapons.Length || index == currentWeaponIndex)
        {
            return;
        }

        // Update the current weapon index
        currentWeaponIndex = index;

        // Loop through all weapons
        for (int i = 0; i < weapons.Length; i++)
        {
            if (weapons[i] != null)
            {
                // Activate the weapon if its index matches the selected index.
                // Deactivate it otherwise.
                weapons[i].SetActive(i == index);
            }
        }
    }
}
