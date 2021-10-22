﻿using Bunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASA.Blazor.Test.Badge
{
    [TestClass]
    public class MBadgeTests:TestBase
    {
        

        [TestMethod]
        public void RenderButtonWithAvatar()
        {
            //Act
            var cut = RenderComponent<MBadge>(props =>
            {
                props.Add(badge => badge.Avatar, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasAvatarClass = classes.Contains("m-badge--avatar");

            // Assert
            Assert.IsTrue(hasAvatarClass);
        }

        [TestMethod]
        public void RenderButtonWithBordered()
        {
            //Act
            var cut = RenderComponent<MBadge>(props =>
            {
                props.Add(badge => badge.Bordered, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasBorderedClass = classes.Contains("m-badge--bordered");

            // Assert
            Assert.IsTrue(hasBorderedClass);
        }

        [TestMethod]
        public void RenderButtonWithBottom()
        {
            //Act
            var cut = RenderComponent<MBadge>(props =>
            {
                props.Add(badge => badge.Bottom, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasBottomClass = classes.Contains("m-badge--bottom");

            // Assert
            Assert.IsTrue(hasBottomClass);
        }

        [TestMethod]
        public void RenderButtonWithDot()
        {
            //Act
            var cut = RenderComponent<MBadge>(props =>
            {
                props.Add(badge => badge.Dot, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasDotClass = classes.Contains("m-badge--dot");

            // Assert
            Assert.IsTrue(hasDotClass);
        }

        [TestMethod]
        public void RenderButtonWithInLine()
        {
            //Act
            var cut = RenderComponent<MBadge>(props =>
            {
                props.Add(badge => badge.InLine, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasInLineClass = classes.Contains("m-badge--inline");

            // Assert
            Assert.IsTrue(hasInLineClass);
        }

        [TestMethod]
        public void RenderButtonWithLeft()
        {
            //Act
            var cut = RenderComponent<MBadge>(props =>
            {
                props.Add(badge => badge.Left, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasLeftClass = classes.Contains("m-badge--left");

            // Assert
            Assert.IsTrue(hasLeftClass);
        }

        [TestMethod]
        public void RenderButtonWithOverLap()
        {
            //Act
            var cut = RenderComponent<MBadge>(props =>
            {
                props.Add(badge => badge.OverLap, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasOverLapClass = classes.Contains("m-badge--overlap");

            // Assert
            Assert.IsTrue(hasOverLapClass);
        }

        [TestMethod]
        public void RenderButtonWithTile()
        {
            //Act
            var cut = RenderComponent<MBadge>(props =>
            {
                props.Add(badge => badge.Tile, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasTileClass = classes.Contains("m-badge--tile");

            // Assert
            Assert.IsTrue(hasTileClass);
        }

    }
}
