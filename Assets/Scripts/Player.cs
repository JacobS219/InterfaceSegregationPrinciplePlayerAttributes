using UnityEngine;

public class Player : MonoBehaviour, IHaveStats, IAttack
{
    public int STR { get; set; } = 5;
    public int STA { get; set; } = 5;
    public int CON { get; set; } = 5;
    public int WIS { get; set; } = 5;
    public int INT { get; set; } = 5;
    public int CHA { get; set; } = 5;

    public int CurrentHealth { get; set; }
    public int HealthMax { get; set; } = 100;

    public int ModifyHealth(int amount)
    {
        CurrentHealth -= amount;
        return CurrentHealth;
    }

    public string fireButtonString = "Fire1";
    public int AttackSpeed { get; set; } = 5;
    public int AttackHitNumber { get; set; } = 5;

    public bool CanFire()
    {
        return (STA > 0) ? (true) : (false);
    }

    void Awake()
    {
        CurrentHealth = HealthMax;
    }

    public void Attack(int attackSpeed, int attackHitNumber)
    {
        if (Input.GetButtonDown(fireButtonString) && CanFire())
        {
            ///FireWeapon();
        }
    }

    void Update()
    {
        
    }
}
