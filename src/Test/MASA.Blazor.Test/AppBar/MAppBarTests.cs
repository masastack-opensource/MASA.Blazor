﻿using Bunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASA.Blazor.Test.AppBar
{
    [TestClass]
    public class MAppBarTests:TestBase
    {
        [TestMethod]
        public void RenderAppBarWithAbsolute()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.Absolute, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var noAbsoluteClass = !classes.Contains("m-app-bar--fixed");

            // Assert
            Assert.IsTrue(noAbsoluteClass);
        }

        [TestMethod]
        public void RenderAppBarWithApp()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.App, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasAppClass = classes.Contains("m-app-bar--fixed");

            // Assert
            Assert.IsTrue(hasAppClass);
        }

        [TestMethod]
        public void RenderAppBarWithBottom()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.Bottom, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasBottomClass = classes.Contains("m-app-bar");

            // Assert
            Assert.IsTrue(hasBottomClass);
        }

        [TestMethod]
        public void RenderAppBarWithClippedRight()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.ClippedRight, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasClippedRightClass = classes.Contains("m-app-bar--clipped");

            // Assert
            Assert.IsTrue(hasClippedRightClass);
        }

        [TestMethod]
        public void RenderAppBarWithClippedLeft()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.ClippedLeft, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasClippedLeftClass = classes.Contains("m-app-bar--clipped");

            // Assert
            Assert.IsTrue(hasClippedLeftClass);
        }

        [TestMethod]
        public void RenderAppBarWithCollapse()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.Collapse, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasClippedLeftClass = classes.Contains("m-app-bar");

            // Assert
            Assert.IsTrue(hasClippedLeftClass);
        }

        [TestMethod]
        public void RenderAppBarWithCollapseOnScroll()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.CollapseOnScroll, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasScrollClass = classes.Contains("m-toolbar--collapse");

            // Assert
            Assert.IsTrue(hasScrollClass);
        }

        [TestMethod]
        public void RenderAppBarWithDense()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.Dense, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasDenseClass = classes.Contains("m-app-bar");

            // Assert
            Assert.IsTrue(hasDenseClass);
        }

        [TestMethod]
        public void RenderAppBarWithDark()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.Dark, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasDarkClass = classes.Contains("theme--dark");

            // Assert
            Assert.IsTrue(hasDarkClass);
        }

        [TestMethod]
        public void RenderButtonWithScroll()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.ElevateOnScroll, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasScrollClass = classes.Contains("m-app-bar--elevate-on-scroll");

            // Assert
            Assert.IsTrue(hasScrollClass);
        }

        [TestMethod]
        public void RenderAppBarWithElevation()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.Elevation, 2);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasElevationClass = classes.Contains("elevation-2");

            // Assert
            Assert.IsTrue(hasElevationClass);
        }

        [TestMethod]
        public void RenderButtonWithExtended()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.Extended, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasScrollClass = classes.Contains("m-app-bar");

            // Assert
            Assert.IsTrue(hasScrollClass);
        }

        [TestMethod]
        public void RenderAppBarWithExtensionHeight()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.ExtensionHeight, 48);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasElevationClass = classes.Contains("m-app-bar");

            // Assert
            Assert.IsTrue(hasElevationClass);
        }

        [TestMethod]
        public void RenderAppBarWithFadeImgOnScroll()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.FadeImgOnScroll, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasFadeImgOnScrollClass = classes.Contains("m-app-bar");

            // Assert
            Assert.IsTrue(hasFadeImgOnScrollClass);
        }

        [TestMethod]
        public void RenderAppBarWithFixed()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.Fixed, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasFixedClass = classes.Contains("m-app-bar--fixed");

            // Assert
            Assert.IsTrue(hasFixedClass);
        }

        [TestMethod]
        public void RenderAppBarWithFlat()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.Flat, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasFlatClass = classes.Contains("m-app-bar");

            // Assert
            Assert.IsTrue(hasFlatClass);
        }

        [TestMethod]
        public void RenderAppBarWithFloating()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.Floating, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasFloatingClass = classes.Contains("m-app-bar");

            // Assert
            Assert.IsTrue(hasFloatingClass);
        }

        [TestMethod]
        public void RenderWithHeight()
        {
            // Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(p => p.Height, 100);
            });
            var inputSlotDiv = cut.Find(".m-toolbar__content");
            var style = inputSlotDiv.GetAttribute("style");

            // Assert
            Assert.AreEqual("height: 100px", style);
        }

        [TestMethod]
        public void RenderWithWidth()
        {
            // Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(p => p.Width, 100);
            });
            var inputSlotDiv = cut.Find(".m-toolbar__content");
            var style = inputSlotDiv.GetAttribute("style");

            // Assert
            Assert.AreEqual("height: 64px", style);
        }

        [TestMethod]
        public void RenderWithMinHeight()
        {
            // Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(p => p.MinHeight, 100);
            });
            var inputSlotDiv = cut.Find(".m-toolbar__content");
            var style = inputSlotDiv.GetAttribute("style");

            // Assert
            Assert.AreEqual("height: 64px", style);
        }

        [TestMethod]
        public void RenderWithMinWidth()
        {
            // Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(p => p.MinWidth, 100);
            });
            var inputSlotDiv = cut.Find(".m-toolbar__content");
            var style = inputSlotDiv.GetAttribute("style");

            // Assert
            Assert.AreEqual("height: 64px", style);
        }

        [TestMethod]
        public void RenderWithMaxHeight()
        {
            // Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(p => p.MaxHeight, 100);
            });
            var inputSlotDiv = cut.Find(".m-toolbar__content");
            var style = inputSlotDiv.GetAttribute("style");

            // Assert
            Assert.AreEqual("height: 64px", style);
        }

        [TestMethod]
        public void RenderWithMaxWidth()
        {
            // Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(p => p.MaxWidth, 100);
            });
            var inputSlotDiv = cut.Find(".m-toolbar__content");
            var style = inputSlotDiv.GetAttribute("style");

            // Assert
            Assert.AreEqual("height: 64px", style);
        }

        [TestMethod]
        public void RenderAppBarWithHideOnScroll()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.HideOnScroll, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasHideOnScrollClass = classes.Contains("m-app-bar");

            // Assert
            Assert.IsTrue(hasHideOnScrollClass);
        }

        [TestMethod]
        public void RenderAppBarWithInvertedScroll()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.InvertedScroll, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasInvertedScrollClass = classes.Contains("m-app-bar");

            // Assert
            Assert.IsTrue(hasInvertedScrollClass);
        }

        [TestMethod]
        public void RenderAppBarWithLight()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.Light, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasLightClass = classes.Contains("theme--light");

            // Assert
            Assert.IsTrue(hasLightClass);
        }

        [TestMethod]
        public void RenderAppBarWithOutlined()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.Outlined, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasOutlinedClass = classes.Contains("m-app-bar");

            // Assert
            Assert.IsTrue(hasOutlinedClass);
        }

        [TestMethod]
        public void RenderAppBarWithProminent()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.Prominent, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasProminentClass = classes.Contains("m-app-bar");

            // Assert
            Assert.IsTrue(hasProminentClass);
        }

        [TestMethod]
        public void RenderAppBarWithRounded()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.Rounded, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasRoundedClass = classes.Contains("m-app-bar");

            // Assert
            Assert.IsTrue(hasRoundedClass);
        }

        [TestMethod]
        public void RenderAppBarWithScrollOffScreen()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.ScrollOffScreen, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasScrollOffScreenClass = classes.Contains("m-app-bar");

            // Assert
            Assert.IsTrue(hasScrollOffScreenClass);
        }

        [TestMethod]
        public void RenderWithScrollThreshold()
        {
            // Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(p => p.ScrollThreshold, 0);
            });
            var inputSlotDiv = cut.Find(".m-app-bar");
            var style = inputSlotDiv.GetAttribute("style");

            // Assert
            Assert.AreEqual("height: 64px;transform:translateY(0px);left:0px;right:0px", style);
        }

        [TestMethod]
        public void RenderAppBarWithShaped()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.Shaped, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasShapedClass = classes.Contains("m-app-bar");

            // Assert
            Assert.IsTrue(hasShapedClass);
        }

        [TestMethod]
        public void RenderButtonWithShrinkOnScroll()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.ShrinkOnScroll, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasScrollClass = classes.Contains("v-app-bar--shrink-on-scroll");

            // Assert
            Assert.IsTrue(hasScrollClass);
        }

        [TestMethod]
        public void RenderAppBarWithTile()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.Tile, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasRoundedClass = classes.Contains("rounded");

            // Assert
            Assert.IsTrue(hasRoundedClass);
        }

        [TestMethod]
        public void RenderAppBarWithValue()
        {
            //Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.Value, true);
            });
            var classes = cut.Instance.CssProvider.GetClass();
            var hasValueClass = classes.Contains("m-app-bar");

            // Assert
            Assert.IsTrue(hasValueClass);
        }

        [TestMethod]
        public void RenderWithChildContent()
        {
            // Arrange & Act
            var cut = RenderComponent<MAppBar>(props =>
            {
                props.Add(appbar => appbar.ChildContent, "<span>Hello world</span>");
            });
            var contentDiv = cut.Find(".m-toolbar__content");

            // Assert
            contentDiv.Children.MarkupMatches("<span>Hello world</span>");
        }
    }
}
