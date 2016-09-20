﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public partial class Switch : Control
    {
        private bool mouseEntered, mouseDown;

        public Switch()
        {
            InitializeComponent();
        }

        private void Switch_MouseClick(object sender, MouseEventArgs e)
        {
            switch (CurrentState)
            {
                case SwitchStates.On:
                    CurrentState = SwitchStates.Off;
                    this.Refresh();
                    break;
                case SwitchStates.Off:
                    CurrentState = SwitchStates.On;
                    this.Refresh();
                    break;
            }

            try
            {
                if (Switched != null)
                {
                    Switched(this, new SwitchedEventArgs(this, CurrentState));
                }

                // TODO: Debug; not working.
                //Switched?.Invoke(this, new SwitchedEventArgs(this, CurrentState));
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        private void Switch_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            this.Refresh();
        }

        private void Switch_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            this.Refresh();
        }

        private void Switch_MouseEnter(object sender, EventArgs e)
        {
            mouseEntered = true;
            this.Refresh();
        }

        private void Switch_MouseLeave(object sender, EventArgs e)
        {
            mouseEntered = false;
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
