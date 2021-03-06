﻿// <copyright file="VectorTests.cs" company="Mark Lauter">
// Copyright (c) Mark Lauter. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tello.State;

namespace Tello.Test
{
    [TestClass]
    public class VectorTests
    {
        [TestMethod]
        public void Vector_move()
        {
            var position = new Vector();
            Assert.AreEqual(0, position.Heading);
            Assert.AreEqual(0, position.X);
            Assert.AreEqual(0, position.Y);

            position = position.Move(Tello.CardinalDirections.Front, 100);
            Assert.AreEqual(0, position.Heading);
            Assert.AreEqual(100, position.X);
            Assert.AreEqual(0, position.Y);

            position = position.Turn(Tello.ClockDirections.Clockwise, 90);
            Assert.AreEqual(90, position.Heading);
            Assert.AreEqual(100, position.X);
            Assert.AreEqual(0, position.Y);

            position = position.Move(Tello.CardinalDirections.Front, 100);
            Assert.AreEqual(90, position.Heading);
            Assert.AreEqual(100, position.X);
            Assert.AreEqual(100, position.Y);

            position = position.Turn(Tello.ClockDirections.Clockwise, 90);
            Assert.AreEqual(180, position.Heading);
            Assert.AreEqual(100, position.X);
            Assert.AreEqual(100, position.Y);

            position = position.Move(Tello.CardinalDirections.Front, 100);
            Assert.AreEqual(180, position.Heading);
            Assert.AreEqual(0, position.X);
            Assert.AreEqual(100, position.Y);

            position = position.Turn(Tello.ClockDirections.Clockwise, 90);
            Assert.AreEqual(270, position.Heading);
            Assert.AreEqual(0, position.X);
            Assert.AreEqual(100, position.Y);

            position = position.Move(Tello.CardinalDirections.Front, 100);
            Assert.AreEqual(270, position.Heading);
            Assert.AreEqual(0, position.X);
            Assert.AreEqual(0, position.Y);

            position = position.Turn(Tello.ClockDirections.Clockwise, 90);
            Assert.AreEqual(0, position.Heading);
            Assert.AreEqual(0, position.X);
            Assert.AreEqual(0, position.Y);

            position = position.Turn(Tello.ClockDirections.Clockwise, 360 + 180);
            Assert.AreEqual(180, position.Heading);
            Assert.AreEqual(0, position.X);
            Assert.AreEqual(0, position.Y);

            position = new Vector();
            position = position.Turn(Tello.ClockDirections.Clockwise, 270 + 180);
            Assert.AreEqual(90, position.Heading);
            Assert.AreEqual(0, position.X);
            Assert.AreEqual(0, position.Y);

            position = new Vector();
            position = position.Turn(Tello.ClockDirections.CounterClockwise, 90);
            Assert.AreEqual(270, position.Heading);
            Assert.AreEqual(0, position.X);
            Assert.AreEqual(0, position.Y);
        }
    }
}
