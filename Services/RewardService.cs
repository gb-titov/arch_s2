using S2.Fabric;
using S2.Rewards;

public class RewardService
{
    private readonly IFabricBase[] _fabrics;

    public RewardService()
    {
        _fabrics = new IFabricBase[]{new GemFabric(), new GoldFabric(), new SilverFabric(), new PlatinumFabric(), new SapphireFabric()};    
    }

    public IRewardItem GetReward() =>_fabrics[new Random().Next(_fabrics.Length)].Create();
}