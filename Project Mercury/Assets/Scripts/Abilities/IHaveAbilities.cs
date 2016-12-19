namespace Assets.Scripts
{
    public interface IHaveAbilities<T>
    {
        T AbilityOne { get; set; }
        T AbilityTwo { get; set; }
        T AbilityThree { get; set; }
    }
}
