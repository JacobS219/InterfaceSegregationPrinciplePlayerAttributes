public interface IAttack
{
    int AttackSpeed { get; set; }
    int AttackHitNumber { get; set; }
    bool CanFire();
    void Attack(int attackSpeed, int attackHitNumber);
}
