﻿using BlazorComponent;
using BlazorComponent.Web;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Element = BlazorComponent.Web.Element;

namespace MASA.Blazor
{
    public partial class MDialog : BDialog, IDialog, IThemeable
    {
        private bool _animated = false;

        protected override string AttachSelector => Attach ?? ".m-application";

        public bool ShowContent { get; set; }

        [CascadingParameter]
        public IThemeable Themeable { get; set; }

        [Parameter]
        public bool Dark { get; set; }

        [Parameter]
        public bool Light { get; set; }

        [Parameter]
        public bool Scrollable { get; set; }

        [Parameter]
        public string Transition { get; set; } = "dialog-transition";

        public bool IsDark
        {
            get
            {
                if (Dark)
                {
                    return true;
                }

                if (Light)
                {
                    return false;
                }

                return Themeable != null && Themeable.IsDark;
            }
        }

        public Dictionary<string, object> ContentAttrs
        {
            get
            {
                var attrs = new Dictionary<string, object>
                {
                    { "role", "document" }
                };
                if (Value)
                {
                    attrs.Add("tabindex", 0);
                }

                return attrs;
            }
        }

        protected override void SetComponentClass()
        {
            var prefix = "m-dialog";

            CssProvider
                .Apply(cssBuilder =>
                {
                    cssBuilder
                        .Add($"{prefix}__container")
                        .AddIf($"{prefix}__container--attached", () => Attach != null);
                })
                .Apply("content", cssBuilder =>
                {
                    cssBuilder
                        .Add($"{prefix}__content")
                        .AddIf($"{prefix}__content--active", () => Value)
                        .AddTheme(IsDark);
                }, styleBuilder =>
                {
                    styleBuilder
                        .Add($"z-index: {ZIndex}");
                })
                .Apply("innerContent", cssBuilder =>
                {
                    cssBuilder
                        .Add(prefix)
                        .AddIf($"{prefix}--active", () => Value)
                        .AddIf($"{prefix}--persistent", () => Persistent)
                        .AddIf($"{prefix}--fullscreen", () => Fullscreen)
                        .AddIf($"{prefix}--scrollable", () => Scrollable)
                        .AddIf($"{prefix}--animated", () => _animated);
                }, styleBuilder =>
                {
                    styleBuilder
                        .Add("transform-origin: center center")
                        .AddWidth(Width)
                        .AddMaxWidth(MaxWidth);
                });

            AbstractProvider
                .Apply<BOverlay, MOverlay>(props =>
                {
                    props[nameof(MOverlay.Value)] = ShowOverlay && Value;
                    props[nameof(MOverlay.ZIndex)] = ZIndex - 1;
                    props[nameof(MOverlay.OnClick)] = EventCallback.Factory.Create<MouseEventArgs>(this, async () =>
                    {
                        if (Persistent)
                        {
                            await AnimateClick();
                        }
                        else
                        {
                            await UpdateValue(false);
                        }

                        if (OnOutsideClick.HasDelegate)
                            await OnOutsideClick.InvokeAsync();
                    });
                })
                .ApplyDialogDefault();
        }

        private async Task AnimateClick()
        {
            _animated = true;
            StateHasChanged();

            await Task.Delay(150);

            _animated = false;
            StateHasChanged();
        }

        public async Task Keydown(KeyboardEventArgs args)
        {
            if (args.Key == "Escape")
            {
                await Close();
            }
        }

        protected override async Task Close()
        {
            if (Persistent)
            {
                await AnimateClick();
                return;
            }

            await base.Close();
        }

        public override async Task ShowLazyContent()
        {
            if (!ShowContent && Value)
            {
                ShowContent = true;
                Value = false;

                StateHasChanged();

                Value = true;

                var overlayElement = ((BDomComponentBase)Overlay).Ref;
                await JsInvokeAsync(JsInteropConstants.AddElementTo, overlayElement, AttachSelector);
                await JsInvokeAsync(JsInteropConstants.AddElementTo, ContentRef, AttachSelector);

                StateHasChanged();
            }
        }
    }
}