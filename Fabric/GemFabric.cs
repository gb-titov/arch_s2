using S2.Fabric;
using S2.Rewards;

public class GemFabric : IFabricBase
{
    public IRewardItem Create() => new Gem();

}