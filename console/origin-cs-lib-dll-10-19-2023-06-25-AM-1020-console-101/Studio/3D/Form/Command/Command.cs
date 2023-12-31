﻿using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    using System.Drawing;

    using System.Windows;
    using System.Windows.Forms;

    public partial class Command : TextBox, IExposable<Command>, ICentralOrder, IStyleOrder, IEventOrder, ITimeOrder
    {
        public static Command Instance;

        public Command()
        {
            ExposeReference();

            CentralOrder();

            return;
        }

        ~Command()
        {
            CleanReference();

            return;
        }

        public Command ExposeReference()
        {
            Instance = this;

            return this;
        }

        public Command CleanReference()
        {
            Instance = null;

            return this;
        }

        public void CentralOrder()
        {
            StyleOrder();

            EventOrder();

            TimeOrder();

            return;
        }

        public void StyleOrder()
        {
            Text = ImmutableConsoleLJTwoSecond.Text;

            Multiline = ImmutableConsoleLJTwoSecond.Multiline;

            AcceptsTab = ImmutableConsoleLJTwoSecond.AcceptTab;

            ReadOnly = ImmutableConsoleLJTwoSecond.ReadOnly;

            WordWrap = ImmutableConsoleLJTwoSecond.WordWrap;

            ScrollBars = ImmutableConsoleLJTwoSecond.ScrollBars;

            BackColor = ImmutableConsoleLJTwoSecond.BackColor;

            ForeColor = ImmutableConsoleLJTwoSecond.ForeColor;

            Font = new Font(ImmutableConsoleLJTwoSecond.FontFamily, ImmutableConsoleLJTwoSecond.FontSize, ImmutableConsoleLJTwoSecond.FontStyle);

            return;
        }

        public void TimeOrder()
        {
            Timer timer;

            timer = new Timer();

            timer.Tick += TickCentral;

            timer.Start();      

            return;
        }

        public void EventOrder()
        {
            KeyDown += Window.RedirectKeyDown;

            return;
        }
    }
}
