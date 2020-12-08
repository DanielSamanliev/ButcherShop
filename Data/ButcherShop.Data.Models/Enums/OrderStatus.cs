namespace ButcherShop.Data.Models.Enums
{
    public enum OrderStatus
    {
        Pending = 1,
        CheckedOut = 2,
        Confirmed = 3,
        SentForDelivery = 4,
        ReadyForPickup = 5,
        Completed = 6,
        Abandoned = 7,
    }
}
