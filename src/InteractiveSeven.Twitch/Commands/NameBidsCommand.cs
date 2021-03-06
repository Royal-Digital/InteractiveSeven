﻿using InteractiveSeven.Core.Data;
using InteractiveSeven.Core.ViewModels;
using InteractiveSeven.Twitch.Model;
using System.Linq;
using TwitchLib.Client.Interfaces;

namespace InteractiveSeven.Twitch.Commands
{
    public class NameBidsCommand : BaseCommand
    {
        private readonly NameBiddingViewModel _biddingVm;
        private readonly ITwitchClient _twitchClient;

        public NameBidsCommand(NameBiddingViewModel nameBiddingViewModel, ITwitchClient twitchClient)
            : base(x => x.NameBidsCommandWords, x => x.NameBiddingSettings.Enabled)
        {
            _biddingVm = nameBiddingViewModel;
            _twitchClient = twitchClient;
        }

        public override void Execute(in CommandData commandData)
        {
            var requested = commandData.Arguments.FirstOrDefault();

            var (exists, name) = CharNames.GetByName(requested);

            if (!exists)
            {
                _twitchClient.SendMessage(commandData.Channel, "Specify a character to see the name bids.");
                return;
            }

            var bidding = _biddingVm.CharacterNameBiddings.SingleOrDefault(x => x.CharName == name);

            if (bidding == null)
            {
                _twitchClient.SendMessage(commandData.Channel, "Specify a character to see the name bids.");
                return;
            }

            var values = bidding.NameBids.OrderByDescending(x => x.TotalBits).Take(5).Select(x => $"({x.Name} {x.TotalBits})");
            string message = string.Join(", ", values);

            _twitchClient.SendMessage(commandData.Channel, $"{bidding.DefaultName} Bids: {message}");
        }
    }
}