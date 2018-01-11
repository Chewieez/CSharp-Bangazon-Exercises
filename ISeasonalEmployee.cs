namespace bangazon
{
    public interface ISeasonalEmployee
    {
        int ContractDuration {get; set;}

        void ExtendContract(int duration);
    }
}