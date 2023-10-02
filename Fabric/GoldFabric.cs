using S2.Fabric;
using S2.Rewards;

public class GoldFabric : IFabricBase
{
    public IRewardItem Create() => new Gold();
}