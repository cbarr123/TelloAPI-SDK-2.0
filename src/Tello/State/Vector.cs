﻿using System;

namespace Tello.State
{
    public class Vector
    {
        public Vector(int heading, double x, double y)
        {
            Heading = heading;
            X = x;
            Y = y;
        }

        public Vector()
            : this(0, 0, 0)
        { }

        public int Heading { get; }
        public double X { get; }
        public double Y { get; }

        public Vector Go(int xDelta, int yDelta)
        {
            return new Vector(Heading, X + xDelta, Y + yDelta);
        }

        public Vector Move(CardinalDirections direction, int distance)
        {
            var heading = Heading;
            switch (direction)
            {
                case CardinalDirections.Right:
                    heading += 90;
                    break;
                case CardinalDirections.Back:
                    heading += 180;
                    break;
                case CardinalDirections.Left:
                    heading += 270;
                    break;
            }

            var radians = heading * Math.PI / 180;
            var adjacent = Math.Cos(radians) * distance;
            var opposite = Math.Sin(radians) * distance;

            return new Vector(Heading, X + adjacent, Y + opposite);
        }

        public Vector Turn(ClockDirections direction, int degrees)
        {
            degrees = Math.Abs(degrees) % 360;

            var heading = Heading;
            switch (direction)
            {
                case ClockDirections.Clockwise:
                    heading += degrees;
                    if (heading >= 360)
                    {
                        heading -= 360;
                    }
                    break;
                case ClockDirections.CounterClockwise:
                    heading -= degrees;
                    if (heading < 360)
                    {
                        heading += 360;
                    }
                    break;
            }

            return new Vector(heading, X, Y);
        }
    }
}