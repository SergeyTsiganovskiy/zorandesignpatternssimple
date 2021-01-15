﻿using Demo.Common;

namespace Demo.Clip06.Modifiers
{
    public class GetSecondFree : IPriceModifier
    {
        public (Money first, Money second) ApplyTo(Money a, Money b) =>
            (a, b.Currency.Zero);
    }
}
