﻿using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Navigator;
using Navigator.Abstraction;
using Navigator.Actions;

namespace FOSCBot.Core.Domain.Command.Sad
{
    public class SadCommandActionHandler : ActionHandler<SadCommandAction>
    {
        public static readonly string SadCrstian = "CAACAgQAAxkBAAI5DF59uqkJYnqzc5LcnEC_bdp0rerIAAJsAwACmOejAAG_qYNUT_L_exgE";

        public SadCommandActionHandler(INavigatorContext ctx) : base(ctx)
        {
        }

        public override async Task<Unit> Handle(SadCommandAction request, CancellationToken cancellationToken)
        {
            await Ctx.Client.SendStickerAsync(Ctx.GetTelegramChat(), SadCrstian, cancellationToken: cancellationToken);

            return Unit.Value;
        }
    }
}