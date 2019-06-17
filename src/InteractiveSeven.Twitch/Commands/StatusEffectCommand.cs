﻿using InteractiveSeven.Core.Battle;
using InteractiveSeven.Core.Memory;
using InteractiveSeven.Core.Models;
using InteractiveSeven.Core.Settings;
using InteractiveSeven.Twitch.Model;
using System.Linq;
using TwitchLib.Client.Interfaces;

namespace InteractiveSeven.Twitch.Commands
{
    public class StatusEffectCommand : BaseCommand
    {
        private readonly ITwitchClient _twitchClient;
        private readonly IStatusAccessor _statusAccessor;
        private readonly GilBank _gilBank;

        private static BattleSettings Settings => ApplicationSettings.Instance.BattleSettings;

        private static string[] AllWords(CommandSettings settings)
            => Settings.AllStatusEffects
                .SelectMany(effect => effect.Words)
                .ToArray();


        public StatusEffectCommand(ITwitchClient twitchClient,
            IStatusAccessor statusAccessor, GilBank gilBank)
            : base(AllWords, x => x.BattleSettings.AllowStatusEffects)
        {
            _twitchClient = twitchClient;
            _statusAccessor = statusAccessor;
            _gilBank = gilBank;
        }

        public override void Execute(CommandData commandData)
        {
            var statusSettings = Settings.ByWord(commandData.CommandText);
            var actor = Allies.ByWord(commandData.Arguments.FirstOrDefault());
            if (statusSettings == null || actor == null)
            {
                _twitchClient.SendMessage(commandData.Channel, "Be sure to name a valid status and actor. Example: !psn top");
                return;
            }

            if (!statusSettings.Enabled)
            {
                _twitchClient.SendMessage(commandData.Channel, $"The {commandData.CommandText} status effect is disabled.");
                return;
            }

            (int balance, int withdrawn) = _gilBank.Withdraw(commandData.User, statusSettings.Cost, true);

            if (withdrawn < statusSettings.Cost)
            {
                _twitchClient.SendMessage(commandData.Channel,
                    $"The {commandData.CommandText} effect costs {statusSettings.Cost}. Your balance {balance}");
                return;
            }

            _statusAccessor.SetActorStatus(actor, statusSettings.Effect);

            _twitchClient.SendMessage(commandData.Channel,
                $"Applied {commandData.CommandText} to {actor.Words.First()}.");
        }
    }
}