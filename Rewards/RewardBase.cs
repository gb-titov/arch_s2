using S2.Rewards;

public abstract class RewardBase : IRewardItem
{
    protected abstract string RewardName { get; }
    protected abstract int MaxCount { get; }
    public virtual string OpenReward() => $"{new Random().Next(1, MaxCount)} {RewardName}";
}