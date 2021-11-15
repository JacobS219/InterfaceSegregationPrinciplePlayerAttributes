public interface IHaveHealth
{
    int CurrentHealth { get; set; }
    int HealthMax { get; set; }
    int ModifyHealth(int amount);
}
