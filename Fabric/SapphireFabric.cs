using S2.Fabric;
using S2.Rewards;

public class SapphireFabric : IFabricBase
{
    public IRewardItem Create() => new Sapphire();
}