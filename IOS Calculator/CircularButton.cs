﻿using IOS_Calculator;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace IOS_Calculator;
public class CircularButton : Button
{
    public CircularButton()
    {
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        Size = new Size(72, 72);
        Color color = ColorTranslator.FromHtml("#505050");
        BackColor = color;
        ForeColor = Color.White;
        Font = new Font("San Francisco", 22, FontStyle.Bold);
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);

        Graphics graphics = pevent.Graphics;
        graphics.SmoothingMode = SmoothingMode.AntiAlias;

        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddEllipse(ClientRectangle);
            Region = new Region(path);
        }
        TextRenderer.DrawText(graphics, Text, Font, ClientRectangle, ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
    }
}