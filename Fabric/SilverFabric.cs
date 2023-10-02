using S2.Fabric;
using S2.Rewards;

public class SilverFabric : IFabricBase
{
    public IRewardItem Create() => new Silver();
}