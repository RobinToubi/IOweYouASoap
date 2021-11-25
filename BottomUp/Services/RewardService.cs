using System;
using System.Collections.Generic;

namespace BottomUp.Services
{
    public class RewardService: IRewardService
    {
        public RewardService()
        {
        }

        public Reward GetReward(string id, int value, string comparator = "=")
        {
            List<Reward> data = new List<Reward>();
            data.Add(new Reward("1", 1, "PREMIÈRE BIÈRE"));
            data.Add(new Reward("2", 5, "BUVEUR DÉBUTANT"));
            data.Add(new Reward("3", 100, "ALCOOLIQUE ANONYME"));

            Reward tempReward = null;
            comparator = "=";
            data.ForEach(item =>
            {
                switch (comparator)
                {   
                    case "=":
                        if (value == item.Value)
                        {
                            tempReward = item;
                        }
                        break;

                    case "<":
                        if (item.Value < value)
                        {
                        if (tempReward == null)
                        {
                            tempReward = item;
                        } else if (tempReward.Value > item.Value && item.Value < value) {
                                tempReward = item;
                            }
                        }
                        break;

                    case ">":
                        if (item.Value > value)
                        {
                            if (tempReward == null)
                            {
                                tempReward = item;
                            }
                            else if (tempReward.Value < item.Value && item.Value > value)
                            {
                                tempReward = item;
                            }
                        }
                        break;

                    case "<=":
                        if (item.Value <= value)
                        {
                            if (tempReward == null)
                            {
                                tempReward = item;
                            }
                            else if (tempReward.Value > item.Value && item.Value <= value)
                            {
                                tempReward = item;
                            }
                        }
                        break;

                    case ">=":
                        if (item.Value >= value)
                        {
                            if (tempReward == null)
                            {
                                tempReward = item;
                            }
                            else if (tempReward.Value < item.Value && item.Value >= value)
                            {
                                tempReward = item;
                            }
                        }
                        break;
                }
                
            });

            var x = tempReward;
            return tempReward;
        }
    }
}
