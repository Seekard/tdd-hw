﻿using System;
using System.Drawing;

namespace TagsCloudVisualization.Curves
{
    public class ArchimedeanSpiral : ICurve
    {
        public double StartRadius { get; }
        public double ExtendRatio { get; }
        public ArchimedeanSpiral(double startRadius = 0, double extendRatio = 0.25)
        {
            if (startRadius < 0 || extendRatio <= 0)
                throw new ArgumentException("Parameters cannot be negative.");
            StartRadius = startRadius;
            ExtendRatio = extendRatio;
        }

        public Point GetPoint(double angle)
        {
            var radius = StartRadius + ExtendRatio * angle;
            var x = Convert.ToInt32(radius * Math.Cos(angle));
            var y = Convert.ToInt32(radius * Math.Sin(angle));
            return new Point(x, y);
        }
    }
}