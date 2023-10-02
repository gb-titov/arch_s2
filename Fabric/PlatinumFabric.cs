using S2.Fabric;
using S2.Rewards;

public class PlatinumFabric : IFabricBase
{
    public IRewardItem Create() => new Platinum();
}